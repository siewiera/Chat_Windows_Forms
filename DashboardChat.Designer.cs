namespace Chat
{
    partial class DashboardChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardChat));
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.chanelButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.Name = "exit";
            this.exit.UseCompatibleTextRendering = true;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // resize
            // 
            resources.ApplyResources(this.resize, "resize");
            this.resize.BackColor = System.Drawing.Color.Transparent;
            this.resize.BackgroundImage = global::Chat.Properties.Resources.increase;
            this.resize.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.resize.FlatAppearance.BorderSize = 0;
            this.resize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resize.ForeColor = System.Drawing.Color.Maroon;
            this.resize.Name = "resize";
            this.resize.UseCompatibleTextRendering = true;
            this.resize.UseVisualStyleBackColor = false;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // chanelButton
            // 
            this.chanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.chanelButton, "chanelButton");
            this.chanelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.chanelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chanelButton.Name = "chanelButton";
            this.chanelButton.UseVisualStyleBackColor = false;
            this.chanelButton.Click += new System.EventHandler(this.chanelButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.accountButton, "accountButton");
            this.accountButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.accountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accountButton.Name = "accountButton";
            this.accountButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button3, "button3");
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // DashboardChat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Chat.Properties.Resources.black_1072366_1920;
            this.CancelButton = this.exit;
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.chanelButton);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardChat";
            this.Load += new System.EventHandler(this.DashboardChat_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button chanelButton;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}