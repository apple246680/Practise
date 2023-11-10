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

        private void SearchTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (SearchTextbox.Text == "Search destination or Listing Title or Attaction")
            {
                SearchTextbox.Text = string.Empty;
            }
        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search destination or Listing Title or Attaction";
            }
        }

        private void LououtBtn_Click(object sender, EventArgs e)
        {
            Global.userID = null;
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Global.BackLogin();
            MessageBox.Show("Success!");
        }

        List<int> CurrentNum = new List<int>() { 0, 0 };

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search destination or Listing Title or Attaction")
            {
                return;
            }
            TravelerDataGridView.Rows.Clear();
            new Session1Entities().Items.Where(x => x.Title == SearchTextbox.Text || x.Area.Name == SearchTextbox.Text || x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attraction.Name == SearchTextbox.Text)).ToList().ForEach(x =>
            {
                TravelerDataGridView.Rows.Add(x.Title, x.Capacity, x.Area.Name, x.ItemType.Name);
            });
            CurrentNum[0] = TravelerDataGridView.Rows.Count;
            ManagementTabControl_SelectedIndexChanged(null, null);
        }

        private void ManagementTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountLabel.Text = $"{CurrentNum[ManagementTabControl.SelectedIndex]} items found.";
        }

        private void Management_Load(object sender, EventArgs e)
        {
            ManagerDataGridView.Rows.Clear();
            var entities = new Session1Entities();
            entities.Items.Where(t => t.UserID == Global.userID).ToList().ForEach(t =>
            {
                ManagerDataGridView.Rows.Add(t.ID, t.Title, t.Capacity, t.Area.Name, t.ItemType.Name, "Edit Details");
            });
            CurrentNum[1] = ManagerDataGridView.Rows.Count; 
        }

        private void ManagerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5)
                return;
            var form = new AddOrEditListing((long)ManagerDataGridView.Rows[e.RowIndex].Cells[0].Value) { Dock=DockStyle.Fill};
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(form);
            form.Show();
        }

        private void AddListingBtn_Click(object sender, EventArgs e)
        {
            var addOrEditListinig = new AddOrEditListing(null) { Dock=DockStyle.Fill};
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(addOrEditListinig);
            addOrEditListinig.Show();
        }
    }
}
