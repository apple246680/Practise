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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        public List<int> CurrentNum = new List<int>() { 0, 0 };
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LououtBtn_Click(object sender, EventArgs e)
        {
            Global.accountID = null;
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Close();
        }
        private void hint_Click(object sender, EventArgs e)
        {
            hint.SendToBack();
            search.Focus();
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
                hint.BringToFront();
        }
        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TravelerDataGridView.Rows.Clear();
                if (!string.IsNullOrWhiteSpace(search.Text))
                {
                    new Session1Entities().Items.Where(x => x.Title == search.Text || x.Area.Name == search.Text|| x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attraction.Name == search.Text)).ToList().ForEach(x =>
                    {
                        TravelerDataGridView.Rows.Add(x.Title, x.Capacity, x.Area.Name, x.ItemType.Name);
                    });
                    CountLabel.Text = $"{TravelerDataGridView.Rows.Count} items found.";
                    CurrentNum[0] = ManageDataGridView.Rows.Count;
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountLabel.Text = $"{CurrentNum[tabControl1.SelectedIndex]} items found.";
        }
        public void manager()
        {
            new Session1Entities().Items.Where(x => x.UserID == Global.accountID).ToList().ForEach(x =>
            {
                ManageDataGridView.Rows.Add(x.ID, x.Title, x.Capacity, x.Area.Name, x.ItemType.Name, "Edit Details");
            });
            this.CurrentNum[1] = ManageDataGridView.Rows.Count;
            this.CountLabel.Text = $"{ManageDataGridView.Rows.Count} items found.";
        }
        private void Management_Load(object sender, EventArgs e)
        {
            manager();
        }
        private void AddListingBtn_Click(object sender, EventArgs e)
        {
            AddOrEditListinig addOrEditListinig =new AddOrEditListinig();   
            addOrEditListinig.ShowDialog();
        }
    }
}