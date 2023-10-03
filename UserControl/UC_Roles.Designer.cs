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
            this.listRoles = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.userFilterBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listRoles
            // 
            this.listRoles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listRoles.AllowColumnReorder = true;
            this.listRoles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listRoles.BackgroundImage")));
            this.listRoles.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.listRoles.HideSelection = false;
            this.listRoles.Location = new System.Drawing.Point(24, 105);
            this.listRoles.Name = "listRoles";
            this.listRoles.Size = new System.Drawing.Size(444, 550);
            this.listRoles.TabIndex = 2;
            this.listRoles.UseCompatibleStateImageBehavior = false;
            this.listRoles.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 26);
            this.textBox1.TabIndex = 5;
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddPermission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPermission.BackgroundImage")));
            this.btnAddPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPermission.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddPermission.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPermission.FlatAppearance.BorderSize = 2;
            this.btnAddPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPermission.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPermission.ForeColor = System.Drawing.Color.White;
            this.btnAddPermission.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPermission.ImageKey = "(none)";
            this.btnAddPermission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPermission.Location = new System.Drawing.Point(506, 602);
            this.btnAddPermission.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddPermission.Size = new System.Drawing.Size(243, 53);
            this.btnAddPermission.TabIndex = 17;
            this.btnAddPermission.Text = "Add permissions";
            this.btnAddPermission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPermission.UseVisualStyleBackColor = false;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRole.BackgroundImage")));
            this.btnAddRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddRole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRole.FlatAppearance.BorderSize = 2;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRole.ImageKey = "(none)";
            this.btnAddRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddRole.Location = new System.Drawing.Point(506, 158);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddRole.Size = new System.Drawing.Size(243, 53);
            this.btnAddRole.TabIndex = 18;
            this.btnAddRole.Text = "Add role";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.UseVisualStyleBackColor = false;
            // 
            // userFilterBox
            // 
            this.userFilterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userFilterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userFilterBox.BackColor = System.Drawing.Color.Gray;
            this.userFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFilterBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userFilterBox.ForeColor = System.Drawing.Color.White;
            this.userFilterBox.Location = new System.Drawing.Point(144, 55);
            this.userFilterBox.Name = "userFilterBox";
            this.userFilterBox.Size = new System.Drawing.Size(324, 30);
            this.userFilterBox.Sorted = true;
            this.userFilterBox.TabIndex = 51;
            // 
            // UC_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userFilterBox);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnAddPermission);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listRoles);
            this.DoubleBuffered = true;
            this.Name = "UC_Roles";
            this.Size = new System.Drawing.Size(846, 691);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listRoles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.Button btnAddRole;
        public System.Windows.Forms.ComboBox userFilterBox;
    }
}
