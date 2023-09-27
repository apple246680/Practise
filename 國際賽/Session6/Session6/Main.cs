using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Session6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            AreaComboBox.Items.Clear();
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            HostComboBox.Items.Clear();
            HostComboBox.DisplayMember = "FullName";
            HostComboBox.ValueMember = "ID";
            QuestComboBox.Items.Clear();
            QuestComboBox.DisplayMember = "FullName";
            QuestComboBox.ValueMember = "ID";
            FormDataTimePicker.CustomFormat = "/ / /";
            ToDateTimePicker.CustomFormat = "/ / /";
            using (Session6Entities entities = new Session6Entities())
            {
                AreaComboBox.Items.AddRange(entities.Areas.Select(x => new { x.ID, x.Name }).ToArray());
                AreaComboBox.Items.Insert(0, new { ID = -1, Name = "" });
                HostComboBox.Items.AddRange(entities.Users.Where(x=>x.Items.Any()).Select(x => new {x.ID,x.FullName}).ToArray());
                HostComboBox.Items.Insert(0, new { ID = -1, FullName = "" });
                QuestComboBox.Items.AddRange(entities.Users.Where(x => x.Bookings.Any()).Select(x => new{x.ID,x.FullName}).ToArray());
                QuestComboBox.Items.Insert(0, new { ID = -1, FullName = "" });
            }
            AreaComboBox.SelectedIndex = 0;
            HostComboBox.SelectedIndex = 0;
            QuestComboBox.SelectedIndex = 0;
        }
        private void ResetBtn_Click(object sender, EventArgs e)=>init();
        private void DataTimePicker_ValueChanged(object sender, EventArgs e)=>((DateTimePicker)sender).CustomFormat= "yyyy/MM/dd";
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (FormDataTimePicker.Text!="/ / /"&& ToDateTimePicker.Text != "/ / /")
                if (FormDataTimePicker.Value >= ToDateTimePicker.Value)
                {
                    MessageBox.Show("Please select a valid date range");
                    return;
                }
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    UnuversalReport();
                    break;
                case 1:
                    ServiceReport();
                    break;
                case 2:
                    HostAnalysis();
                    break;
            }
        }
        public void CreateLabel(string text,Control control,int index)
        {
            Label label = new Label()
            {
                Text = text,
                AutoSize = true,
                Location = new Point(10, index * 20),
                Font=base.Font
            };
            control.Controls.Add(label);
        }
        public void UnuversalReport()
        {
            PropertyOrListingsSummaryGroupBox.Controls.Clear();
            Session6Entities entities = new Session6Entities();
            var booking=entities.BookingDetails.ToList();
            if ( !string.IsNullOrEmpty(QuestComboBox.Text))
            {
                booking.Where(x=>x.ID==(long)QuestComboBox.SelectedValue);
            }
            #region PropertyOrListingsSummary
            CreateLabel(, PropertyOrListingsSummaryGroupBox, 1);
            #endregion
        }
        public void ServiceReport()
        {

        }
        public void HostAnalysis()
        {

        }
    }
}
