namespace CamundaWorkers
{
    partial class UiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCamundaRestUrl = new System.Windows.Forms.TextBox();
            this.btnLoadProcesses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlProcessDefinitions = new System.Windows.Forms.ComboBox();
            this.txtBpmnFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseBpmnFile = new System.Windows.Forms.Button();
            this.bpmOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDeployWorkFlow = new System.Windows.Forms.Button();
            this.txtDeploymentName = new System.Windows.Forms.TextBox();
            this.txtInitiateProcessInstances = new System.Windows.Forms.TextBox();
            this.btnIntiateProcessInstances = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlExternalTasks = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExternalTaskReturnVariablesJson = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCompleteExternalTask = new System.Windows.Forms.Button();
            this.txtProcessStartPayloadJson = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUserTaskReturnVariable = new System.Windows.Forms.RichTextBox();
            this.ddlUserTasks = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCamundaRestUrl
            // 
            this.txtCamundaRestUrl.Location = new System.Drawing.Point(187, 22);
            this.txtCamundaRestUrl.Name = "txtCamundaRestUrl";
            this.txtCamundaRestUrl.Size = new System.Drawing.Size(1014, 23);
            this.txtCamundaRestUrl.TabIndex = 0;
            this.txtCamundaRestUrl.Text = "http://localhost:8080/engine-rest";
            // 
            // btnLoadProcesses
            // 
            this.btnLoadProcesses.Location = new System.Drawing.Point(1227, 17);
            this.btnLoadProcesses.Name = "btnLoadProcesses";
            this.btnLoadProcesses.Size = new System.Drawing.Size(117, 23);
            this.btnLoadProcesses.TabIndex = 1;
            this.btnLoadProcesses.Text = "Connect/Referesh";
            this.btnLoadProcesses.UseVisualStyleBackColor = true;
            this.btnLoadProcesses.Click += new System.EventHandler(this.btnLoadProcesses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camunnda Rest Uri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Process Definitions";
            // 
            // ddlProcessDefinitions
            // 
            this.ddlProcessDefinitions.FormattingEnabled = true;
            this.ddlProcessDefinitions.Location = new System.Drawing.Point(187, 117);
            this.ddlProcessDefinitions.Name = "ddlProcessDefinitions";
            this.ddlProcessDefinitions.Size = new System.Drawing.Size(512, 23);
            this.ddlProcessDefinitions.TabIndex = 4;
            // 
            // txtBpmnFilePath
            // 
            this.txtBpmnFilePath.Location = new System.Drawing.Point(187, 73);
            this.txtBpmnFilePath.Name = "txtBpmnFilePath";
            this.txtBpmnFilePath.ReadOnly = true;
            this.txtBpmnFilePath.Size = new System.Drawing.Size(512, 23);
            this.txtBpmnFilePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deployment Name";
            // 
            // btnBrowseBpmnFile
            // 
            this.btnBrowseBpmnFile.Location = new System.Drawing.Point(725, 72);
            this.btnBrowseBpmnFile.Name = "btnBrowseBpmnFile";
            this.btnBrowseBpmnFile.Size = new System.Drawing.Size(117, 23);
            this.btnBrowseBpmnFile.TabIndex = 1;
            this.btnBrowseBpmnFile.Text = "Browse";
            this.btnBrowseBpmnFile.UseVisualStyleBackColor = true;
            this.btnBrowseBpmnFile.Click += new System.EventHandler(this.btnBrowseBpmnFile_Click);
            // 
            // btnDeployWorkFlow
            // 
            this.btnDeployWorkFlow.Location = new System.Drawing.Point(1234, 73);
            this.btnDeployWorkFlow.Name = "btnDeployWorkFlow";
            this.btnDeployWorkFlow.Size = new System.Drawing.Size(117, 23);
            this.btnDeployWorkFlow.TabIndex = 1;
            this.btnDeployWorkFlow.Text = "Deploy Workfow";
            this.btnDeployWorkFlow.UseVisualStyleBackColor = true;
            this.btnDeployWorkFlow.Click += new System.EventHandler(this.btnDeployWorkFlow_Click);
            // 
            // txtDeploymentName
            // 
            this.txtDeploymentName.Location = new System.Drawing.Point(994, 70);
            this.txtDeploymentName.Name = "txtDeploymentName";
            this.txtDeploymentName.Size = new System.Drawing.Size(205, 23);
            this.txtDeploymentName.TabIndex = 0;
            // 
            // txtInitiateProcessInstances
            // 
            this.txtInitiateProcessInstances.Location = new System.Drawing.Point(871, 111);
            this.txtInitiateProcessInstances.Name = "txtInitiateProcessInstances";
            this.txtInitiateProcessInstances.Size = new System.Drawing.Size(205, 23);
            this.txtInitiateProcessInstances.TabIndex = 0;
            this.txtInitiateProcessInstances.Text = "1";
            // 
            // btnIntiateProcessInstances
            // 
            this.btnIntiateProcessInstances.Location = new System.Drawing.Point(1107, 110);
            this.btnIntiateProcessInstances.Name = "btnIntiateProcessInstances";
            this.btnIntiateProcessInstances.Size = new System.Drawing.Size(117, 23);
            this.btnIntiateProcessInstances.TabIndex = 1;
            this.btnIntiateProcessInstances.Text = "Start";
            this.btnIntiateProcessInstances.UseVisualStyleBackColor = true;
            this.btnIntiateProcessInstances.Click += new System.EventHandler(this.btnIntiateProcessInstances_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Initiate Process Instances";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "External Tasks";
            // 
            // ddlExternalTasks
            // 
            this.ddlExternalTasks.FormattingEnabled = true;
            this.ddlExternalTasks.Location = new System.Drawing.Point(163, 22);
            this.ddlExternalTasks.Name = "ddlExternalTasks";
            this.ddlExternalTasks.Size = new System.Drawing.Size(512, 23);
            this.ddlExternalTasks.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExternalTaskReturnVariablesJson);
            this.groupBox1.Controls.Add(this.ddlExternalTasks);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCompleteExternalTask);
            this.groupBox1.Location = new System.Drawing.Point(28, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 231);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "External Tasks";
            // 
            // txtExternalTaskReturnVariablesJson
            // 
            this.txtExternalTaskReturnVariablesJson.Location = new System.Drawing.Point(163, 65);
            this.txtExternalTaskReturnVariablesJson.Name = "txtExternalTaskReturnVariablesJson";
            this.txtExternalTaskReturnVariablesJson.Size = new System.Drawing.Size(512, 106);
            this.txtExternalTaskReturnVariablesJson.TabIndex = 7;
            this.txtExternalTaskReturnVariablesJson.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Task Return Variables(Json)";
            // 
            // btnCompleteExternalTask
            // 
            this.btnCompleteExternalTask.Location = new System.Drawing.Point(558, 191);
            this.btnCompleteExternalTask.Name = "btnCompleteExternalTask";
            this.btnCompleteExternalTask.Size = new System.Drawing.Size(117, 23);
            this.btnCompleteExternalTask.TabIndex = 1;
            this.btnCompleteExternalTask.Text = "Complete Task";
            this.btnCompleteExternalTask.UseVisualStyleBackColor = true;
            this.btnCompleteExternalTask.Click += new System.EventHandler(this.btnCompleteExternalTask_Click);
            // 
            // txtProcessStartPayloadJson
            // 
            this.txtProcessStartPayloadJson.Location = new System.Drawing.Point(187, 170);
            this.txtProcessStartPayloadJson.Name = "txtProcessStartPayloadJson";
            this.txtProcessStartPayloadJson.Size = new System.Drawing.Size(655, 106);
            this.txtProcessStartPayloadJson.TabIndex = 7;
            this.txtProcessStartPayloadJson.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Process Start Payload(Json)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUserTaskReturnVariable);
            this.groupBox2.Controls.Add(this.ddlUserTasks);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(770, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 231);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Tasks";
            // 
            // txtUserTaskReturnVariable
            // 
            this.txtUserTaskReturnVariable.Location = new System.Drawing.Point(163, 65);
            this.txtUserTaskReturnVariable.Name = "txtUserTaskReturnVariable";
            this.txtUserTaskReturnVariable.Size = new System.Drawing.Size(512, 106);
            this.txtUserTaskReturnVariable.TabIndex = 7;
            this.txtUserTaskReturnVariable.Text = "";
            // 
            // ddlUserTasks
            // 
            this.ddlUserTasks.FormattingEnabled = true;
            this.ddlUserTasks.Location = new System.Drawing.Point(163, 22);
            this.ddlUserTasks.Name = "ddlUserTasks";
            this.ddlUserTasks.Size = new System.Drawing.Size(512, 23);
            this.ddlUserTasks.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Task Return Variables(Json)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "User Tasks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Complete Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCompleteUserTask_Clicked);
            // 
            // UiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 805);
            this.Controls.Add(this.txtProcessStartPayloadJson);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBpmnFilePath);
            this.Controls.Add(this.ddlProcessDefinitions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIntiateProcessInstances);
            this.Controls.Add(this.btnDeployWorkFlow);
            this.Controls.Add(this.btnBrowseBpmnFile);
            this.Controls.Add(this.btnLoadProcesses);
            this.Controls.Add(this.txtInitiateProcessInstances);
            this.Controls.Add(this.txtDeploymentName);
            this.Controls.Add(this.txtCamundaRestUrl);
            this.Name = "UiForm";
            this.Text = "Camunda Demo Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCamundaRestUrl;
        private System.Windows.Forms.Button btnLoadProcesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlProcessDefinitions;
        private System.Windows.Forms.TextBox txtBpmnFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseBpmnFile;
        private System.Windows.Forms.OpenFileDialog bpmOpenFileDialog;
        private System.Windows.Forms.Button btnDeployWorkFlow;
        private System.Windows.Forms.TextBox txtDeploymentName;
        private System.Windows.Forms.TextBox txtInitiateProcessInstances;
        private System.Windows.Forms.Button btnIntiateProcessInstances;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlExternalTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtExternalTaskReturnVariablesJson;
        private System.Windows.Forms.RichTextBox txtProcessStartPayloadJson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCompleteExternalTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtUserTaskReturnVariable;
        private System.Windows.Forms.ComboBox ddlUserTasks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

