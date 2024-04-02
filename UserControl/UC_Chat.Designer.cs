namespace Chat
{
    partial class UC_Chat
    {

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.MessageFieldTextBox = new System.Windows.Forms.RichTextBox();
            this.ChatBoxLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MyMessageLabel5 = new System.Windows.Forms.Label();
            this.MyNicknameAndTimeLabel5 = new System.Windows.Forms.Label();
            this.MyMessageAreaLPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.OtherMessageAreaLPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OtherNicknameAndTimeLabel1 = new System.Windows.Forms.Label();
            this.OtherMessageLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ChatBoxLayoutPanel.SuspendLayout();
            this.MyMessageAreaLPanel5.SuspendLayout();
            this.OtherMessageAreaLPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.ChatBoxLayoutPanel);
            this.panel1.Controls.Add(this.sendMessageBtn);
            this.panel1.Controls.Add(this.MessageFieldTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 440);
            this.panel1.TabIndex = 0;
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendMessageBtn.BackgroundImage")));
            this.sendMessageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendMessageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendMessageBtn.ForeColor = System.Drawing.Color.Lime;
            this.sendMessageBtn.Location = new System.Drawing.Point(679, 378);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(91, 30);
            this.sendMessageBtn.TabIndex = 3;
            this.sendMessageBtn.Text = "Send";
            this.sendMessageBtn.UseVisualStyleBackColor = true;
            // 
            // MessageFieldTextBox
            // 
            this.MessageFieldTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageFieldTextBox.Location = new System.Drawing.Point(230, 380);
            this.MessageFieldTextBox.Name = "MessageFieldTextBox";
            this.MessageFieldTextBox.Size = new System.Drawing.Size(443, 28);
            this.MessageFieldTextBox.TabIndex = 2;
            this.MessageFieldTextBox.Text = "";
            // 
            // ChatBoxLayoutPanel
            // 
            this.ChatBoxLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChatBoxLayoutPanel.Controls.Add(this.MyMessageAreaLPanel5);
            this.ChatBoxLayoutPanel.Controls.Add(this.OtherMessageAreaLPanel1);
            this.ChatBoxLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatBoxLayoutPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChatBoxLayoutPanel.Location = new System.Drawing.Point(230, 26);
            this.ChatBoxLayoutPanel.Name = "ChatBoxLayoutPanel";
            this.ChatBoxLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ChatBoxLayoutPanel.Size = new System.Drawing.Size(540, 348);
            this.ChatBoxLayoutPanel.TabIndex = 1;
            this.ChatBoxLayoutPanel.WrapContents = false;
            this.ChatBoxLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // MyMessageLabel5
            // 
            this.MyMessageLabel5.AutoSize = true;
            this.MyMessageLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MyMessageLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyMessageAreaLPanel5.SetFlowBreak(this.MyMessageLabel5, true);
            this.MyMessageLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyMessageLabel5.ForeColor = System.Drawing.Color.Black;
            this.MyMessageLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyMessageLabel5.Location = new System.Drawing.Point(320, 18);
            this.MyMessageLabel5.Margin = new System.Windows.Forms.Padding(5);
            this.MyMessageLabel5.MaximumSize = new System.Drawing.Size(200, 50);
            this.MyMessageLabel5.MinimumSize = new System.Drawing.Size(200, 20);
            this.MyMessageLabel5.Name = "MyMessageLabel5";
            this.MyMessageLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyMessageLabel5.Size = new System.Drawing.Size(200, 20);
            this.MyMessageLabel5.TabIndex = 2;
            this.MyMessageLabel5.Text = "label3";
            this.MyMessageLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyNicknameAndTimeLabel5
            // 
            this.MyNicknameAndTimeLabel5.AutoSize = true;
            this.MyNicknameAndTimeLabel5.ForeColor = System.Drawing.Color.White;
            this.MyNicknameAndTimeLabel5.Location = new System.Drawing.Point(437, 0);
            this.MyNicknameAndTimeLabel5.Name = "MyNicknameAndTimeLabel5";
            this.MyNicknameAndTimeLabel5.Size = new System.Drawing.Size(85, 13);
            this.MyNicknameAndTimeLabel5.TabIndex = 3;
            this.MyNicknameAndTimeLabel5.Text = "Username 10:34";
            // 
            // MyMessageAreaLPanel5
            // 
            this.MyMessageAreaLPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MyMessageAreaLPanel5.BackColor = System.Drawing.Color.Transparent;
            this.MyMessageAreaLPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyMessageAreaLPanel5.Controls.Add(this.MyNicknameAndTimeLabel5);
            this.MyMessageAreaLPanel5.Controls.Add(this.MyMessageLabel5);
            this.ChatBoxLayoutPanel.SetFlowBreak(this.MyMessageAreaLPanel5, true);
            this.MyMessageAreaLPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MyMessageAreaLPanel5.Location = new System.Drawing.Point(8, 8);
            this.MyMessageAreaLPanel5.Name = "MyMessageAreaLPanel5";
            this.MyMessageAreaLPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyMessageAreaLPanel5.Size = new System.Drawing.Size(525, 61);
            this.MyMessageAreaLPanel5.TabIndex = 6;
            // 
            // OtherMessageAreaLPanel1
            // 
            this.OtherMessageAreaLPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OtherMessageAreaLPanel1.BackColor = System.Drawing.Color.Transparent;
            this.OtherMessageAreaLPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OtherMessageAreaLPanel1.Controls.Add(this.OtherNicknameAndTimeLabel1);
            this.OtherMessageAreaLPanel1.Controls.Add(this.OtherMessageLabel1);
            this.OtherMessageAreaLPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatBoxLayoutPanel.SetFlowBreak(this.OtherMessageAreaLPanel1, true);
            this.OtherMessageAreaLPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OtherMessageAreaLPanel1.Location = new System.Drawing.Point(8, 75);
            this.OtherMessageAreaLPanel1.Name = "OtherMessageAreaLPanel1";
            this.OtherMessageAreaLPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OtherMessageAreaLPanel1.Size = new System.Drawing.Size(525, 61);
            this.OtherMessageAreaLPanel1.TabIndex = 7;
            // 
            // OtherNicknameAndTimeLabel1
            // 
            this.OtherNicknameAndTimeLabel1.AutoSize = true;
            this.OtherNicknameAndTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.OtherNicknameAndTimeLabel1.Location = new System.Drawing.Point(3, 0);
            this.OtherNicknameAndTimeLabel1.Name = "OtherNicknameAndTimeLabel1";
            this.OtherNicknameAndTimeLabel1.Size = new System.Drawing.Size(85, 13);
            this.OtherNicknameAndTimeLabel1.TabIndex = 3;
            this.OtherNicknameAndTimeLabel1.Text = "Username 10:34";
            // 
            // OtherMessageLabel1
            // 
            this.OtherMessageLabel1.AutoSize = true;
            this.OtherMessageLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OtherMessageLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtherMessageAreaLPanel1.SetFlowBreak(this.OtherMessageLabel1, true);
            this.OtherMessageLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OtherMessageLabel1.ForeColor = System.Drawing.Color.Black;
            this.OtherMessageLabel1.Location = new System.Drawing.Point(5, 18);
            this.OtherMessageLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.OtherMessageLabel1.MaximumSize = new System.Drawing.Size(200, 50);
            this.OtherMessageLabel1.MinimumSize = new System.Drawing.Size(200, 20);
            this.OtherMessageLabel1.Name = "OtherMessageLabel1";
            this.OtherMessageLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OtherMessageLabel1.Size = new System.Drawing.Size(200, 20);
            this.OtherMessageLabel1.TabIndex = 2;
            this.OtherMessageLabel1.Text = "label3";
            this.OtherMessageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Chat
            // 
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Chat";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(794, 444);
            this.panel1.ResumeLayout(false);
            this.ChatBoxLayoutPanel.ResumeLayout(false);
            this.MyMessageAreaLPanel5.ResumeLayout(false);
            this.MyMessageAreaLPanel5.PerformLayout();
            this.OtherMessageAreaLPanel1.ResumeLayout(false);
            this.OtherMessageAreaLPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel ChatBoxLayoutPanel;
        private System.Windows.Forms.Button sendMessageBtn;
        private System.Windows.Forms.RichTextBox MessageFieldTextBox;
        private System.Windows.Forms.FlowLayoutPanel MyMessageAreaLPanel5;
        private System.Windows.Forms.Label MyNicknameAndTimeLabel5;
        private System.Windows.Forms.Label MyMessageLabel5;
        private System.Windows.Forms.FlowLayoutPanel OtherMessageAreaLPanel1;
        private System.Windows.Forms.Label OtherNicknameAndTimeLabel1;
        private System.Windows.Forms.Label OtherMessageLabel1;
    }
}
