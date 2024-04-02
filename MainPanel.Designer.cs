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
            this.roomList = new System.Windows.Forms.ListView();
            this.connectBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.roomList);
            this.panel2.Controls.Add(this.connectBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 698);
            this.panel2.TabIndex = 0;
            // 
            // roomList
            // 
            this.roomList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.roomList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
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
            this.roomList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomList.Name = "roomList";
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
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.connectBtn.Size = new System.Drawing.Size(176, 37);
            this.connectBtn.TabIndex = 20;
            this.connectBtn.Text = "Connect";
            this.connectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectBtn.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 702);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 702);
            this.MinimumSize = new System.Drawing.Size(400, 702);
            this.Name = "MainPanel";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text = "ChatPanel";
            this.Load += new System.EventHandler(this.roomList_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ListView roomList;
    }
}