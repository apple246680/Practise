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
    public partial class AddOrEditListingForm : Form
    {
        public AddOrEditListingForm()
        {
            InitializeComponent();
            foreach (DataGridViewColumn item in AttractionDataGridView.Columns)
            {
                item.Width = (AttractionDataGridView.Width / AttractionDataGridView.Columns.Count) - 1;
            }
        }

        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229, 26, 46);
        }

        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }
    }
}
