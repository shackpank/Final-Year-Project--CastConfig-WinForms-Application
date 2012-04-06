namespace WindowsApplication1
{
    partial class cmConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmConfigForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.authPw = new System.Windows.Forms.TextBox();
            this.authUser = new System.Windows.Forms.TextBox();
            this.listenPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectionAccept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authRequired = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseLocation = new System.Windows.Forms.Button();
            this.mediaPath = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.transcodeMethod = new System.Windows.Forms.ComboBox();
            this.transcode = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.rescan = new System.Windows.Forms.CheckBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.authPwConfirm = new System.Windows.Forms.TextBox();
            this.configStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authPwConfirm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.authPw);
            this.groupBox1.Controls.Add(this.authUser);
            this.groupBox1.Controls.Add(this.listenPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.connectionAccept);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.authRequired);
            this.groupBox1.Location = new System.Drawing.Point(11, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security && Connection Settings";
            // 
            // authPw
            // 
            this.authPw.Location = new System.Drawing.Point(252, 42);
            this.authPw.Name = "authPw";
            this.authPw.PasswordChar = '*';
            this.authPw.Size = new System.Drawing.Size(159, 20);
            this.authPw.TabIndex = 8;
            // 
            // authUser
            // 
            this.authUser.Location = new System.Drawing.Point(252, 16);
            this.authUser.Name = "authUser";
            this.authUser.Size = new System.Drawing.Size(159, 20);
            this.authUser.TabIndex = 7;
            // 
            // listenPort
            // 
            this.listenPort.Location = new System.Drawing.Point(298, 99);
            this.listenPort.Name = "listenPort";
            this.listenPort.Size = new System.Drawing.Size(50, 20);
            this.listenPort.TabIndex = 6;
            this.listenPort.Text = "3457";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Accept connections from";
            // 
            // connectionAccept
            // 
            this.connectionAccept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectionAccept.FormattingEnabled = true;
            this.connectionAccept.Items.AddRange(new object[] {
            "Any computer",
            "This computer only"});
            this.connectionAccept.Location = new System.Drawing.Point(137, 99);
            this.connectionAccept.Name = "connectionAccept";
            this.connectionAccept.Size = new System.Drawing.Size(123, 21);
            this.connectionAccept.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // authRequired
            // 
            this.authRequired.AutoSize = true;
            this.authRequired.Location = new System.Drawing.Point(9, 19);
            this.authRequired.Name = "authRequired";
            this.authRequired.Size = new System.Drawing.Size(134, 17);
            this.authRequired.TabIndex = 0;
            this.authRequired.Text = "Require Authentication";
            this.authRequired.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chooseLocation);
            this.groupBox2.Controls.Add(this.mediaPath);
            this.groupBox2.Location = new System.Drawing.Point(11, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Media Location";
            // 
            // chooseLocation
            // 
            this.chooseLocation.Location = new System.Drawing.Point(380, 16);
            this.chooseLocation.Name = "chooseLocation";
            this.chooseLocation.Size = new System.Drawing.Size(31, 22);
            this.chooseLocation.TabIndex = 1;
            this.chooseLocation.Text = "...";
            this.chooseLocation.UseVisualStyleBackColor = true;
            this.chooseLocation.Click += new System.EventHandler(this.chooseLocation_Click);
            // 
            // mediaPath
            // 
            this.mediaPath.AutoSize = true;
            this.mediaPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaPath.Location = new System.Drawing.Point(6, 21);
            this.mediaPath.Name = "mediaPath";
            this.mediaPath.Size = new System.Drawing.Size(97, 13);
            this.mediaPath.TabIndex = 0;
            this.mediaPath.Text = "Not chosen yet!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.transcodeMethod);
            this.groupBox3.Controls.Add(this.transcode);
            this.groupBox3.Location = new System.Drawing.Point(11, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transcoding";
            // 
            // transcodeMethod
            // 
            this.transcodeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transcodeMethod.FormattingEnabled = true;
            this.transcodeMethod.Items.AddRange(new object[] {
            "Resize & use libx264 (Flash 9)",
            "Keep original video (Faster, less compatible)"});
            this.transcodeMethod.Location = new System.Drawing.Point(176, 17);
            this.transcodeMethod.Name = "transcodeMethod";
            this.transcodeMethod.Size = new System.Drawing.Size(235, 21);
            this.transcodeMethod.TabIndex = 1;
            // 
            // transcode
            // 
            this.transcode.AutoSize = true;
            this.transcode.Location = new System.Drawing.Point(9, 19);
            this.transcode.Name = "transcode";
            this.transcode.Size = new System.Drawing.Size(161, 17);
            this.transcode.TabIndex = 0;
            this.transcode.Text = "Transcode video files to FLV";
            this.transcode.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(331, 437);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 30);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save && Exit";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // rescan
            // 
            this.rescan.AutoSize = true;
            this.rescan.Location = new System.Drawing.Point(225, 445);
            this.rescan.Name = "rescan";
            this.rescan.Size = new System.Drawing.Size(100, 17);
            this.rescan.TabIndex = 3;
            this.rescan.Text = "Rescan on Quit";
            this.rescan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirm Password";
            // 
            // authPwConfirm
            // 
            this.authPwConfirm.Location = new System.Drawing.Point(252, 68);
            this.authPwConfirm.Name = "authPwConfirm";
            this.authPwConfirm.PasswordChar = '*';
            this.authPwConfirm.Size = new System.Drawing.Size(159, 20);
            this.authPwConfirm.TabIndex = 10;
            // 
            // configStatus
            // 
            this.configStatus.AutoSize = true;
            this.configStatus.Location = new System.Drawing.Point(12, 142);
            this.configStatus.Name = "configStatus";
            this.configStatus.Size = new System.Drawing.Size(303, 13);
            this.configStatus.TabIndex = 4;
            this.configStatus.Text = "Settings loaded from config.py; make changes below and save";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 65);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(446, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 369);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 73);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 67);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(45)))), ((int)(((byte)(103)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(555, 120);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // cmConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 479);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.configStatus);
            this.Controls.Add(this.rescan);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cmConfigForm";
            this.Text = "CastMedia Config";
            this.Load += new System.EventHandler(this.cmConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button chooseLocation;
        private System.Windows.Forms.Label mediaPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox listenPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox connectionAccept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox authRequired;
        private System.Windows.Forms.ComboBox transcodeMethod;
        private System.Windows.Forms.CheckBox transcode;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox rescan;
        private System.Windows.Forms.TextBox authPw;
        private System.Windows.Forms.TextBox authUser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox authPwConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label configStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

