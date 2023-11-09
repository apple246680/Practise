namespace Session1
{
    partial class ManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagementTabControl = new System.Windows.Forms.TabControl();
            this.TravelerPage = new System.Windows.Forms.TabPage();
            this.TravelerDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPicturebox = new System.Windows.Forms.PictureBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.ManagerPage = new System.Windows.Forms.TabPage();
            this.RegisterAndLoginBtn = new System.Windows.Forms.Button();
            this.ManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.Title1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arae1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LogoPicturebox = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LououtBtn = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ManagementTabControl.SuspendLayout();
            this.TravelerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicturebox)).BeginInit();
            this.ManagerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagementTabControl
            // 
            this.ManagementTabControl.Controls.Add(this.TravelerPage);
            this.ManagementTabControl.Controls.Add(this.ManagerPage);
            this.ManagementTabControl.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ManagementTabControl.Location = new System.Drawing.Point(12, 106);
            this.ManagementTabControl.Name = "ManagementTabControl";
            this.ManagementTabControl.SelectedIndex = 0;
            this.ManagementTabControl.Size = new System.Drawing.Size(776, 300);
            this.ManagementTabControl.TabIndex = 1;
            this.ManagementTabControl.SelectedIndexChanged += new System.EventHandler(this.ManagementTabControl_SelectedIndexChanged);
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
            this.TravelerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TravelerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TravelerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.TravelerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TravelerDataGridView.RowTemplate.Height = 27;
            this.TravelerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TravelerDataGridView.Size = new System.Drawing.Size(754, 217);
            this.TravelerDataGridView.TabIndex = 2;
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.MinimumWidth = 6;
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 125;
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.HeaderText = "Capacity";
            this.CapacityColumn.MinimumWidth = 6;
            this.CapacityColumn.Name = "CapacityColumn";
            this.CapacityColumn.ReadOnly = true;
            this.CapacityColumn.Width = 125;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.ReadOnly = true;
            this.AreaColumn.Width = 125;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.MinimumWidth = 6;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 125;
            // 
            // SearchPicturebox
            // 
            this.SearchPicturebox.Image = global::Session1.Properties.Resources._135_search2;
            this.SearchPicturebox.Location = new System.Drawing.Point(40, 6);
            this.SearchPicturebox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchPicturebox.Name = "SearchPicturebox";
            this.SearchPicturebox.Size = new System.Drawing.Size(29, 28);
            this.SearchPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchPicturebox.TabIndex = 1;
            this.SearchPicturebox.TabStop = false;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.SearchTextbox.Location = new System.Drawing.Point(72, 6);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(559, 28);
            this.SearchTextbox.TabIndex = 0;
            this.SearchTextbox.Text = "Search destination or Listing Title or Attaction";
            this.SearchTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTextbox_MouseClick);
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // ManagerPage
            // 
            this.ManagerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ManagerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManagerPage.Controls.Add(this.RegisterAndLoginBtn);
            this.ManagerPage.Controls.Add(this.ManagerDataGridView);
            this.ManagerPage.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ManagerPage.Location = new System.Drawing.Point(4, 31);
            this.ManagerPage.Name = "ManagerPage";
            this.ManagerPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManagerPage.Size = new System.Drawing.Size(768, 265);
            this.ManagerPage.TabIndex = 1;
            this.ManagerPage.Text = "I\'m Owner/Manager";
            // 
            // RegisterAndLoginBtn
            // 
            this.RegisterAndLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.RegisterAndLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.RegisterAndLoginBtn.FlatAppearance.BorderSize = 2;
            this.RegisterAndLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.RegisterAndLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterAndLoginBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.RegisterAndLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.RegisterAndLoginBtn.Image = global::Session1.Properties.Resources._267_plus1;
            this.RegisterAndLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterAndLoginBtn.Location = new System.Drawing.Point(63, 2);
            this.RegisterAndLoginBtn.Name = "RegisterAndLoginBtn";
            this.RegisterAndLoginBtn.Size = new System.Drawing.Size(138, 36);
            this.RegisterAndLoginBtn.TabIndex = 8;
            this.RegisterAndLoginBtn.Text = "Add Listing";
            this.RegisterAndLoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegisterAndLoginBtn.UseVisualStyleBackColor = false;
            this.RegisterAndLoginBtn.Click += new System.EventHandler(this.RegisterAndLoginBtn_Click);
            this.RegisterAndLoginBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Down);
            this.RegisterAndLoginBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            // 
            // ManagerDataGridView
            // 
            this.ManagerDataGridView.AllowUserToAddRows = false;
            this.ManagerDataGridView.AllowUserToDeleteRows = false;
            this.ManagerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ManagerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManagerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ManagerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ManagerDataGridView.RowTemplate.Height = 27;
            this.ManagerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManagerDataGridView.Size = new System.Drawing.Size(754, 217);
            this.ManagerDataGridView.TabIndex = 3;
            this.ManagerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManagerDataGridView_CellContentClick);
            // 
            // Title1Column
            // 
            this.Title1Column.HeaderText = "Title";
            this.Title1Column.MinimumWidth = 6;
            this.Title1Column.Name = "Title1Column";
            this.Title1Column.ReadOnly = true;
            this.Title1Column.Width = 125;
            // 
            // Capacity1Column
            // 
            this.Capacity1Column.HeaderText = "Capacity";
            this.Capacity1Column.MinimumWidth = 6;
            this.Capacity1Column.Name = "Capacity1Column";
            this.Capacity1Column.ReadOnly = true;
            this.Capacity1Column.Width = 125;
            // 
            // Arae1Column
            // 
            this.Arae1Column.HeaderText = "Area";
            this.Arae1Column.MinimumWidth = 6;
            this.Arae1Column.Name = "Arae1Column";
            this.Arae1Column.ReadOnly = true;
            this.Arae1Column.Width = 125;
            // 
            // Type1Column
            // 
            this.Type1Column.HeaderText = "Type";
            this.Type1Column.MinimumWidth = 6;
            this.Type1Column.Name = "Type1Column";
            this.Type1Column.ReadOnly = true;
            this.Type1Column.Width = 125;
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
            this.TColumn.Width = 125;
            // 
            // LogoPicturebox
            // 
            this.LogoPicturebox.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.LogoPicturebox.Location = new System.Drawing.Point(157, 12);
            this.LogoPicturebox.Name = "LogoPicturebox";
            this.LogoPicturebox.Size = new System.Drawing.Size(440, 88);
            this.LogoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicturebox.TabIndex = 0;
            this.LogoPicturebox.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ExitBtn.FlatAppearance.BorderSize = 2;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ExitBtn.Location = new System.Drawing.Point(702, 24);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 36);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LououtBtn
            // 
            this.LououtBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.LououtBtn.FlatAppearance.BorderSize = 2;
            this.LououtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LououtBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.LououtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LououtBtn.Location = new System.Drawing.Point(621, 24);
            this.LououtBtn.Name = "LououtBtn";
            this.LououtBtn.Size = new System.Drawing.Size(75, 36);
            this.LououtBtn.TabIndex = 9;
            this.LououtBtn.Text = "Logout";
            this.LououtBtn.UseVisualStyleBackColor = true;
            this.LououtBtn.Click += new System.EventHandler(this.LououtBtn_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.CountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.CountLabel.Location = new System.Drawing.Point(19, 409);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(114, 22);
            this.CountLabel.TabIndex = 12;
            this.CountLabel.Text = "0 items found.";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LououtBtn);
            this.Controls.Add(this.ManagementTabControl);
            this.Controls.Add(this.LogoPicturebox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ManagementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Management";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.ManagementTabControl.ResumeLayout(false);
            this.TravelerPage.ResumeLayout(false);
            this.TravelerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicturebox)).EndInit();
            this.ManagerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPicturebox;
        private System.Windows.Forms.TabControl ManagementTabControl;
        private System.Windows.Forms.TabPage TravelerPage;
        private System.Windows.Forms.TabPage ManagerPage;
        private System.Windows.Forms.PictureBox SearchPicturebox;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.DataGridView TravelerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridView ManagerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arae1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type1Column;
        private System.Windows.Forms.DataGridViewLinkColumn TColumn;
        private System.Windows.Forms.Button RegisterAndLoginBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LououtBtn;
        private System.Windows.Forms.Label CountLabel;
    }
}