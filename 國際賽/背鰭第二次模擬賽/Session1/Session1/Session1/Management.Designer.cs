namespace Session1
{
    partial class Management
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TravelertabPage = new System.Windows.Forms.TabPage();
            this.TravelerDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchIcoPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ManagertabPage = new System.Windows.Forms.TabPage();
            this.OwnerDataGridView = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AddListBtn = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.TravelertabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcoPictureBox)).BeginInit();
            this.ManagertabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwnerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TravelertabPage);
            this.tabControl.Controls.Add(this.ManagertabPage);
            this.tabControl.Location = new System.Drawing.Point(19, 151);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(956, 469);
            this.tabControl.TabIndex = 0;
            // 
            // TravelertabPage
            // 
            this.TravelertabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TravelertabPage.Controls.Add(this.TravelerDataGridView);
            this.TravelertabPage.Controls.Add(this.SearchIcoPictureBox);
            this.TravelertabPage.Controls.Add(this.SearchTextBox);
            this.TravelertabPage.Location = new System.Drawing.Point(4, 29);
            this.TravelertabPage.Name = "TravelertabPage";
            this.TravelertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TravelertabPage.Size = new System.Drawing.Size(992, 447);
            this.TravelertabPage.TabIndex = 0;
            this.TravelertabPage.Text = "I\'m Traveler";
            // 
            // TravelerDataGridView
            // 
            this.TravelerDataGridView.AllowUserToAddRows = false;
            this.TravelerDataGridView.AllowUserToDeleteRows = false;
            this.TravelerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TravelerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TravelerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TravelerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn1,
            this.CapacityColumn1,
            this.AreaColumn1,
            this.TypeColumn1});
            this.TravelerDataGridView.EnableHeadersVisualStyles = false;
            this.TravelerDataGridView.Location = new System.Drawing.Point(84, 69);
            this.TravelerDataGridView.Name = "TravelerDataGridView";
            this.TravelerDataGridView.ReadOnly = true;
            this.TravelerDataGridView.RowHeadersVisible = false;
            this.TravelerDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.TravelerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TravelerDataGridView.Size = new System.Drawing.Size(780, 369);
            this.TravelerDataGridView.TabIndex = 2;
            // 
            // SearchIcoPictureBox
            // 
            this.SearchIcoPictureBox.Image = global::Session1.Properties.Resources._135_search;
            this.SearchIcoPictureBox.Location = new System.Drawing.Point(117, 31);
            this.SearchIcoPictureBox.Name = "SearchIcoPictureBox";
            this.SearchIcoPictureBox.Size = new System.Drawing.Size(32, 32);
            this.SearchIcoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchIcoPictureBox.TabIndex = 1;
            this.SearchIcoPictureBox.TabStop = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.White;
            this.SearchTextBox.Font = new System.Drawing.Font("Open Sans", 10F);
            this.SearchTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextBox.Location = new System.Drawing.Point(155, 31);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(521, 30);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Text = "Search destination or Listing TItle or Attraction";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // ManagertabPage
            // 
            this.ManagertabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ManagertabPage.Controls.Add(this.OwnerDataGridView);
            this.ManagertabPage.Controls.Add(this.AddListBtn);
            this.ManagertabPage.Location = new System.Drawing.Point(4, 29);
            this.ManagertabPage.Name = "ManagertabPage";
            this.ManagertabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagertabPage.Size = new System.Drawing.Size(948, 436);
            this.ManagertabPage.TabIndex = 1;
            this.ManagertabPage.Text = "I\'m Owner/Manager";
            // 
            // OwnerDataGridView
            // 
            this.OwnerDataGridView.AllowUserToAddRows = false;
            this.OwnerDataGridView.AllowUserToDeleteRows = false;
            this.OwnerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OwnerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OwnerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OwnerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwnerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.TitleColumn,
            this.CapacityColumn2,
            this.AreaColumn,
            this.TypeColumn,
            this.TColumn});
            this.OwnerDataGridView.EnableHeadersVisualStyles = false;
            this.OwnerDataGridView.Location = new System.Drawing.Point(38, 56);
            this.OwnerDataGridView.Name = "OwnerDataGridView";
            this.OwnerDataGridView.ReadOnly = true;
            this.OwnerDataGridView.RowHeadersVisible = false;
            this.OwnerDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.OwnerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.OwnerDataGridView.Size = new System.Drawing.Size(870, 359);
            this.OwnerDataGridView.TabIndex = 3;
            this.OwnerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OwnerDataGridView_CellClick);
            // 
            // Column
            // 
            this.Column.HeaderText = "ID";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column.Visible = false;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // CapacityColumn2
            // 
            this.CapacityColumn2.HeaderText = "Capacity";
            this.CapacityColumn2.MinimumWidth = 6;
            this.CapacityColumn2.Name = "CapacityColumn2";
            this.CapacityColumn2.ReadOnly = true;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.MinimumWidth = 6;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // TColumn
            // 
            this.TColumn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TColumn.HeaderText = "";
            this.TColumn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TColumn.MinimumWidth = 6;
            this.TColumn.Name = "TColumn";
            this.TColumn.ReadOnly = true;
            this.TColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TColumn.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // AddListBtn
            // 
            this.AddListBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddListBtn.Image = global::Session1.Properties.Resources._267_plus;
            this.AddListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddListBtn.Location = new System.Drawing.Point(38, 6);
            this.AddListBtn.Name = "AddListBtn";
            this.AddListBtn.Size = new System.Drawing.Size(129, 44);
            this.AddListBtn.TabIndex = 1;
            this.AddListBtn.Text = "Add Listing";
            this.AddListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddListBtn.UseVisualStyleBackColor = true;
            this.AddListBtn.Click += new System.EventHandler(this.AddListBtn_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(840, 111);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 34);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(921, 111);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 34);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en1;
            this.LogoPictureBox.Location = new System.Drawing.Point(362, 22);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(261, 97);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 3;
            this.LogoPictureBox.TabStop = false;
            // 
            // TitleColumn1
            // 
            this.TitleColumn1.HeaderText = "Title";
            this.TitleColumn1.MinimumWidth = 6;
            this.TitleColumn1.Name = "TitleColumn1";
            this.TitleColumn1.ReadOnly = true;
            // 
            // CapacityColumn1
            // 
            this.CapacityColumn1.HeaderText = "Capacity";
            this.CapacityColumn1.MinimumWidth = 6;
            this.CapacityColumn1.Name = "CapacityColumn1";
            this.CapacityColumn1.ReadOnly = true;
            // 
            // AreaColumn1
            // 
            this.AreaColumn1.HeaderText = "Area";
            this.AreaColumn1.MinimumWidth = 6;
            this.AreaColumn1.Name = "AreaColumn1";
            this.AreaColumn1.ReadOnly = true;
            // 
            // TypeColumn1
            // 
            this.TypeColumn1.HeaderText = "Type";
            this.TypeColumn1.MinimumWidth = 6;
            this.TypeColumn1.Name = "TypeColumn1";
            this.TypeColumn1.ReadOnly = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            this.Name = "Management";
            this.Size = new System.Drawing.Size(1000, 635);
            this.Load += new System.EventHandler(this.Management_Load);
            this.tabControl.ResumeLayout(false);
            this.TravelertabPage.ResumeLayout(false);
            this.TravelertabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcoPictureBox)).EndInit();
            this.ManagertabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OwnerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TravelertabPage;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TabPage ManagertabPage;
        private System.Windows.Forms.PictureBox SearchIcoPictureBox;
        private System.Windows.Forms.DataGridView TravelerDataGridView;
        private System.Windows.Forms.Button AddListBtn;
        private System.Windows.Forms.DataGridView OwnerDataGridView;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewLinkColumn TColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn1;
    }
}
