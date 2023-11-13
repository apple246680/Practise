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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagerPage = new System.Windows.Forms.TabPage();
            this.ManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arae1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TravelerPage = new System.Windows.Forms.TabPage();
            this.TravelerDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LououtBtn = new System.Windows.Forms.Button();
            this.ManagementTabControl = new System.Windows.Forms.TabControl();
            this.LogoPicturebox = new System.Windows.Forms.PictureBox();
            this.SearchPicturebox = new System.Windows.Forms.PictureBox();
            this.AddListingBtn = new System.Windows.Forms.Button();
            this.ManagerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).BeginInit();
            this.TravelerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).BeginInit();
            this.ManagementTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerPage
            // 
            this.ManagerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ManagerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManagerPage.Controls.Add(this.AddListingBtn);
            this.ManagerPage.Controls.Add(this.ManagerDataGridView);
            this.ManagerPage.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ManagerPage.Location = new System.Drawing.Point(4, 31);
            this.ManagerPage.Name = "ManagerPage";
            this.ManagerPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagerPage.Size = new System.Drawing.Size(768, 265);
            this.ManagerPage.TabIndex = 1;
            this.ManagerPage.Text = "I\'m Owner/Manager";
            // 
            // ManagerDataGridView
            // 
            this.ManagerDataGridView.AllowUserToAddRows = false;
            this.ManagerDataGridView.AllowUserToDeleteRows = false;
            this.ManagerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManagerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ManagerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManagerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Title1Column,
            this.Capacity1Column,
            this.Arae1Column,
            this.Type1Column,
            this.TColumn});
            this.ManagerDataGridView.EnableHeadersVisualStyles = false;
            this.ManagerDataGridView.GridColor = System.Drawing.Color.Black;
            this.ManagerDataGridView.Location = new System.Drawing.Point(6, 44);
            this.ManagerDataGridView.Name = "ManagerDataGridView";
            this.ManagerDataGridView.ReadOnly = true;
            this.ManagerDataGridView.RowHeadersVisible = false;
            this.ManagerDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ManagerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ManagerDataGridView.RowTemplate.Height = 27;
            this.ManagerDataGridView.Size = new System.Drawing.Size(754, 217);
            this.ManagerDataGridView.TabIndex = 3;
            this.ManagerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManagerDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Title1Column
            // 
            this.Title1Column.HeaderText = "Title";
            this.Title1Column.MinimumWidth = 6;
            this.Title1Column.Name = "Title1Column";
            this.Title1Column.ReadOnly = true;
            // 
            // Capacity1Column
            // 
            this.Capacity1Column.HeaderText = "Capacity";
            this.Capacity1Column.MinimumWidth = 6;
            this.Capacity1Column.Name = "Capacity1Column";
            this.Capacity1Column.ReadOnly = true;
            // 
            // Arae1Column
            // 
            this.Arae1Column.HeaderText = "Area";
            this.Arae1Column.MinimumWidth = 6;
            this.Arae1Column.Name = "Arae1Column";
            this.Arae1Column.ReadOnly = true;
            // 
            // Type1Column
            // 
            this.Type1Column.HeaderText = "Type";
            this.Type1Column.MinimumWidth = 6;
            this.Type1Column.Name = "Type1Column";
            this.Type1Column.ReadOnly = true;
            // 
            // TColumn
            // 
            this.TColumn.ActiveLinkColor = System.Drawing.Color.Black;
            this.TColumn.HeaderText = "";
            this.TColumn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.TColumn.MinimumWidth = 6;
            this.TColumn.Name = "TColumn";
            this.TColumn.ReadOnly = true;
            this.TColumn.Text = "Edit Details";
            this.TColumn.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // TravelerPage
            // 
            this.TravelerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TravelerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TravelerPage.Controls.Add(this.TravelerDataGridView);
            this.TravelerPage.Controls.Add(this.SearchPicturebox);
            this.TravelerPage.Controls.Add(this.SearchTextbox);
            this.TravelerPage.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.TravelerPage.Location = new System.Drawing.Point(4, 31);
            this.TravelerPage.Name = "TravelerPage";
            this.TravelerPage.Padding = new System.Windows.Forms.Padding(3);
            this.TravelerPage.Size = new System.Drawing.Size(768, 265);
            this.TravelerPage.TabIndex = 0;
            this.TravelerPage.Text = "I\'m Traveler";
            // 
            // TravelerDataGridView
            // 
            this.TravelerDataGridView.AllowUserToAddRows = false;
            this.TravelerDataGridView.AllowUserToDeleteRows = false;
            this.TravelerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TravelerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TravelerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TravelerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TravelerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.CapacityColumn,
            this.AreaColumn,
            this.TypeColumn});
            this.TravelerDataGridView.EnableHeadersVisualStyles = false;
            this.TravelerDataGridView.GridColor = System.Drawing.Color.Black;
            this.TravelerDataGridView.Location = new System.Drawing.Point(6, 40);
            this.TravelerDataGridView.Name = "TravelerDataGridView";
            this.TravelerDataGridView.ReadOnly = true;
            this.TravelerDataGridView.RowHeadersVisible = false;
            this.TravelerDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.TravelerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TravelerDataGridView.RowTemplate.Height = 27;
            this.TravelerDataGridView.Size = new System.Drawing.Size(754, 217);
            this.TravelerDataGridView.TabIndex = 2;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.HeaderText = "Capacity";
            this.CapacityColumn.MinimumWidth = 6;
            this.CapacityColumn.Name = "CapacityColumn";
            this.CapacityColumn.ReadOnly = true;
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
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.White;
            this.SearchTextbox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextbox.Location = new System.Drawing.Point(72, 6);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(559, 28);
            this.SearchTextbox.TabIndex = 0;
            this.SearchTextbox.Text = "Search destination or Listing Title or Attaction";
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.CountLabel.ForeColor = System.Drawing.Color.Black;
            this.CountLabel.Location = new System.Drawing.Point(122, 526);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(114, 22);
            this.CountLabel.TabIndex = 22;
            this.CountLabel.Text = "0 items found.";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ExitBtn.FlatAppearance.BorderSize = 2;
            this.ExitBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ExitBtn.Location = new System.Drawing.Point(805, 141);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 36);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // LououtBtn
            // 
            this.LououtBtn.BackColor = System.Drawing.Color.White;
            this.LououtBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.LououtBtn.FlatAppearance.BorderSize = 2;
            this.LououtBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.LououtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LououtBtn.Location = new System.Drawing.Point(724, 141);
            this.LououtBtn.Name = "LououtBtn";
            this.LououtBtn.Size = new System.Drawing.Size(75, 36);
            this.LououtBtn.TabIndex = 20;
            this.LououtBtn.Text = "Logout";
            this.LououtBtn.UseVisualStyleBackColor = false;
            // 
            // ManagementTabControl
            // 
            this.ManagementTabControl.Controls.Add(this.TravelerPage);
            this.ManagementTabControl.Controls.Add(this.ManagerPage);
            this.ManagementTabControl.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ManagementTabControl.Location = new System.Drawing.Point(115, 223);
            this.ManagementTabControl.Name = "ManagementTabControl";
            this.ManagementTabControl.SelectedIndex = 0;
            this.ManagementTabControl.Size = new System.Drawing.Size(776, 300);
            this.ManagementTabControl.TabIndex = 19;
            this.ManagementTabControl.SelectedIndexChanged += new System.EventHandler(this.ManagementTabControl_SelectedIndexChanged);
            // 
            // LogoPicturebox
            // 
            this.LogoPicturebox.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.LogoPicturebox.Location = new System.Drawing.Point(260, 129);
            this.LogoPicturebox.Name = "LogoPicturebox";
            this.LogoPicturebox.Size = new System.Drawing.Size(440, 88);
            this.LogoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicturebox.TabIndex = 18;
            this.LogoPicturebox.TabStop = false;
            // 
            // SearchPicturebox
            // 
            this.SearchPicturebox.Image = global::Session1.Properties.Resources._135_search;
            this.SearchPicturebox.Location = new System.Drawing.Point(40, 6);
            this.SearchPicturebox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchPicturebox.Name = "SearchPicturebox";
            this.SearchPicturebox.Size = new System.Drawing.Size(29, 28);
            this.SearchPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchPicturebox.TabIndex = 1;
            this.SearchPicturebox.TabStop = false;
            // 
            // AddListingBtn
            // 
            this.AddListingBtn.BackColor = System.Drawing.Color.White;
            this.AddListingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.AddListingBtn.FlatAppearance.BorderSize = 2;
            this.AddListingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.AddListingBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.AddListingBtn.ForeColor = System.Drawing.Color.Black;
            this.AddListingBtn.Image = global::Session1.Properties.Resources._267_plus;
            this.AddListingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddListingBtn.Location = new System.Drawing.Point(64, -1);
            this.AddListingBtn.Name = "AddListingBtn";
            this.AddListingBtn.Size = new System.Drawing.Size(114, 36);
            this.AddListingBtn.TabIndex = 8;
            this.AddListingBtn.Text = "Add Listing";
            this.AddListingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddListingBtn.UseVisualStyleBackColor = false;
            this.AddListingBtn.Click += new System.EventHandler(this.AddListingBtn_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.LogoPicturebox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LououtBtn);
            this.Controls.Add(this.ManagementTabControl);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Management";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.Management_Load);
            this.ManagerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).EndInit();
            this.TravelerPage.ResumeLayout(false);
            this.TravelerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).EndInit();
            this.ManagementTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicturebox;
        private System.Windows.Forms.TabPage ManagerPage;
        private System.Windows.Forms.Button AddListingBtn;
        private System.Windows.Forms.DataGridView ManagerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arae1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type1Column;
        private System.Windows.Forms.DataGridViewLinkColumn TColumn;
        private System.Windows.Forms.PictureBox SearchPicturebox;
        private System.Windows.Forms.TabPage TravelerPage;
        private System.Windows.Forms.DataGridView TravelerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LououtBtn;
        private System.Windows.Forms.TabControl ManagementTabControl;
    }
}
