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
            System.Windows.Forms.Button AddPermissionBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Roles));
            this.rolesFilterBox = new System.Windows.Forms.ComboBox();
            this.rolesNameBox = new System.Windows.Forms.TextBox();
            this.rolesListBox = new System.Windows.Forms.ListBox();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.rolesFilterIcon = new System.Windows.Forms.Button();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.rolesList = new System.Windows.Forms.ListView();
            this.removeRoleBtn = new System.Windows.Forms.Button();
            this.editRoleBtn = new System.Windows.Forms.Button();
            this.rolesEditNameBox = new System.Windows.Forms.TextBox();
            this.saveEditBtn = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.rolesEditIcon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            AddPermissionBtn = new System.Windows.Forms.Button();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPermissionBtn
            // 
            AddPermissionBtn.BackColor = System.Drawing.Color.DarkGray;
            AddPermissionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPermissionBtn.BackgroundImage")));
            AddPermissionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            AddPermissionBtn.Cursor = System.Windows.Forms.Cursors.Default;
            AddPermissionBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            AddPermissionBtn.FlatAppearance.BorderSize = 2;
            AddPermissionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddPermissionBtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            AddPermissionBtn.ForeColor = System.Drawing.Color.MediumOrchid;
            AddPermissionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AddPermissionBtn.ImageKey = "(none)";
            AddPermissionBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            AddPermissionBtn.Location = new System.Drawing.Point(498, 630);
            AddPermissionBtn.Margin = new System.Windows.Forms.Padding(4);
            AddPermissionBtn.Name = "AddPermissionBtn";
            AddPermissionBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            AddPermissionBtn.Size = new System.Drawing.Size(284, 53);
            AddPermissionBtn.TabIndex = 17;
            AddPermissionBtn.Text = "Add permissions";
            AddPermissionBtn.UseVisualStyleBackColor = false;
            AddPermissionBtn.Click += new System.EventHandler(this.AddPermissionBtn_Click);
            // 
            // rolesFilterBox
            // 
            this.rolesFilterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rolesFilterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rolesFilterBox.BackColor = System.Drawing.Color.Gray;
            this.rolesFilterBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rolesFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rolesFilterBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.rolesFilterBox.ForeColor = System.Drawing.Color.White;
            this.rolesFilterBox.Location = new System.Drawing.Point(79, 96);
            this.rolesFilterBox.Name = "rolesFilterBox";
            this.rolesFilterBox.Size = new System.Drawing.Size(386, 34);
            this.rolesFilterBox.Sorted = true;
            this.rolesFilterBox.TabIndex = 51;
            this.rolesFilterBox.SelectedIndexChanged += new System.EventHandler(this.rolesFilterBox_SelectedIndexChanged);
            // 
            // rolesNameBox
            // 
            this.rolesNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.rolesNameBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.rolesNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.rolesNameBox.Location = new System.Drawing.Point(498, 155);
            this.rolesNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rolesNameBox.Name = "rolesNameBox";
            this.rolesNameBox.Size = new System.Drawing.Size(284, 33);
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
            this.rolesListBox.Location = new System.Drawing.Point(498, 369);
            this.rolesListBox.Name = "rolesListBox";
            this.rolesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rolesListBox.Size = new System.Drawing.Size(284, 234);
            this.rolesListBox.TabIndex = 53;
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.permissionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.permissionLabel.Location = new System.Drawing.Point(498, 332);
            this.permissionLabel.MaximumSize = new System.Drawing.Size(284, 0);
            this.permissionLabel.MinimumSize = new System.Drawing.Size(284, 0);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(284, 34);
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
            this.rolesFilterIcon.Location = new System.Drawing.Point(11, 83);
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
            this.AddRoleBtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.AddRoleBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddRoleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRoleBtn.ImageKey = "(none)";
            this.AddRoleBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddRoleBtn.Location = new System.Drawing.Point(641, 197);
            this.AddRoleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddRoleBtn.Size = new System.Drawing.Size(141, 53);
            this.AddRoleBtn.TabIndex = 18;
            this.AddRoleBtn.Text = "Add role";
            this.AddRoleBtn.UseCompatibleTextRendering = true;
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            this.AddRoleBtn.Click += new System.EventHandler(this.AddRoleBtn_Click);
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
            this.rolesList.Location = new System.Drawing.Point(11, 155);
            this.rolesList.Margin = new System.Windows.Forms.Padding(0);
            this.rolesList.MaximumSize = new System.Drawing.Size(454, 528);
            this.rolesList.MinimumSize = new System.Drawing.Size(454, 528);
            this.rolesList.MultiSelect = false;
            this.rolesList.Name = "rolesList";
            this.rolesList.Size = new System.Drawing.Size(454, 528);
            this.rolesList.TabIndex = 2;
            this.rolesList.UseCompatibleStateImageBehavior = false;
            this.rolesList.View = System.Windows.Forms.View.Details;
            // 
            // removeRoleBtn
            // 
            this.removeRoleBtn.BackColor = System.Drawing.Color.DarkGray;
            this.removeRoleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeRoleBtn.BackgroundImage")));
            this.removeRoleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeRoleBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.removeRoleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.removeRoleBtn.FlatAppearance.BorderSize = 2;
            this.removeRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRoleBtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.removeRoleBtn.ForeColor = System.Drawing.Color.Red;
            this.removeRoleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeRoleBtn.ImageKey = "(none)";
            this.removeRoleBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.removeRoleBtn.Location = new System.Drawing.Point(498, 197);
            this.removeRoleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeRoleBtn.Name = "removeRoleBtn";
            this.removeRoleBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.removeRoleBtn.Size = new System.Drawing.Size(135, 53);
            this.removeRoleBtn.TabIndex = 59;
            this.removeRoleBtn.Text = "Remove";
            this.removeRoleBtn.UseCompatibleTextRendering = true;
            this.removeRoleBtn.UseVisualStyleBackColor = false;
            this.removeRoleBtn.Click += new System.EventHandler(this.removeRoleBtn_Click);
            // 
            // editRoleBtn
            // 
            this.editRoleBtn.BackColor = System.Drawing.Color.DarkGray;
            this.editRoleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editRoleBtn.BackgroundImage")));
            this.editRoleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editRoleBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.editRoleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editRoleBtn.FlatAppearance.BorderSize = 2;
            this.editRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoleBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.editRoleBtn.ForeColor = System.Drawing.Color.White;
            this.editRoleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editRoleBtn.ImageKey = "(none)";
            this.editRoleBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editRoleBtn.Location = new System.Drawing.Point(498, 258);
            this.editRoleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editRoleBtn.Name = "editRoleBtn";
            this.editRoleBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editRoleBtn.Size = new System.Drawing.Size(284, 53);
            this.editRoleBtn.TabIndex = 60;
            this.editRoleBtn.Text = "Edit";
            this.editRoleBtn.UseCompatibleTextRendering = true;
            this.editRoleBtn.UseVisualStyleBackColor = false;
            this.editRoleBtn.Click += new System.EventHandler(this.editRoleBtn_Click);
            // 
            // rolesEditNameBox
            // 
            this.rolesEditNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.rolesEditNameBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.rolesEditNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.rolesEditNameBox.Location = new System.Drawing.Point(68, 16);
            this.rolesEditNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rolesEditNameBox.Name = "rolesEditNameBox";
            this.rolesEditNameBox.Size = new System.Drawing.Size(284, 33);
            this.rolesEditNameBox.TabIndex = 61;
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.BackColor = System.Drawing.Color.DarkGray;
            this.saveEditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveEditBtn.BackgroundImage")));
            this.saveEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveEditBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.saveEditBtn.FlatAppearance.BorderSize = 2;
            this.saveEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEditBtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.saveEditBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.saveEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveEditBtn.ImageKey = "(none)";
            this.saveEditBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveEditBtn.Location = new System.Drawing.Point(360, 6);
            this.saveEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saveEditBtn.Size = new System.Drawing.Size(94, 43);
            this.saveEditBtn.TabIndex = 62;
            this.saveEditBtn.Text = "Save";
            this.saveEditBtn.UseCompatibleTextRendering = true;
            this.saveEditBtn.UseVisualStyleBackColor = false;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.rolesEditIcon);
            this.editPanel.Controls.Add(this.rolesEditNameBox);
            this.editPanel.Controls.Add(this.saveEditBtn);
            this.editPanel.Location = new System.Drawing.Point(11, 11);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(454, 69);
            this.editPanel.TabIndex = 63;
            this.editPanel.Visible = false;
            // 
            // rolesEditIcon
            // 
            this.rolesEditIcon.BackColor = System.Drawing.Color.Transparent;
            this.rolesEditIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rolesEditIcon.BackgroundImage")));
            this.rolesEditIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rolesEditIcon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.rolesEditIcon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rolesEditIcon.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.rolesEditIcon.FlatAppearance.BorderSize = 0;
            this.rolesEditIcon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rolesEditIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rolesEditIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolesEditIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.rolesEditIcon.ForeColor = System.Drawing.Color.Maroon;
            this.rolesEditIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rolesEditIcon.Location = new System.Drawing.Point(0, 6);
            this.rolesEditIcon.Margin = new System.Windows.Forms.Padding(0);
            this.rolesEditIcon.Name = "rolesEditIcon";
            this.rolesEditIcon.Size = new System.Drawing.Size(50, 43);
            this.rolesEditIcon.TabIndex = 64;
            this.rolesEditIcon.UseCompatibleTextRendering = true;
            this.rolesEditIcon.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 64;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 39);
            this.button2.TabIndex = 65;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 39);
            this.button3.TabIndex = 66;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 39);
            this.button4.TabIndex = 67;
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
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.editRoleBtn);
            this.Controls.Add(this.removeRoleBtn);
            this.Controls.Add(this.permissionLabel);
            this.Controls.Add(this.rolesFilterIcon);
            this.Controls.Add(this.rolesListBox);
            this.Controls.Add(this.rolesNameBox);
            this.Controls.Add(this.rolesFilterBox);
            this.Controls.Add(this.AddRoleBtn);
            this.Controls.Add(AddPermissionBtn);
            this.Controls.Add(this.rolesList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(806, 690);
            this.MinimumSize = new System.Drawing.Size(806, 690);
            this.Name = "UC_Roles";
            this.Size = new System.Drawing.Size(806, 690);
            this.Load += new System.EventHandler(this.UC_Roles_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView rolesList;
        private System.Windows.Forms.Button AddRoleBtn;
        public System.Windows.Forms.ComboBox rolesFilterBox;
        private System.Windows.Forms.TextBox rolesNameBox;
        private System.Windows.Forms.ListBox rolesListBox;
        private System.Windows.Forms.Button rolesFilterIcon;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.Button removeRoleBtn;
        private System.Windows.Forms.Button editRoleBtn;
        private System.Windows.Forms.TextBox rolesEditNameBox;
        private System.Windows.Forms.Button saveEditBtn;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button rolesEditIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
