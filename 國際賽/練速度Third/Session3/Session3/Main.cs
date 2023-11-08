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
        public Main()
        {
            InitializeComponent();
            SimpleSearchFormBtn_Click(null,null);
        }

        private void SimpleSearchFormBtn_Click(object sender, EventArgs e)
        {
            TopPanel.Visible= false;
            ListBoxHint.Visible= false;
            DownPanel.Visible= false;
            ToDatePanel.Visible= false;
            SearchTextBox.Visible= true;
            SimpleSearchBtn.Visible = true;
            AdvanedFormBtn.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 170);
            Size =new Size(1202, 450);
        }

        private void AdvanedFormBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.Visible= false;
            ListBoxHint.Visible = false;
            SimpleSearchBtn.Visible = false;
            AdvanedFormBtn.Visible = false;
            TopPanel.Visible = true;
            DownPanel.Visible = true;
            ToDatePanel.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 295);
            Size = new Size(1202, 602);
        }

        private void SearchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (SearchTextBox.Text== "Enter area name, attraction, property title, property type, amenities ...")
            {
                SearchTextBox.Text = "";
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text=="")
            {
                SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
            }
        }
    }
}
