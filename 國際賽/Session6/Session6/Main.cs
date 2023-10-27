﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            init();
        }
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
            #region Monthly Vacancy Ratio
            var timefilter = !string.IsNullOrWhiteSpace(ToDateTimePicker.Text) ? ToDateTimePicker.Value : DateTime.Now;
            var start = new DateTime(timefilter.AddMonths(-2).Year, timefilter.AddMonths(-2).Month, 1);
            var end = new DateTime(timefilter.Year, timefilter.Month, DateTime.DaysInMonth(timefilter.Year, timefilter.Month));
            for (DateTime temp = start; temp < end; temp = temp.AddMonths(1))
            {
                var nextMonth = temp.AddMonths(1);
                var data = itemPrices.Where(x => x.Date >= temp && x.Date < nextMonth).ToList();
                chart.Series[0].Points.AddXY(temp.Date.ToString("MMM", new CultureInfo("en-US")), data.Count(x => !x.BookingDetails.Any() || x.BookingDetails.All(y => y.isRefund)));
                chart.Series[1].Points.AddXY(temp.Date.ToString("MMM", new CultureInfo("en-US")), data.Count(x => x.BookingDetails.Any(y => !y.isRefund)));
            }
            #endregion
            #region Financial Summary
            decimal cancelAmount = 0;
            decimal totalDiscount = 0;
            var userRevenue = new List<(Users, decimal)>();
            foreach (var booking in transactions.SelectMany(x=>x.Bookings))
            {
                foreach (var bookingDetail in booking.BookingDetails)
                {
                    if ((!string.IsNullOrWhiteSpace(HostComboBox.Text) && bookingDetail.ItemPrices.Items.UserID == (long)HostComboBox.SelectedValue) || (!string.IsNullOrWhiteSpace(GuestComboBox.Text) && booking.UserID == (long)GuestComboBox.SelectedValue))
                        continue;
                    var total = bookingDetail.ItemPrices.Price - bookingDetail.ItemPrices.Price * (bookingDetail.ItemPrices.CancellationPolicies.Commission / 100);
                    if (booking.CouponID.HasValue)
                    {
                        decimal discount = bookingDetail.ItemPrices.Price * (booking.Coupons.DiscountPercent / 100);
                        if (discount > booking.Coupons.MaximimDiscountAmount)
                            discount = booking.Coupons.MaximimDiscountAmount;
                        total-=discount;
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
                    userRevenue.Add((booking.Users, total));
                }
            }
            var userRevenueMapping = userRevenue.GroupBy(x => x.Item1).ToList();
            CreateLabel($"Average net revenue of all owners / managers: {(userRevenueMapping.Count!=0?userRevenueMapping.Average(x=>x.Sum(y=>y.Item2)).ToString("#.##"):"0")}", FinancialSummaryPanel, 0);
            CreateLabel($"Highest net revenue for an owner / manager: {(userRevenueMapping.Count()!=0?userRevenueMapping.OrderByDescending(x=>x.Sum(y=>y.Item2)).First().Key.FullName:"N/A")}", FinancialSummaryPanel, 1);
            CreateLabel($"Our total revenue from cancellations: {cancelAmount.ToString("#.##")}", FinancialSummaryPanel, 2);
            CreateLabel($"Total discounts from coupons: {totalDiscount.ToString("#.##")}", FinancialSummaryPanel, 3);
            #endregion
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
    }
}