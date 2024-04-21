namespace Chat
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.fullNameDetailsLabel = new System.Windows.Forms.Label();
            this.emailDetailsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secured = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.adminPanelBtn);
            this.panel2.Controls.Add(this.settingsBtn);
            this.panel2.Controls.Add(this.fullNameDetailsLabel);
            this.panel2.Controls.Add(this.emailDetailsLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.minimizeBtn);
            this.panel2.Controls.Add(this.resizeBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.roomList);
            this.panel2.Controls.Add(this.connectBtn);
            this.panel2.Name = "panel2";
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.BackColor = System.Drawing.Color.Black;
            this.adminPanelBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminPanelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminPanelBtn.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.adminPanelBtn, "adminPanelBtn");
            this.adminPanelBtn.ForeColor = System.Drawing.Color.White;
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.UseVisualStyleBackColor = false;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Black;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.settingsBtn, "settingsBtn");
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // fullNameDetailsLabel
            // 
            resources.ApplyResources(this.fullNameDetailsLabel, "fullNameDetailsLabel");
            this.fullNameDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullNameDetailsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fullNameDetailsLabel.Name = "fullNameDetailsLabel";
            // 
            // emailDetailsLabel
            // 
            resources.ApplyResources(this.emailDetailsLabel, "emailDetailsLabel");
            this.emailDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailDetailsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailDetailsLabel.Name = "emailDetailsLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.ForeColor = System.Drawing.Color.Maroon;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimizeBtn
            // 
            resources.ApplyResources(this.minimizeBtn, "minimizeBtn");
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Maroon;
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.UseCompatibleTextRendering = true;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // resizeBtn
            // 
            resources.ApplyResources(this.resizeBtn, "resizeBtn");
            this.resizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.resizeBtn.BackgroundImage = global::Chat.Properties.Resources.increase;
            this.resizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.resizeBtn.FlatAppearance.BorderSize = 0;
            this.resizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resizeBtn.ForeColor = System.Drawing.Color.Maroon;
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.UseCompatibleTextRendering = true;
            this.resizeBtn.UseVisualStyleBackColor = false;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Name = "panel1";
            // 
            // roomList
            // 
            this.roomList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            resources.ApplyResources(this.roomList, "roomList");
            this.roomList.AllowColumnReorder = true;
            this.roomList.AutoArrange = false;
            this.roomList.BackColor = System.Drawing.Color.Gray;
            this.roomList.BackgroundImageTiled = true;
            this.roomList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.secured});
            this.roomList.ForeColor = System.Drawing.Color.White;
            this.roomList.FullRowSelect = true;
            this.roomList.HideSelection = false;
            this.roomList.MultiSelect = false;
            this.roomList.Name = "roomList";
            this.roomList.ShowGroups = false;
            this.roomList.ShowItemToolTips = true;
            this.roomList.UseCompatibleStateImageBehavior = false;
            this.roomList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            // 
            // secured
            // 
            resources.ApplyResources(this.secured, "secured");
            // 
            // connectBtn
            // 
            resources.ApplyResources(this.connectBtn, "connectBtn");
            this.connectBtn.BackColor = System.Drawing.Color.Black;
            this.connectBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.connectBtn.FlatAppearance.BorderSize = 2;
            this.connectBtn.ForeColor = System.Drawing.Color.Transparent;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.exitBtn;
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPanel";
            this.Load += new System.EventHandler(this.roomList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ListView roomList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader secured;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fullNameDetailsLabel;
        private System.Windows.Forms.Label emailDetailsLabel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button adminPanelBtn;
    }
}