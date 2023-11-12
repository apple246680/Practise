using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Session3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SimpleSearchFormBtn_Click(null,null);
            init();
        }
        List<ComboBox> amenityComboBoxList;
        public void init()
        {
            amenityComboBoxList = new List<ComboBox>()
            {
                AmenityComboBox1,
                AmenityComboBox2,
                AmenityComboBox3
            };
            var entities = new Session3Entities();
            ResultsDataGridView.Rows.Clear();
            SearchTextBox.Text = "";
            ResultsLabel.Text = "";
            FromDateTimePicker.Value = DateTime.Now;
            FromDateTimePicker.MinDate = DateTime.Now;
            ToDateTimePicker.Value = DateTime.Now;
            ToDateTimePicker.MinDate = DateTime.Now;
            NightsNumber.Value = NightsNumber.Minimum;
            PeopleNumber.Value = PeopleNumber.Minimum;
            StartPrice.ResetText();
            MaxPrice.ResetText();
            AreaComboBox.Items.Clear();
            AttractionComboBox.Items.Clear();
            TitleComboBox.Items.Clear();
            TypeComboBox.Items.Clear();
            AmenityComboBox1.Items.Clear();
            AmenityComboBox2.Items.Clear();
            AmenityComboBox3.Items.Clear();
            AreaComboBox.Items.AddRange(entities.Areas.Select(x => new {x.ID,x.Name }).ToArray());
            AreaComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.Items.AddRange(entities.Attractions.Select(x => new {x.ID,x.Name }).ToArray());
            AttractionComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.Items.AddRange(entities.Items.Select(x => new {x.ID, Name = x.Title }).ToArray());
            TitleComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            TypeComboBox.Items.AddRange(entities.ItemTypes.Select(x => new {x.ID,x.Name }).ToArray());
            TypeComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            foreach (var comboBox in amenityComboBoxList)
            {
                comboBox.Items.AddRange(entities.Amenities.Select(x => new {x.ID,x.Name }).ToArray());
                comboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            }
        }
        private void AdvanedFormBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Properties or Listings(Advanced)";
            SimpleAdvancedGroupBox.Size = new Size(1169, 295);
            SearchResultsGroupBox.Visible = false;
            SimpleSearchBtn.Visible=false;
            AdvanedFormBtn.Visible=false;
            HintLabel.Visible=false;
            SearchTextBox.Visible=false;
            ListBoxHint.Visible=false;
            TopPanel.Visible = true;
            ToDatePanel.Visible = true;
            ResultsDataGridView.Columns[5].Visible = true;
            Size = new Size(1200, 590);
        }
        private void SimpleSearchFormBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Properties or Listings";
            SimpleAdvancedGroupBox.Size = new Size(1169, 170);
            SearchResultsGroupBox.Visible = false;
            TopPanel.Visible=false;
            ToDatePanel.Visible = false;
            ListBoxHint.Visible = false;
            ResultsDataGridView.Columns[5].Visible = false ;
            SimpleSearchBtn.Visible = true;
            AdvanedFormBtn.Visible = true;
            HintLabel.Visible = true;
            SearchTextBox.Visible = true;
            Size = new Size(1200, 450);
        }
        private void HintLabel_Click(object sender, EventArgs e)
        {
            HintLabel.Visible = false;
            SearchTextBox.Focus();
        }
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            HintLabel.Visible = false;
        }
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text) && SimpleSearchBtn.Visible)
            {
                HintLabel.Visible = true;
            }
        }
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Results";
            using (var entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text))
                    items = items.Where(x => x.Area.Name == SearchTextBox.Text || x.Title == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attraction.Name == SearchTextBox.Text) || x.ItemType.Name == SearchTextBox.Text || x.ItemAmenities.Any(y => y.Amenity.Name == SearchTextBox.Text)).ToList();
                var nights = (int)NightsNumber.Value;
                var people = (int)PeopleNumber.Value;
                DateTime from = FromDateTimePicker.Value;
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
                    ResultsDataGridView.Rows.Add(x.Title, x.Area.Name, score, totalComplate, amount);
                });
                ResultsLabel.Text = $"Displaying {items.Count()} options";
                SearchResultsGroupBox.Visible = true;
            }
        }
        private void AdvancedSearchBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Results(Advanced)";
            int onoptions = 4;
            var entities = new Session3Entities();
            if (FromDateTimePicker.Value > ToDateTimePicker.Value)
            {
                MessageBox.Show("From date can't over to date.");
                return;
            }
            if ((!string.IsNullOrEmpty(StartPrice.Text)) && (!string.IsNullOrEmpty(MaxPrice.Text)))
            {
                if (StartPrice.Value > MaxPrice.Value)
                {
                    MessageBox.Show("Starting oruce can't iver Maxinum price.");
                    return;
                }
            }
            var items = entities.Items.ToList();
            if (!string.IsNullOrEmpty(AreaComboBox.Text))
            {
                items = items.Where(x => x.AreaID == (long)AreaComboBox.SelectedIndex).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(AttractionComboBox.Text))
            {
                items = items.Where(x => x.ItemAttractions.Any(y => y.AttractionID == (long)AttractionComboBox.SelectedValue)).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(TitleComboBox.Text))
            {
                items = items.Where(x => x.ID == (long)TitleComboBox.SelectedValue).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(TypeComboBox.Text))
            {
                items = items.Where(x => x.ItemTypeID == (long)TypeComboBox.SelectedValue).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(StartPrice.Text))
            {
                onoptions++;
            }
            if (!string.IsNullOrEmpty(MaxPrice.Text))
            {
                onoptions++;
            }
            var amenityIdList = amenityComboBoxList.Where(t => t.Text != "").Select(t => (long)t.SelectedValue).Distinct().ToList();
            if (amenityIdList.Count() != 0)
            {
                onoptions += amenityIdList.Count();
                items = items.Where(t => t.ItemAmenities.Any(x => amenityIdList.Contains(x.ID))).ToList();
            }
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDateTimePicker.Value && x.Date <= ToDateTimePicker.Value) && t.Capacity >= PeopleNumber.Value).ToList();
            ResultsDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.0") : "";
                var totalconpate = item.ItemPrices.Any() ? item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                foreach (var x in item.ItemPrices.Where(x => x.Date > FromDateTimePicker.Value && x.Date <= ToDateTimePicker.Value).ToList())
                {
                    DateTime endDate = x.Date.AddDays((int)NightsNumber.Value);
                    var priceData = item.ItemPrices.Where(y => y.Date >= x.Date && y.Date < endDate).ToList();
                    var amount = priceData.Count() != 0 ? priceData.Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    if (!String.IsNullOrEmpty(StartPrice.Text) && priceData.Count() != 0 && StartPrice.Value > priceData.Sum(y => y.Price))
                    {
                        continue;
                    }
                    if (!String.IsNullOrEmpty(MaxPrice.Text) && priceData.Count() != 0 && MaxPrice.Value < priceData.Sum(y => y.Price))
                    {
                        continue;
                    }
                    ResultsDataGridView.Rows.Add(item.Title, item.Area.Name, score, totalconpate, amount, x.Date.ToString("dd/MM/yyyy"));
                }
            }
            ResultsLabel.Text = $"Displaying {items.Count()} options from {onoptions} properties";
            SearchResultsGroupBox.Visible = true;
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ListBoxHint.Items.Clear();
            ListBoxHint.Visible = false;
            if (SearchTextBox.Text.Length >= 3)
            {
                var entities = new Session3Entities();
                foreach (var x in entities.Areas.Where(t => t.Name.Contains(SearchTextBox.Text)))
                {
                    ListBoxHint.Items.Add(x.Name + "      Area");
                }
                foreach (var x in entities.Attractions.Where(t => t.Name.Contains(SearchTextBox.Text)))
                {
                    ListBoxHint.Items.Add(x.Name + "      Attraction");
                }
                foreach (var x in entities.Items.Where(t => t.Title.Contains(SearchTextBox.Text)))
                {
                    ListBoxHint.Items.Add(x.Title + "      Listing");
                }
                foreach (var x in entities.ItemTypes.Where(t => t.Name.Contains(SearchTextBox.Text)))
                {
                    ListBoxHint.Items.Add(x.Name + "      ItemType");
                }
                foreach (var x in entities.Amenities.Where(t => t.Name.Contains(SearchTextBox.Text)))
                {
                    ListBoxHint.Items.Add(x.Name + "      Amenities");
                }
                if (ListBoxHint.Items.Count != 0)
                {
                    ListBoxHint.BringToFront();
                    ListBoxHint.Visible = true;
                    ListBoxHint.SelectedIndex = 0;
                }
                if (ListBoxHint.Text.Replace("      ", "@").Split('@')[0] == SearchTextBox.Text)
                {
                    ListBoxHint.Visible = false;
                }
            }
        }
        private void ListBoxHint_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@').First();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}