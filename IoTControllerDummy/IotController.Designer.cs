namespace IoTControllerDummy
{
    partial class IotController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IotController));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.panelDeliver = new System.Windows.Forms.Panel();
            this.txtHelpText = new System.Windows.Forms.RichTextBox();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.chkMainLock = new System.Windows.Forms.CheckBox();
            this.panelInstall = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDeliver = new System.Windows.Forms.TabPage();
            this.tabInstall = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkWeight = new System.Windows.Forms.CheckBox();
            this.chkCamera = new System.Windows.Forms.CheckBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.timerSimulateAddPackage = new System.Windows.Forms.Timer(this.components);
            this.timerSimulateGenerateReciepe = new System.Windows.Forms.Timer(this.components);
            this.btnDoorSwitch = new System.Windows.Forms.Button();
            this.timerSendLogEntry = new System.Windows.Forms.Timer(this.components);
            this.panelDeliver.SuspendLayout();
            this.panelInstall.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDeliver.SuspendLayout();
            this.tabInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(196, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(12, 787);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(196, 44);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "Installasjon";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // panelDeliver
            // 
            this.panelDeliver.Controls.Add(this.txtHelpText);
            this.panelDeliver.Controls.Add(this.btnDeliver);
            this.panelDeliver.Controls.Add(this.label1);
            this.panelDeliver.Controls.Add(this.txtDeliveryId);
            this.panelDeliver.Location = new System.Drawing.Point(6, 6);
            this.panelDeliver.Name = "panelDeliver";
            this.panelDeliver.Size = new System.Drawing.Size(961, 515);
            this.panelDeliver.TabIndex = 3;
            // 
            // txtHelpText
            // 
            this.txtHelpText.Location = new System.Drawing.Point(15, 55);
            this.txtHelpText.Name = "txtHelpText";
            this.txtHelpText.Size = new System.Drawing.Size(294, 203);
            this.txtHelpText.TabIndex = 3;
            this.txtHelpText.Text = "\nLegg inn en leveringsKode i feltet over og trykk \"Lever\"";
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(216, 24);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(93, 23);
            this.btnDeliver.TabIndex = 2;
            this.btnDeliver.Text = "Lever";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leveringskode / pakkeId";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(15, 28);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(194, 20);
            this.txtDeliveryId.TabIndex = 0;
            // 
            // chkMainLock
            // 
            this.chkMainLock.AutoSize = true;
            this.chkMainLock.Checked = true;
            this.chkMainLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMainLock.Location = new System.Drawing.Point(214, 814);
            this.chkMainLock.Name = "chkMainLock";
            this.chkMainLock.Size = new System.Drawing.Size(60, 17);
            this.chkMainLock.TabIndex = 4;
            this.chkMainLock.Text = "DørLås";
            this.chkMainLock.UseVisualStyleBackColor = true;
            // 
            // panelInstall
            // 
            this.panelInstall.Controls.Add(this.label2);
            this.panelInstall.Location = new System.Drawing.Point(6, 6);
            this.panelInstall.Name = "panelInstall";
            this.panelInstall.Size = new System.Drawing.Size(961, 515);
            this.panelInstall.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDeliver);
            this.tabControl.Controls.Add(this.tabInstall);
            this.tabControl.Location = new System.Drawing.Point(214, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(981, 553);
            this.tabControl.TabIndex = 6;
            // 
            // tabDeliver
            // 
            this.tabDeliver.Controls.Add(this.panelDeliver);
            this.tabDeliver.Location = new System.Drawing.Point(4, 22);
            this.tabDeliver.Name = "tabDeliver";
            this.tabDeliver.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeliver.Size = new System.Drawing.Size(973, 527);
            this.tabDeliver.TabIndex = 0;
            this.tabDeliver.UseVisualStyleBackColor = true;
            // 
            // tabInstall
            // 
            this.tabInstall.Controls.Add(this.panelInstall);
            this.tabInstall.Location = new System.Drawing.Point(4, 22);
            this.tabInstall.Name = "tabInstall";
            this.tabInstall.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstall.Size = new System.Drawing.Size(973, 527);
            this.tabInstall.TabIndex = 1;
            this.tabInstall.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 610);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // chkWeight
            // 
            this.chkWeight.AutoSize = true;
            this.chkWeight.Location = new System.Drawing.Point(446, 814);
            this.chkWeight.Name = "chkWeight";
            this.chkWeight.Size = new System.Drawing.Size(87, 17);
            this.chkWeight.TabIndex = 8;
            this.chkWeight.Text = "Trykk sensor";
            this.chkWeight.UseVisualStyleBackColor = true;
            // 
            // chkCamera
            // 
            this.chkCamera.AutoSize = true;
            this.chkCamera.Location = new System.Drawing.Point(461, 596);
            this.chkCamera.Name = "chkCamera";
            this.chkCamera.Size = new System.Drawing.Size(62, 17);
            this.chkCamera.TabIndex = 9;
            this.chkCamera.Text = "Kamera";
            this.chkCamera.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(663, 666);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(104, 13);
            this.lblTemp.TabIndex = 10;
            this.lblTemp.Text = "Temperatur sensor ?";
            // 
            // timerSimulateAddPackage
            // 
            this.timerSimulateAddPackage.Interval = 2000;
            this.timerSimulateAddPackage.Tick += new System.EventHandler(this.timerSimulateAddPackage_Tick);
            // 
            // timerSimulateGenerateReciepe
            // 
            this.timerSimulateGenerateReciepe.Interval = 2000;
            this.timerSimulateGenerateReciepe.Tick += new System.EventHandler(this.timerSimulateGenerateReciepe_Tick);
            // 
            // btnDoorSwitch
            // 
            this.btnDoorSwitch.Location = new System.Drawing.Point(270, 772);
            this.btnDoorSwitch.Name = "btnDoorSwitch";
            this.btnDoorSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnDoorSwitch.TabIndex = 11;
            this.btnDoorSwitch.Text = "Lukk døra";
            this.btnDoorSwitch.UseVisualStyleBackColor = true;
            this.btnDoorSwitch.Click += new System.EventHandler(this.btnDoorSwitch_Click);
            // 
            // timerSendLogEntry
            // 
            this.timerSendLogEntry.Interval = 2000;
            this.timerSendLogEntry.Tick += new System.EventHandler(this.timerSendLogEntry_Tick);
            // 
            // IotController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.btnDoorSwitch);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.chkCamera);
            this.Controls.Add(this.chkWeight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.chkMainLock);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.btnStart);
            this.Name = "IotController";
            this.Text = "Controller Dummy";
            this.panelDeliver.ResumeLayout(false);
            this.panelDeliver.PerformLayout();
            this.panelInstall.ResumeLayout(false);
            this.panelInstall.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDeliver.ResumeLayout(false);
            this.tabInstall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Panel panelDeliver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.RichTextBox txtHelpText;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.CheckBox chkMainLock;
        private System.Windows.Forms.Panel panelInstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDeliver;
        private System.Windows.Forms.TabPage tabInstall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkWeight;
        private System.Windows.Forms.CheckBox chkCamera;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Timer timerSimulateAddPackage;
        private System.Windows.Forms.Timer timerSimulateGenerateReciepe;
        private System.Windows.Forms.Button btnDoorSwitch;
        private System.Windows.Forms.Timer timerSendLogEntry;
    }
}

