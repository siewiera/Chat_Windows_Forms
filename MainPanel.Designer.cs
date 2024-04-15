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
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomList = new System.Windows.Forms.ListView();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.minimizeBtn);
            this.panel2.Controls.Add(this.resizeBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.roomList);
            this.panel2.Controls.Add(this.connectBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 698);
            this.panel2.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.AccessibleDescription = "exit";
            this.exitBtn.AccessibleName = "exit";
            this.exitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.Maroon;
            this.exitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitBtn.Location = new System.Drawing.Point(1152, 10);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(33, 28);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.BackgroundImage")));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.minimizeBtn.ForeColor = System.Drawing.Color.Maroon;
            this.minimizeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeBtn.Location = new System.Drawing.Point(1052, 10);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(33, 28);
            this.minimizeBtn.TabIndex = 24;
            this.minimizeBtn.UseCompatibleTextRendering = true;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.resizeBtn.BackgroundImage = global::Chat.Properties.Resources.increase;
            this.resizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.resizeBtn.FlatAppearance.BorderSize = 0;
            this.resizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.resizeBtn.ForeColor = System.Drawing.Color.Maroon;
            this.resizeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resizeBtn.Location = new System.Drawing.Point(1106, 10);
            this.resizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(32, 28);
            this.resizeBtn.TabIndex = 25;
            this.resizeBtn.UseCompatibleTextRendering = true;
            this.resizeBtn.UseVisualStyleBackColor = false;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(390, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 445);
            this.panel1.TabIndex = 22;
            // 
            // roomList
            // 
            this.roomList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.roomList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.roomList.AllowColumnReorder = true;
            this.roomList.AutoArrange = false;
            this.roomList.BackColor = System.Drawing.Color.Gray;
            this.roomList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomList.BackgroundImage")));
            this.roomList.BackgroundImageTiled = true;
            this.roomList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomList.ForeColor = System.Drawing.Color.White;
            this.roomList.FullRowSelect = true;
            this.roomList.HideSelection = false;
            this.roomList.LabelWrap = false;
            this.roomList.Location = new System.Drawing.Point(16, 243);
            this.roomList.Margin = new System.Windows.Forms.Padding(2);
            this.roomList.MultiSelect = false;
            this.roomList.Name = "roomList";
            this.roomList.ShowGroups = false;
            this.roomList.ShowItemToolTips = true;
            this.roomList.Size = new System.Drawing.Size(362, 374);
            this.roomList.TabIndex = 21;
            this.roomList.UseCompatibleStateImageBehavior = false;
            this.roomList.View = System.Windows.Forms.View.Details;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectBtn.BackgroundImage")));
            this.connectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.connectBtn.FlatAppearance.BorderSize = 2;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.connectBtn.ForeColor = System.Drawing.Color.Transparent;
            this.connectBtn.Image = ((System.Drawing.Image)(resources.GetObject("connectBtn.Image")));
            this.connectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.connectBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.connectBtn.Location = new System.Drawing.Point(202, 647);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.connectBtn.Size = new System.Drawing.Size(176, 37);
            this.connectBtn.TabIndex = 20;
            this.connectBtn.Text = "Connect";
            this.connectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(956, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 702);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 702);
            this.MinimumSize = new System.Drawing.Size(1200, 702);
            this.Name = "MainPanel";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatPanel";
            this.Load += new System.EventHandler(this.roomList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        public System.Windows.Forms.Label label1;
    }
}