namespace Sessopn2
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdvancedSearchBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PeopleNum = new System.Windows.Forms.NumericUpDown();
            this.NightNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.FromDateTImePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.PromptWordLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).BeginInit();
            this.SearchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdvancedSearchBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PeopleNum);
            this.groupBox1.Controls.Add(this.NightNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FromDateTImePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchListBox);
            this.groupBox1.Controls.Add(this.PromptWordLabel);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple search";
            // 
            // AdvancedSearchBtn
            // 
            this.AdvancedSearchBtn.Location = new System.Drawing.Point(748, 61);
            this.AdvancedSearchBtn.Name = "AdvancedSearchBtn";
            this.AdvancedSearchBtn.Size = new System.Drawing.Size(204, 23);
            this.AdvancedSearchBtn.TabIndex = 6;
            this.AdvancedSearchBtn.Text = "Advanced Search";
            this.AdvancedSearchBtn.UseVisualStyleBackColor = true;
            this.AdvancedSearchBtn.Click += new System.EventHandler(this.AdvancedSearchBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(748, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(204, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "night and";
            // 
            // PeopleNum
            // 
            this.PeopleNum.Location = new System.Drawing.Point(616, 107);
            this.PeopleNum.Name = "PeopleNum";
            this.PeopleNum.Size = new System.Drawing.Size(53, 25);
            this.PeopleNum.TabIndex = 2;
            // 
            // NightNum
            // 
            this.NightNum.Location = new System.Drawing.Point(479, 107);
            this.NightNum.Name = "NightNum";
            this.NightNum.Size = new System.Drawing.Size(53, 25);
            this.NightNum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "for";
            // 
            // FromDateTImePicker
            // 
            this.FromDateTImePicker.CustomFormat = "dd/MM/yyyy";
            this.FromDateTImePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTImePicker.Location = new System.Drawing.Point(131, 100);
            this.FromDateTImePicker.Name = "FromDateTImePicker";
            this.FromDateTImePicker.Size = new System.Drawing.Size(200, 25);
            this.FromDateTImePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 15;
            this.SearchListBox.Items.AddRange(new object[] {
            " "});
            this.SearchListBox.Location = new System.Drawing.Point(17, 52);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(456, 94);
            this.SearchListBox.TabIndex = 1;
            // 
            // PromptWordLabel
            // 
            this.PromptWordLabel.Location = new System.Drawing.Point(14, 26);
            this.PromptWordLabel.Name = "PromptWordLabel";
            this.PromptWordLabel.Size = new System.Drawing.Size(695, 23);
            this.PromptWordLabel.TabIndex = 1;
            this.PromptWordLabel.Text = "Enter area name,attraction,property type,amenities...";
            this.PromptWordLabel.Click += new System.EventHandler(this.PromptWordLabel_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(17, 24);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(692, 25);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // SearchResultsGroupBox
            // 
            this.SearchResultsGroupBox.Controls.Add(this.ResultsDataGridView);
            this.SearchResultsGroupBox.Location = new System.Drawing.Point(12, 174);
            this.SearchResultsGroupBox.Name = "SearchResultsGroupBox";
            this.SearchResultsGroupBox.Size = new System.Drawing.Size(952, 351);
            this.SearchResultsGroupBox.TabIndex = 7;
            this.SearchResultsGroupBox.TabStop = false;
            this.SearchResultsGroupBox.Text = "Search results";
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ResultsDataGridView.Location = new System.Drawing.Point(6, 24);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.RowHeadersVisible = false;
            this.ResultsDataGridView.RowHeadersWidth = 51;
            this.ResultsDataGridView.RowTemplate.Height = 27;
            this.ResultsDataGridView.Size = new System.Drawing.Size(940, 319);
            this.ResultsDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservations";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(87, 524);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(117, 15);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Displaying  options";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.SearchResultsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Seoul Stay-Search Properties or Listings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).EndInit();
            this.SearchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label PromptWordLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PeopleNum;
        private System.Windows.Forms.NumericUpDown NightNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FromDateTImePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Button AdvancedSearchBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox SearchResultsGroupBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label CountLabel;
    }
}

