namespace Chat
{
    partial class UC_Chat
    {

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomIdLabel = new System.Windows.Forms.Label();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.ChatBoxLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.MessageFieldTBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.RoomIdLabel);
            this.panel1.Controls.Add(this.RoomNameLabel);
            this.panel1.Controls.Add(this.ChatBoxLayoutPanel);
            this.panel1.Controls.Add(this.SendMessageBtn);
            this.panel1.Controls.Add(this.MessageFieldTBox);
            this.panel1.Name = "panel1";
            // 
            // RoomIdLabel
            // 
            resources.ApplyResources(this.RoomIdLabel, "RoomIdLabel");
            this.RoomIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RoomIdLabel.Name = "RoomIdLabel";
            // 
            // RoomNameLabel
            // 
            resources.ApplyResources(this.RoomNameLabel, "RoomNameLabel");
            this.RoomNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RoomNameLabel.Name = "RoomNameLabel";
            // 
            // ChatBoxLayoutPanel
            // 
            resources.ApplyResources(this.ChatBoxLayoutPanel, "ChatBoxLayoutPanel");
            this.ChatBoxLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChatBoxLayoutPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChatBoxLayoutPanel.Name = "ChatBoxLayoutPanel";
            // 
            // SendMessageBtn
            // 
            resources.ApplyResources(this.SendMessageBtn, "SendMessageBtn");
            this.SendMessageBtn.ForeColor = System.Drawing.Color.Lime;
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // MessageFieldTBox
            // 
            resources.ApplyResources(this.MessageFieldTBox, "MessageFieldTBox");
            this.MessageFieldTBox.BackColor = System.Drawing.Color.Black;
            this.MessageFieldTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MessageFieldTBox.Name = "MessageFieldTBox";
            // 
            // UC_Chat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_Chat";
            this.Load += new System.EventHandler(this.UC_Chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel ChatBoxLayoutPanel;
        public System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.Label RoomIdLabel;
        private System.Windows.Forms.Label RoomNameLabel;
        public System.Windows.Forms.RichTextBox MessageFieldTBox;
    }
}
