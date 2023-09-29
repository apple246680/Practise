using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                Location = new Point(10, index * 50),
                Font=base.Font
            };
            control.Controls.Add(label);
        }
        public void UnuversalReport()
        {
            Session6Entities entities = new Session6Entities();
            PropertyOrListingsSummaryGroupBox.Controls.Clear();
            ScoresSummaryGroupBox.Controls.Clear();
            FinancialSummaryGroupBox.Controls.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            var items = entities.Items.ToList();
            var itemPrices = entities.ItemPrices.ToList();
            var transactions = entities.Transactions.ToList();
            var bookingDetails = entities.BookingDetails.ToList();
            if (!String.IsNullOrWhiteSpace(FormDataTimePicker.Text))
            {
                itemPrices = itemPrices.Where(t => t.Date.Date >= FormDataTimePicker.Value.Date).ToList();
                transactions = transactions.Where(t => t.TransactionDate.Date >= FormDataTimePicker.Value.Date).ToList();
            }
            if (!String.IsNullOrWhiteSpace(ToDateTimePicker.Text))
            {
                itemPrices = itemPrices.Where(t => t.Date.Date <= ToDateTimePicker.Value.Date).ToList();
                transactions = transactions.Where(t => t.TransactionDate.Date <= ToDateTimePicker.Value.Date).ToList();
            }
            if (!String.IsNullOrWhiteSpace(AreaComboBox.Text))
            {
                var areaId = (long)AreaComboBox.SelectedValue;
                items = items.Where(t => t.AreaID == areaId).ToList();
                itemPrices = itemPrices.Where(t => t.Items.AreaID == areaId).ToList();
            }
            if (!String.IsNullOrWhiteSpace(HostComboBox.Text))
            {
                var hostId = (long)HostComboBox.SelectedValue;
                items = items.Where(t => t.UserID == hostId).ToList();
                itemPrices = itemPrices.Where(t => t.Items.UserID == hostId).ToList();
                transactions = transactions.Where(t => t.UserID == hostId).ToList();
            }
            if (!String.IsNullOrWhiteSpace(QuestComboBox.Text))
            {
                var guestId = (long)QuestComboBox.SelectedValue;
                transactions = transactions.Where(t => t.UserID == guestId).ToList();
                bookingDetails = bookingDetails.Where(t => t.Bookings.UserID == guestId).ToList();
            }
            #region PropertyOrListingsSummary
            var completeBooked = bookingDetails.Where(t => !t.isRefund && t.ItemPrices.Date.Date < DateTime.Now.Date);
            CreateLabel($"Secured post bookings:{completeBooked.Count()}", PropertyOrListingsSummaryGroupBox, 1);
            var aa = bookingDetails
                .Where(t => !t.isRefund && t.ItemPrices.Date.Date >= DateTime.Now.Date);
            CreateLabel($"Upcoming bookings(reservations):{aa.Count()}", PropertyOrListingsSummaryGroupBox, 2);
            var mostBookedDate = completeBooked.GroupBy(t => t.ItemPrices.Date.DayOfWeek).OrderByDescending(t => t.Count()).FirstOrDefault();
            CreateLabel($"Most booked day of week:{(mostBookedDate != null ? mostBookedDate.Key.ToString() : "N/A")}", PropertyOrListingsSummaryGroupBox, 3);
            CreateLabel($"Inactive listings or properties:{items.Where(t => !t.ItemPrices.Any()).Count()}", PropertyOrListingsSummaryGroupBox, 4);
            var coupons = bookingDetails.Where(t => t.Bookings.CouponID.HasValue).GroupBy(t => t.Bookings.Coupons).Select(t => new { Name = t.Key.CouponCode, Count = t.Count() }).GroupBy(t => t.Count).OrderByDescending(t => t.Key).FirstOrDefault();
            CreateLabel($"Camcelled reservations:", PropertyOrListingsSummaryGroupBox, 5);
            CreateLabel($"Most used coupon:{(coupons == null ? "N/A" : String.Join(",", coupons.Select(t => t.Name)))}", PropertyOrListingsSummaryGroupBox, 6);
            CreateLabel($"Vacancy ratio:{itemPrices.Where(t => !t.BookingDetails.Any() || t.BookingDetails.All(x => x.isRefund)).Count()}/{itemPrices.Count()}", PropertyOrListingsSummaryGroupBox, 7);
            #endregion
            #region Scores Summary
            CreateLabel("Average score for listings:",ScoresSummaryGroupBox,1);
            CreateLabel("Name of listing with highest score:", ScoresSummaryGroupBox, 2);
            CreateLabel("Top ownew/manager by average score:", ScoresSummaryGroupBox, 3);
            CreateLabel("The least clean owner/manager:", ScoresSummaryGroupBox, 4);
            #endregion
            #region Financial Summary
            CreateLabel("Average net revenue of all owners/managers:", FinancialSummaryGroupBox, 1);
            CreateLabel("Highest net revenue for an owner/manager:", FinancialSummaryGroupBox, 2);
            CreateLabel("Our total revenue from cancellations:",FinancialSummaryGroupBox,3);
            CreateLabel("Total discounts from coupons:",FinancialSummaryGroupBox,4);
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
