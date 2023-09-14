namespace Chat
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.headerLogin = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.passwordImg = new System.Windows.Forms.PictureBox();
            this.usernameImg = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameImg)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.White;
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.loginBox, "loginBox");
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.loginBox.Name = "loginBox";
            this.loginBox.UseWaitCursor = true;
            // 
            // passwordBox
            // 
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.UseWaitCursor = true;
            // 
            // headerLogin
            // 
            resources.ApplyResources(this.headerLogin, "headerLogin");
            this.headerLogin.BackColor = System.Drawing.Color.Transparent;
            this.headerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(44)))), ((int)(((byte)(203)))));
            this.headerLogin.Name = "headerLogin";
            this.headerLogin.UseWaitCursor = true;
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Name = "exit";
            this.exit.UseCompatibleTextRendering = true;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.UseWaitCursor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_2);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(44)))), ((int)(((byte)(203)))));
            resources.ApplyResources(this.signInBtn, "signInBtn");
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.signInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.UseWaitCursor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click_1);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            resources.ApplyResources(this.signUpBtn, "signUpBtn");
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.signUpBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.UseWaitCursor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click_1);
            // 
            // passwordImg
            // 
            this.passwordImg.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.passwordImg, "passwordImg");
            this.passwordImg.Name = "passwordImg";
            this.passwordImg.TabStop = false;
            this.passwordImg.UseWaitCursor = true;
            // 
            // usernameImg
            // 
            this.usernameImg.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.usernameImg, "usernameImg");
            this.usernameImg.Name = "usernameImg";
            this.usernameImg.TabStop = false;
            this.usernameImg.UseWaitCursor = true;
            // 
            // minimize
            // 
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.ForeColor = System.Drawing.Color.Maroon;
            this.minimize.Name = "minimize";
            this.minimize.UseCompatibleTextRendering = true;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.UseWaitCursor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.exit;
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.passwordImg);
            this.Controls.Add(this.usernameImg);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.headerLogin);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.passwordImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label headerLogin;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.PictureBox passwordImg;
        private System.Windows.Forms.PictureBox usernameImg;
        private System.Windows.Forms.Button minimize;
    }
}

