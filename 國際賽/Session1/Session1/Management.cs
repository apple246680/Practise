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
            
        }
        private void hint_Click(object sender, EventArgs e)
        {
            
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void search_Leave(object sender, EventArgs e)
        {
            
        }
        private void search_Enter(object sender, EventArgs e)
        {
            
        }
        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
