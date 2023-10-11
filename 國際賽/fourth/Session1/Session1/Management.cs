using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Session1
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            ManageDataGridView.Rows.Clear();
            Session1Entities entities = new Session1Entities();
            entities.Items.Where(t => t.UserID == Global.accountID).ToList().ForEach(t =>
            {
                ManageDataGridView.Rows.Add(t.ID, t.Title, t.Capacity, t.Area.Name, t.ItemType.Name, "Edit Details");
            });
            CurrentNum[1] = ManageDataGridView.Rows.Count;
            tabControl1_SelectedIndexChanged(null, null) ;
        }
        bool IsClose;
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Global.accountID = null;
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            IsClose = false;
            Global.login.Visible = true;
            MessageBox.Show("Success!");
            Close();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            IsClose = true;
            Close();
        }
        private void hint_Click(object sender, EventArgs e)=>hint.Visible = false;
        public List<int> CurrentNum = new List<int>() { 0, 0 };
        private void search_TextChanged(object sender, EventArgs e)
        {
            TravelerDataGridView.Rows.Clear();
            new Session1Entities().Items.Where(x => x.Title == search.Text || x.Area.Name == search.Text || x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attraction.Name == search.Text)).ToList().ForEach(x =>
            {
                TravelerDataGridView.Rows.Add(x.Title, x.Capacity, x.Area.Name, x.ItemType.Name);
            });
            CurrentNum[0] = TravelerDataGridView.Rows.Count;
            CountLabel.Text = $"{TravelerDataGridView.Rows.Count} items found.";
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(search.Text))
                hint.Visible = true;
        }
        private void search_Enter(object sender, EventArgs e)=>hint.Visible = false;
        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                Global.login.Close();
            else
                Global.login.Visible = true;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)=>CountLabel.Text = $"{CurrentNum[tabControl1.SelectedIndex]} items found.";
        private void AddListingBtn_Click(object sender, EventArgs e)
        {
            new AddOrEditListinig(null).ShowDialog();
            init();
        }
        private void ManageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5)
                return;
            long id = (long)ManageDataGridView.Rows[e.RowIndex].Cells[0].Value;
            AddOrEditListinig form = new AddOrEditListinig(id);
            form.ShowDialog();
            ManageDataGridView.Rows.Clear();
            Session1Entities entities = new Session1Entities();
            var data = entities.Items.Where(x => x.UserID == Global.accountID).ToList();
            data.ForEach(x =>
            {
                ManageDataGridView.Rows.Add(x.ID, x.Title, x.Capacity, x.Area.Name, x.ItemType.Name, "Edit Details");
            });
            CurrentNum[1] = data.Count();
            tabControl1_SelectedIndexChanged(sender,e);
        }
    }
}