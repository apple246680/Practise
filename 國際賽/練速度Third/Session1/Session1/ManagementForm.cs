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
    public partial class ManagementForm : Form
    {
        /// <summary>
        /// InitializeComponent ManagementForm
        /// </summary>
        public ManagementForm()
        {
            InitializeComponent();
            foreach (DataGridViewColumn item in TravelerDataGridView.Columns)
            {
                item.Width = (TravelerDataGridView.Width / TravelerDataGridView.Columns.Count)-1;
            }
            foreach (DataGridViewColumn item in ManagerDataGridView.Columns)
            {
                item.Width = (ManagerDataGridView.Width / ManagerDataGridView.Columns.Count)-1;
            }
        }
        /// <summary>
        /// The button down event can color the button to red
        /// </summary>
        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229, 26, 46);
        }
        /// <summary>
        /// The button up event can color the button to grey
        /// </summary>
        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }
        /// <summary>
        /// SearchTextbox Reset
        /// </summary>
        private void SearchTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if(SearchTextbox.Text== "Search destination or Listing Title or Attaction")
            {
                SearchTextbox.Text=string.Empty;
            }
        }
        /// <summary>
        /// SearchTextbox Reset
        /// </summary>
        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text=="")
            {
                SearchTextbox.Text = "Search destination or Listing Title or Attaction";
            }
        }
        /// <summary>
        /// Logout the Application
        /// </summary>
        private void LououtBtn_Click(object sender, EventArgs e)
        {
            Global.accountID = null;
            Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Global.LoginForm.Visible = true;
            MessageBox.Show("Success!");
            Close();
        }
        List<int> CurrentNum = new List<int>() { 0, 0 };
        /// <summary>
        /// Exit the Application
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Search destination or Listing Title or Attaction
        /// </summary>
        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextbox.Text== "Search destination or Listing Title or Attaction")
            {
                return;
            }
                TravelerDataGridView.Rows.Clear();
                new Session1Entities().Items.Where(x => x.Title == SearchTextbox.Text || x.Areas.Name == SearchTextbox.Text || x.ItemAttractions.Any(y => y.Distance <= 1 && y.Attractions.Name == SearchTextbox.Text)).ToList().ForEach(x =>
                {
                    TravelerDataGridView.Rows.Add(x.Title, x.Capacity, x.Areas.Name, x.ItemTypes.Name);
                });
                CurrentNum[0] = TravelerDataGridView.Rows.Count;
                ManagementTabControl_SelectedIndexChanged(null, null);
        }
        /// <summary>
        /// Show current page data count
        /// </summary>
        private void ManagementTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountLabel.Text = $"{CurrentNum[ManagementTabControl.SelectedIndex]} items found.";
        }
        /// <summary>
        /// initialization ManagerDataGridView Data
        /// </summary>
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ManagerDataGridView.Rows.Clear();
            var entities = new Session1Entities();
            entities.Items.Where(t => t.UserID == Global.accountID).ToList().ForEach(t =>
            {
                ManagerDataGridView.Rows.Add(t.ID, t.Title, t.Capacity, t.Areas.Name, t.ItemTypes.Name, "Edit Details");
            });
            CurrentNum[1] = ManagerDataGridView.Rows.Count;
        }
        /// <summary>
        /// Edit owner item
        /// </summary>
        private void ManagerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5)
                return;
            var form = new AddOrEditListingForm((long)ManagerDataGridView.Rows[e.RowIndex].Cells[0].Value);
            form.ShowDialog();
            ManagerDataGridView.Rows.Clear();
            var data = new Session1Entities().Items.Where(x => x.UserID == Global.accountID).ToList();
            data.ForEach(x =>
            {
                ManagerDataGridView.Rows.Add(x.ID, x.Title, x.Capacity, x.Areas.Name, x.ItemTypes.Name, "Edit Details");
            });
            CurrentNum[1] = data.Count();
            ManagementTabControl_SelectedIndexChanged(null, null);
        }

        private void RegisterAndLoginBtn_Click(object sender, EventArgs e)
        {
            var addOrEditListinig = new AddOrEditListingForm(null);
            addOrEditListinig.ShowDialog();
            ManagementForm_Load(null, null);
        }
    }
}
