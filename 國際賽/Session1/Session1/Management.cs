using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        List<int>datacount = new List<int>() { 0,0};
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Global.accountID = null;
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Global.login.Visible = true;
            MessageBox.Show("Success!");
            Close();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void hint_Click(object sender, EventArgs e)
        {
            hint.Visible = false;
            search.Focus();
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search.Text))
                return;
            var entities = new Session1Entities();
            var data = entities.Items.Where(x => x.Title == search.Text || x.Area.Name == search.Text || x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attraction.Name == search.Text)).Select(x => new
            {
                Title=x.Title,
                Capacity=x.Capacity,
                Area=x.Area.Name,
                Type=x.ItemType.Name,
            }).ToList();
            TravelerDataGridView.DataSource = data;
            datacount[tabControl1.SelectedIndex] = data.Count;
            CountLabel.Text = $"{data.Count} items found.";
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(search.Text))
                hint.Visible = true;
        }
        private void search_Enter(object sender, EventArgs e)
        {
            

        }
        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.login.Close();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Management_Load(object sender, EventArgs e)
        {
            
        }
        private void AddListingBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void ManageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}