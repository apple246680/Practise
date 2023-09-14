using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Sesosin3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            reset();
        }
        public void reset()
        {
            ResultGroupBox.Visible = false;
            ListBoxHint.Visible = false;
            SearchTextBox.Text = "";
            ResultDataGridView.Rows.Clear();
            ResultLabel.Text = "";
            FromDateTimePicker.Value = DateTime.Now.Date;
            FromDateTimePicker.MinDate = DateTime.Now;
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (Session3Entities entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text))
                    items = items.Where(x => x.Area.Name == SearchTextBox.Text || x.Title == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attraction.Name == SearchTextBox.Text) || x.ItemType.Name == SearchTextBox.Text || x.ItemAmenities.Any(y => y.Amenity.Name == SearchTextBox.Text)).ToList();
                int nights = (int)NightsNumber.Value;
                int people = (int)PeopleNumber.Value;
                DateTime from = FromDateTimePicker.Value;
                DateTime to = from.AddDays(nights);
                items = items.Where(x => x.ItemPrices.Any(y => y.Date >= from && y.Date <= to)
                    && x.Capacity >= people).OrderBy(x => x.Title).ToList();
                ResultDataGridView.Rows.Clear();
                items.ForEach(x =>
                {
                    var score = x.ItemScores.Any() ? Math.Round(x.ItemScores.Average(y => y.Value), 2).ToString() : "";
                    var totalComplate = x.ItemPrices.Any() ?
                        x.ItemPrices.Count(y => y.BookingDetails.Any(z => !z.isRefund)) : 0;
                    var amount = x.ItemPrices.Any(y => y.Date >= from && y.Date < to)
                        ? x.ItemPrices.Where(y => y.Date >= from && y.Date <= to).Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    ResultDataGridView.Rows.Add(x.Title, x.Area.Name, score, totalComplate, amount);
                });
                ResultLabel.Text = $"Displaying {items.Count()} options";
                Text = "Seoul Stay - Search Results";
                ResultGroupBox.Visible = true;
            }
        }
        private void HintLabel_Click(object sender, EventArgs e)
        {
            SearchTextBox.Focus();
        }
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            HintLabel.Visible = false;
        }
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text))
                HintLabel.Visible = true;
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ListBoxHint.Items.Clear();
            ListBoxHint.Visible = false;
            if (SearchTextBox.Text.Length >= 3)
            {
                Session3Entities entities = new Session3Entities();
                foreach (var x in entities.Areas.Where(t => t.Name.Contains(SearchTextBox.Text)))
                    ListBoxHint.Items.Add(x.Name + "      Area");
                foreach (var x in entities.Attractions.Where(t => t.Name.Contains(SearchTextBox.Text)))
                    ListBoxHint.Items.Add(x.Name + "      Attraction");
                foreach (var x in entities.Items.Where(t => t.Title.Contains(SearchTextBox.Text)))
                    ListBoxHint.Items.Add(x.Title + "      Listing");
                foreach (var x in entities.ItemTypes.Where(t => t.Name.Contains(SearchTextBox.Text)))
                    ListBoxHint.Items.Add(x.Name + "      ItemType");
                foreach (var x in entities.Amenities.Where(t => t.Name.Contains(SearchTextBox.Text)))
                    ListBoxHint.Items.Add(x.Name + "      Amenities");
                if (ListBoxHint.Items.Count != 0)
                {
                    ListBoxHint.BringToFront();
                    ListBoxHint.Visible = true;
                    ListBoxHint.SelectedIndex = 0;
                }
                if (ListBoxHint.Text.Replace("      ", "@").Split('@')[0] == SearchTextBox.Text)
                    ListBoxHint.Visible = false;
            }
        }

        private void ListBoxHint_KeyDown(object sender, KeyEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@')[0];
        }
        private void ListBoxHint_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@')[0];
        }

        private void AdvanedBtn_Click(object sender, EventArgs e)
        {
            AdvancedSearch advancedSearch = new AdvancedSearch();
            advancedSearch.Show();
        }
    }
}