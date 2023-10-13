using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Sesosin3
{
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
            init();
        }
        List<ComboBox> amenityComboBoxList;
        public void init()
        {
            amenityComboBoxList = new List<ComboBox>() { AmenityComboBox1, AmenityComboBox2, AmenityComboBox3 };
            Session3Entities entities = new Session3Entities();
            ResultDataGridView.Visible = false;
            ClearComboBoxes(AreaComboBox, AttractionComboBox, TitleComboBox, TypeComboBox, AmenityComboBox1, AmenityComboBox2, AmenityComboBox3);
            var nulldata = new { ID = (long)-1, Name = "" };
            ComboBoxAddData(AreaComboBox, entities.Areas.ToArray());
            ComboBoxAddData(AttractionComboBox, entities.Attractions.ToArray());
            ComboBoxAddData(TitleComboBox, entities.Items.Select(x => new { x.ID, Name = x.Title }).ToArray());
            ComboBoxAddData(TypeComboBox, entities.ItemTypes.ToArray());
            foreach (var item in amenityComboBoxList)
                ComboBoxAddData(item, entities.Amenities.ToArray());
            StartPrice.ResetText();
            MaxPrice.ResetText();
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
            NightNum.Value = NightNum.Minimum;
            PeopleNum.Value = PeopleNum.Minimum;
        }
        public void ComboBoxAddData(ComboBox comboBox,object[] a)
        {
            comboBox.Items.AddRange(a);
            comboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
        }
        private void ClearComboBoxes(params ComboBox[] comboBoxes) => comboBoxes.ToList().ForEach(x => { x.Items.Clear(); });
        private void ClearBtn_Click(object sender, EventArgs e) => init();
        private void SimpleSearchBtn_Click(object sender, EventArgs e) => Close();
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int onoptions = 4;
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
            var items = new Session3Entities().Items.ToList();
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
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDate.Value && x.Date <= ToDate.Value) && t.Capacity >= PeopleNum.Value).ToList();
            ResultDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.0") : "";
                var totalconpate = item.ItemPrices.Any() ? item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                foreach (var x in item.ItemPrices.Where(x => x.Date > FromDate.Value && x.Date <= ToDate.Value).ToList())
                {
                    var priceData = item.ItemPrices.Where(y => y.Date >= x.Date && y.Date < x.Date.AddDays((int)NightNum.Value)).ToList();
                    var amount = priceData.Count() != 0 ? priceData.Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    if ((!String.IsNullOrEmpty(StartPrice.Text) && priceData.Count() != 0 && StartPrice.Value > priceData.Sum(y => y.Price))||
                        (!String.IsNullOrEmpty(MaxPrice.Text) && priceData.Count() != 0 && MaxPrice.Value < priceData.Sum(y => y.Price)))
                        continue;
                    ResultDataGridView.Rows.Add(item.Title, item.Area.Name, score, totalconpate, amount, x.Date.ToString("dd/MM/yyyy"));
                }
            }
            ResultDataGridView.Visible = true;
        }
    }
}