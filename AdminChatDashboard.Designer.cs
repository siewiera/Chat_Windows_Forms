namespace Chat
{
    partial class AdminChatDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChatDashboard));
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.chanelButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersButton = new System.Windows.Forms.Button();
            this.roleButton = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.chanelButton.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.chanelButton, "chanelButton");
            this.chanelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.chanelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chanelButton.FlatAppearance.BorderSize = 2;
            this.chanelButton.ForeColor = System.Drawing.Color.White;
            this.chanelButton.Image = global::Chat.Properties.Resources.conversation6;
            this.chanelButton.Name = "chanelButton";
            this.chanelButton.UseVisualStyleBackColor = false;
            this.chanelButton.Click += new System.EventHandler(this.chanelButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.settingsButton.FlatAppearance.BorderSize = 2;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.usersButton, "usersButton");
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.usersButton.FlatAppearance.BorderSize = 2;
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Name = "usersButton";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // roleButton
            // 
            this.roleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.roleButton, "roleButton");
            this.roleButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.roleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roleButton.FlatAppearance.BorderSize = 2;
            this.roleButton.ForeColor = System.Drawing.Color.White;
            this.roleButton.Name = "roleButton";
            this.roleButton.UseVisualStyleBackColor = false;
            // 
            // messageButton
            // 
            this.messageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.messageButton, "messageButton");
            this.messageButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.messageButton.FlatAppearance.BorderSize = 2;
            this.messageButton.ForeColor = System.Drawing.Color.White;
            this.messageButton.Name = "messageButton";
            this.messageButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.Name = "titleLabel";
            // 
            // listUsers
            // 
            this.listUsers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            resources.ApplyResources(this.listUsers, "listUsers");
            this.listUsers.AllowDrop = true;
            this.listUsers.BackColor = System.Drawing.Color.Silver;
            this.listUsers.BackgroundImage = global::Chat.Properties.Resources.black_1072366_1920;
            this.listUsers.BackgroundImageTiled = true;
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listUsers.ForeColor = System.Drawing.Color.White;
            this.listUsers.HideSelection = false;
            this.listUsers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listUsers.Items")))});
            this.listUsers.Name = "listUsers";
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "check-red.png");
            // 
            // AdminChatDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelButton = this.exit;
            this.ControlBox = false;
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.roleButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.chanelButton);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminChatDashboard";
            this.Load += new System.EventHandler(this.AdminChatDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button chanelButton;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button roleButton;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ImageList imageList1;
    }
}