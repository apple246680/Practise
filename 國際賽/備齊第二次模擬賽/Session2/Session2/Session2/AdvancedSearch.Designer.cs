namespace Session2
{
    partial class AdvancedSearch
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.MaxPriceLabel = new System.Windows.Forms.Label();
            this.StartPriceLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.PeopleNum = new System.Windows.Forms.NumericUpDown();
            this.StartPrice = new System.Windows.Forms.NumericUpDown();
            this.NightLabel = new System.Windows.Forms.Label();
            this.NightNum = new System.Windows.Forms.NumericUpDown();
            this.ForLabel = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AttractionComboBox = new System.Windows.Forms.ComboBox();
            this.AttractionLabel = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.AdvancedSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.SearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompletedReservationsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SimpleSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).BeginInit();
            this.AdvancedSearchGroupBox.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.SearchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TypeComboBox.DisplayMember = "Name";
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(820, 140);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(283, 25);
            this.TypeComboBox.TabIndex = 20;
            this.TypeComboBox.ValueMember = "ID";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(718, 147);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(88, 17);
            this.TypeLabel.TabIndex = 19;
            this.TypeLabel.Text = "Property Type:";
            // 
            // MaxPrice
            // 
            this.MaxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.MaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxPrice.DecimalPlaces = 2;
            this.MaxPrice.ForeColor = System.Drawing.Color.Black;
            this.MaxPrice.Location = new System.Drawing.Point(501, 140);
            this.MaxPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(120, 24);
            this.MaxPrice.TabIndex = 18;
            // 
            // MaxPriceLabel
            // 
            this.MaxPriceLabel.AutoSize = true;
            this.MaxPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.MaxPriceLabel.Location = new System.Drawing.Point(361, 144);
            this.MaxPriceLabel.Name = "MaxPriceLabel";
            this.MaxPriceLabel.Size = new System.Drawing.Size(96, 17);
            this.MaxPriceLabel.TabIndex = 17;
            this.MaxPriceLabel.Text = "Maximum price:";
            // 
            // StartPriceLabel
            // 
            this.StartPriceLabel.AutoSize = true;
            this.StartPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.StartPriceLabel.Location = new System.Drawing.Point(53, 144);
            this.StartPriceLabel.Name = "StartPriceLabel";
            this.StartPriceLabel.Size = new System.Drawing.Size(84, 17);
            this.StartPriceLabel.TabIndex = 15;
            this.StartPriceLabel.Text = "Starting price:";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.ForeColor = System.Drawing.Color.Black;
            this.PeopleLabel.Location = new System.Drawing.Point(1057, 90);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(46, 17);
            this.PeopleLabel.TabIndex = 14;
            this.PeopleLabel.Text = "people";
            // 
            // PeopleNum
            // 
            this.PeopleNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.PeopleNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeopleNum.ForeColor = System.Drawing.Color.Black;
            this.PeopleNum.Location = new System.Drawing.Point(913, 86);
            this.PeopleNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PeopleNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleNum.Name = "PeopleNum";
            this.PeopleNum.Size = new System.Drawing.Size(129, 24);
            this.PeopleNum.TabIndex = 13;
            this.PeopleNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartPrice
            // 
            this.StartPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.StartPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPrice.DecimalPlaces = 2;
            this.StartPrice.ForeColor = System.Drawing.Color.Black;
            this.StartPrice.Location = new System.Drawing.Point(192, 140);
            this.StartPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StartPrice.Name = "StartPrice";
            this.StartPrice.Size = new System.Drawing.Size(120, 24);
            this.StartPrice.TabIndex = 16;
            // 
            // NightLabel
            // 
            this.NightLabel.AutoSize = true;
            this.NightLabel.ForeColor = System.Drawing.Color.Black;
            this.NightLabel.Location = new System.Drawing.Point(833, 90);
            this.NightLabel.Name = "NightLabel";
            this.NightLabel.Size = new System.Drawing.Size(58, 17);
            this.NightLabel.TabIndex = 12;
            this.NightLabel.Text = "night and";
            // 
            // NightNum
            // 
            this.NightNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.NightNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NightNum.ForeColor = System.Drawing.Color.Black;
            this.NightNum.Location = new System.Drawing.Point(689, 86);
            this.NightNum.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.NightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NightNum.Name = "NightNum";
            this.NightNum.Size = new System.Drawing.Size(138, 24);
            this.NightNum.TabIndex = 11;
            this.NightNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ForLabel
            // 
            this.ForLabel.AutoSize = true;
            this.ForLabel.ForeColor = System.Drawing.Color.Black;
            this.ForLabel.Location = new System.Drawing.Point(642, 90);
            this.ForLabel.Name = "ForLabel";
            this.ForLabel.Size = new System.Drawing.Size(24, 17);
            this.ForLabel.TabIndex = 10;
            this.ForLabel.Text = "for";
            // 
            // ToDate
            // 
            this.ToDate.CalendarForeColor = System.Drawing.Color.Black;
            this.ToDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ToDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.ToDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.ToDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(406, 86);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 24);
            this.ToDate.TabIndex = 9;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.ForeColor = System.Drawing.Color.Black;
            this.ToLabel.Location = new System.Drawing.Point(331, 90);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(24, 17);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "To:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.ForeColor = System.Drawing.Color.Black;
            this.FromLabel.Location = new System.Drawing.Point(49, 90);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(40, 17);
            this.FromLabel.TabIndex = 6;
            this.FromLabel.Text = "From:";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TitleComboBox.ForeColor = System.Drawing.Color.Black;
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(850, 41);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(253, 25);
            this.TitleComboBox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(759, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(85, 17);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Property Title:";
            // 
            // AttractionComboBox
            // 
            this.AttractionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.AttractionComboBox.DisplayMember = "Name";
            this.AttractionComboBox.ForeColor = System.Drawing.Color.Black;
            this.AttractionComboBox.FormattingEnabled = true;
            this.AttractionComboBox.Location = new System.Drawing.Point(458, 41);
            this.AttractionComboBox.Name = "AttractionComboBox";
            this.AttractionComboBox.Size = new System.Drawing.Size(253, 25);
            this.AttractionComboBox.TabIndex = 3;
            this.AttractionComboBox.ValueMember = "ID";
            // 
            // AttractionLabel
            // 
            this.AttractionLabel.AutoSize = true;
            this.AttractionLabel.ForeColor = System.Drawing.Color.Black;
            this.AttractionLabel.Location = new System.Drawing.Point(388, 44);
            this.AttractionLabel.Name = "AttractionLabel";
            this.AttractionLabel.Size = new System.Drawing.Size(64, 17);
            this.AttractionLabel.TabIndex = 2;
            this.AttractionLabel.Text = "Attraction:";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.AreaComboBox.DisplayMember = "Name";
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.ForeColor = System.Drawing.Color.Black;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(102, 41);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(253, 25);
            this.AreaComboBox.TabIndex = 1;
            this.AreaComboBox.ValueMember = "ID";
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.ForeColor = System.Drawing.Color.Black;
            this.AreaLabel.Location = new System.Drawing.Point(49, 45);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(36, 17);
            this.AreaLabel.TabIndex = 0;
            this.AreaLabel.Text = "Area:";
            // 
            // FromDate
            // 
            this.FromDate.CalendarForeColor = System.Drawing.Color.Black;
            this.FromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.FromDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.FromDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.FromDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(102, 86);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 24);
            this.FromDate.TabIndex = 7;
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // AdvancedSearchGroupBox
            // 
            this.AdvancedSearchGroupBox.Controls.Add(this.SearchBtn);
            this.AdvancedSearchGroupBox.Controls.Add(this.ClearBtn);
            this.AdvancedSearchGroupBox.Controls.Add(this.SimpleSearchBtn);
            this.AdvancedSearchGroupBox.Controls.Add(this.TypeComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.TypeLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.MaxPrice);
            this.AdvancedSearchGroupBox.Controls.Add(this.MaxPriceLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.StartPrice);
            this.AdvancedSearchGroupBox.Controls.Add(this.StartPriceLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.PeopleLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.PeopleNum);
            this.AdvancedSearchGroupBox.Controls.Add(this.NightLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.NightNum);
            this.AdvancedSearchGroupBox.Controls.Add(this.ForLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.ToDate);
            this.AdvancedSearchGroupBox.Controls.Add(this.ToLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.FromDate);
            this.AdvancedSearchGroupBox.Controls.Add(this.FromLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.TitleComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.TitleLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.AttractionComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.AttractionLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.AreaComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.AreaLabel);
            this.AdvancedSearchGroupBox.Location = new System.Drawing.Point(20, 15);
            this.AdvancedSearchGroupBox.Name = "AdvancedSearchGroupBox";
            this.AdvancedSearchGroupBox.Size = new System.Drawing.Size(1208, 235);
            this.AdvancedSearchGroupBox.TabIndex = 2;
            this.AdvancedSearchGroupBox.TabStop = false;
            this.AdvancedSearchGroupBox.Text = "Advanced Search";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.CountLabel);
            this.ResultsPanel.Controls.Add(this.SearchResultsGroupBox);
            this.ResultsPanel.ForeColor = System.Drawing.Color.Black;
            this.ResultsPanel.Location = new System.Drawing.Point(20, 256);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(1208, 441);
            this.ResultsPanel.TabIndex = 3;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.CountLabel.Location = new System.Drawing.Point(11, 409);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(43, 23);
            this.CountLabel.TabIndex = 39;
            this.CountLabel.Text = "here";
            // 
            // SearchResultsGroupBox
            // 
            this.SearchResultsGroupBox.Controls.Add(this.ResultsDataGridView);
            this.SearchResultsGroupBox.Location = new System.Drawing.Point(9, 10);
            this.SearchResultsGroupBox.Name = "SearchResultsGroupBox";
            this.SearchResultsGroupBox.Size = new System.Drawing.Size(1196, 396);
            this.SearchResultsGroupBox.TabIndex = 38;
            this.SearchResultsGroupBox.TabStop = false;
            this.SearchResultsGroupBox.Text = "Search results";
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.AllowUserToResizeColumns = false;
            this.ResultsDataGridView.AllowUserToResizeRows = false;
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Light", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyColumn,
            this.AreaColumn,
            this.AverageScoreColumn,
            this.TotalCompletedReservationsColumn,
            this.AmountPayableColumn,
            this.CheckInColumn});
            this.ResultsDataGridView.EnableHeadersVisualStyles = false;
            this.ResultsDataGridView.GridColor = System.Drawing.Color.Black;
            this.ResultsDataGridView.Location = new System.Drawing.Point(6, 24);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.RowHeadersVisible = false;
            this.ResultsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultsDataGridView.Size = new System.Drawing.Size(1184, 366);
            this.ResultsDataGridView.TabIndex = 0;
            // 
            // PropertyColumn
            // 
            this.PropertyColumn.HeaderText = "Property";
            this.PropertyColumn.MinimumWidth = 6;
            this.PropertyColumn.Name = "PropertyColumn";
            this.PropertyColumn.ReadOnly = true;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.ReadOnly = true;
            // 
            // AverageScoreColumn
            // 
            this.AverageScoreColumn.HeaderText = "Average Score";
            this.AverageScoreColumn.MinimumWidth = 6;
            this.AverageScoreColumn.Name = "AverageScoreColumn";
            this.AverageScoreColumn.ReadOnly = true;
            // 
            // TotalCompletedReservationsColumn
            // 
            this.TotalCompletedReservationsColumn.HeaderText = "Total completed reservations";
            this.TotalCompletedReservationsColumn.MinimumWidth = 6;
            this.TotalCompletedReservationsColumn.Name = "TotalCompletedReservationsColumn";
            this.TotalCompletedReservationsColumn.ReadOnly = true;
            // 
            // AmountPayableColumn
            // 
            this.AmountPayableColumn.HeaderText = "Amount payable";
            this.AmountPayableColumn.MinimumWidth = 6;
            this.AmountPayableColumn.Name = "AmountPayableColumn";
            this.AmountPayableColumn.ReadOnly = true;
            // 
            // CheckInColumn
            // 
            this.CheckInColumn.HeaderText = "Check-in at";
            this.CheckInColumn.MinimumWidth = 6;
            this.CheckInColumn.Name = "CheckInColumn";
            this.CheckInColumn.ReadOnly = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = global::Session2.Properties.Resources._135_search;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(791, 182);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(173, 47);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Image = global::Session2.Properties.Resources.Screenshot_2023_11_20_154843;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(612, 182);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(173, 47);
            this.ClearBtn.TabIndex = 28;
            this.ClearBtn.Text = "Clear form";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SimpleSearchBtn
            // 
            this.SimpleSearchBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleSearchBtn.Image = global::Session2.Properties.Resources.Screenshot_2023_11_20_154641;
            this.SimpleSearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SimpleSearchBtn.Location = new System.Drawing.Point(433, 182);
            this.SimpleSearchBtn.Name = "SimpleSearchBtn";
            this.SimpleSearchBtn.Size = new System.Drawing.Size(173, 47);
            this.SimpleSearchBtn.TabIndex = 27;
            this.SimpleSearchBtn.Text = "Simple Search";
            this.SimpleSearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SimpleSearchBtn.UseVisualStyleBackColor = true;
            this.SimpleSearchBtn.Click += new System.EventHandler(this.SimpleSearchBtn_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.AdvancedSearchGroupBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdvancedSearch";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).EndInit();
            this.AdvancedSearchGroupBox.ResumeLayout(false);
            this.AdvancedSearchGroupBox.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            this.SearchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SimpleSearchBtn;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.NumericUpDown MaxPrice;
        private System.Windows.Forms.Label MaxPriceLabel;
        private System.Windows.Forms.Label StartPriceLabel;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.NumericUpDown PeopleNum;
        private System.Windows.Forms.NumericUpDown StartPrice;
        private System.Windows.Forms.Label NightLabel;
        private System.Windows.Forms.NumericUpDown NightNum;
        private System.Windows.Forms.Label ForLabel;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox AttractionComboBox;
        private System.Windows.Forms.Label AttractionLabel;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.GroupBox AdvancedSearchGroupBox;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.GroupBox SearchResultsGroupBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompletedReservationsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInColumn;
    }
}
