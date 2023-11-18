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
        /// <summary>
        /// InitializeComponent Management Form
        /// </summary>
        public Management()
        {
            InitializeComponent();
            OwnerDataGridView.Columns[5].SortMode=DataGridViewColumnSortMode.NotSortable;
        }
        /// <summary>
        /// init SearchTextbox
        /// </summary>
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            SearchTextBox.Text = SearchTextBox.Text== "Search destination or Listing TItle or Attraction" ? "" : SearchTextBox.Text;
        }
        /// <summary>
        /// init SearchTextbox
        /// </summary>
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            SearchTextBox.Text = SearchTextBox.Text == "" ? "Search destination or Listing TItle or Attraction" : SearchTextBox.Text;
        }
        /// <summary>
        /// Keyword query
        /// </summary>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TravelerDataGridView.Rows.Clear();
            foreach (DataGridViewColumn item in TravelerDataGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn item in TravelerDataGridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            if (SearchTextBox.Text!= "Search destination or Listing TItle or Attraction"&&!string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                new Session1Entities().Items.Where(x => x.Title.Contains(SearchTextBox.Text) || x.Areas.Name.Contains(SearchTextBox.Text) || x.ItemAttractions.Any(y => y.Attractions.Name.Contains(SearchTextBox.Text) && y.Distance < 1)).ToList().ForEach(x => 
                {
                    TravelerDataGridView.Rows.Add(x.Title,x.Capacity,x.Areas.Name,x.ItemTypes.Name);
                });
            }
        }
        /// <summary>
        /// add OwnerDataGridView data
        /// </summary>
        private void Management_Load(object sender, EventArgs e)
        {
            OwnerDataGridView.Rows.Clear();
            new Session1Entities().Items.Where(x => x.UserID == Global.userID).ToList().ForEach(x =>
            {
                OwnerDataGridView.Rows.Add(x.ID, x.Title,x.Capacity, x.Areas.Name, x.ItemTypes.Name, "Edit Details");
            });

        }
        /// <summary>
        /// Exit the Application
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Logout
        /// </summary>
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
        /// <summary>
        /// Add a new item
        /// </summary>
        private void AddListBtn_Click(object sender, EventArgs e)
        {
            var listing=new Listing(null) {Dock=DockStyle.Fill};
            Global.MainForm.Text = "Seoul Stay - Add Listing";
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(listing);
        }
        /// <summary>
        /// Edit item
        /// </summary>
        private void OwnerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 && e.RowIndex <0)
                return;
            long id;
            try
            {
                id = (long)OwnerDataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {
                return;
            }
            var listing = new Listing(id) { Dock = DockStyle.Fill };
            Global.MainForm.Text = "Seoul Stay - Edit Listing";
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(listing);
        }
    }
}
