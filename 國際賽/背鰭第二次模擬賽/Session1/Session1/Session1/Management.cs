using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            SearchTextBox.Text = SearchTextBox.Text== "Search destination or Listing TItle or Attraction" ? "" : SearchTextBox.Text;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBox.Text = SearchTextBox.Text == "" ? "Search destination or Listing TItle or Attraction" : SearchTextBox.Text;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text!= "Search destination or Listing TItle or Attraction")
            {
                var filter=new Session1Entities().Items.Where(x => x.Title == SearchTextBox.Text || x.Areas.Name == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attractions.Name == SearchTextBox.Text && y.Distance < 1)).Select(x => new
                {
                    x.Title,
                    x.Capacity,
                    Area=x.Areas.Name,
                    Type=x.ItemTypes.Name
                }).ToList();
                TravelerDataGridView.DataSource= filter;
            }
        }

        private void Management_Load(object sender, EventArgs e)
        {
            OwnerDataGridView.Rows.Clear();
            new Session1Entities().Items.Where(x => x.UserID == Global.userID).ToList().ForEach(x =>
            {
                OwnerDataGridView.Rows.Add(x.ID, x.Title,x.Capacity, x.Areas.Name, x.ItemTypes.Name, "Edit Details");
            });

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Global.userID = 0;
            var entities=new Session1Entities();
            entities.LogRecords.Add(new LogRecords
            {
                GUID = Guid.NewGuid(),
                FormName = "Log out",
                Task = "Successful",
                UsersID = Global.userID,
                LogDT = DateTime.Now
            });
            entities.SaveChanges();
            Global.ShowLoginForm();
        }

        private void AddListBtn_Click(object sender, EventArgs e)
        {
            var listing=new Listing(null) {Dock=DockStyle.Fill};
            Global.MainForm.Text = "Seoul Stay - Add Listing";
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(listing);
        }

        private void OwnerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 && e.RowIndex != -1)
                return;
            var id = (long)OwnerDataGridView.Rows[e.RowIndex].Cells[0].Value;
            var listing = new Listing(id) { Dock = DockStyle.Fill };
            Global.MainForm.Text = "Seoul Stay - Edit Listing";
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(listing);
        }
    }
}
