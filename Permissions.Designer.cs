namespace Chat
{
    partial class Permissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permissions));
            this.panelPermissions = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.backChangesBtn = new System.Windows.Forms.Button();
            this.savePermissionBtn = new System.Windows.Forms.Button();
            this.roleTxtLabel = new System.Windows.Forms.Label();
            this.usedPermissionsFilterBox = new System.Windows.Forms.ComboBox();
            this.newPermissionsFilterBox = new System.Windows.Forms.ComboBox();
            this.nameRoleLabel = new System.Windows.Forms.TextBox();
            this.leftArrowBtn = new System.Windows.Forms.Button();
            this.dbLeftArrowBtn = new System.Windows.Forms.Button();
            this.dbRightArrowBtn = new System.Windows.Forms.Button();
            this.rightArrowBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleNewPermissionLabel = new System.Windows.Forms.Label();
            this.titlePermissionLabel = new System.Windows.Forms.Label();
            this.newPermissionsList = new System.Windows.Forms.ListView();
            this.newId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newPermissionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usedPermissionsList = new System.Windows.Forms.ListView();
            this.usedId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usedPermissionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleLabel = new System.Windows.Forms.Label();
            this.panelPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPermissions
            // 
            this.panelPermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPermissions.BackColor = System.Drawing.Color.Transparent;
            this.panelPermissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPermissions.BackgroundImage")));
            this.panelPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPermissions.Controls.Add(this.minimize);
            this.panelPermissions.Controls.Add(this.exit);
            this.panelPermissions.Controls.Add(this.backChangesBtn);
            this.panelPermissions.Controls.Add(this.savePermissionBtn);
            this.panelPermissions.Controls.Add(this.roleTxtLabel);
            this.panelPermissions.Controls.Add(this.usedPermissionsFilterBox);
            this.panelPermissions.Controls.Add(this.newPermissionsFilterBox);
            this.panelPermissions.Controls.Add(this.nameRoleLabel);
            this.panelPermissions.Controls.Add(this.leftArrowBtn);
            this.panelPermissions.Controls.Add(this.dbLeftArrowBtn);
            this.panelPermissions.Controls.Add(this.dbRightArrowBtn);
            this.panelPermissions.Controls.Add(this.rightArrowBtn);
            this.panelPermissions.Controls.Add(this.pictureBox1);
            this.panelPermissions.Controls.Add(this.titleNewPermissionLabel);
            this.panelPermissions.Controls.Add(this.titlePermissionLabel);
            this.panelPermissions.Controls.Add(this.newPermissionsList);
            this.panelPermissions.Controls.Add(this.usedPermissionsList);
            this.panelPermissions.Controls.Add(this.titleLabel);
            this.panelPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPermissions.Location = new System.Drawing.Point(2, 2);
            this.panelPermissions.Name = "panelPermissions";
            this.panelPermissions.Padding = new System.Windows.Forms.Padding(2);
            this.panelPermissions.Size = new System.Drawing.Size(773, 636);
            this.panelPermissions.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.minimize.ForeColor = System.Drawing.Color.Maroon;
            this.minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimize.Location = new System.Drawing.Point(691, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 28);
            this.minimize.TabIndex = 77;
            this.minimize.UseCompatibleTextRendering = true;
            this.minimize.UseVisualStyleBackColor = false;
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
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(738, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 28);
            this.exit.TabIndex = 76;
            this.exit.UseCompatibleTextRendering = true;
            this.exit.UseVisualStyleBackColor = false;
            // 
            // backChangesBtn
            // 
            this.backChangesBtn.BackColor = System.Drawing.Color.DarkGray;
            this.backChangesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backChangesBtn.BackgroundImage")));
            this.backChangesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backChangesBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.backChangesBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.backChangesBtn.FlatAppearance.BorderSize = 2;
            this.backChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backChangesBtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.backChangesBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.backChangesBtn.Image = ((System.Drawing.Image)(resources.GetObject("backChangesBtn.Image")));
            this.backChangesBtn.ImageKey = "(none)";
            this.backChangesBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backChangesBtn.Location = new System.Drawing.Point(457, 579);
            this.backChangesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backChangesBtn.MaximumSize = new System.Drawing.Size(140, 50);
            this.backChangesBtn.MinimumSize = new System.Drawing.Size(140, 50);
            this.backChangesBtn.Name = "backChangesBtn";
            this.backChangesBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backChangesBtn.Size = new System.Drawing.Size(140, 50);
            this.backChangesBtn.TabIndex = 75;
            this.backChangesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backChangesBtn.UseCompatibleTextRendering = true;
            this.backChangesBtn.UseVisualStyleBackColor = false;
            this.backChangesBtn.Click += new System.EventHandler(this.backChangesBtn_Click);
            // 
            // savePermissionBtn
            // 
            this.savePermissionBtn.BackColor = System.Drawing.Color.DarkGray;
            this.savePermissionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savePermissionBtn.BackgroundImage")));
            this.savePermissionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savePermissionBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.savePermissionBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.savePermissionBtn.FlatAppearance.BorderSize = 2;
            this.savePermissionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePermissionBtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.savePermissionBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.savePermissionBtn.Image = ((System.Drawing.Image)(resources.GetObject("savePermissionBtn.Image")));
            this.savePermissionBtn.ImageKey = "(none)";
            this.savePermissionBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.savePermissionBtn.Location = new System.Drawing.Point(617, 579);
            this.savePermissionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.savePermissionBtn.MaximumSize = new System.Drawing.Size(140, 50);
            this.savePermissionBtn.MinimumSize = new System.Drawing.Size(140, 50);
            this.savePermissionBtn.Name = "savePermissionBtn";
            this.savePermissionBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.savePermissionBtn.Size = new System.Drawing.Size(140, 50);
            this.savePermissionBtn.TabIndex = 74;
            this.savePermissionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savePermissionBtn.UseCompatibleTextRendering = true;
            this.savePermissionBtn.UseVisualStyleBackColor = false;
            this.savePermissionBtn.Click += new System.EventHandler(this.savePermissionBtn_Click);
            // 
            // roleTxtLabel
            // 
            this.roleTxtLabel.AutoSize = true;
            this.roleTxtLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roleTxtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roleTxtLabel.Location = new System.Drawing.Point(130, 91);
            this.roleTxtLabel.MaximumSize = new System.Drawing.Size(60, 30);
            this.roleTxtLabel.MinimumSize = new System.Drawing.Size(60, 30);
            this.roleTxtLabel.Name = "roleTxtLabel";
            this.roleTxtLabel.Size = new System.Drawing.Size(60, 30);
            this.roleTxtLabel.TabIndex = 73;
            this.roleTxtLabel.Text = "Role";
            // 
            // usedPermissionsFilterBox
            // 
            this.usedPermissionsFilterBox.BackColor = System.Drawing.Color.Black;
            this.usedPermissionsFilterBox.DisplayMember = "-";
            this.usedPermissionsFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usedPermissionsFilterBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usedPermissionsFilterBox.ForeColor = System.Drawing.Color.White;
            this.usedPermissionsFilterBox.Items.AddRange(new object[] {
            "-"});
            this.usedPermissionsFilterBox.Location = new System.Drawing.Point(457, 203);
            this.usedPermissionsFilterBox.Name = "usedPermissionsFilterBox";
            this.usedPermissionsFilterBox.Size = new System.Drawing.Size(300, 25);
            this.usedPermissionsFilterBox.Sorted = true;
            this.usedPermissionsFilterBox.TabIndex = 72;
            this.usedPermissionsFilterBox.ValueMember = "-";
            this.usedPermissionsFilterBox.SelectedIndexChanged += new System.EventHandler(this.usedPermissionsFilterBox_SelectedIndexChanged);
            // 
            // newPermissionsFilterBox
            // 
            this.newPermissionsFilterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.newPermissionsFilterBox.BackColor = System.Drawing.Color.Black;
            this.newPermissionsFilterBox.DisplayMember = "-";
            this.newPermissionsFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPermissionsFilterBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.newPermissionsFilterBox.ForeColor = System.Drawing.Color.White;
            this.newPermissionsFilterBox.Items.AddRange(new object[] {
            "-"});
            this.newPermissionsFilterBox.Location = new System.Drawing.Point(11, 203);
            this.newPermissionsFilterBox.Name = "newPermissionsFilterBox";
            this.newPermissionsFilterBox.Size = new System.Drawing.Size(300, 25);
            this.newPermissionsFilterBox.Sorted = true;
            this.newPermissionsFilterBox.TabIndex = 71;
            this.newPermissionsFilterBox.SelectedIndexChanged += new System.EventHandler(this.newPermissionsFilterBox_SelectedIndexChanged);
            // 
            // nameRoleLabel
            // 
            this.nameRoleLabel.BackColor = System.Drawing.Color.DimGray;
            this.nameRoleLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameRoleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameRoleLabel.ForeColor = System.Drawing.Color.White;
            this.nameRoleLabel.Location = new System.Drawing.Point(196, 91);
            this.nameRoleLabel.MaximumSize = new System.Drawing.Size(220, 30);
            this.nameRoleLabel.MinimumSize = new System.Drawing.Size(220, 30);
            this.nameRoleLabel.Name = "nameRoleLabel";
            this.nameRoleLabel.ReadOnly = true;
            this.nameRoleLabel.Size = new System.Drawing.Size(220, 30);
            this.nameRoleLabel.TabIndex = 70;
            this.nameRoleLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameRoleLabel.WordWrap = false;
            // 
            // leftArrowBtn
            // 
            this.leftArrowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftArrowBtn.BackgroundImage")));
            this.leftArrowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftArrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.leftArrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftArrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftArrowBtn.ForeColor = System.Drawing.Color.Transparent;
            this.leftArrowBtn.Location = new System.Drawing.Point(361, 427);
            this.leftArrowBtn.MaximumSize = new System.Drawing.Size(45, 45);
            this.leftArrowBtn.MinimumSize = new System.Drawing.Size(45, 45);
            this.leftArrowBtn.Name = "leftArrowBtn";
            this.leftArrowBtn.Size = new System.Drawing.Size(45, 45);
            this.leftArrowBtn.TabIndex = 69;
            this.leftArrowBtn.UseVisualStyleBackColor = true;
            this.leftArrowBtn.Click += new System.EventHandler(this.leftArrowBtn_Click);
            // 
            // dbLeftArrowBtn
            // 
            this.dbLeftArrowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbLeftArrowBtn.BackgroundImage")));
            this.dbLeftArrowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbLeftArrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.dbLeftArrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dbLeftArrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dbLeftArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbLeftArrowBtn.ForeColor = System.Drawing.Color.Transparent;
            this.dbLeftArrowBtn.Location = new System.Drawing.Point(361, 478);
            this.dbLeftArrowBtn.MaximumSize = new System.Drawing.Size(45, 45);
            this.dbLeftArrowBtn.MinimumSize = new System.Drawing.Size(45, 45);
            this.dbLeftArrowBtn.Name = "dbLeftArrowBtn";
            this.dbLeftArrowBtn.Size = new System.Drawing.Size(45, 45);
            this.dbLeftArrowBtn.TabIndex = 68;
            this.dbLeftArrowBtn.UseVisualStyleBackColor = true;
            this.dbLeftArrowBtn.Click += new System.EventHandler(this.dbLeftArrowBtn_Click);
            // 
            // dbRightArrowBtn
            // 
            this.dbRightArrowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbRightArrowBtn.BackgroundImage")));
            this.dbRightArrowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbRightArrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.dbRightArrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dbRightArrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dbRightArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbRightArrowBtn.ForeColor = System.Drawing.Color.Transparent;
            this.dbRightArrowBtn.Location = new System.Drawing.Point(361, 337);
            this.dbRightArrowBtn.MaximumSize = new System.Drawing.Size(45, 45);
            this.dbRightArrowBtn.MinimumSize = new System.Drawing.Size(45, 45);
            this.dbRightArrowBtn.Name = "dbRightArrowBtn";
            this.dbRightArrowBtn.Size = new System.Drawing.Size(45, 45);
            this.dbRightArrowBtn.TabIndex = 67;
            this.dbRightArrowBtn.UseVisualStyleBackColor = true;
            this.dbRightArrowBtn.Click += new System.EventHandler(this.dbRightArrowBtn_Click);
            // 
            // rightArrowBtn
            // 
            this.rightArrowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrowBtn.BackgroundImage")));
            this.rightArrowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightArrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.rightArrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightArrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightArrowBtn.ForeColor = System.Drawing.Color.Transparent;
            this.rightArrowBtn.Location = new System.Drawing.Point(361, 286);
            this.rightArrowBtn.MaximumSize = new System.Drawing.Size(45, 45);
            this.rightArrowBtn.MinimumSize = new System.Drawing.Size(45, 45);
            this.rightArrowBtn.Name = "rightArrowBtn";
            this.rightArrowBtn.Size = new System.Drawing.Size(45, 45);
            this.rightArrowBtn.TabIndex = 66;
            this.rightArrowBtn.UseVisualStyleBackColor = true;
            this.rightArrowBtn.Click += new System.EventHandler(this.rightArrowBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(120, 120);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(120, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // titleNewPermissionLabel
            // 
            this.titleNewPermissionLabel.AutoSize = true;
            this.titleNewPermissionLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleNewPermissionLabel.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.titleNewPermissionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.titleNewPermissionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titleNewPermissionLabel.Location = new System.Drawing.Point(6, 161);
            this.titleNewPermissionLabel.Name = "titleNewPermissionLabel";
            this.titleNewPermissionLabel.Size = new System.Drawing.Size(201, 32);
            this.titleNewPermissionLabel.TabIndex = 53;
            this.titleNewPermissionLabel.Text = "New permissions";
            this.titleNewPermissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePermissionLabel
            // 
            this.titlePermissionLabel.AutoSize = true;
            this.titlePermissionLabel.BackColor = System.Drawing.Color.Transparent;
            this.titlePermissionLabel.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.titlePermissionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.titlePermissionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titlePermissionLabel.Location = new System.Drawing.Point(452, 161);
            this.titlePermissionLabel.Name = "titlePermissionLabel";
            this.titlePermissionLabel.Size = new System.Drawing.Size(207, 32);
            this.titlePermissionLabel.TabIndex = 52;
            this.titlePermissionLabel.Text = "Used permissions";
            this.titlePermissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPermissionsList
            // 
            this.newPermissionsList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.newPermissionsList.AllowColumnReorder = true;
            this.newPermissionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPermissionsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPermissionsList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newPermissionsList.BackgroundImage")));
            this.newPermissionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.newId,
            this.newPermissionName});
            this.newPermissionsList.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Italic);
            this.newPermissionsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newPermissionsList.FullRowSelect = true;
            this.newPermissionsList.HideSelection = false;
            this.newPermissionsList.Location = new System.Drawing.Point(11, 238);
            this.newPermissionsList.Margin = new System.Windows.Forms.Padding(0);
            this.newPermissionsList.MaximumSize = new System.Drawing.Size(300, 320);
            this.newPermissionsList.MinimumSize = new System.Drawing.Size(300, 320);
            this.newPermissionsList.Name = "newPermissionsList";
            this.newPermissionsList.Size = new System.Drawing.Size(300, 320);
            this.newPermissionsList.TabIndex = 51;
            this.newPermissionsList.UseCompatibleStateImageBehavior = false;
            this.newPermissionsList.View = System.Windows.Forms.View.Details;
            // 
            // newId
            // 
            this.newId.Text = "ID";
            // 
            // newPermissionName
            // 
            this.newPermissionName.Text = "Permission Name";
            this.newPermissionName.Width = 238;
            // 
            // usedPermissionsList
            // 
            this.usedPermissionsList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.usedPermissionsList.AllowColumnReorder = true;
            this.usedPermissionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usedPermissionsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usedPermissionsList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usedPermissionsList.BackgroundImage")));
            this.usedPermissionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usedId,
            this.usedPermissionName});
            this.usedPermissionsList.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Italic);
            this.usedPermissionsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usedPermissionsList.FullRowSelect = true;
            this.usedPermissionsList.HideSelection = false;
            this.usedPermissionsList.Location = new System.Drawing.Point(457, 238);
            this.usedPermissionsList.Margin = new System.Windows.Forms.Padding(0);
            this.usedPermissionsList.MaximumSize = new System.Drawing.Size(300, 320);
            this.usedPermissionsList.MinimumSize = new System.Drawing.Size(300, 320);
            this.usedPermissionsList.Name = "usedPermissionsList";
            this.usedPermissionsList.Size = new System.Drawing.Size(300, 320);
            this.usedPermissionsList.TabIndex = 50;
            this.usedPermissionsList.UseCompatibleStateImageBehavior = false;
            this.usedPermissionsList.View = System.Windows.Forms.View.Details;
            // 
            // usedId
            // 
            this.usedId.Text = "ID";
            // 
            // usedPermissionName
            // 
            this.usedPermissionName.Text = "Permission Name";
            this.usedPermissionName.Width = 238;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titleLabel.Location = new System.Drawing.Point(125, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(285, 69);
            this.titleLabel.TabIndex = 49;
            this.titleLabel.Text = "Permisson";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Permissions
            // 
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(777, 640);
            this.Controls.Add(this.panelPermissions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(777, 640);
            this.MinimumSize = new System.Drawing.Size(777, 640);
            this.Name = "Permissions";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.permissions_Load);
            this.panelPermissions.ResumeLayout(false);
            this.panelPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPermissions;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView usedPermissionsList;
        private System.Windows.Forms.ListView newPermissionsList;
        private System.Windows.Forms.Label titleNewPermissionLabel;
        private System.Windows.Forms.Label titlePermissionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rightArrowBtn;
        private System.Windows.Forms.Button leftArrowBtn;
        private System.Windows.Forms.Button dbLeftArrowBtn;
        private System.Windows.Forms.Button dbRightArrowBtn;
        private System.Windows.Forms.TextBox nameRoleLabel;
        private System.Windows.Forms.ColumnHeader newId;
        private System.Windows.Forms.ColumnHeader newPermissionName;
        private System.Windows.Forms.ColumnHeader usedId;
        private System.Windows.Forms.ColumnHeader usedPermissionName;
        public System.Windows.Forms.ComboBox newPermissionsFilterBox;
        public System.Windows.Forms.ComboBox usedPermissionsFilterBox;
        private System.Windows.Forms.Label roleTxtLabel;
        private System.Windows.Forms.Button backChangesBtn;
        private System.Windows.Forms.Button savePermissionBtn;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
    }
}
