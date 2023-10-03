namespace Chat
{
    partial class UC_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Users));
            this.userFilterIcon = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListView();
            this.userFilterBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userFilterIcon
            // 
            this.userFilterIcon.BackColor = System.Drawing.Color.Transparent;
            this.userFilterIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userFilterIcon.BackgroundImage")));
            this.userFilterIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userFilterIcon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.userFilterIcon.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.userFilterIcon.FlatAppearance.BorderSize = 0;
            this.userFilterIcon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userFilterIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.userFilterIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userFilterIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.userFilterIcon.ForeColor = System.Drawing.Color.Maroon;
            this.userFilterIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userFilterIcon.Location = new System.Drawing.Point(58, 156);
            this.userFilterIcon.Margin = new System.Windows.Forms.Padding(0);
            this.userFilterIcon.Name = "userFilterIcon";
            this.userFilterIcon.Size = new System.Drawing.Size(42, 36);
            this.userFilterIcon.TabIndex = 55;
            this.userFilterIcon.UseCompatibleTextRendering = true;
            this.userFilterIcon.UseVisualStyleBackColor = false;
            // 
            // listUsers
            // 
            this.listUsers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listUsers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listUsers.AllowColumnReorder = true;
            this.listUsers.AutoArrange = false;
            this.listUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listUsers.BackgroundImage")));
            this.listUsers.BackgroundImageTiled = true;
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsers.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listUsers.ForeColor = System.Drawing.Color.Black;
            this.listUsers.FullRowSelect = true;
            this.listUsers.HideSelection = false;
            this.listUsers.LabelWrap = false;
            this.listUsers.Location = new System.Drawing.Point(58, 217);
            this.listUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUsers.MultiSelect = false;
            this.listUsers.Name = "listUsers";
            this.listUsers.ShowGroups = false;
            this.listUsers.ShowItemToolTips = true;
            this.listUsers.Size = new System.Drawing.Size(728, 440);
            this.listUsers.TabIndex = 53;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            // 
            // userFilterBox
            // 
            this.userFilterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userFilterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userFilterBox.BackColor = System.Drawing.Color.Gray;
            this.userFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFilterBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userFilterBox.ForeColor = System.Drawing.Color.White;
            this.userFilterBox.Location = new System.Drawing.Point(115, 162);
            this.userFilterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userFilterBox.Name = "userFilterBox";
            this.userFilterBox.Size = new System.Drawing.Size(288, 30);
            this.userFilterBox.Sorted = true;
            this.userFilterBox.TabIndex = 54;
            // 
            // UC_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userFilterIcon);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.userFilterBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(986, 824);
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userFilterIcon;
        public System.Windows.Forms.ListView listUsers;
        public System.Windows.Forms.ComboBox userFilterBox;
    }
}
