namespace Session2
{
    partial class SimpleSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSearch));
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.NightLabel = new System.Windows.Forms.Label();
            this.ForLabel = new System.Windows.Forms.Label();
            this.PeopleNumber = new System.Windows.Forms.NumericUpDown();
            this.NightsNumber = new System.Windows.Forms.NumericUpDown();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ListBoxHint = new System.Windows.Forms.ListBox();
            this.TopGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchFilterPanel = new System.Windows.Forms.Panel();
            this.FromLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompletedReservationsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.AdvanedBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightsNumber)).BeginInit();
            this.TopGroupBox.SuspendLayout();
            this.SearchFilterPanel.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(560, 5);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(46, 17);
            this.PeopleLabel.TabIndex = 4;
            this.PeopleLabel.Text = "people";
            // 
            // NightLabel
            // 
            this.NightLabel.AutoSize = true;
            this.NightLabel.Location = new System.Drawing.Point(362, 5);
            this.NightLabel.Name = "NightLabel";
            this.NightLabel.Size = new System.Drawing.Size(64, 17);
            this.NightLabel.TabIndex = 4;
            this.NightLabel.Text = "nights and";
            // 
            // ForLabel
            // 
            this.ForLabel.AutoSize = true;
            this.ForLabel.Location = new System.Drawing.Point(204, 5);
            this.ForLabel.Name = "ForLabel";
            this.ForLabel.Size = new System.Drawing.Size(24, 17);
            this.ForLabel.TabIndex = 4;
            this.ForLabel.Text = "for";
            // 
            // PeopleNumber
            // 
            this.PeopleNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.PeopleNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeopleNumber.Location = new System.Drawing.Point(447, 1);
            this.PeopleNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PeopleNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleNumber.Name = "PeopleNumber";
            this.PeopleNumber.Size = new System.Drawing.Size(92, 24);
            this.PeopleNumber.TabIndex = 3;
            this.PeopleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NightsNumber
            // 
            this.NightsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.NightsNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NightsNumber.Location = new System.Drawing.Point(249, 1);
            this.NightsNumber.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.NightsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NightsNumber.Name = "NightsNumber";
            this.NightsNumber.Size = new System.Drawing.Size(92, 24);
            this.NightsNumber.TabIndex = 3;
            this.NightsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.FromDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.FromDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.FromDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.FromDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.FromDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTimePicker.Location = new System.Drawing.Point(68, 1);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(115, 24);
            this.FromDateTimePicker.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(51, 31);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(774, 24);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // ListBoxHint
            // 
            this.ListBoxHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ListBoxHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxHint.DisplayMember = "Name";
            this.ListBoxHint.ForeColor = System.Drawing.Color.Black;
            this.ListBoxHint.FormattingEnabled = true;
            this.ListBoxHint.ItemHeight = 17;
            this.ListBoxHint.Location = new System.Drawing.Point(51, 61);
            this.ListBoxHint.Name = "ListBoxHint";
            this.ListBoxHint.ScrollAlwaysVisible = true;
            this.ListBoxHint.Size = new System.Drawing.Size(774, 87);
            this.ListBoxHint.TabIndex = 10;
            this.ListBoxHint.ValueMember = "ID";
            this.ListBoxHint.Visible = false;
            this.ListBoxHint.Click += new System.EventHandler(this.ListBoxHint_Click);
            // 
            // TopGroupBox
            // 
            this.TopGroupBox.Controls.Add(this.SearchFilterPanel);
            this.TopGroupBox.Controls.Add(this.AdvanedBtn);
            this.TopGroupBox.Controls.Add(this.SearchBtn);
            this.TopGroupBox.Controls.Add(this.SearchTextBox);
            this.TopGroupBox.Controls.Add(this.ListBoxHint);
            this.TopGroupBox.Location = new System.Drawing.Point(52, 30);
            this.TopGroupBox.Name = "TopGroupBox";
            this.TopGroupBox.Size = new System.Drawing.Size(1134, 192);
            this.TopGroupBox.TabIndex = 2;
            this.TopGroupBox.TabStop = false;
            this.TopGroupBox.Text = "Simple search";
            // 
            // SearchFilterPanel
            // 
            this.SearchFilterPanel.Controls.Add(this.PeopleLabel);
            this.SearchFilterPanel.Controls.Add(this.FromLabel);
            this.SearchFilterPanel.Controls.Add(this.FromDateTimePicker);
            this.SearchFilterPanel.Controls.Add(this.NightLabel);
            this.SearchFilterPanel.Controls.Add(this.NightsNumber);
            this.SearchFilterPanel.Controls.Add(this.ForLabel);
            this.SearchFilterPanel.Controls.Add(this.PeopleNumber);
            this.SearchFilterPanel.Location = new System.Drawing.Point(61, 92);
            this.SearchFilterPanel.Name = "SearchFilterPanel";
            this.SearchFilterPanel.Size = new System.Drawing.Size(620, 32);
            this.SearchFilterPanel.TabIndex = 9;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(7, 5);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(40, 17);
            this.FromLabel.TabIndex = 1;
            this.FromLabel.Text = "From:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.CountLabel.Location = new System.Drawing.Point(12, 437);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(143, 23);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "Displaying  options";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.ResultGroupBox);
            this.ResultsPanel.Controls.Add(this.ExportBtn);
            this.ResultsPanel.Controls.Add(this.CountLabel);
            this.ResultsPanel.Location = new System.Drawing.Point(52, 228);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(1151, 469);
            this.ResultsPanel.TabIndex = 9;
            this.ResultsPanel.Visible = false;
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultLabel);
            this.ResultGroupBox.Controls.Add(this.ResultDataGridView);
            this.ResultGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(1134, 372);
            this.ResultGroupBox.TabIndex = 4;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Search results";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(55, 343);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 17);
            this.ResultLabel.TabIndex = 11;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AllowUserToResizeColumns = false;
            this.ResultDataGridView.AllowUserToResizeRows = false;
            this.ResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Light", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyColumn,
            this.AreaColumn,
            this.AverageScoreColumn,
            this.TotalCompletedReservationsColumn,
            this.AmountPayableColumn});
            this.ResultDataGridView.EnableHeadersVisualStyles = false;
            this.ResultDataGridView.GridColor = System.Drawing.Color.Black;
            this.ResultDataGridView.Location = new System.Drawing.Point(13, 30);
            this.ResultDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultDataGridView.RowTemplate.Height = 27;
            this.ResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ResultDataGridView.Size = new System.Drawing.Size(1108, 330);
            this.ResultDataGridView.TabIndex = 0;
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
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.Color.White;
            this.ExportBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBtn.Image = global::Session2.Properties.Resources.Screenshot_2023_11_19_160855;
            this.ExportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportBtn.Location = new System.Drawing.Point(938, 381);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(196, 49);
            this.ExportBtn.TabIndex = 8;
            this.ExportBtn.Text = "Export Report";
            this.ExportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // AdvanedBtn
            // 
            this.AdvanedBtn.BackColor = System.Drawing.Color.White;
            this.AdvanedBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 10.8F);
            this.AdvanedBtn.Image = global::Session2.Properties.Resources.Screenshot_2023_11_19_160115;
            this.AdvanedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdvanedBtn.Location = new System.Drawing.Point(908, 92);
            this.AdvanedBtn.Name = "AdvanedBtn";
            this.AdvanedBtn.Size = new System.Drawing.Size(216, 42);
            this.AdvanedBtn.TabIndex = 7;
            this.AdvanedBtn.Text = "Advanced Search";
            this.AdvanedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdvanedBtn.UseVisualStyleBackColor = false;
            this.AdvanedBtn.Click += new System.EventHandler(this.AdvanedBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.White;
            this.SearchBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 10.8F);
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(908, 31);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(216, 42);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SimpleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.TopGroupBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimpleSearch";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightsNumber)).EndInit();
            this.TopGroupBox.ResumeLayout(false);
            this.TopGroupBox.PerformLayout();
            this.SearchFilterPanel.ResumeLayout(false);
            this.SearchFilterPanel.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AdvanedBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label NightLabel;
        private System.Windows.Forms.Label ForLabel;
        private System.Windows.Forms.NumericUpDown PeopleNumber;
        private System.Windows.Forms.NumericUpDown NightsNumber;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox ListBoxHint;
        private System.Windows.Forms.GroupBox TopGroupBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Panel SearchFilterPanel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompletedReservationsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayableColumn;
    }
}
