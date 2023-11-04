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
        public void init()
        {
            Session3Entities entities = new Session3Entities();
            AreaComboBox.Items.Clear();
            AttractionComboBox.Items.Clear();
            TitleComboBox.Items.Clear();
            TypeComboBox.Items.Clear();
            AmenityComboBox1.Items.Clear();
            AmenityComboBox2.Items.Clear();
            AmenityComboBox3.Items.Clear();
            AreaComboBox.Items.AddRange(entities.Areas.Select(x => new {ID=x.ID,Name=x.Name}).ToArray());
            AreaComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            AttractionComboBox.Items.AddRange(entities.Attractions.Select(x => new {ID=x.ID,Name=x.Name}).ToArray());
            AttractionComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DisplayMember = "Name";
            AttractionComboBox.ValueMember = "ID";
            TitleComboBox.Items.AddRange(entities.Items.Select(x => new {ID=x.ID,Name=x.Title}).ToArray());
            TitleComboBox.Items.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DisplayMember = "Name";
            TitleComboBox.ValueMember = "ID";
            TypeComboBox.Items.AddRange(entities.ItemTypes.Select(x => new {ID=x.ID,Name=x.Name}).ToArray());
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
            FromDate.Value= DateTime.Now;
            ToDate.Value= DateTime.Now;
            NightNum.Value = NightNum.Minimum;
            PeopleNum.Value = PeopleNum.Minimum;
        }
        private void ClearBtn_Click(object sender, EventArgs e)=>init();
        private void SimpleSearchBtn_Click(object sender, EventArgs e)=>Close();
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<ComboBox> amenityComboBoxList = new List<ComboBox>()
            {
                AmenityComboBox1,
                AmenityComboBox2,
                AmenityComboBox3
            };
            int onoptions = 4;
            Session3Entities entities = new Session3Entities();
            if (FromDate.Value>ToDate.Value)
            {
                MessageBox.Show("From date can't over to date.");
                return;
            }
            if ((!string.IsNullOrEmpty(StartPrice.Text))&&(!string.IsNullOrEmpty(MaxPrice.Text)))
            {
                if (StartPrice.Value>MaxPrice.Value)
                {
                    MessageBox.Show("Starting oruce can't iver Maxinum price.");
                    return;
                }
            }
            List<ComboBox>amenityComboBox= new List<ComboBox>() {AmenityComboBox1,AmenityComboBox2,AmenityComboBox3};
            var items=entities.Items.ToList();
            if (!string.IsNullOrEmpty(AreaComboBox.Text))
            {
                items = items.Where(x=>x.AreaID==(long)AreaComboBox.SelectedIndex).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(AttractionComboBox.Text))
            {
                items = items.Where(x=>x.ItemAttractions.Any(y=>y.AttractionID==(long)AttractionComboBox.SelectedValue)).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(TitleComboBox.Text))
            {
                items = items.Where(x => x.ID == (long)TitleComboBox.SelectedValue).ToList();
                onoptions++;
            }
            if (!string.IsNullOrEmpty(TypeComboBox.Text))
            {
                items = items.Where(x=>x.ItemTypeID==(long)TypeComboBox.SelectedValue).ToList();
                onoptions++;
            }
            if(!string.IsNullOrEmpty(StartPrice.Text))
                onoptions++;
            if(!string.IsNullOrEmpty(MaxPrice.Text))
                onoptions++;
            var amenityIdList = amenityComboBoxList.Where(t => t.Text != "").Select(t => (long)t.SelectedValue).Distinct().ToList();
            if (amenityIdList.Count() != 0)
            {
                onoptions += amenityIdList.Count();
                items = items.Where(t => t.ItemAmenities.Any(x => amenityIdList.Contains(x.ID))).ToList();
            }
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDate.Value && x.Date <= ToDate.Value)&& t.Capacity >= PeopleNum.Value).ToList();
            ResultDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.0"):"";
                var totalconpate = item.ItemPrices.Any() ? item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)):0;
                foreach (var x in item.ItemPrices.Where(x => x.Date > FromDate.Value && x.Date <= ToDate.Value).ToList())
                {
                    DateTime endDate = x.Date.AddDays((int)NightNum.Value);
                    var priceData = item.ItemPrices.Where(y => y.Date >= x.Date && y.Date < endDate).ToList();
                    var amount = priceData.Count() != 0 ? priceData.Sum(y => y.Price).ToString() + "$" : "Price data not found.";
                    if (!String.IsNullOrEmpty(StartPrice.Text) && priceData.Count() != 0 && StartPrice.Value > priceData.Sum(y => y.Price))
                        continue;
                    if (!String.IsNullOrEmpty(MaxPrice.Text) && priceData.Count() != 0 && MaxPrice.Value < priceData.Sum(y => y.Price))
                        continue;
                    ResultDataGridView.Rows.Add(item.Title, item.Area.Name, score, totalconpate, amount, x.Date.ToString("dd/MM/yyyy"));
                }
            }
            ResultDataGridView.Visible = true;
            DisplayingLabel.Text = $"Displaying {onoptions} optionns from {ResultDataGridView.Rows.Count} properties";
        }
    }
}
