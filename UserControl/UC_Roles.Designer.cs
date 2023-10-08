namespace Chat
{
    partial class UC_Roles
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Roles));
            this.rolesFilterBox = new System.Windows.Forms.ComboBox();
            this.rolesNameBox = new System.Windows.Forms.TextBox();
            this.rolesListBox = new System.Windows.Forms.ListBox();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.rolesFilterIcon = new System.Windows.Forms.Button();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.AddPermissionBtn = new System.Windows.Forms.Button();
            this.rolesList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rolesFilterBox
            // 
            this.rolesFilterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rolesFilterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rolesFilterBox.BackColor = System.Drawing.Color.Gray;
            this.rolesFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rolesFilterBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rolesFilterBox.ForeColor = System.Drawing.Color.White;
            this.rolesFilterBox.Location = new System.Drawing.Point(68, 122);
            this.rolesFilterBox.Name = "rolesFilterBox";
            this.rolesFilterBox.Size = new System.Drawing.Size(386, 30);
            this.rolesFilterBox.Sorted = true;
            this.rolesFilterBox.TabIndex = 51;
            this.rolesFilterBox.SelectedIndexChanged += new System.EventHandler(this.rolesFilterBox_SelectedIndexChanged);
            // 
            // rolesNameBox
            // 
            this.rolesNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.rolesNameBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.rolesNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.rolesNameBox.Location = new System.Drawing.Point(515, 181);
            this.rolesNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rolesNameBox.Name = "rolesNameBox";
            this.rolesNameBox.Size = new System.Drawing.Size(243, 33);
            this.rolesNameBox.TabIndex = 52;
            // 
            // rolesListBox
            // 
            this.rolesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rolesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rolesListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rolesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rolesListBox.FormattingEnabled = true;
            this.rolesListBox.ItemHeight = 29;
            this.rolesListBox.Location = new System.Drawing.Point(515, 375);
            this.rolesListBox.Name = "rolesListBox";
            this.rolesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rolesListBox.Size = new System.Drawing.Size(243, 263);
            this.rolesListBox.TabIndex = 53;
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.permissionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.permissionLabel.Location = new System.Drawing.Point(515, 330);
            this.permissionLabel.MaximumSize = new System.Drawing.Size(243, 0);
            this.permissionLabel.MinimumSize = new System.Drawing.Size(243, 0);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(243, 34);
            this.permissionLabel.TabIndex = 58;
            this.permissionLabel.Text = "Permission";
            // 
            // rolesFilterIcon
            // 
            this.rolesFilterIcon.BackColor = System.Drawing.Color.Transparent;
            this.rolesFilterIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rolesFilterIcon.BackgroundImage")));
            this.rolesFilterIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rolesFilterIcon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.rolesFilterIcon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rolesFilterIcon.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rolesFilterIcon.FlatAppearance.BorderSize = 0;
            this.rolesFilterIcon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rolesFilterIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rolesFilterIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolesFilterIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.rolesFilterIcon.ForeColor = System.Drawing.Color.Maroon;
            this.rolesFilterIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rolesFilterIcon.Location = new System.Drawing.Point(0, 109);
            this.rolesFilterIcon.Margin = new System.Windows.Forms.Padding(0);
            this.rolesFilterIcon.Name = "rolesFilterIcon";
            this.rolesFilterIcon.Size = new System.Drawing.Size(50, 43);
            this.rolesFilterIcon.TabIndex = 56;
            this.rolesFilterIcon.UseCompatibleTextRendering = true;
            this.rolesFilterIcon.UseVisualStyleBackColor = false;
            this.rolesFilterIcon.Click += new System.EventHandler(this.rolesFilterIcon_Click);
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.BackColor = System.Drawing.Color.DarkGray;
            this.AddRoleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddRoleBtn.BackgroundImage")));
            this.AddRoleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRoleBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddRoleBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.AddRoleBtn.FlatAppearance.BorderSize = 2;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoleBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddRoleBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddRoleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRoleBtn.ImageKey = "(none)";
            this.AddRoleBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddRoleBtn.Location = new System.Drawing.Point(515, 223);
            this.AddRoleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddRoleBtn.Size = new System.Drawing.Size(243, 53);
            this.AddRoleBtn.TabIndex = 18;
            this.AddRoleBtn.Text = "Add role";
            this.AddRoleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            this.AddRoleBtn.Click += new System.EventHandler(this.AddRoleBtn_Click);
            // 
            // AddPermissionBtn
            // 
            this.AddPermissionBtn.BackColor = System.Drawing.Color.DarkGray;
            this.AddPermissionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPermissionBtn.BackgroundImage")));
            this.AddPermissionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPermissionBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddPermissionBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddPermissionBtn.FlatAppearance.BorderSize = 2;
            this.AddPermissionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPermissionBtn.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddPermissionBtn.ForeColor = System.Drawing.Color.White;
            this.AddPermissionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPermissionBtn.ImageKey = "(none)";
            this.AddPermissionBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddPermissionBtn.Location = new System.Drawing.Point(515, 656);
            this.AddPermissionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddPermissionBtn.Name = "AddPermissionBtn";
            this.AddPermissionBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPermissionBtn.Size = new System.Drawing.Size(243, 53);
            this.AddPermissionBtn.TabIndex = 17;
            this.AddPermissionBtn.Text = "Add permissions";
            this.AddPermissionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPermissionBtn.UseVisualStyleBackColor = false;
            this.AddPermissionBtn.Click += new System.EventHandler(this.AddPermissionBtn_Click);
            // 
            // rolesList
            // 
            this.rolesList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.rolesList.AllowColumnReorder = true;
            this.rolesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rolesList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rolesList.BackgroundImage")));
            this.rolesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rolesList.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.rolesList.FullRowSelect = true;
            this.rolesList.HideSelection = false;
            this.rolesList.Location = new System.Drawing.Point(0, 181);
            this.rolesList.Margin = new System.Windows.Forms.Padding(0);
            this.rolesList.MaximumSize = new System.Drawing.Size(454, 528);
            this.rolesList.MinimumSize = new System.Drawing.Size(454, 528);
            this.rolesList.Name = "rolesList";
            this.rolesList.Size = new System.Drawing.Size(454, 528);
            this.rolesList.TabIndex = 2;
            this.rolesList.UseCompatibleStateImageBehavior = false;
            this.rolesList.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 59;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 60;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 61;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(416, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 62;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UC_Roles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.permissionLabel);
            this.Controls.Add(this.rolesFilterIcon);
            this.Controls.Add(this.rolesListBox);
            this.Controls.Add(this.rolesNameBox);
            this.Controls.Add(this.rolesFilterBox);
            this.Controls.Add(this.AddRoleBtn);
            this.Controls.Add(this.AddPermissionBtn);
            this.Controls.Add(this.rolesList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(827, 717);
            this.MinimumSize = new System.Drawing.Size(827, 717);
            this.Name = "UC_Roles";
            this.Size = new System.Drawing.Size(827, 717);
            this.Load += new System.EventHandler(this.UC_Roles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView rolesList;
        private System.Windows.Forms.Button AddPermissionBtn;
        private System.Windows.Forms.Button AddRoleBtn;
        public System.Windows.Forms.ComboBox rolesFilterBox;
        private System.Windows.Forms.TextBox rolesNameBox;
        private System.Windows.Forms.ListBox rolesListBox;
        private System.Windows.Forms.Button rolesFilterIcon;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
