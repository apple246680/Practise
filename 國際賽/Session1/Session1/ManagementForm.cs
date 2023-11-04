using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class ManagementForm : Form
    {
        /// <summary>
        /// This is a constructor for the ManagementForm
        /// </summary>
        public ManagementForm()
        {
            InitializeComponent();
            foreach (DataGridViewColumn item in TravelerDataGridView.Columns)
            {
                item.Width = (TravelerDataGridView.Width / TravelerDataGridView.Columns.Count)-1;
            }
            foreach (DataGridViewColumn item in ManagerDataGridView.Columns)
            {
                item.Width = (ManagerDataGridView.Width / ManagerDataGridView.Columns.Count)-1;
            }
            ManagerDataGridView.Rows.Add(0,0,0,0,"Edit Details");
            ManagerDataGridView.Rows.Add(0, 0, 0, 0, "Edit Details");
        }
        /// <summary>
        /// The button down event can color the button to red
        /// </summary>
        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229, 26, 46);
        }
        /// <summary>
        /// The button up event can color the button to grey
        /// </summary>
        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }

        private void SearchTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if(SearchTextbox.Text== "Search destination or Listing Title or Attaction")
            {
                SearchTextbox.Text=string.Empty;
            }
        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text=="")
            {
                SearchTextbox.Text = "Search destination or Listing Title or Attaction";
            }
        }
    }
}
