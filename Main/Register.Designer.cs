namespace Chat
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.headerRegister = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.usernameImg = new System.Windows.Forms.PictureBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.emailImg = new System.Windows.Forms.PictureBox();
            this.passwordImg = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usernameImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImg)).BeginInit();
            this.SuspendLayout();
            // 
            // headerRegister
            // 
            this.headerRegister.AutoSize = true;
            this.headerRegister.BackColor = System.Drawing.Color.Transparent;
            this.headerRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(44)))), ((int)(((byte)(203)))));
            this.headerRegister.Location = new System.Drawing.Point(348, 110);
            this.headerRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerRegister.Name = "headerRegister";
            this.headerRegister.Size = new System.Drawing.Size(237, 63);
            this.headerRegister.TabIndex = 0;
            this.headerRegister.Text = "Register";
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(918, 9);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 28);
            this.exit.TabIndex = 6;
            this.exit.UseCompatibleTextRendering = true;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // usernameImg
            // 
            this.usernameImg.BackColor = System.Drawing.Color.Transparent;
            this.usernameImg.BackgroundImage = global::Chat.Properties.Resources.user;
            this.usernameImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usernameImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameImg.ErrorImage = null;
            this.usernameImg.Location = new System.Drawing.Point(193, 209);
            this.usernameImg.Margin = new System.Windows.Forms.Padding(4);
            this.usernameImg.Name = "usernameImg";
            this.usernameImg.Size = new System.Drawing.Size(53, 46);
            this.usernameImg.TabIndex = 8;
            this.usernameImg.TabStop = false;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.loginBox.Location = new System.Drawing.Point(303, 209);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(419, 46);
            this.loginBox.TabIndex = 9;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.emailBox.Location = new System.Drawing.Point(303, 277);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(419, 46);
            this.emailBox.TabIndex = 12;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.passwordBox.Location = new System.Drawing.Point(303, 343);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(419, 46);
            this.passwordBox.TabIndex = 14;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(44)))), ((int)(((byte)(203)))));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.Location = new System.Drawing.Point(568, 437);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendButton.Name = "sendButton";
            this.sendButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendButton.Size = new System.Drawing.Size(155, 41);
            this.sendButton.TabIndex = 15;
            this.sendButton.Text = "Send";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.signInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.signInButton.Image = ((System.Drawing.Image)(resources.GetObject("signInButton.Image")));
            this.signInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signInButton.Location = new System.Drawing.Point(303, 437);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(163, 41);
            this.signInButton.TabIndex = 16;
            this.signInButton.Text = "Sign In";
            this.signInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // emailImg
            // 
            this.emailImg.BackColor = System.Drawing.Color.Transparent;
            this.emailImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailImg.BackgroundImage")));
            this.emailImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailImg.ErrorImage = null;
            this.emailImg.Location = new System.Drawing.Point(193, 277);
            this.emailImg.Margin = new System.Windows.Forms.Padding(4);
            this.emailImg.Name = "emailImg";
            this.emailImg.Size = new System.Drawing.Size(53, 46);
            this.emailImg.TabIndex = 17;
            this.emailImg.TabStop = false;
            // 
            // passwordImg
            // 
            this.passwordImg.BackColor = System.Drawing.Color.Transparent;
            this.passwordImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordImg.BackgroundImage")));
            this.passwordImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordImg.ErrorImage = null;
            this.passwordImg.Location = new System.Drawing.Point(193, 343);
            this.passwordImg.Margin = new System.Windows.Forms.Padding(4);
            this.passwordImg.Name = "passwordImg";
            this.passwordImg.Size = new System.Drawing.Size(53, 46);
            this.passwordImg.TabIndex = 18;
            this.passwordImg.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.minimize.ForeColor = System.Drawing.Color.Maroon;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(873, 9);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 28);
            this.minimize.TabIndex = 23;
            this.minimize.UseCompatibleTextRendering = true;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 620);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.passwordImg);
            this.Controls.Add(this.emailImg);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.usernameImg);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.headerRegister);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.usernameImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerRegister;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox usernameImg;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.PictureBox emailImg;
        private System.Windows.Forms.PictureBox passwordImg;
        private System.Windows.Forms.Button minimize;
    }
}