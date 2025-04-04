namespace RAA__Roblox_Admin_Application_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PSWPrompt = new Guna.UI2.WinForms.Guna2TextBox();
            this.USRPrompt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ValidateButton = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.RobloxCopyRight = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PSWPrompt
            // 
            this.PSWPrompt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PSWPrompt.DefaultText = "";
            this.PSWPrompt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PSWPrompt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PSWPrompt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PSWPrompt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PSWPrompt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PSWPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSWPrompt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PSWPrompt.Location = new System.Drawing.Point(247, 159);
            this.PSWPrompt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PSWPrompt.Name = "PSWPrompt";
            this.PSWPrompt.PasswordChar = '.';
            this.PSWPrompt.PlaceholderText = "Password";
            this.PSWPrompt.SelectedText = "";
            this.PSWPrompt.Size = new System.Drawing.Size(257, 50);
            this.PSWPrompt.TabIndex = 2;
            this.PSWPrompt.TextChanged += new System.EventHandler(this.PSWPrompt_TextChanged);
            // 
            // USRPrompt
            // 
            this.USRPrompt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.USRPrompt.DefaultText = "";
            this.USRPrompt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.USRPrompt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.USRPrompt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.USRPrompt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.USRPrompt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USRPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USRPrompt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USRPrompt.Location = new System.Drawing.Point(247, 101);
            this.USRPrompt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.USRPrompt.Name = "USRPrompt";
            this.USRPrompt.PlaceholderText = "Username";
            this.USRPrompt.SelectedText = "";
            this.USRPrompt.Size = new System.Drawing.Size(257, 50);
            this.USRPrompt.TabIndex = 3;
            this.USRPrompt.TextChanged += new System.EventHandler(this.USRPrompt_TextChanged);
            // 
            // ValidateButton
            // 
            this.ValidateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ValidateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ValidateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ValidateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ValidateButton.FillColor = System.Drawing.Color.White;
            this.ValidateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ValidateButton.ForeColor = System.Drawing.Color.Black;
            this.ValidateButton.Location = new System.Drawing.Point(287, 216);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(180, 45);
            this.ValidateButton.TabIndex = 4;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.Image = global::RAA__Roblox_Admin_Application_.Properties.Resources.RBXLogo;
            this.Logo.Location = new System.Drawing.Point(216, -56);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(308, 122);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.RobloxCopyRight.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RobloxCopyRight);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.USRPrompt);
            this.Controls.Add(this.PSWPrompt);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RAA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private Guna.UI2.WinForms.Guna2TextBox PSWPrompt;
        private Guna.UI2.WinForms.Guna2TextBox USRPrompt;
        private Guna.UI2.WinForms.Guna2Button ValidateButton;
        private Guna.UI2.WinForms.Guna2TextBox RobloxCopyRight;
    }
}

