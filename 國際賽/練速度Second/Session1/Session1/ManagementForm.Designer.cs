﻿namespace Session1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.CountLabel = new System.Windows.Forms.Label();
            this.PageTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.TravelerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hint = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddListingBtn = new System.Windows.Forms.Button();
            this.ManageDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LououtBtn = new System.Windows.Forms.Button();
            this.PageTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(53, 520);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(108, 22);
            this.CountLabel.TabIndex = 11;
            this.CountLabel.Text = "0 items found.";
            // 
            // PageTabControl
            // 
            this.PageTabControl.Controls.Add(this.tabPage1);
            this.PageTabControl.Controls.Add(this.tabPage2);
            this.PageTabControl.Location = new System.Drawing.Point(16, 102);
            this.PageTabControl.Name = "PageTabControl";
            this.PageTabControl.SelectedIndex = 0;
            this.PageTabControl.Size = new System.Drawing.Size(1005, 405);
            this.PageTabControl.TabIndex = 10;
            this.PageTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.tabPage1.Controls.Add(this.SearchIcon);
            this.tabPage1.Controls.Add(this.TravelerDataGridView);
            this.tabPage1.Controls.Add(this.hint);
            this.tabPage1.Controls.Add(this.search);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I\'m Traveler";
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.Location = new System.Drawing.Point(83, 18);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(38, 38);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchIcon.TabIndex = 7;
            this.SearchIcon.TabStop = false;
            // 
            // TravelerDataGridView
            // 
            this.TravelerDataGridView.AllowUserToAddRows = false;
            this.TravelerDataGridView.AllowUserToDeleteRows = false;
            this.TravelerDataGridView.AllowUserToResizeColumns = false;
            this.TravelerDataGridView.AllowUserToResizeRows = false;
            this.TravelerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TravelerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TravelerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.TravelerDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TravelerDataGridView.Location = new System.Drawing.Point(83, 58);
            this.TravelerDataGridView.MultiSelect = false;
            this.TravelerDataGridView.Name = "TravelerDataGridView";
            this.TravelerDataGridView.ReadOnly = true;
            this.TravelerDataGridView.RowHeadersVisible = false;
            this.TravelerDataGridView.RowHeadersWidth = 51;
            this.TravelerDataGridView.RowTemplate.Height = 27;
            this.TravelerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TravelerDataGridView.Size = new System.Drawing.Size(760, 289);
            this.TravelerDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Area";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // hint
            // 
            this.hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.hint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hint.ForeColor = System.Drawing.Color.Black;
            this.hint.Location = new System.Drawing.Point(124, 18);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(719, 22);
            this.hint.TabIndex = 1;
            this.hint.Text = "Search destination or Listing Title or Attraction";
            this.hint.Click += new System.EventHandler(this.hint_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.search.Location = new System.Drawing.Point(127, 18);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(716, 21);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.tabPage2.Controls.Add(this.AddListingBtn);
            this.tabPage2.Controls.Add(this.ManageDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "I\'m Owner / manager";
            // 
            // AddListingBtn
            // 
            this.AddListingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddListingBtn.Font = new System.Drawing.Font("Open Sans Light", 10F);
            this.AddListingBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddListingBtn.Image")));
            this.AddListingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddListingBtn.Location = new System.Drawing.Point(104, 33);
            this.AddListingBtn.Name = "AddListingBtn";
            this.AddListingBtn.Size = new System.Drawing.Size(195, 37);
            this.AddListingBtn.TabIndex = 6;
            this.AddListingBtn.Text = "Add Listing";
            this.AddListingBtn.UseVisualStyleBackColor = true;
            this.AddListingBtn.Click += new System.EventHandler(this.AddListingBtn_Click);
            // 
            // ManageDataGridView
            // 
            this.ManageDataGridView.AllowUserToAddRows = false;
            this.ManageDataGridView.AllowUserToDeleteRows = false;
            this.ManageDataGridView.AllowUserToResizeColumns = false;
            this.ManageDataGridView.AllowUserToResizeRows = false;
            this.ManageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ManageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.ManageDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ManageDataGridView.Location = new System.Drawing.Point(93, 94);
            this.ManageDataGridView.MultiSelect = false;
            this.ManageDataGridView.Name = "ManageDataGridView";
            this.ManageDataGridView.ReadOnly = true;
            this.ManageDataGridView.RowHeadersVisible = false;
            this.ManageDataGridView.RowHeadersWidth = 51;
            this.ManageDataGridView.RowTemplate.Height = 27;
            this.ManageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ManageDataGridView.Size = new System.Drawing.Size(799, 253);
            this.ManageDataGridView.TabIndex = 7;
            this.ManageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 36;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 66;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Capacity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 95;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Area";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 71;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 23;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.Image")));
            this.IconPictureBox.Location = new System.Drawing.Point(244, 10);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(464, 86);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 9;
            this.IconPictureBox.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(923, 24);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 36);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LououtBtn
            // 
            this.LououtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LououtBtn.ForeColor = System.Drawing.Color.Black;
            this.LououtBtn.Location = new System.Drawing.Point(842, 24);
            this.LououtBtn.Name = "LououtBtn";
            this.LououtBtn.Size = new System.Drawing.Size(75, 36);
            this.LououtBtn.TabIndex = 7;
            this.LououtBtn.Text = "Logout";
            this.LououtBtn.UseVisualStyleBackColor = true;
            this.LououtBtn.Click += new System.EventHandler(this.LououtBtn_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1037, 553);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.PageTabControl);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LououtBtn);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ManagementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.PageTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelerDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TabControl PageTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView TravelerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddListingBtn;
        private System.Windows.Forms.DataGridView ManageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LououtBtn;
        private System.Windows.Forms.PictureBox SearchIcon;
    }
}