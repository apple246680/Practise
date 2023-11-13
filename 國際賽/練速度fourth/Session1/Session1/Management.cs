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
    public partial class Management : UserControl
    {
        public Management()
        {
            InitializeComponent();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search destination or Listing Title or Attaction")
            {
                return;
            }
            TravelerDataGridView.Rows.Clear();
            new Session1Entities().Items.Where(x => x.Title == SearchTextbox.Text || x.Areas.Name == SearchTextbox.Text || x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attractions.Name == SearchTextbox.Text)).ToList().ForEach(x =>
            {
                TravelerDataGridView.Rows.Add(x.Title, x.Capacity, x.Areas.Name, x.ItemTypes.Name);
            });
            ManagementTabControl_SelectedIndexChanged(null, null);
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search destination or Listing Title or Attaction")
            {
                SearchTextbox.Text = "";
            }
        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search destination or Listing Title or Attaction";
            }
        }

        private void Management_Load(object sender, EventArgs e)
        {
            ManagerDataGridView.Rows.Clear();
            var entities = new Session1Entities();
            entities.Items.Where(t => t.UserID == Global.userID).ToList().ForEach(t =>
            {
                ManagerDataGridView.Rows.Add(t.ID, t.Title, t.Capacity, t.Areas.Name, t.ItemTypes.Name, "Edit Details");
            });
        }

        private void ManagementTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            switch (ManagementTabControl.SelectedIndex)
            {
                case 0:
                    count = TravelerDataGridView.RowCount;
                    break;
                case 1:
                    count = ManagerDataGridView.ColumnCount;
                    break;
            }
            CountLabel.Text = $"{count} items found.";
        }

        public void ShowAddOrEditListing()
        {
            Global.main.Controls.Clear();
            Global.main.Controls.Add(new AddOrEditListing() {Dock=DockStyle.Fill});
        }

        private void AddListingBtn_Click(object sender, EventArgs e)
        {
            Global.AddItemID = null;
            ShowAddOrEditListing();
        }

        private void ManagerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5)
                return;
            Global.AddItemID = (long)ManagerDataGridView.Rows[e.RowIndex].Cells[0].Value;
            ShowAddOrEditListing();
        }
    }
}
