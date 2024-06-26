﻿namespace Chat
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.notifTitlelabel = new System.Windows.Forms.Label();
            this.notifContentLabel = new System.Windows.Forms.Label();
            this.notifiImageBox = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.notificationPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.notifiImageBox)).BeginInit();
            this.notificationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifTitlelabel
            // 
            this.notifTitlelabel.AutoSize = true;
            this.notifTitlelabel.BackColor = System.Drawing.Color.Transparent;
            this.notifTitlelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifTitlelabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notifTitlelabel.ForeColor = System.Drawing.Color.Red;
            this.notifTitlelabel.Location = new System.Drawing.Point(103, 22);
            this.notifTitlelabel.MaximumSize = new System.Drawing.Size(260, 46);
            this.notifTitlelabel.MinimumSize = new System.Drawing.Size(260, 46);
            this.notifTitlelabel.Name = "notifTitlelabel";
            this.notifTitlelabel.Size = new System.Drawing.Size(260, 46);
            this.notifTitlelabel.TabIndex = 0;
            this.notifTitlelabel.Text = "Error!";
            this.notifTitlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifContentLabel
            // 
            this.notifContentLabel.AutoSize = true;
            this.notifContentLabel.BackColor = System.Drawing.Color.Transparent;
            this.notifContentLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notifContentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notifContentLabel.Location = new System.Drawing.Point(-2, 90);
            this.notifContentLabel.MaximumSize = new System.Drawing.Size(421, 40);
            this.notifContentLabel.MinimumSize = new System.Drawing.Size(421, 40);
            this.notifContentLabel.Name = "notifContentLabel";
            this.notifContentLabel.Size = new System.Drawing.Size(421, 40);
            this.notifContentLabel.TabIndex = 1;
            this.notifContentLabel.Text = "Something went wrong!";
            this.notifContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notifContentLabel.UseCompatibleTextRendering = true;
            // 
            // notifiImageBox
            // 
            this.notifiImageBox.BackColor = System.Drawing.Color.Transparent;
            this.notifiImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notifiImageBox.BackgroundImage")));
            this.notifiImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notifiImageBox.Location = new System.Drawing.Point(3, 3);
            this.notifiImageBox.Name = "notifiImageBox";
            this.notifiImageBox.Size = new System.Drawing.Size(84, 84);
            this.notifiImageBox.TabIndex = 2;
            this.notifiImageBox.TabStop = false;
            // 
            // exit
            // 
            this.exit.AccessibleDescription = "exit";
            this.exit.AccessibleName = "exit";
            this.exit.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(391, 3);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 25);
            this.exit.TabIndex = 10;
            this.exit.UseCompatibleTextRendering = true;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.Transparent;
            this.notificationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notificationPanel.BackgroundImage")));
            this.notificationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notificationPanel.Controls.Add(this.notifTitlelabel);
            this.notificationPanel.Controls.Add(this.exit);
            this.notificationPanel.Controls.Add(this.notifContentLabel);
            this.notificationPanel.Controls.Add(this.notifiImageBox);
            this.notificationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationPanel.Location = new System.Drawing.Point(1, 1);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(421, 198);
            this.notificationPanel.TabIndex = 11;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(423, 200);
            this.Controls.Add(this.notificationPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(423, 200);
            this.MinimumSize = new System.Drawing.Size(423, 200);
            this.Name = "Notification";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)(this.notifiImageBox)).EndInit();
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label notifTitlelabel;
        private System.Windows.Forms.Label notifContentLabel;
        private System.Windows.Forms.PictureBox notifiImageBox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel notificationPanel;
    }
}