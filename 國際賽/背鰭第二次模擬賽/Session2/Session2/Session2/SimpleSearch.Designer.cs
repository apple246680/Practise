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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HintLabel = new System.Windows.Forms.Label();
            this.AdvanedBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PeopleNumber = new System.Windows.Forms.NumericUpDown();
            this.NightsNumber = new System.Windows.Forms.NumericUpDown();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ListBoxHint = new System.Windows.Forms.ListBox();
            this.TopGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.ResultGroupBox.SuspendLayout();
            this.TopGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(87, 34);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(474, 22);
            this.HintLabel.TabIndex = 9;
            this.HintLabel.Text = "Enter area name, attraction, property title, property type, amenities ...";
            // 
            // AdvanedBtn
            // 
            this.AdvanedBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvanedBtn.Location = new System.Drawing.Point(848, 93);
            this.AdvanedBtn.Name = "AdvanedBtn";
            this.AdvanedBtn.Size = new System.Drawing.Size(280, 39);
            this.AdvanedBtn.TabIndex = 7;
            this.AdvanedBtn.Text = "Advanced Search";
            this.AdvanedBtn.UseVisualStyleBackColor = true;
            this.AdvanedBtn.Click += new System.EventHandler(this.AdvanedBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.Location = new System.Drawing.Point(848, 31);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(280, 39);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "people";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "nights and";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "for";
            // 
            // PeopleNumber
            // 
            this.PeopleNumber.Location = new System.Drawing.Point(648, 120);
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
            this.PeopleNumber.Size = new System.Drawing.Size(92, 28);
            this.PeopleNumber.TabIndex = 3;
            this.PeopleNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NightsNumber
            // 
            this.NightsNumber.Location = new System.Drawing.Point(446, 120);
            this.NightsNumber.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NightsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NightsNumber.Name = "NightsNumber";
            this.NightsNumber.Size = new System.Drawing.Size(92, 28);
            this.NightsNumber.TabIndex = 3;
            this.NightsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTimePicker.Location = new System.Drawing.Point(75, 117);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(297, 28);
            this.FromDateTimePicker.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AllowUserToResizeColumns = false;
            this.ResultDataGridView.AllowUserToResizeRows = false;
            this.ResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ResultDataGridView.EnableHeadersVisualStyles = false;
            this.ResultDataGridView.Location = new System.Drawing.Point(51, 46);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.RowHeadersWidth = 51;
            this.ResultDataGridView.RowTemplate.Height = 27;
            this.ResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ResultDataGridView.Size = new System.Drawing.Size(1032, 289);
            this.ResultDataGridView.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservations";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.ResultLabel);
            this.ResultGroupBox.Controls.Add(this.ResultDataGridView);
            this.ResultGroupBox.Location = new System.Drawing.Point(58, 345);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(1134, 372);
            this.ResultGroupBox.TabIndex = 3;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Search results";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(55, 343);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 22);
            this.ResultLabel.TabIndex = 11;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(51, 31);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(774, 28);
            this.SearchTextBox.TabIndex = 0;
            // 
            // ListBoxHint
            // 
            this.ListBoxHint.FormattingEnabled = true;
            this.ListBoxHint.ItemHeight = 22;
            this.ListBoxHint.Location = new System.Drawing.Point(46, 77);
            this.ListBoxHint.Name = "ListBoxHint";
            this.ListBoxHint.ScrollAlwaysVisible = true;
            this.ListBoxHint.Size = new System.Drawing.Size(774, 114);
            this.ListBoxHint.TabIndex = 10;
            // 
            // TopGroupBox
            // 
            this.TopGroupBox.Controls.Add(this.HintLabel);
            this.TopGroupBox.Controls.Add(this.AdvanedBtn);
            this.TopGroupBox.Controls.Add(this.SearchBtn);
            this.TopGroupBox.Controls.Add(this.label4);
            this.TopGroupBox.Controls.Add(this.label3);
            this.TopGroupBox.Controls.Add(this.label2);
            this.TopGroupBox.Controls.Add(this.PeopleNumber);
            this.TopGroupBox.Controls.Add(this.NightsNumber);
            this.TopGroupBox.Controls.Add(this.FromDateTimePicker);
            this.TopGroupBox.Controls.Add(this.label1);
            this.TopGroupBox.Controls.Add(this.SearchTextBox);
            this.TopGroupBox.Controls.Add(this.ListBoxHint);
            this.TopGroupBox.Location = new System.Drawing.Point(58, 60);
            this.TopGroupBox.Name = "TopGroupBox";
            this.TopGroupBox.Size = new System.Drawing.Size(1134, 258);
            this.TopGroupBox.TabIndex = 2;
            this.TopGroupBox.TabStop = false;
            this.TopGroupBox.Text = "Simple search";
            // 
            // SimpleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.TopGroupBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SimpleSearch";
            this.Size = new System.Drawing.Size(1250, 800);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.TopGroupBox.ResumeLayout(false);
            this.TopGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button AdvanedBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PeopleNumber;
        private System.Windows.Forms.NumericUpDown NightsNumber;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox ListBoxHint;
        private System.Windows.Forms.GroupBox TopGroupBox;
    }
}
