using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            Session6Entities entities = new Session6Entities();
            FromDateTimePicker.CustomFormat = " ";
            ToDateTimePicker.CustomFormat = " ";
            var areaData = entities.Areas.Select(t => new { t.ID, t.Name }).ToList();
            areaData.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DataSource = areaData;
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            var hostData = entities.Users.Where(t => t.Items.Any()).Select(t => new { t.ID, t.FullName }).OrderBy(t => t.FullName).ToList();
            hostData.Insert(0, new { ID = (long)-1, FullName = "" });
            HostComboBox.DataSource = hostData;
            HostComboBox.DisplayMember = "FullName";
            HostComboBox.ValueMember = "ID";
            var guestData = entities.Users.Where(t => t.Bookings.Any()).OrderBy(t => t.Items.Count()).ToList().Reverse<Users>().Select(t => new { t.ID, t.FullName }).ToList();
            guestData.Insert(0, new { ID = (long)-1, FullName = "" });
            GuestComboBox.DataSource = guestData;
            GuestComboBox.DisplayMember = "FullName";
            GuestComboBox.ValueMember = "ID";
        }
        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
            ((DateTimePicker)sender).CustomFormat = "yyyy-MM-dd";
        }
        private void ResetBtn_Click(object sender, EventArgs e) => init();
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(FromDateTimePicker.Text) && !String.IsNullOrWhiteSpace(ToDateTimePicker.Text))
            {
                if (FromDateTimePicker.Value.Date > ToDateTimePicker.Value.Date)
                {
                    MessageBox.Show("From date can't over To date.");
                    return;
                }
            }
            if (TabControlMain.SelectedIndex == 0)
                page1();
            if (TabControlMain.SelectedIndex == 1)
                page2();
            if (TabControlMain.SelectedIndex == 2)
                page3();
        }
        public void page1()
        {
            Session6Entities entities = new Session6Entities();
            ListingsSummaryPanel.Controls.Clear();
            ScoresSummaryPanel.Controls.Clear();
            FinancialSummaryPanel.Controls.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            var items = entities.Items.ToList();
            var itemPrices = entities.ItemPrices.ToList();
            var transactions = entities.Transactions.ToList();
            var bookingDetails = entities.BookingDetails.ToList();
            if (!String.IsNullOrWhiteSpace(FromDateTimePicker.Text))
            {
                itemPrices = itemPrices.Where(t => t.Date.Date >= FromDateTimePicker.Value.Date).ToList();
                transactions = transactions.Where(t => t.TransactionDate.Date >= FromDateTimePicker.Value.Date).ToList();
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
            if (!String.IsNullOrWhiteSpace(GuestComboBox.Text))
            {
                var guestId = (long)GuestComboBox.SelectedValue;
                transactions = transactions.Where(t => t.UserID == guestId).ToList();
                bookingDetails = bookingDetails.Where(t => t.Bookings.UserID == guestId).ToList();
            }
            #region Property or listing summary
            var completeBooked = bookingDetails.Where(t => !t.isRefund && t.ItemPrices.Date.Date < DateTime.Now.Date).ToList();
            CreateLabel($"Secured Bookings: {completeBooked.Count()}", ListingsSummaryPanel, 0);
            var ppcomingBooked = bookingDetails
                .Where(t => !t.isRefund && t.ItemPrices.Date.Date >= DateTime.Now.Date).ToList();
            CreateLabel($"Upcoming Bookings(reservations): {ppcomingBooked.Count()}", ListingsSummaryPanel, 1);
            var mostBookedDate = completeBooked.GroupBy(t => t.ItemPrices.Date.DayOfWeek).OrderByDescending(t => t.Count()).FirstOrDefault();
            CreateLabel($"Most booked day of week: {(mostBookedDate != null ? mostBookedDate.Key.ToString() : "N/A")}", ListingsSummaryPanel, 2);
            var inactiveItems = items.Where(t => !t.ItemPrices.Any()).ToList();
            CreateLabel($"Inactive listings or properties: {inactiveItems.Count()}", ListingsSummaryPanel, 3);
            var coupons = bookingDetails.Where(t => t.Bookings.CouponID.HasValue).GroupBy(t => t.Bookings.Coupons).Select(t => new { Name = t.Key.CouponCode, Count = t.Count() }).GroupBy(t => t.Count).OrderByDescending(t => t.Key).FirstOrDefault();
            CreateLabel($"Most used coupon:  {(coupons == null ? "N/A" : String.Join(",", coupons.Select(t => t.Name)))}", ListingsSummaryPanel, 4);
            var vacancy = itemPrices.Where(t => !t.BookingDetails.Any() || t.BookingDetails.All(x => x.isRefund)).ToList();
            CreateLabel($"Vacancy ratio: {vacancy.Count()}/{itemPrices.Count()}", ListingsSummaryPanel, 5);
            #endregion
            #region Scores Summary
            var AverageScore = items.Where(x => x.ItemScores.Any()).SelectMany(x => x.ItemScores);
            CreateLabel($"Average score for listings:  {(AverageScore.Any() ? AverageScore.Average(t => t.Value).ToString("#.##") : "N/A")}", ScoresSummaryPanel, 0);
            var hightscore = items.Where(t => t.ItemScores.Any()).Select(t => new { Name = t.Title, Score = t.ItemScores.Average(x => x.Value) }).OrderByDescending(t => t.Score).FirstOrDefault();
            CreateLabel($"Name of listing with highest score:  {(hightscore == null ? "N/A" : hightscore.Name)}", ScoresSummaryPanel, 1);
            var topScoreUser = items.Where(t => t.ItemScores.Any()).Select(t => new { Name = t.Users.FullName, Score = t.ItemScores.Average(x => x.Value) }).GroupBy(t => t.Score).OrderByDescending(t => t.Key).FirstOrDefault();
            CreateLabel($"Top owner / manager by average score: {(topScoreUser == null ? "N/A" : String.Join(",", topScoreUser.Select(t => t.Name)))}", ScoresSummaryPanel, 2);
            var leastScoreUser = items.Where(t => t.ItemScores.Any()).Select(t => new { Name = t.Users.FullName, Score = t.ItemScores.Average(x => x.Value) }).GroupBy(t => t.Score).OrderBy(t => t.Key).FirstOrDefault();
            CreateLabel($"The least clean owner / manager:   {(leastScoreUser == null ? "N/A" : String.Join(",", leastScoreUser.Select(t => t.Name)))}", ScoresSummaryPanel, 3);
            #endregion
            #region Monthly Vacancy Ratio:
            var timefiler = !String.IsNullOrWhiteSpace(ToDateTimePicker.Text) ? ToDateTimePicker.Value : DateTime.Now;
            var start = new DateTime(timefiler.AddMonths(-2).Year, timefiler.AddMonths(-2).Month, 1);
            var end = new DateTime(timefiler.Year, timefiler.Month, DateTime.DaysInMonth(timefiler.Year, timefiler.Month));
            for (DateTime temp = start; temp < end; temp = temp.AddMonths(1))
            {
                DateTime nextMonth = temp.AddMonths(1);
                var data = itemPrices.Where(t => t.Date >= temp && t.Date < nextMonth).ToList();
                chart.Series[0].Points.AddXY(temp.Date.ToString("MMM", new CultureInfo("en-US")), data.Count(t => !t.BookingDetails.Any() || t.BookingDetails.All(x => x.isRefund)));
                chart.Series[1].Points.AddXY(temp.Date.ToString("MMM", new CultureInfo("en-US")), data.Count(t => t.BookingDetails.Any(x => !x.isRefund)));
            }
            #endregion
            #region Financial Summary
            decimal cancelAmount = 0;
            decimal totalDiscount = 0;
            List<Tuple<Users, decimal>> userRevenue = new List<Tuple<Users, decimal>>();
            foreach (var transaction in transactions)
            {
                foreach (var booking in transaction.Bookings)
                {
                    foreach (var bookingDetail in booking.BookingDetails)
                    {
                        if (!String.IsNullOrWhiteSpace(HostComboBox.Text)
                            && bookingDetail.ItemPrices.Items.UserID == (long)HostComboBox.SelectedValue)
                        {
                            continue;
                        }
                        if (!String.IsNullOrWhiteSpace(GuestComboBox.Text)
                            && booking.UserID == (long)GuestComboBox.SelectedValue)
                        {
                            continue;
                        }
                        decimal total = bookingDetail.ItemPrices.Price -
                            bookingDetail.ItemPrices.Price * (bookingDetail.ItemPrices.CancellationPolicies.Commission / 100);
                        if (booking.CouponID.HasValue)
                        {
                            decimal discount = bookingDetail.ItemPrices.Price * (booking.Coupons.DiscountPercent / 100);
                            if (discount > booking.Coupons.MaximimDiscountAmount)
                            {
                                discount = booking.Coupons.MaximimDiscountAmount;
                            }
                            total -= discount;
                            totalDiscount += discount;
                        }
                        if (bookingDetail.isRefund)
                        {
                            total = 0;
                            var dayLeft = (bookingDetail.ItemPrices.Date - bookingDetail.RefundDate.Value).Days;
                            var fee = entities.CancellationRefundFees
                                .FirstOrDefault(t => t.CancellationPolicyID == bookingDetail.RefundCancellationPoliciyID
                                    && t.DaysLeft == dayLeft);
                            if (fee != null)
                            {
                                var refundAmount = bookingDetail.ItemPrices.Price * (fee.PenaltyPercentage / 100) / 2;
                                cancelAmount += refundAmount;
                                total = refundAmount;
                            }
                        }
                        userRevenue.Add(new Tuple<Users, decimal>(booking.Users, total));
                    }
                }
            }
            var userRevenueMapping = userRevenue.GroupBy(t => t.Item1).ToList();
            CreateLabel($"Average net revenue of all owners / managers: {(userRevenueMapping.Count() != 0 ? userRevenueMapping.Average(t => t.Sum(x => x.Item2)).ToString("#.##") : "0")}", FinancialSummaryPanel, 0);
            CreateLabel($"Highest net revenue for an owner / manager: " + $"{(userRevenueMapping.Count() != 0 ? userRevenueMapping.OrderByDescending(t => t.Sum(x => x.Item2)).First().Key.FullName : "N/A")}", FinancialSummaryPanel, 1);
            CreateLabel($"Our total revenue from cancellations: {cancelAmount.ToString("#.##")}", FinancialSummaryPanel, 2);
            CreateLabel($"Total discounts from coupons: {totalDiscount.ToString("#.##")}", FinancialSummaryPanel, 3);
            #endregion
        }
        public void page2()
        {
            Session6Entities entities = new Session6Entities();
            ServiceDataGridView.DataSource = null;
            AddonServicesPanel.Controls.Clear();
            var addonServiceDetails = entities.AddonServiceDetails.ToList();
            if (!String.IsNullOrWhiteSpace(FromDateTimePicker.Text))
            {
                addonServiceDetails = addonServiceDetails.Where(t => t.FromDate.Date >= FromDateTimePicker.Value.Date).ToList();
            }
            if (!String.IsNullOrWhiteSpace(ToDateTimePicker.Text))
            {
                addonServiceDetails = addonServiceDetails.Where(t => t.FromDate.Date <= ToDateTimePicker.Value.Date).ToList();
            }
            CreateLabel($"Number of purchased services: {addonServiceDetails.Where(t => t.FromDate.Date <= DateTime.Today.Date && !t.isRefund).Count()}", AddonServicesPanel, 0);

            decimal totalRevenue = addonServiceDetails.Sum(t =>
            {
                if (t.isRefund)
                    return 0;
                var amount = t.NumberOfPeople * t.Services.Price;
                if (t.AddonServices.CouponID.HasValue)
                {
                    var discount = amount * (t.AddonServices.Coupons.DiscountPercent / 100);
                    if (discount > t.AddonServices.Coupons.MaximimDiscountAmount)
                        discount = t.AddonServices.Coupons.MaximimDiscountAmount;
                    amount -= discount;
                }
                return amount;
            });
            CreateLabel($"Total revenue from service reservations: {totalRevenue.ToString("#.##")}", AddonServicesPanel, 1);
            var mostBookedService = addonServiceDetails.GroupBy(t => t.Services).GroupBy(t => t.Count()).OrderByDescending(t => t.Key).FirstOrDefault();
            CreateLabel($"Most booked service: {(mostBookedService == null ? "N/A" : String.Join(",", mostBookedService.Select(t => t.Key.Name)))}", AddonServicesPanel, 2);
            List<object> dataSource = new List<object>();
            var yearFilter = !String.IsNullOrWhiteSpace(ToDateTimePicker.Text) ? ToDateTimePicker.Value.Year : DateTime.Now.Year;
            var fromMonth = !String.IsNullOrWhiteSpace(FromDateTimePicker.Text) ? FromDateTimePicker.Value.Month : 1;
            var toMonth = !String.IsNullOrWhiteSpace(ToDateTimePicker.Text) ? ToDateTimePicker.Value.Month : 12;
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
                            timeRange.AddRange(Enumerable.Range(1, DateTime.DaysInMonth(yearFilter, month)));
                        if (!timeRange.Any())
                        {
                            var source = String.IsNullOrWhiteSpace(service.DayOfMonth) ? service.DayOfWeek : service.DayOfMonth;
                            timeRange.AddRange(source.Split(',').Select(t => t.Split('-')).SelectMany(t => Enumerable.Range(Convert.ToInt32(t.First()), (Convert.ToInt32(t.Last()) - Convert.ToInt32(t.First())) + 1)).OrderBy(t => t).ToList());
                        }
                        var details = service.AddonServiceDetails.Where(t => t.FromDate.Year == yearFilter && t.FromDate.Month == month && !t.isRefund).ToList();
                        if (!String.IsNullOrWhiteSpace(service.DayOfWeek))
                        {
                            avaiable |= timeRange.Any(t =>
                            {
                                var data = details.Where(x => x.FromDate.DayOfWeek == (DayOfWeek)t).ToList();
                                if (data.Count() == 0)
                                    return true;
                                return data.Sum(x => x.NumberOfPeople) <= service.DailyCap;
                            });
                        }
                        if (!String.IsNullOrWhiteSpace(service.DayOfMonth))
                        {
                            avaiable |= timeRange.Any(t =>
                            {
                                var data = details.Where(x => x.FromDate.Day == t).ToList();
                                if (data.Count() == 0)
                                    return true;
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
                    Dec = serviceMonthlyAvaiable[11].ToString(),
                });
            }
            ServiceDataGridView.DataSource = dataSource;
            ServiceDataGridView.Columns[0].HeaderText = "";
        }
        public void page3()
        {
            Session6Entities entities = new Session6Entities();
            HostDataGridView.DataSource = null;
            TransactionDataGridView.Rows.Clear();
            TransactionTitleLabel.Text = null;
            var tansactions = entities.Transactions.ToList();
            var hosts = entities.Users.Where(t => t.Items.Any()).ToList();
            if (!String.IsNullOrWhiteSpace(this.FromDateTimePicker.Text))
            {
                tansactions = tansactions.Where(t => t.TransactionDate.Date >= this.FromDateTimePicker.Value.Date).ToList();
            }
            if (!String.IsNullOrWhiteSpace(this.ToDateTimePicker.Text))
            {
                tansactions = tansactions.Where(t => t.TransactionDate.Date <= this.ToDateTimePicker.Value.Date).ToList();
            }
            if (!String.IsNullOrWhiteSpace(this.HostComboBox.Text))
            {
                hosts = hosts.Where(t => t.ID == (long)this.HostComboBox.SelectedValue).ToList();
            }
            List<Tuple<Users, decimal, decimal>> userRevenue = new List<Tuple<Users, decimal, decimal>>();
            foreach (var transaction in tansactions)
            {
                foreach (var booking in transaction.Bookings)
                {
                    foreach (var bookingDetail in booking.BookingDetails)
                    {
                        if (!String.IsNullOrWhiteSpace(this.HostComboBox.Text)
                            && bookingDetail.ItemPrices.Items.UserID == (long)this.HostComboBox.SelectedValue)
                        {
                            continue;
                        }
                        if (!String.IsNullOrWhiteSpace(this.GuestComboBox.Text)
                            && booking.UserID == (long)this.GuestComboBox.SelectedValue)
                        {
                            continue;
                        }
                        decimal commission = bookingDetail.ItemPrices.Price * (bookingDetail.ItemPrices.CancellationPolicies.Commission / 100);
                        decimal total = bookingDetail.ItemPrices.Price;
                        if (booking.CouponID.HasValue)
                        {
                            decimal discount = bookingDetail.ItemPrices.Price * (booking.Coupons.DiscountPercent / 100);
                            if (discount > booking.Coupons.MaximimDiscountAmount)
                            {
                                discount = booking.Coupons.MaximimDiscountAmount;
                            }
                            total -= discount;
                        }
                        if (bookingDetail.isRefund)
                        {
                            total = 0;
                            var dayLeft = (bookingDetail.ItemPrices.Date - bookingDetail.RefundDate.Value).Days;
                            var fee = entities.CancellationRefundFees
                                .FirstOrDefault(t => t.CancellationPolicyID == bookingDetail.RefundCancellationPoliciyID
                                    && t.DaysLeft == dayLeft);
                            if (fee != null)
                            {
                                var refundAmount = bookingDetail.ItemPrices.Price * (fee.PenaltyPercentage / 100) / 2;
                                total = refundAmount;
                            }
                        }
                        userRevenue.Add(new Tuple<Users, decimal, decimal>(bookingDetail.ItemPrices.Items.Users, total, commission));
                    }
                }
            }
            this.HostDataGridView.DataSource = hosts.Select(t =>
            {
                var total = userRevenue.Where(x => x.Item1.ID == t.ID).Sum(x => x.Item2);
                var commission = userRevenue.Where(x => x.Item1.ID == t.ID).Sum(x => x.Item3);
                var net = total - commission;
                var withdrawData = tansactions.Where(x => x.UserID == t.ID && x.TransactionTypeID == 2).ToList();
                return new
                {
                    t.ID,
                    t.FullName,
                    TotalRevenue = "$" + total,
                    NetRevenun = "$" + net,
                    RemainingBalance = "$" + (total - withdrawData.Sum(x => x.Amount)),
                    LastWithdrawal = withdrawData.LastOrDefault()?.TransactionDate.ToString("yyyy-MM-dd") ?? ""
                };
            }).ToList();
        }
        public void CreateLabel(string text, Control control, int index)
        {
            Label label = new Label()
            {
                Text = text,
                AutoSize = true,
                Location = new Point(15, (index + 1) * 30),
                Font = base.Font
            };
            control.Controls.Add(label);
        }
        private void ServiceDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 1)
                return;
            int value = Convert.ToInt32(e.Value);
            e.Value = "";
            if (value == 1)
                e.CellStyle.BackColor = Color.FromArgb(229, 26, 46);
            else if (value == 2)
                ServiceDataGridView.Columns[e.ColumnIndex].HeaderText = "";
        }
        private void HostDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            this.TransactionTitleLabel.Text = $"Transaction detail for {this.HostDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()}";
            this.TransactionDataGridView.Rows.Clear();

            long hostId = (long)this.HostDataGridView.Rows[e.RowIndex].Cells[0].Value;

            using (Session6Entities entities = new Session6Entities())
            {
                var bookings = entities.Bookings.ToList();
                if (!String.IsNullOrWhiteSpace(this.FromDateTimePicker.Text))
                {
                    bookings = bookings.Where(t => t.BookingDate.Date >= this.FromDateTimePicker.Value.Date).ToList();
                }
                if (!String.IsNullOrWhiteSpace(this.ToDateTimePicker.Text))
                {
                    bookings = bookings.Where(t => t.BookingDate.Date <= this.ToDateTimePicker.Value.Date).ToList();
                }
                if (!String.IsNullOrWhiteSpace(this.GuestComboBox.Text))
                {
                    bookings = bookings.Where(t => t.UserID == (long)this.GuestComboBox.SelectedValue).ToList();
                }

                foreach (var booking in bookings.Where(t => t.BookingDetails.All(x => x.ItemPrices.Items.UserID == hostId)).OrderBy(t => t.BookingDate))
                {
                    List<BookingDetails> refundDetails = new List<BookingDetails>();
                    foreach (var bookingDetailGropping in booking.BookingDetails.GroupBy(t => t.ItemPrices.Items))
                    {
                        decimal amount = 0;
                        decimal commission = 0;
                        var bookingDetailGroppingOrderBy = bookingDetailGropping.OrderBy(t => t.ItemPrices.Date);
                        foreach (var bookingDetails in bookingDetailGroppingOrderBy)
                        {
                            if (bookingDetails.isRefund)
                            {
                                refundDetails.Add(bookingDetails);
                            }

                            decimal value = bookingDetails.ItemPrices.Price;
                            commission += bookingDetails.ItemPrices.Price * (bookingDetails.ItemPrices.CancellationPolicies.Commission / 100);
                            if (booking.CouponID.HasValue)
                            {
                                var discount = bookingDetails.ItemPrices.Price * (booking.Coupons.DiscountPercent / 100);
                                if (discount > booking.Coupons.MaximimDiscountAmount)
                                {
                                    discount = booking.Coupons.MaximimDiscountAmount;
                                }
                                value -= discount;
                            }
                            amount += value;
                        }
                        this.TransactionDataGridView.Rows.Add(booking.Transactions.TransactionDate.ToString("yyyy-MM-dd"),
                            "$" + amount,
                            "$" + commission,
                            $"Reserve {bookingDetailGroppingOrderBy.First().ItemPrices.Items.Title} from {bookingDetailGroppingOrderBy.First().ItemPrices.Date.ToString("yyyy-MM-dd")} - {bookingDetailGroppingOrderBy.Last().ItemPrices.Date.ToString("yyyy-MM-dd")}");
                    }

                    List<BookingDetails> current = new List<BookingDetails>();
                    List<List<BookingDetails>> refundGropping = new List<List<BookingDetails>>();
                    for (int i = 0; i < refundDetails.Count(); i++)
                    {
                        if (i == 0)
                        {
                            current.Add(refundDetails[i]);
                            if (i == refundDetails.Count() - 1)
                            {
                                refundGropping.Add(current);
                            }
                            continue;
                        }
                        if (refundDetails[i].ItemPrices.Date.Date == refundDetails[i - 1].ItemPrices.Date.AddDays(1).Date)
                        {
                            current.Add(refundDetails[i]);
                            if (i == refundDetails.Count() - 1)
                            {
                                refundGropping.Add(current);
                            }
                        }
                        else
                        {

                            refundGropping.Add(current);
                            current = new List<BookingDetails>() { refundDetails[i] };
                            if (i == refundDetails.Count() - 1)
                            {
                                refundGropping.Add(current);
                            }
                        }
                    }
                    foreach (var refunds in refundGropping)
                    {
                        decimal amount = 0;
                        decimal commission = 0;
                        refunds.ForEach(t =>
                        {
                            decimal value = t.ItemPrices.Price;
                            if (booking.CouponID.HasValue)
                            {
                                var discount = value * (booking.Coupons.DiscountPercent / 100);
                                if (discount > booking.Coupons.MaximimDiscountAmount)
                                {
                                    discount = booking.Coupons.MaximimDiscountAmount;
                                }
                                value -= discount;
                            }
                            amount += value;

                            var dayLeft = (t.ItemPrices.Date - t.RefundDate.Value).Days;
                            var fee = entities.CancellationRefundFees
                                .FirstOrDefault(x => x.CancellationPolicyID == t.RefundCancellationPoliciyID
                                    && x.DaysLeft == dayLeft);
                            if (fee != null)
                            {
                                var refundAmount = t.ItemPrices.Price * (fee.PenaltyPercentage / 100) / 2;
                                commission += refundAmount;
                            }
                        });
                        this.TransactionDataGridView.Rows.Add(booking.Transactions.TransactionDate.ToString("yyyy-MM-dd"),
                            "$" + amount,
                            "$" + commission,
                            $"Cancel Reserve {refunds.First().ItemPrices.Items.Title} from {refunds.First().ItemPrices.Date.ToString("yyyy-MM-dd")} - {refunds.Last().ItemPrices.Date.ToString("yyyy-MM-dd")}");
                    }
                }
            }
        }
    }
}
