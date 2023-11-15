using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class Main : Form
    {
        List<ComboBox> amenityComboBoxList = new List<ComboBox>();
        public Main()
        {
            InitializeComponent();
            SimpleSearchFormBtn_Click(null, null);
            init();
        }
        
        public void init()
        {
            amenityComboBoxList = new List<ComboBox>()
            {
                AmenityComboBox1, AmenityComboBox2, AmenityComboBox3
            };

        }

        private void SimpleSearchFormBtn_Click(object sender, EventArgs e)
        {
            TopPanel.Visible = false;
            ListBoxHint.Visible = false;
            DownPanel.Visible = false;
            ToDatePanel.Visible = false;
            SearchResultsGroupBox.Visible = false;
            ResultsDataGridView.Columns[5].Visible = false;
            SearchTextBox.Visible = true;
            SimpleSearchBtn.Visible = true;
            AdvanedFormBtn.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1180, 170);
            Size = new Size(1200, 535);
        }

        private void AdvanedFormBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.Visible = false;
            ListBoxHint.Visible = false;
            SimpleSearchBtn.Visible = false;
            AdvanedFormBtn.Visible = false;
            SearchResultsGroupBox.Visible = false;
            amenityComboBoxList.Skip(1).ToList().ForEach(x => x.Enabled = false);
            ResultsDataGridView.Columns[5].Visible = true;
            TopPanel.Visible = true;
            ToDatePanel.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 295);
            Size = new Size(1200, 650);
            //ClearBtn_Click(null, null);
            DownPanel.Visible = true;
            //FromDateTimePicker_ValueChanged(null, null);
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter area name, attraction, property title, property type, amenities ...")
            {
                SearchTextBox.Text = "";
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
            }
        }
    }
}
