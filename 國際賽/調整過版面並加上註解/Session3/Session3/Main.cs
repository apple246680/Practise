using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class Main : Form
    {
        /// <summary>
        /// InitializeComponent the Main Form
        /// </summary>
        public Main()
        {
            InitializeComponent();
            SimpleSearchFormBtn_Click(null, null);
            init();
        }
        List<ComboBox> amenityComboBoxList;
        /// <summary>
        /// init the Form
        /// </summary>
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
            SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
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
            var areadata=(entities.Areas.Select(x => new { x.ID, x.Name }).ToList());
            areadata.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DataSource = areadata;
            var Attractiondata=(entities.Attractions.Select(x => new { x.ID, x.Name }).ToList());
            Attractiondata.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DataSource = Attractiondata;
            var titledata=(entities.Items.Select(x => new { x.ID, Name = x.Title }).ToList());
            titledata.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DataSource = titledata;
            var typedata=(entities.ItemTypes.Select(x => new { x.ID, x.Name }).ToList());
            typedata.Insert(0, new { ID = (long)-1, Name = "" });
            TypeComboBox.DataSource = typedata;
            var amenities=(entities.Amenities.Select(x => new { x.ID, x.Name }).ToList());
            amenities.Insert(0, new { ID = (long)-1, Name = "" });
            AmenityComboBox1.DataSource = new List<object>(amenities);
            AmenityComboBox2.DataSource = new List<object>(amenities);
            AmenityComboBox3.DataSource = new List<object>(amenities);
        }
        /// <summary>
        /// Show Advaned Search Page
        /// </summary>
        private void AdvanedFormBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Properties or Listings(Advanced)";
            SimpleAdvancedGroupBox.Size = new Size(1169, 295);
            SearchResultsGroupBox.Visible = false;
            SimpleSearchBtn.Visible = false;
            AdvanedFormBtn.Visible = false;
            SearchTextBox.Visible = false;
            ListBoxHint.Visible = false;
            TopPanel.Visible = true;
            ToDatePanel.Visible = true;
            ResultsDataGridView.Columns[5].Visible = true;
            Size = new Size(1200, 590);
        }
        /// <summary>
        /// Show Simple Search Page
        /// </summary>
        private void SimpleSearchFormBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Properties or Listings";
            SimpleAdvancedGroupBox.Size = new Size(1169, 170);
            SearchResultsGroupBox.Visible = false;
            TopPanel.Visible = false;
            ToDatePanel.Visible = false;
            ListBoxHint.Visible = false;
            ResultsDataGridView.Columns[5].Visible = false;
            SimpleSearchBtn.Visible = true;
            AdvanedFormBtn.Visible = true;
            SearchTextBox.Visible = true;
            Size = new Size(1200, 450);
        }
        /// <summary>
        /// Using Filter simple search item data
        /// </summary>
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Results";
            using (var entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text)&&SearchTextBox.Text!= "Enter area name, attraction, property title, property type, amenities ...")
                    items = items.Where(x => x.Areas.Name == SearchTextBox.Text || x.Title == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attractions.Name == SearchTextBox.Text) || x.ItemTypes.Name == SearchTextBox.Text || x.ItemAmenities.Any(y => y.Amenities.Name == SearchTextBox.Text)).ToList();
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
                    ResultsDataGridView.Rows.Add(x.Title, x.Areas.Name, score, totalComplate, amount);
                });
                ResultsLabel.Text = $"Displaying {items.Count()} options";
                SearchResultsGroupBox.Visible = true;
            }
        }
        /// <summary>
        /// Using Filter Advanced search item data
        /// </summary>
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
                var id = (long)AreaComboBox.SelectedValue;
                items = items.Where(x => x.AreaID == id).ToList();
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
                    ResultsDataGridView.Rows.Add(item.Title, item.Areas.Name, score, totalconpate, amount, x.Date.ToString("dd/MM/yyyy"));
                }
            }
            ResultsLabel.Text = $"Displaying {items.Count()} options from {onoptions} properties";
            SearchResultsGroupBox.Visible = true;
        }
        /// <summary>
        /// Using keyword to search related information
        /// </summary>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text!= "Enter area name, attraction, property title, property type, amenities ...")
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
        }
        /// <summary>
        /// keyword to searchtextbox
        /// </summary>
        private void ListBoxHint_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@').First();
        }
        /// <summary>
        /// SearchTextbox reset
        /// </summary>
        private void SearchTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (SearchTextBox.Text== "Enter area name, attraction, property title, property type, amenities ...")
            {
                SearchTextBox.Text = "";
            }
        }
        /// <summary>
        /// SearchTextbox reset
        /// </summary>
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text=="")
            {
                SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
            }
        }
    }
}
