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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset1();
            reset2();
        }
        public void reset1()
        {
            ResultGroupBox1.Visible = false;
            ListBoxHint.Visible = false;
            SearchTextBox.Text = "";
            SimpleResultDataGridView.Rows.Clear();
            ResultLabel.Text = "";
            FromDateTimePicker.Value = DateTime.Now;
            FromDateTimePicker.MinDate = DateTime.Now;
        }
        public void reset2()
        {
            Session3Entities entities = new Session3Entities();
            AreaComboBox.Items.Clear();
            AttractionComboBox.Items.Clear();
            TitleComboBox.Items.Clear();
            TypeComboBox.Items.Clear();
            AmenityComboBox1.Items.Clear();
            AmenityComboBox2.Items.Clear();
            AmenityComboBox3.Items.Clear();
            AreaComboBox.Items.AddRange(entities.Areas.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AreaComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            AttractionComboBox.Items.AddRange(entities.Attractions.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AttractionComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DisplayMember = "Name";
            AttractionComboBox.ValueMember = "ID";
            TitleComboBox.Items.AddRange(entities.Items.Select(x => new { ID = x.ID, Name = x.Title }).ToArray());
            TitleComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DisplayMember = "Name";
            TitleComboBox.ValueMember = "ID";
            TypeComboBox.Items.AddRange(entities.ItemTypes.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            TypeComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            TypeComboBox.DisplayMember = "Name";
            TypeComboBox.ValueMember = "ID";
            AmenityComboBox1.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AmenityComboBox1.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AmenityComboBox1.DisplayMember = "Name";
            AmenityComboBox1.ValueMember = "ID";
            AmenityComboBox2.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AmenityComboBox2.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AmenityComboBox2.DisplayMember = "Name";
            AmenityComboBox2.ValueMember = "ID";
            AmenityComboBox3.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AmenityComboBox3.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AmenityComboBox3.DisplayMember = "Name";
            AmenityComboBox3.ValueMember = "ID";
            StartPrice.ResetText();
            MaxPrice.ResetText();
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
            NightNum.Value = NightNum.Minimum;
            PeopleNumber2.Value = PeopleNumber2.Minimum;
        }
        private void AdvanedFormBtn_Click(object sender, EventArgs e)
        {
            AdvancedGroupBox.Visible = true;
            ResultGroupBox2.Visible= false;  
            SimpleGroupBox.Visible = false;
            ResultGroupBox1.Visible = false;
            reset2();
        }

        private void SimpleSearchFormBtn_Click(object sender, EventArgs e)
        {
            AdvancedGroupBox.Visible = false;
            ResultGroupBox2.Visible = false;
            SimpleGroupBox.Visible = true;
            ResultGroupBox1.Visible = false;
            reset1();
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
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            HintLabel.Visible = true;
        }
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            using (Session3Entities entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text))
                    items = items.Where(x => x.Areas.Name == SearchTextBox.Text || x.Title == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attractions.Name == SearchTextBox.Text) || x.ItemTypes.Name == SearchTextBox.Text || x.ItemAmenities.Any(y => y.Amenities.Name == SearchTextBox.Text)).ToList();
                int nights = (int)NightsNumber.Value;
                int people = (int)PeopleNumber1.Value;
                DateTime from = FromDateTimePicker.Value;
                DateTime to = from.AddDays(nights);
                items = items.Where(x => x.ItemPrices.Any(y => y.Date >= from && y.Date <= to)
                    && x.Capacity >= people).OrderBy(x => x.Title).ToList();
                SimpleResultDataGridView.Rows.Clear();
                items.ForEach(x =>
                {
                    var score = x.ItemScores.Any() ? Math.Round(x.ItemScores.Average(y => y.Value), 2).ToString() : "";
                    var totalComplate = x.ItemPrices.Any() ?
                        x.ItemPrices.Count(y => y.BookingDetails.Any(z => !z.isRefund)) : 0;
                    var amount = x.ItemPrices.Any(y => y.Date >= from && y.Date < to)
                        ? x.ItemPrices.Where(y => y.Date >= from && y.Date <= to).Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    SimpleResultDataGridView.Rows.Add(x.Title, x.Areas.Name, score, totalComplate, amount);
                });
                ResultLabel.Text = $"Displaying {items.Count()} options";
                Text = "Seoul Stay - Search Results";
                ResultGroupBox1.Visible = true;
            }
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
        private void ListBoxHint_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@')[0];
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            reset2();
        }

        private void AdvancedSearchBtn_Click(object sender, EventArgs e)
        {
            List<ComboBox> amenityComboBoxList = new List<ComboBox>()
            {
                AmenityComboBox1,
                AmenityComboBox2,
                AmenityComboBox3
            };
            int onoptions = 4;
            Session3Entities entities = new Session3Entities();
            if (FromDate.Value > ToDate.Value)
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
            List<ComboBox> amenityComboBox = new List<ComboBox>() { AmenityComboBox1, AmenityComboBox2, AmenityComboBox3 };
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
                onoptions++;
            if (!string.IsNullOrEmpty(MaxPrice.Text))
                onoptions++;
            var amenityIdList = amenityComboBoxList.Where(t => t.Text != "").Select(t => (long)t.SelectedValue).Distinct().ToList();
            if (amenityIdList.Count() != 0)
            {
                onoptions += amenityIdList.Count();
                items = items.Where(t => t.ItemAmenities.Any(x => amenityIdList.Contains(x.ID))).ToList();
            }
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDate.Value && x.Date <= ToDate.Value) && t.Capacity >= PeopleNumber2.Value).ToList();
            AdvancedResultDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.0") : "";
                var totalconpate = item.ItemPrices.Any() ? item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                foreach (var x in item.ItemPrices.Where(x => x.Date > FromDate.Value && x.Date <= ToDate.Value).ToList())
                {
                    DateTime endDate = x.Date.AddDays((int)NightNum.Value);
                    var priceData = item.ItemPrices.Where(y => y.Date >= x.Date && y.Date < endDate).ToList();
                    var amount = priceData.Count() != 0 ? priceData.Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    if (!String.IsNullOrEmpty(StartPrice.Text) && priceData.Count() != 0 && StartPrice.Value > priceData.Sum(y => y.Price))
                        continue;
                    if (!String.IsNullOrEmpty(MaxPrice.Text) && priceData.Count() != 0 && MaxPrice.Value < priceData.Sum(y => y.Price))
                        continue;
                    AdvancedResultDataGridView.Rows.Add(item.Title, item.Areas.Name, score, totalconpate, amount, x.Date.ToString("dd/MM/yyyy"));
                }
            }
            ResultGroupBox2.Visible = true;
        }
    }
}
