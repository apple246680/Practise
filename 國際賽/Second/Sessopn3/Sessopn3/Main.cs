using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sessopn2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SearchListBox.Visible = false;
        }

        private void AdvancedSearchBtn_Click(object sender, EventArgs e)
        {
            AdvancedSearch advancedSearch = new AdvancedSearch();
            Visible = false;
            advancedSearch.ShowDialog();
            Visible = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (Session3Entities entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text))
                    items = items.Where(x => x.Areas.Name == SearchTextBox.Text || x.Title == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attractions.Name == SearchTextBox.Text) || x.ItemTypes.Name == SearchTextBox.Text || x.ItemAmenities.Any(y => y.Amenities.Name == SearchTextBox.Text)).ToList();
                int nights = (int)NightNum.Value;
                int people = (int)PeopleNum.Value;
                DateTime from = FromDateTImePicker.Value;
                DateTime to = from.AddDays(nights);
                items = items.Where(x => x.ItemPrices.Any(y => y.Date >= from && y.Date <= to)
                    && x.Capacity >= people).OrderBy(x => x.Title).ToList();
                ResultsDataGridView.Rows.Clear();
                items.ForEach(x =>
                {
                    var score = x.ItemScores.Any() ? Math.Round(x.ItemScores.Average(y => y.Value), 2).ToString() : "";
                    var totalComplate = x.ItemPrices.Any() ?
                        x.ItemPrices.Count(y => y.BookingDetails.Any(z => !z.isRefund)) : 0;
                    var amount = x.ItemPrices.Any(y => y.Date >= from && y.Date < to)
                        ? x.ItemPrices.Where(y => y.Date >= from && y.Date <= to).Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    ResultsDataGridView.Rows.Add(x.Title, x.Areas.Name, score, totalComplate, amount);
                });
                CountLabel.Text = $"Displaying {items.Count()} options";
                Text = "Seoul Stay - Search Results";
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchListBox.Visible = false;
            SearchListBox.Items.Clear();
            if (SearchTextBox.Text.Length >= 3)
            {
                Session3Entities entities = new Session3Entities();
                var searchResults = entities.Areas
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "Area" })
                .Concat(entities.Attractions
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "Attraction" }))
                .Concat(entities.Items
                .Where(t => t.Title.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Title, Type = "Listing" }))
                .Concat(entities.ItemTypes
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "ItemType" }))
                .Concat(entities.Amenities
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "Amenities" }))
                .ToList();
                foreach (var result in searchResults)
                    SearchListBox.Items.Add($"{result.Name}      {result.Type}");
                SearchListBox.Visible=true;
            }
        }
        private void PromptWordLabel_Click(object sender, EventArgs e)
        {
            PromptWordLabel.SendToBack();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                PromptWordLabel.BringToFront();
                SearchListBox.Visible=false;
            }
        }

        private void SearchListBox_MouseClick(object sender, MouseEventArgs e)
        {
            SearchListBox.Visible = false;
            SearchTextBox.Text = SearchListBox.Text.Replace("      ", "@").Split('@')[0];
        }
    }
}
