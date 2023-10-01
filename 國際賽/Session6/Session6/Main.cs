using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            PropertyOrListingsSummaryGroupBox.Controls.Clear();
            ScoresSummaryGroupBox.Controls.Clear();
            FinancialSummaryGroupBox.Controls.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            dataGridView1.DataSource=null;
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            label6.Text = "Number of purchased services:";
            label7.Text="Total revenue from service reservations:";
            label8.Text = "Most booked service:";
            AreaComboBox.Items.Clear();
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            HostComboBox.Items.Clear();
            HostComboBox.DisplayMember = "FullName";
            HostComboBox.ValueMember = "ID";
            QuestComboBox.Items.Clear();
            QuestComboBox.DisplayMember = "FullName";
            QuestComboBox.ValueMember = "ID";
            FormDataTimePicker.CustomFormat = " ";
            ToDateTimePicker.CustomFormat = " ";
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
            if (FormDataTimePicker.Text!=" "&& ToDateTimePicker.Text != " ")
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
            CreateLabel($"Camcelled reservations:{bookingDetails.Select(x=>x.ItemPrices.CancellationPolicies).Count()}", PropertyOrListingsSummaryGroupBox, 5);
            CreateLabel($"Most used coupon:{(coupons == null ? "N/A" : String.Join(",", coupons.Select(t => t.Name)))}", PropertyOrListingsSummaryGroupBox, 6);
            var vacancy = itemPrices
                    .Where(t => !t.BookingDetails.Any()
                        || t.BookingDetails.All(x => x.isRefund)).ToList();
            CreateLabel($"Vacancy ratio:{vacancy.Count()}/{itemPrices.Count()}", PropertyOrListingsSummaryGroupBox, 7);
            #endregion
            #region Scores Summary
            var averagescore = items.Where(x => x.ItemScores.Any()).SelectMany(X => X.ItemScores);
            CreateLabel($"Average score for listings:{(averagescore.Any() ? averagescore.Average(t => t.Value).ToString("#.##") : "N/A")}",ScoresSummaryGroupBox,1);
            var heightScore = items.Where(x => x.ItemScores.Any()).Select(X => new {name=X.Title,value=X.ItemScores.Average(x=>x.Value)}).OrderByDescending(t => t.value).FirstOrDefault();
            CreateLabel($"Name of listing with highest score:{(heightScore == null ? "N/A" : heightScore.name)}", ScoresSummaryGroupBox, 2);
            var topScoreUser = items
                   .Where(t => t.ItemScores.Any())
                   .Select(t => new { Name = t.Users.FullName, Score = t.ItemScores.Average(x => x.Value) })
                   .GroupBy(t => t.Score)
                   .OrderByDescending(t => t.Key)
                   .FirstOrDefault();
            CreateLabel($"Top ownew/manager by average score:{(topScoreUser == null ? "N/A" : String.Join(",", topScoreUser.Select(t => t.Name)))}", ScoresSummaryGroupBox, 3);
            var leastScoreUser = items
                    .Where(t => t.ItemScores.Any())
                    .Select(t => new { Name = t.Users.FullName, Score = t.ItemScores.Average(x => x.Value) })
                    .GroupBy(t => t.Score)
                    .OrderBy(t => t.Key)
                    .FirstOrDefault();
            CreateLabel($"The least clean owner/manager:{(leastScoreUser == null ? "N/A" : String.Join(",", leastScoreUser.Select(t => t.Name)))}", ScoresSummaryGroupBox, 4);
            #endregion
            #region Financial Summary
            CreateLabel("Average net revenue of all owners/managers:", FinancialSummaryGroupBox, 1);
            CreateLabel("Highest net revenue for an owner/manager:", FinancialSummaryGroupBox, 2);
            CreateLabel("Our total revenue from cancellations:",FinancialSummaryGroupBox,3);
            CreateLabel("Total discounts from coupons:",FinancialSummaryGroupBox,4);
            #endregion
            #region Chart
            var timefiler = !String.IsNullOrWhiteSpace(ToDateTimePicker.Text) ? ToDateTimePicker.Value : DateTime.Now;
            var start=new DateTime(timefiler.AddMonths(-2).Year, timefiler.AddMonths(-2).Month, 1);
            var end = new DateTime(timefiler.Year, timefiler.Month, DateTime.DaysInMonth(timefiler.Year, timefiler.Month));
            for (var temp = start; temp < end; temp = temp.AddMonths(1))
            {
                DateTime nextMonth = temp.AddMonths(1);
                var data = itemPrices.Where(t => t.Date >= temp && t.Date < nextMonth).ToList();
                chart.Series[0].Points.AddXY(temp.Date.ToString("MMM", new CultureInfo("en-US")), data.Count(t => !t.BookingDetails.Any() || t.BookingDetails.All(x => x.isRefund)));
                chart.Series[1].Points.AddXY(temp.Date.ToString("MMM", new CultureInfo("en-US")), data.Count(t => t.BookingDetails.Any(x => !x.isRefund)));
            }
            #endregion
        }
        public void ServiceReport()
        {
            this.dataGridView1.DataSource = null;
            using (Session6Entities entities = new Session6Entities())
            {
                var addonServiceDetails = entities.AddonServiceDetails.ToList();
                if (!String.IsNullOrWhiteSpace(this.FormDataTimePicker.Text))
                {
                    addonServiceDetails = addonServiceDetails.Where(t => t.FromDate.Date >= this.FormDataTimePicker.Value.Date).ToList();
                }
                if (!String.IsNullOrWhiteSpace(this.ToDateTimePicker.Text))
                {
                    addonServiceDetails = addonServiceDetails.Where(t => t.FromDate.Date <= this.ToDateTimePicker.Value.Date).ToList();
                }
                label6.Text = $"Number of purchased services: {addonServiceDetails.Where(t => t.FromDate.Date <= DateTime.Today.Date && !t.isRefund).Count()}";

                decimal totalRevenue = addonServiceDetails.Sum(t =>
                {
                    if (t.isRefund)
                    {
                        return 0;
                    }
                    var amount = t.NumberOfPeople * t.Services.Price;
                    if (t.AddonServices.CouponID.HasValue)
                    {
                        var discount = amount * (t.AddonServices.Coupons.DiscountPercent / 100);
                        if (discount > t.AddonServices.Coupons.MaximimDiscountAmount)
                        {
                            discount = t.AddonServices.Coupons.MaximimDiscountAmount;
                        }
                        amount -= discount;
                    }
                    return amount;
                });
                label7.Text=$"Total revenue from service reservations: {totalRevenue.ToString("#.##")}";
                var mostBookedService = addonServiceDetails
                    .GroupBy(t => t.Services)
                    .GroupBy(t => t.Count())
                    .OrderByDescending(t => t.Key)
                    .FirstOrDefault();
                label8.Text = $"Most booked service: {(mostBookedService == null ? "N/A" : String.Join(",", mostBookedService.Select(t => t.Key.Name)))}";
                List<object> dataSource = new List<object>();
                var yearFilter = !String.IsNullOrWhiteSpace(this.ToDateTimePicker.Text) ? this.ToDateTimePicker.Value.Year : DateTime.Now.Year;
                var fromMonth = !String.IsNullOrWhiteSpace(this.FormDataTimePicker.Text) ? this.FormDataTimePicker.Value.Month : 1;
                var toMonth = !String.IsNullOrWhiteSpace(this.ToDateTimePicker.Text) ? this.ToDateTimePicker.Value.Month : 12;
                foreach (var serviceType in entities.ServiceTypes.ToList())
                {
                    List<int> serviceMonthlyAvaiable = new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
                    for (int month = fromMonth; month <= toMonth; month++)
                    {
                        bool avaiable = false;
                        foreach (var service in serviceType.Services)
                        {
                            List<int> timeRange = new List<int>();
                            if (service.DayOfMonth == "*" || service.DayOfWeek == "*")
                            {
                                timeRange.AddRange(Enumerable.Range(1, DateTime.DaysInMonth(yearFilter, month)));
                            }
                            if (!timeRange.Any())
                            {
                                var source = String.IsNullOrWhiteSpace(service.DayOfMonth) ? service.DayOfWeek : service.DayOfMonth;
                                timeRange.AddRange(source.Split(',')
                                    .Select(t => t.Split('-'))
                                    .SelectMany(t => Enumerable.Range(Convert.ToInt32(t.First()), (Convert.ToInt32(t.Last()) - Convert.ToInt32(t.First())) + 1))
                                    .OrderBy(t => t)
                                    .ToList());
                            }

                            var details = service.AddonServiceDetails
                                .Where(t => t.FromDate.Year == yearFilter && t.FromDate.Month == month && !t.isRefund)
                                .ToList();
                            if (!String.IsNullOrWhiteSpace(service.DayOfWeek))
                            {
                                avaiable |= timeRange.Any(t =>
                                {
                                    var data = details.Where(x => x.FromDate.DayOfWeek == (DayOfWeek)t).ToList();
                                    if (data.Count() == 0)
                                    {
                                        return true;
                                    }
                                    return data.Sum(x => x.NumberOfPeople) <= service.DailyCap;
                                });
                            }
                            if (!String.IsNullOrWhiteSpace(service.DayOfMonth))
                            {
                                avaiable |= timeRange.Any(t =>
                                {
                                    var data = details.Where(x => x.FromDate.Day == t).ToList();
                                    if (data.Count() == 0)
                                    {
                                        return true;
                                    }
                                    return data.Sum(x => x.NumberOfPeople) <= service.DailyCap;
                                });
                            }
                        }
                        serviceMonthlyAvaiable[month - 1] = Convert.ToInt32(avaiable);
                    }
                    dataSource.Add(new
                    {
                        serviceType.Name,
                        Jan = serviceMonthlyAvaiable[0].ToString(),
                        Feb = serviceMonthlyAvaiable[1].ToString(),
                        Mar = serviceMonthlyAvaiable[2].ToString(),
                        Apr = serviceMonthlyAvaiable[3].ToString(),
                        May = serviceMonthlyAvaiable[4].ToString(),
                        Jun = serviceMonthlyAvaiable[5].ToString(),
                        Jul = serviceMonthlyAvaiable[6].ToString(),
                        Aug = serviceMonthlyAvaiable[7].ToString(),
                        Sep = serviceMonthlyAvaiable[8].ToString(),
                        Oct = serviceMonthlyAvaiable[9].ToString(),
                        Nov = serviceMonthlyAvaiable[10].ToString(),
                        Dec = serviceMonthlyAvaiable[11].ToString()
                    });
                }
                dataGridView1.DataSource = dataSource;
            }
        }
        public void HostAnalysis()
        {
            Session6Entities entities = new Session6Entities();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            var tansactions = entities.Transactions.ToList();
            var hosts = entities.Users.Where(t => t.Items.Any()).ToList();






        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 1)
                return;
            int value = Convert.ToInt32(e.Value);
            e.Value = "";
            if (value == 1)
                e.CellStyle.BackColor = Color.FromArgb(229, 26, 46);
        }
    }
}