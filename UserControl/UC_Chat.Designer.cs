namespace Chat
{
    partial class UC_Chat
    {

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChatBoxLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MyMessageAreaLPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.MyNicknameAndTimeLabel5 = new System.Windows.Forms.Label();
            this.MyMessageLabel5 = new System.Windows.Forms.Label();
            this.OtherMessageAreaLPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OtherNicknameAndTimeLabel1 = new System.Windows.Forms.Label();
            this.OtherMessageLabel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.MessageFieldTBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.ChatBoxLayoutPanel.SuspendLayout();
            this.MyMessageAreaLPanel5.SuspendLayout();
            this.OtherMessageAreaLPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.ChatBoxLayoutPanel);
            this.panel1.Controls.Add(this.SendMessageBtn);
            this.panel1.Controls.Add(this.MessageFieldTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 440);
            this.panel1.TabIndex = 0;
            // 
            // ChatBoxLayoutPanel
            // 
            this.ChatBoxLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatBoxLayoutPanel.AutoScroll = true;
            this.ChatBoxLayoutPanel.AutoScrollMinSize = new System.Drawing.Size(0, 430);
            this.ChatBoxLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatBoxLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChatBoxLayoutPanel.Controls.Add(this.MyMessageAreaLPanel5);
            this.ChatBoxLayoutPanel.Controls.Add(this.OtherMessageAreaLPanel1);
            this.ChatBoxLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.ChatBoxLayoutPanel.Controls.Add(this.flowLayoutPanel2);
            this.ChatBoxLayoutPanel.Controls.Add(this.flowLayoutPanel3);
            this.ChatBoxLayoutPanel.Controls.Add(this.flowLayoutPanel4);
            this.ChatBoxLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChatBoxLayoutPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChatBoxLayoutPanel.Location = new System.Drawing.Point(230, 26);
            this.ChatBoxLayoutPanel.Name = "ChatBoxLayoutPanel";
            this.ChatBoxLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.ChatBoxLayoutPanel.Size = new System.Drawing.Size(540, 346);
            this.ChatBoxLayoutPanel.TabIndex = 1;
            this.ChatBoxLayoutPanel.WrapContents = false;
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
            this.MyMessageAreaLPanel5.Location = new System.Drawing.Point(8, 23);
            this.MyMessageAreaLPanel5.MaximumSize = new System.Drawing.Size(525, 99999);
            this.MyMessageAreaLPanel5.MinimumSize = new System.Drawing.Size(460, 61);
            this.MyMessageAreaLPanel5.Name = "MyMessageAreaLPanel5";
            this.MyMessageAreaLPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyMessageAreaLPanel5.Size = new System.Drawing.Size(510, 61);
            this.MyMessageAreaLPanel5.TabIndex = 6;
            // 
            // MyNicknameAndTimeLabel5
            // 
            this.MyNicknameAndTimeLabel5.AutoSize = true;
            this.MyNicknameAndTimeLabel5.ForeColor = System.Drawing.Color.White;
            this.MyNicknameAndTimeLabel5.Location = new System.Drawing.Point(422, 0);
            this.MyNicknameAndTimeLabel5.Name = "MyNicknameAndTimeLabel5";
            this.MyNicknameAndTimeLabel5.Size = new System.Drawing.Size(85, 13);
            this.MyNicknameAndTimeLabel5.TabIndex = 3;
            this.MyNicknameAndTimeLabel5.Text = "Username 10:34";
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
            this.MyMessageLabel5.Location = new System.Drawing.Point(305, 18);
            this.MyMessageLabel5.Margin = new System.Windows.Forms.Padding(5);
            this.MyMessageLabel5.MaximumSize = new System.Drawing.Size(480, 99999);
            this.MyMessageLabel5.MinimumSize = new System.Drawing.Size(200, 20);
            this.MyMessageLabel5.Name = "MyMessageLabel5";
            this.MyMessageLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyMessageLabel5.Size = new System.Drawing.Size(200, 20);
            this.MyMessageLabel5.TabIndex = 2;
            this.MyMessageLabel5.Text = "label3";
            this.MyMessageLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.OtherMessageAreaLPanel1.Location = new System.Drawing.Point(8, 90);
            this.OtherMessageAreaLPanel1.Name = "OtherMessageAreaLPanel1";
            this.OtherMessageAreaLPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OtherMessageAreaLPanel1.Size = new System.Drawing.Size(510, 61);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.ChatBoxLayoutPanel.SetFlowBreak(this.flowLayoutPanel1, true);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 157);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(525, 99999);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(460, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(510, 61);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username 10:34";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.label2, true);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(305, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.MaximumSize = new System.Drawing.Size(480, 99999);
            this.label2.MinimumSize = new System.Drawing.Size(200, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.ChatBoxLayoutPanel.SetFlowBreak(this.flowLayoutPanel2, true);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 224);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(525, 99999);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(460, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(510, 61);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(422, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username 10:34";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel2.SetFlowBreak(this.label4, true);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(305, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.MaximumSize = new System.Drawing.Size(480, 99999);
            this.label4.MinimumSize = new System.Drawing.Size(200, 20);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "label3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.ChatBoxLayoutPanel.SetFlowBreak(this.flowLayoutPanel3, true);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 291);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(525, 99999);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(460, 61);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel3.Size = new System.Drawing.Size(510, 61);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username 10:34";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel3.SetFlowBreak(this.label6, true);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(305, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.MaximumSize = new System.Drawing.Size(480, 99999);
            this.label6.MinimumSize = new System.Drawing.Size(200, 20);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "label3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.ChatBoxLayoutPanel.SetFlowBreak(this.flowLayoutPanel4, true);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(8, 358);
            this.flowLayoutPanel4.MaximumSize = new System.Drawing.Size(525, 99999);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(460, 61);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel4.Size = new System.Drawing.Size(510, 61);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(422, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username 10:34";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel4.SetFlowBreak(this.label8, true);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(305, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.MaximumSize = new System.Drawing.Size(480, 99999);
            this.label8.MinimumSize = new System.Drawing.Size(200, 20);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "label3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendMessageBtn.BackgroundImage")));
            this.SendMessageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendMessageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendMessageBtn.ForeColor = System.Drawing.Color.Lime;
            this.SendMessageBtn.Location = new System.Drawing.Point(679, 378);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(91, 30);
            this.SendMessageBtn.TabIndex = 3;
            this.SendMessageBtn.Text = "Send";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // MessageFieldTBox
            // 
            this.MessageFieldTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageFieldTBox.Location = new System.Drawing.Point(230, 378);
            this.MessageFieldTBox.Name = "MessageFieldTBox";
            this.MessageFieldTBox.Size = new System.Drawing.Size(443, 28);
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
            this.Size = new System.Drawing.Size(794, 444);
            this.panel1.ResumeLayout(false);
            this.ChatBoxLayoutPanel.ResumeLayout(false);
            this.MyMessageAreaLPanel5.ResumeLayout(false);
            this.MyMessageAreaLPanel5.PerformLayout();
            this.OtherMessageAreaLPanel1.ResumeLayout(false);
            this.OtherMessageAreaLPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel ChatBoxLayoutPanel;
        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.FlowLayoutPanel MyMessageAreaLPanel5;
        private System.Windows.Forms.Label MyNicknameAndTimeLabel5;
        private System.Windows.Forms.Label MyMessageLabel5;
        private System.Windows.Forms.RichTextBox MessageFieldTBox;
        private System.Windows.Forms.FlowLayoutPanel OtherMessageAreaLPanel1;
        private System.Windows.Forms.Label OtherNicknameAndTimeLabel1;
        private System.Windows.Forms.Label OtherMessageLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
