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
            this.usersList = new System.Windows.Forms.ListView();
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
            this.userFilterIcon.Location = new System.Drawing.Point(0, 113);
            this.userFilterIcon.Margin = new System.Windows.Forms.Padding(0);
            this.userFilterIcon.Name = "userFilterIcon";
            this.userFilterIcon.Size = new System.Drawing.Size(50, 43);
            this.userFilterIcon.TabIndex = 55;
            this.userFilterIcon.UseCompatibleTextRendering = true;
            this.userFilterIcon.UseVisualStyleBackColor = false;
            this.userFilterIcon.UseWaitCursor = true;
            this.userFilterIcon.Click += new System.EventHandler(this.userFilterIcon_Click);
            // 
            // usersList
            // 
            this.usersList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.usersList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.usersList.AllowColumnReorder = true;
            this.usersList.AutoArrange = false;
            this.usersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usersList.BackgroundImage")));
            this.usersList.BackgroundImageTiled = true;
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersList.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.usersList.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.usersList.ForeColor = System.Drawing.Color.Black;
            this.usersList.FullRowSelect = true;
            this.usersList.HideSelection = false;
            this.usersList.LabelWrap = false;
            this.usersList.Location = new System.Drawing.Point(0, 182);
            this.usersList.Margin = new System.Windows.Forms.Padding(0);
            this.usersList.MultiSelect = false;
            this.usersList.Name = "usersList";
            this.usersList.ShowGroups = false;
            this.usersList.ShowItemToolTips = true;
            this.usersList.Size = new System.Drawing.Size(811, 528);
            this.usersList.TabIndex = 53;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.UseWaitCursor = true;
            this.usersList.View = System.Windows.Forms.View.Details;
            // 
            // userFilterBox
            // 
            this.userFilterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userFilterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userFilterBox.BackColor = System.Drawing.Color.Gray;
            this.userFilterBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userFilterBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userFilterBox.ForeColor = System.Drawing.Color.White;
            this.userFilterBox.Location = new System.Drawing.Point(73, 126);
            this.userFilterBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.userFilterBox.Name = "userFilterBox";
            this.userFilterBox.Size = new System.Drawing.Size(345, 30);
            this.userFilterBox.Sorted = true;
            this.userFilterBox.TabIndex = 54;
            this.userFilterBox.UseWaitCursor = true;
            this.userFilterBox.SelectedIndexChanged += new System.EventHandler(this.userFilterBox_SelectedIndexChanged);
            // 
            // UC_Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userFilterIcon);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.userFilterBox);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(827, 717);
            this.MinimumSize = new System.Drawing.Size(827, 717);
            this.Name = "UC_Users";
            this.Size = new System.Drawing.Size(1241, 1076);
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.UC_Users_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userFilterIcon;
        public System.Windows.Forms.ListView usersList;
        public System.Windows.Forms.ComboBox userFilterBox;
    }
}
