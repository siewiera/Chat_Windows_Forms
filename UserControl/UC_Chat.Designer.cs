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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.RoomIdLabel);
            this.panel1.Controls.Add(this.RoomNameLabel);
            this.panel1.Controls.Add(this.ChatBoxLayoutPanel);
            this.panel1.Controls.Add(this.SendMessageBtn);
            this.panel1.Controls.Add(this.MessageFieldTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 441);
            this.panel1.TabIndex = 0;
            // 
            // RoomIdLabel
            // 
            this.RoomIdLabel.AutoSize = true;
            this.RoomIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoomIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RoomIdLabel.Location = new System.Drawing.Point(16, 11);
            this.RoomIdLabel.MaximumSize = new System.Drawing.Size(40, 20);
            this.RoomIdLabel.MinimumSize = new System.Drawing.Size(40, 20);
            this.RoomIdLabel.Name = "RoomIdLabel";
            this.RoomIdLabel.Size = new System.Drawing.Size(40, 20);
            this.RoomIdLabel.TabIndex = 5;
            this.RoomIdLabel.Text = "0";
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoomNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RoomNameLabel.Location = new System.Drawing.Point(71, 11);
            this.RoomNameLabel.MaximumSize = new System.Drawing.Size(200, 20);
            this.RoomNameLabel.MinimumSize = new System.Drawing.Size(200, 20);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(200, 20);
            this.RoomNameLabel.TabIndex = 4;
            this.RoomNameLabel.Text = "Room name";
            // 
            // ChatBoxLayoutPanel
            // 
            this.ChatBoxLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatBoxLayoutPanel.AutoScroll = true;
            this.ChatBoxLayoutPanel.AutoScrollMinSize = new System.Drawing.Size(0, 300);
            this.ChatBoxLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatBoxLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChatBoxLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatBoxLayoutPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChatBoxLayoutPanel.Location = new System.Drawing.Point(14, 34);
            this.ChatBoxLayoutPanel.Name = "ChatBoxLayoutPanel";
            this.ChatBoxLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.ChatBoxLayoutPanel.Size = new System.Drawing.Size(761, 368);
            this.ChatBoxLayoutPanel.TabIndex = 1;
            this.ChatBoxLayoutPanel.WrapContents = false;
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendMessageBtn.BackgroundImage")));
            this.SendMessageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendMessageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendMessageBtn.ForeColor = System.Drawing.Color.Lime;
            this.SendMessageBtn.Location = new System.Drawing.Point(644, 407);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(130, 30);
            this.SendMessageBtn.TabIndex = 3;
            this.SendMessageBtn.Text = "Send";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // MessageFieldTBox
            // 
            this.MessageFieldTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageFieldTBox.Location = new System.Drawing.Point(14, 407);
            this.MessageFieldTBox.Name = "MessageFieldTBox";
            this.MessageFieldTBox.Size = new System.Drawing.Size(620, 30);
            this.MessageFieldTBox.TabIndex = 2;
            this.MessageFieldTBox.Text = "";
            // 
            // UC_Chat
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Chat";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(795, 445);
            this.Load += new System.EventHandler(this.UC_Chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel ChatBoxLayoutPanel;
        private System.Windows.Forms.RichTextBox MessageFieldTBox;
        public System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.Label RoomIdLabel;
        private System.Windows.Forms.Label RoomNameLabel;
    }
}
