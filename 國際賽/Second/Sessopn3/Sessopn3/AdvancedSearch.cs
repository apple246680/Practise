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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
            init();
        }
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void init()
        {
            Session3Entities entities = new Session3Entities();
            AreaComboBox.Items.Clear();
            AttractionComboBox.Items.Clear();
            PropertyTitleComboBox.Items.Clear();
            PropertyTypeNum.Items.Clear();
            Amenity1ComboBox.Items.Clear();
            Amenity2ComboBox.Items.Clear();
            Amenity3ComboBox.Items.Clear();
            AreaComboBox.Items.AddRange(entities.Areas.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AreaComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            AttractionComboBox.Items.AddRange(entities.Attractions.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AttractionComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DisplayMember = "Name";
            AttractionComboBox.ValueMember = "ID";
            PropertyTitleComboBox.Items.AddRange(entities.Items.Select(x => new { ID = x.ID, Name = x.Title }).ToArray());
            PropertyTitleComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            PropertyTitleComboBox.DisplayMember = "Name";
            PropertyTitleComboBox.ValueMember = "ID";
            PropertyTypeNum.Items.AddRange(entities.ItemTypes.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            PropertyTypeNum.Items.Insert(0, new { ID = (long)-1, Name = "" });
            PropertyTypeNum.DisplayMember = "Name";
            PropertyTypeNum.ValueMember = "ID";
            Amenity1ComboBox.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            Amenity1ComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            Amenity1ComboBox.DisplayMember = "Name";
            Amenity1ComboBox.ValueMember = "ID";
            Amenity2ComboBox.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            Amenity2ComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            Amenity2ComboBox.DisplayMember = "Name";
            Amenity2ComboBox.ValueMember = "ID";
            Amenity3ComboBox.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            Amenity3ComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            Amenity3ComboBox.DisplayMember = "Name";
            Amenity3ComboBox.ValueMember = "ID";
            StartingPriceNum.ResetText();
            MaximumPriceNum.ResetText();
            FromDateTimePicker.Value = DateTime.Now;
            ToDateTimePicker.Value = DateTime.Now;
            NightNum.Value = NightNum.Minimum;
            PeopleNum.Value = PeopleNum.Minimum;
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<ComboBox> amenityComboBoxList = new List<ComboBox>()
            {
                Amenity1ComboBox,
                Amenity2ComboBox,
                Amenity3ComboBox
            };
            int onoptions = 4;
            Session3Entities entities = new Session3Entities();
            if (FromDateTimePicker.Value > ToDateTimePicker.Value)
            {
                MessageBox.Show("From date can't over to date.");
                return;
            }
            if ((!string.IsNullOrEmpty(StartingPriceNum.Text)) && (!string.IsNullOrEmpty(MaximumPriceNum.Text)))
            {
                if (StartingPriceNum.Value > MaximumPriceNum.Value)
                {
                    MessageBox.Show("Starting oruce can't iver Maxinum price.");
                    return;
                }
            }
            List<ComboBox> amenityComboBox = new List<ComboBox>() { Amenity1ComboBox, Amenity2ComboBox, Amenity3ComboBox };
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
            if (!string.IsNullOrEmpty(PropertyTitleComboBox.Text))
            {
                items = items.Where(x => x.ID == (long)PropertyTitleComboBox.SelectedValue).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(PropertyTitleComboBox.Text))
            {
                items = items.Where(x => x.ItemTypeID == (long)PropertyTitleComboBox.SelectedValue).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(StartingPriceNum.Text))
                onoptions++;
            if (!string.IsNullOrEmpty(MaximumPriceNum.Text))
                onoptions++;
            var amenityIdList = amenityComboBoxList.Where(t => t.Text != "").Select(t => (long)t.SelectedValue).Distinct().ToList();
            if (amenityIdList.Count() != 0)
            {
                onoptions += amenityIdList.Count();
                items = items.Where(t => t.ItemAmenities.Any(x => amenityIdList.Contains(x.ID))).ToList();
            }
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDateTimePicker.Value && x.Date <= ToDateTimePicker.Value) && t.Capacity >= PeopleNum.Value).ToList();
            ResultsDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.0") : "";
                var totalconpate = item.ItemPrices.Any() ? item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                foreach (var x in item.ItemPrices.Where(x => x.Date > FromDateTimePicker.Value && x.Date <= ToDateTimePicker.Value).ToList())
                {
                    DateTime endDate = x.Date.AddDays((int)NightNum.Value);
                    var priceData = item.ItemPrices.Where(y => y.Date >= x.Date && y.Date < endDate).ToList();
                    var amount = priceData.Count() != 0 ? priceData.Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    if (!String.IsNullOrEmpty(StartingPriceNum.Text) && priceData.Count() != 0 && StartingPriceNum.Value > priceData.Sum(y => y.Price))
                        continue;
                    if (!String.IsNullOrEmpty(MaximumPriceNum.Text) && priceData.Count() != 0 && MaximumPriceNum.Value < priceData.Sum(y => y.Price))
                        continue;
                    ResultsDataGridView.Rows.Add(item.Title, item.Areas.Name, score, totalconpate, amount, x.Date.ToString("dd/MM/yyyy"));
                }
            }
            CountLabel.Text = $"Displaying {onoptions} optionns from {ResultsDataGridView.Rows.Count} properties";
        }
        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            init();
        }
    }
}
