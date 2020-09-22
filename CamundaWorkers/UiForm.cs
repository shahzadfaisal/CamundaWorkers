using Camunda.Api.Client;
using Camunda.Api.Client.Deployment;
using Camunda.Api.Client.ExternalTask;
using Camunda.Api.Client.ProcessDefinition;
using Camunda.Api.Client.UserTask;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamundaWorkers
{
    public partial class UiForm : Form
    {
        private CamundaClient camundaClient = null;
        List<ProcessDefinitionInfo> ProcessDefinitions;
        List<ExternalTaskInfo> ExternalTasks;
        List<UserTaskInfo> UserTasks = null;
        public UiForm()
        {
            ProcessDefinitions = new List<ProcessDefinitionInfo>();
            ExternalTasks = new List<ExternalTaskInfo>();
            UserTasks = new List<UserTaskInfo>();
            InitializeComponent();
        }

        private async void btnDeployWorkFlow_Click(object sender, EventArgs e)
        {
            if (!EnsureRestUrl())
            {
                ShowRestUrlRequiredMessage();
                return;
            }
            if (!EnsureWorkflowDeploymentName())
            {
                ShowDeploymentNameRequiredMessage();
                return;
            }
            try
            {
                CreateCamundaClient();
                var deploymentInfo = await camundaClient.Deployments.Create(txtDeploymentName.Text.Trim(),
                    new ResourceDataContent(File.OpenRead(txtBpmnFilePath.Text), $"{txtDeploymentName.Text.Trim()}.bpmn"));
                txtBpmnFilePath.Text = "";
                txtDeploymentName.Text = "";
                await LoadProcessDefinitions();
                ShowDeploymentSuccessMessage(deploymentInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured,{ex.Message}");
            }
        }

        private async void btnLoadProcesses_Click(object sender, EventArgs e)
        {
            
            if (!EnsureRestUrl())
            {
                ShowRestUrlRequiredMessage();
                return;
            }
            try
            {
                CreateCamundaClient();
                await LoadProcessDefinitions();
                await LoadExternalTasks();
                await LoadUserTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured,{ex.Message}");
            }
        }

        private async Task LoadProcessDefinitions()
        { 
            ProcessDefinitions = await camundaClient.ProcessDefinitions.Query().List();
            ddlProcessDefinitions.DataSource = ProcessDefinitions.Select(s => new { s.Name, s.Key }).ToList();
            ddlProcessDefinitions.DisplayMember = "Name";
            ddlProcessDefinitions.ValueMember = "Key";
            ddlProcessDefinitions.SelectedIndex = 0;
        }

        private async Task LoadExternalTasks()
        {
            ExternalTasks = await camundaClient.ExternalTasks.Query(new ExternalTaskQuery
            {
                //ProcessDefinitionId = processDefinitionId
            }).List();

            ddlExternalTasks.DataSource = ExternalTasks.Select(s => new { TopicName = $"{s.TopicName}({s.ProcessInstanceId})", s.Id }).ToList();
            ddlExternalTasks.DisplayMember = "TopicName";
            ddlExternalTasks.ValueMember = "Id";
            if (ExternalTasks != null && ExternalTasks.Count > 0)
                ddlExternalTasks.SelectedIndex = 0;
        }

        private async Task LoadUserTasks()
        {
            UserTasks = await camundaClient.UserTasks.Query().List();

            ddlUserTasks.DataSource = UserTasks.Select(s => new { Name = $"{s.Name}({s.ProcessInstanceId})", Id = s.Id }).ToList();
            ddlUserTasks.DisplayMember = "Name";
            ddlUserTasks.ValueMember = "Id";
            if (UserTasks != null && UserTasks.Count > 0)
                ddlUserTasks.SelectedIndex = 0;
        }

        private async void btnIntiateProcessInstances_Click(object sender, EventArgs e)
        {
            if (!EnsureAtleastOneInstance())
            {
                ShowAtLeastOneInstanceRequiredMessage();
                return;
            }

            if (ddlProcessDefinitions.Items.Count == 0)
            {
                MessageBox.Show("Please Select Process Definition(Workflow");
                return;
            }

            CreateCamundaClient();
            try
            {
                int instances = Convert.ToInt32(txtInitiateProcessInstances.Text.Trim());
                for (int i = 0; i < instances; i++)
                {
                    var processInstance = camundaClient.ProcessDefinitions.ByKey("SubmitJobOffer").StartProcessInstance(new StartProcessInstance()
                    {
                        WithVariablesInReturn = true,
                        BusinessKey = Guid.NewGuid().ToString(),
                        Variables = string.IsNullOrWhiteSpace(txtProcessStartPayloadJson.Text) ? null : ConvertToVariableValueDictionary(JObject.Parse(txtProcessStartPayloadJson.Text.Trim()))
                    });
                }
                MessageBox.Show("Instances Initiated Successfully");
                await LoadExternalTasks();
                await LoadUserTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured,{ex.Message}");
            }
        }

        private void ddlProcessDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var processDefinitionId = ddlProcessDefinitions.SelectedValue.ToString();
            try
            {
                if (string.IsNullOrWhiteSpace(processDefinitionId))
                {
                    ddlExternalTasks.Items.Clear();
                    return;
                }

                ExternalTasks = await camundaClient.ExternalTasks.Query(new ExternalTaskQuery
                {
                    ProcessDefinitionId = processDefinitionId 
                }).List();

                ddlExternalTasks.DataSource = ExternalTasks.Select(s => new { s.TopicName, s.Id }).ToList();
                ddlExternalTasks.DisplayMember = "TopicName";
                ddlExternalTasks.ValueMember = "Id";
                if (ExternalTasks != null && ExternalTasks.Count > 0)
                    ddlExternalTasks.SelectedIndex = 0;
            }
            catch (Exception ex) { }
        
            */
        }
         


        private async void btnCompleteExternalTask_Click(object sender, EventArgs e)
        {
            if (ExternalTasks != null && ExternalTasks.Count > 0)
            {
                JObject returnPayload = null;
                if (!string.IsNullOrWhiteSpace(txtExternalTaskReturnVariablesJson.Text))
                {
                    returnPayload = JObject.Parse(txtExternalTaskReturnVariablesJson.Text.Trim());
                }

                try
                {
                    var selectedETask = ExternalTasks.FirstOrDefault(f => f.Id == ddlExternalTasks.SelectedValue.ToString());
                    if (selectedETask == null)
                    {
                        MessageBox.Show("Task Not Found");
                        return;
                    }
                    var lockedEtasks = await camundaClient.ExternalTasks.FetchAndLock(new FetchExternalTasks
                    {
                        MaxTasks = 100,
                        AsyncResponseTimeout = 60 * 1000,
                        WorkerId = "eWorker",
                        Topics = new List<FetchExternalTaskTopic>
                        {
                            new FetchExternalTaskTopic(selectedETask?.TopicName,60000)
                        }
                    });

                    /*Parallel.ForEach(lockedEtasks, (etask) =>
                    {
                        camundaClient.ExternalTasks[etask.Id].Complete(new CompleteExternalTask
                        {
                            Variables = returnPayload == null ? null : ConvertToVariableValueDictionary(returnPayload),
                            WorkerId = "eWorker"
                        });
                    });*/

                    var taskToComplete = lockedEtasks.FirstOrDefault(f => f.ProcessInstanceId == selectedETask.ProcessInstanceId);
                    await camundaClient.ExternalTasks[taskToComplete.Id].Complete(new CompleteExternalTask
                    {
                        Variables = returnPayload == null ? null : ConvertToVariableValueDictionary(returnPayload),
                        WorkerId = "eWorker"
                    });

                    MessageBox.Show($"Task Completed Successfully");
                    await LoadExternalTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Occured,{ex.Message}");
                }
            }
        }
        private async void btnCompleteUserTask_Clicked(object sender, EventArgs e)
        {
            if (UserTasks != null && UserTasks.Count > 0)
            {
                JObject returnPayload = null;
                if (!string.IsNullOrWhiteSpace(txtUserTaskReturnVariable.Text))
                {
                    returnPayload = JObject.Parse(txtUserTaskReturnVariable.Text.Trim());
                }

                try
                { 
                    await camundaClient.UserTasks[ddlExternalTasks.SelectedValue.ToString()].Complete(new CompleteTask
                    {
                        Variables = returnPayload == null ? null : ConvertToVariableValueDictionary(returnPayload)
                    });
                     
                    MessageBox.Show($"User Task Completed Successfully");
                    await LoadExternalTasks();
                    await LoadUserTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Occured(User Tast),  Message: {ex.Message}");
                }
            }
        }
        private void btnBrowseBpmnFile_Click(object sender, EventArgs e)
        {
            if (bpmOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBpmnFilePath.Text = bpmOpenFileDialog.FileName;
            }
        }
        private CamundaClient CreateCamundaClient()
        {
            if (camundaClient == null)
            {
                camundaClient = CamundaClient.Create(txtCamundaRestUrl.Text.Trim());
            }
            return camundaClient;
        }

        private Dictionary<string, VariableValue> ConvertToVariableValueDictionary(JObject jObject)
        {
            var result = new Dictionary<string, VariableValue>();
            var props = jObject.Properties();
            foreach (var prop in props)
            {
                var valueType = prop.Value.ToObject(typeof(object)).GetType();
                result.Add(prop.Name, VariableValue.FromObject(prop.Value.ToObject(valueType)));
            }

            return result;
        }
        private bool EnsureRestUrl()
        {
            return !string.IsNullOrWhiteSpace(txtCamundaRestUrl.Text);
        }
        private bool EnsureAtleastOneInstance()
        {
            return !string.IsNullOrWhiteSpace(txtInitiateProcessInstances.Text);
        }
        private bool EnsureWorkflowDeploymentName()
        {
            return !string.IsNullOrWhiteSpace(txtDeploymentName.Text);
        }

        private void ShowRestUrlRequiredMessage()
        {
            MessageBox.Show("Camunda Rest Engine Uri Is Required");
        }
        private void ShowAtLeastOneInstanceRequiredMessage()
        {
            MessageBox.Show("Atleast One(1) Process Instance Is Required");
        }
        private void ShowDeploymentNameRequiredMessage()
        {
            MessageBox.Show("Workflow Deployment Name Is Required");
        }
        private void ShowDeploymentSuccessMessage(DeploymentInfo deploymentInfo)
        {
            MessageBox.Show($"Status:Success, DeploymentInfo:{JsonConvert.SerializeObject(deploymentInfo)}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
