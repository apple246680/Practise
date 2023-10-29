using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Session1
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }
        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.mainForm.Visible = true;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LououtBtn_Click(object sender, EventArgs e)
        {
            Global.accountID = null;
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Global.mainForm.Visible = true;
            MessageBox.Show("Success!");
            Close();
        }
        public List<int> CurrentNum = new List<int>() { 0, 0 };
        private void search_TextChanged(object sender, EventArgs e)
        {
            TravelerDataGridView.Rows.Clear();
            new Session1Entities().Items.Where(x => x.Title == search.Text || x.Areas.Name == search.Text || x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attractions.Name == search.Text)).ToList().ForEach(x =>
            {
                TravelerDataGridView.Rows.Add(x.Title, x.Capacity, x.Areas.Name, x.ItemTypes.Name);
            });
            CurrentNum[0] = TravelerDataGridView.Rows.Count;
            CountLabel.Text = $"{TravelerDataGridView.Rows.Count} items found.";
        }
        private void hint_Click(object sender, EventArgs e)
        {
            hint.Visible = false;
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(search.Text))
                hint.Visible = true;
        }
        private void search_Enter(object sender, EventArgs e)
        {
            hint.Visible = false;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountLabel.Text = $"{CurrentNum[PageTabControl.SelectedIndex]} items found.";
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ManageDataGridView.Rows.Clear();
            Session1Entities entities = new Session1Entities();
            entities.Items.Where(t => t.UserID == Global.accountID).ToList().ForEach(t =>
            {
                ManageDataGridView.Rows.Add(t.ID, t.Title, t.Capacity, t.Areas.Name, t.ItemTypes.Name, "Edit Details");
            });
            CurrentNum[1] = ManageDataGridView.Rows.Count;
        }
        private void ManageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5)
                return;
            var form = new AddOrEditListinigForm((long)ManageDataGridView.Rows[e.RowIndex].Cells[0].Value);
            form.ShowDialog();
            ManageDataGridView.Rows.Clear();
            var data = new Session1Entities().Items.Where(x => x.UserID == Global.accountID).ToList();
            data.ForEach(x =>
            {
                ManageDataGridView.Rows.Add(x.ID, x.Title, x.Capacity, x.Areas.Name, x.ItemTypes.Name, "Edit Details");
            });
            CurrentNum[1] = data.Count();
            CountLabel.Text = $"{data.Count()} items found.";
        }
        private void AddListingBtn_Click(object sender, EventArgs e)
        {
            var addOrEditListinig = new AddOrEditListinigForm(null);
            addOrEditListinig.ShowDialog();
            ManagementForm_Load(null, null);
        }
    }
}