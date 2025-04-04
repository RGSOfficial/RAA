namespace RAA__Roblox_Admin_Application_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Action = new System.Windows.Forms.CheckedListBox();
            this.Reason = new System.Windows.Forms.CheckedListBox();
            this.UsernameInputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendRequestButtonModPLR = new Guna.UI2.WinForms.Guna2Button();
            this.ModeraterMessage = new System.Windows.Forms.RichTextBox();
            this.RobloxCopyRight = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDownloadLogs = new Guna.UI2.WinForms.Guna2Button();
            this.userinfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.richTextLogs = new System.Windows.Forms.RichTextBox();
            this.btnSaveLog = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::RAA__Roblox_Admin_Application_.Properties.Resources.RBXLogo;
            this.pictureBox1.Location = new System.Drawing.Point(216, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 122);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Action
            // 
            this.Action.FormattingEnabled = true;
            this.Action.Items.AddRange(new object[] {
            "Kick",
            "Warn",
            "Ban",
            "Terminate",
            "Poision"});
            this.Action.Location = new System.Drawing.Point(2, 128);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(142, 79);
            this.Action.TabIndex = 3;
            this.Action.SelectedIndexChanged += new System.EventHandler(this.Action_SelectedIndexChanged);
            // 
            // Reason
            // 
            this.Reason.FormattingEnabled = true;
            this.Reason.Items.AddRange(new object[] {
            "Hacking & Exploiting",
            "Swearing",
            "Spam",
            "Inappropriate Avatar",
            "Inappropriate Game",
            "Report",
            "Custom"});
            this.Reason.Location = new System.Drawing.Point(2, 213);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(142, 109);
            this.Reason.TabIndex = 4;
            this.Reason.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Reason_ItemCheck);
            this.Reason.SelectedIndexChanged += new System.EventHandler(this.Reason_SelectedIndexChanged);
            // 
            // UsernameInputBox
            // 
            this.UsernameInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameInputBox.DefaultText = "";
            this.UsernameInputBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameInputBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameInputBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameInputBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameInputBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameInputBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameInputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameInputBox.Location = new System.Drawing.Point(2, 86);
            this.UsernameInputBox.Name = "UsernameInputBox";
            this.UsernameInputBox.PlaceholderText = "PLRUsername";
            this.UsernameInputBox.SelectedText = "";
            this.UsernameInputBox.Size = new System.Drawing.Size(142, 36);
            this.UsernameInputBox.TabIndex = 5;
            this.UsernameInputBox.TextChanged += new System.EventHandler(this.UsernameInputBox_TextChanged);
            // 
            // CustomReason
            // 
            this.CustomReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomReason.DefaultText = "";
            this.CustomReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomReason.Location = new System.Drawing.Point(151, 285);
            this.CustomReason.Name = "CustomReason";
            this.CustomReason.PlaceholderText = "Custom Reason";
            this.CustomReason.ReadOnly = true;
            this.CustomReason.SelectedText = "";
            this.CustomReason.Size = new System.Drawing.Size(200, 36);
            this.CustomReason.TabIndex = 6;
            this.CustomReason.TextChanged += new System.EventHandler(this.CustomReason_TextChanged);
            // 
            // SendRequestButtonModPLR
            // 
            this.SendRequestButtonModPLR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendRequestButtonModPLR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendRequestButtonModPLR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendRequestButtonModPLR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendRequestButtonModPLR.FillColor = System.Drawing.Color.White;
            this.SendRequestButtonModPLR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendRequestButtonModPLR.ForeColor = System.Drawing.Color.Black;
            this.SendRequestButtonModPLR.Location = new System.Drawing.Point(2, 328);
            this.SendRequestButtonModPLR.Name = "SendRequestButtonModPLR";
            this.SendRequestButtonModPLR.Size = new System.Drawing.Size(349, 31);
            this.SendRequestButtonModPLR.TabIndex = 8;
            this.SendRequestButtonModPLR.Text = "Send Request";
            // 
            // ModeraterMessage
            // 
            this.ModeraterMessage.Location = new System.Drawing.Point(150, 86);
            this.ModeraterMessage.Name = "ModeraterMessage";
            this.ModeraterMessage.Size = new System.Drawing.Size(201, 193);
            this.ModeraterMessage.TabIndex = 9;
            this.ModeraterMessage.Text = "Moderater Message";
            // 
            // RobloxCopyRight
            // 
            this.RobloxCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.RobloxCopyRight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RobloxCopyRight.DefaultText = "© 2025 Roblox Corporation. Internal Use Only.";
            this.RobloxCopyRight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RobloxCopyRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RobloxCopyRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RobloxCopyRight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RobloxCopyRight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RobloxCopyRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RobloxCopyRight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RobloxCopyRight.Location = new System.Drawing.Point(12, 402);
            this.RobloxCopyRight.Name = "RobloxCopyRight";
            this.RobloxCopyRight.PlaceholderText = "";
            this.RobloxCopyRight.ReadOnly = true;
            this.RobloxCopyRight.SelectedText = "";
            this.RobloxCopyRight.Size = new System.Drawing.Size(260, 36);
            this.RobloxCopyRight.TabIndex = 10;
            // 
            // btnDownloadLogs
            // 
            this.btnDownloadLogs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownloadLogs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownloadLogs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownloadLogs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownloadLogs.FillColor = System.Drawing.Color.White;
            this.btnDownloadLogs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownloadLogs.ForeColor = System.Drawing.Color.Black;
            this.btnDownloadLogs.Location = new System.Drawing.Point(650, 12);
            this.btnDownloadLogs.Name = "btnDownloadLogs";
            this.btnDownloadLogs.Size = new System.Drawing.Size(147, 31);
            this.btnDownloadLogs.TabIndex = 11;
            this.btnDownloadLogs.Text = "Download Logs";
            this.btnDownloadLogs.Click += new System.EventHandler(this.btnDownloadLogs_Click);
            // 
            // userinfo
            // 
            this.userinfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userinfo.DefaultText = "lblUserInfo";
            this.userinfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userinfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userinfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userinfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userinfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userinfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userinfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userinfo.Location = new System.Drawing.Point(2, 3);
            this.userinfo.Name = "userinfo";
            this.userinfo.PlaceholderText = "";
            this.userinfo.ReadOnly = true;
            this.userinfo.SelectedText = "";
            this.userinfo.Size = new System.Drawing.Size(195, 40);
            this.userinfo.TabIndex = 12;
            // 
            // richTextLogs
            // 
            this.richTextLogs.Location = new System.Drawing.Point(650, 49);
            this.richTextLogs.Name = "richTextLogs";
            this.richTextLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextLogs.Size = new System.Drawing.Size(147, 389);
            this.richTextLogs.TabIndex = 13;
            this.richTextLogs.Text = "";
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveLog.FillColor = System.Drawing.Color.White;
            this.btnSaveLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveLog.ForeColor = System.Drawing.Color.Black;
            this.btnSaveLog.Location = new System.Drawing.Point(652, 407);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(145, 31);
            this.btnSaveLog.TabIndex = 14;
            this.btnSaveLog.Text = "Save logs";
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.richTextLogs);
            this.Controls.Add(this.userinfo);
            this.Controls.Add(this.btnDownloadLogs);
            this.Controls.Add(this.RobloxCopyRight);
            this.Controls.Add(this.ModeraterMessage);
            this.Controls.Add(this.SendRequestButtonModPLR);
            this.Controls.Add(this.CustomReason);
            this.Controls.Add(this.UsernameInputBox);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "RAA (dole.simupling.com)";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox Action;
        private System.Windows.Forms.CheckedListBox Reason;
        private Guna.UI2.WinForms.Guna2TextBox UsernameInputBox;
        private Guna.UI2.WinForms.Guna2TextBox CustomReason;
        private Guna.UI2.WinForms.Guna2Button SendRequestButtonModPLR;
        private System.Windows.Forms.RichTextBox ModeraterMessage;
        private Guna.UI2.WinForms.Guna2TextBox RobloxCopyRight;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnDownloadLogs;
        private Guna.UI2.WinForms.Guna2TextBox userinfo;
        private System.Windows.Forms.RichTextBox richTextLogs;
        private Guna.UI2.WinForms.Guna2Button btnSaveLog;
    }
}