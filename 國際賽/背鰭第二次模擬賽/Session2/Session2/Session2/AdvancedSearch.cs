using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class AdvancedSearch : UserControl
    {
        public AdvancedSearch()
        {
            InitializeComponent();
            init();
            if (Global.FromDate.HasValue)
            {
                FromDate.Value = Global.FromDate.Value;
            }
            if (Global.Night.HasValue)
            {
                NightNum.Value = Global.Night.Value;
            }
            if (Global.People.HasValue)
            {
                PeopleNum.Value = Global.People.Value;
            }
            ToDate.MinDate = FromDate.Value;
            ToDate.Value = FromDate.Value;
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
            var entities = new Session2Entities();
            StartPrice.ResetText();
            MaxPrice.ResetText();
            NightNum.Value = NightNum.Minimum;
            PeopleNum.Value = PeopleNum.Minimum;
            FromDate.MinDate = DateTime.Now.Date;
            FromDate.Value = DateTime.Now;
            ToDate.MinDate = FromDate.Value;
            ToDate.Value = FromDate.Value;
            var areadata = (entities.Areas.Select(x => new { x.ID, x.Name }).ToList());
            areadata.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DataSource = areadata;
            var Attractiondata = (entities.Attractions.Select(x => new { x.ID, x.Name }).ToList());
            Attractiondata.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DataSource = Attractiondata;
            var typedata = (entities.ItemTypes.Select(x => new { x.ID, x.Name }).ToList());
            typedata.Insert(0, new { ID = (long)-1, Name = "" });
            TypeComboBox.DataSource = typedata;
            var amenities = (entities.Amenities.Select(x => new { x.ID, x.Name }).ToList());
            amenities.Insert(0, new { ID = (long)-1, Name = "" });
            AmenityComboBox1.DataSource = new List<object>(amenities);
            amenityComboBoxList.Skip(1).ToList().ForEach(x => x.Enabled = false);
        }
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            Global.FromDate = FromDate.Value;
            Global.Night = (int)NightNum.Value;
            Global.People = (int)PeopleNum.Value;
            Global.ShowSimpleSearch();
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            ToDate.MinDate = FromDate.Value.Date;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void AmenityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tag = int.Parse(((ComboBox)(sender)).Tag.ToString());
            amenityComboBoxList.ForEach(x =>
            {
                x.Enabled = int.Parse(x.Tag.ToString()) <= tag + 1;
            });
            if (AmenityComboBox1.Text == "")
            {
                AmenityComboBox2.Text = "";
                AmenityComboBox2.Enabled = false;
            }
            if (AmenityComboBox2.Text == "")
            {
                AmenityComboBox3.Text = "";
                AmenityComboBox3.Enabled = false;
            }
        }
        long att = 0;
        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entities = new Session2Entities();
            if (AreaComboBox.Text == "" && AttractionComboBox.Text == "")
            {
                TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                TitleComboBox.DataSource = null;
                var Attractiondata = (entities.Attractions.Select(x => new { x.ID, x.Name }).ToList());
                Attractiondata.Insert(0, new { ID = (long)-1, Name = "" });
                AttractionComboBox.DataSource = Attractiondata;
                return;
            }
            var item = entities.Items.ToList();
            if (AreaComboBox.Text != "")
            {
                item = item.Where(x => x.AreaID == (long)AreaComboBox.SelectedValue).ToList();
            }
            var AttractionData = item.SelectMany(x => x.ItemAttractions).Select(x => new { x.Attraction.ID, x.Attraction.Name }).Distinct().ToList();
            AttractionData.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DataSource = AttractionData;
            TitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var titledata = item.Select(x => new { x.ID, Name = x.Title }).ToList();
            titledata.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DisplayMember = "Name";
            TitleComboBox.ValueMember = "ID";
            TitleComboBox.DataSource = titledata;
            var match = AttractionData.SingleOrDefault(x => x.ID == att && att != 0);
            if (match != null)
            {
                AttractionComboBox.SelectedValue = att;
            }
        }

        private void AttractionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entities = new Session2Entities();
            if (AreaComboBox.Text == "" && AttractionComboBox.Text == "")
            {
                TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                TitleComboBox.DataSource = null;
                var Attractiondata = (entities.Attractions.Select(x => new { x.ID, x.Name }).ToList());
                Attractiondata.Insert(0, new { ID = (long)-1, Name = "" });
                AttractionComboBox.DataSource = Attractiondata;
            }
            if (AttractionComboBox.Text == "")
            {
                AreaComboBox_SelectedIndexChanged(null, null);
                return;
            }
            var item = entities.Items.ToList();
            if (AttractionComboBox.Text != "")
            {
                var data = entities.Attractions.Find((long)AttractionComboBox.SelectedValue).ItemAttractions.Select(x => x.Item).ToList();
                if (AreaComboBox.Text != "")
                {
                    data = data.Where(x => x.Area.ID == (long)AreaComboBox.SelectedValue).ToList();
                }
                TitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                var titledata = data.Select(x => new { x.ID, Name = x.Title }).ToList();
                titledata.Insert(0, new { ID = (long)-1, Name = "" });
                TitleComboBox.DisplayMember = "Name";
                TitleComboBox.ValueMember = "ID";
                TitleComboBox.DataSource = titledata;
            }
            att = (long)((ComboBox)(sender)).SelectedValue;
        }
        private void AmenityComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            var amenitiesss = new List<Amenity>();
            amenitiesss = new Session2Entities().Amenities.ToList();
            if (AmenityComboBox1.Text == "")
            {
                var amenities = (amenitiesss.Select(x => new { x.ID, x.Name }).ToList());
                amenities.Insert(0, new { ID = (long)-1, Name = "" });
                AmenityComboBox1.DataSource = new List<object>(amenities);
                return;
            }
            List<string> bb = new List<string>();
            foreach (var cc in amenityComboBoxList)
            {
                bb.Add(cc.Text);
            }
            bb = bb.Where(x => x != "").ToList();
            var result = amenitiesss.Select(x => x.Name).Except(bb).ToList();
            var dd = new List<Amenity>();
            foreach (var item in result)
            {
                dd.Add(amenitiesss.First(x => x.Name == item));
            }
            var amenitiess = (dd.Select(x => new { x.ID, x.Name }).ToList());
            amenitiess.Insert(0, new { ID = (long)-1, Name = "" });
            ((ComboBox)(sender)).DataSource = new List<object>(amenitiess);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var entities = new Session2Entities();
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
            var items = entities.Items.ToList();
            if (!string.IsNullOrEmpty(AreaComboBox.Text))
            {
                var id = (long)AreaComboBox.SelectedValue;
                items = items.Where(x => x.AreaID == id).ToList();
            }
            if (!string.IsNullOrEmpty(AttractionComboBox.Text))
            {
                items = items.Where(x => x.ItemAttractions.Any(y => y.AttractionID == (long)AttractionComboBox.SelectedValue)).ToList();
            }
            if (!string.IsNullOrEmpty(TitleComboBox.Text))
            {
                items = items.Where(x => x.ID == (long)TitleComboBox.SelectedValue).ToList();
            }
            if (!string.IsNullOrEmpty(TypeComboBox.Text))
            {
                items = items.Where(x => x.ItemTypeID == (long)TypeComboBox.SelectedValue).ToList();
            }
            var amenityIdList = amenityComboBoxList.Where(t => t.Text != "").Select(t => (long)t.SelectedValue).Distinct().ToList();
            if (amenityIdList.Count() != 0)
            {
                items = items.Where(t => t.ItemAmenities.Any(x => amenityIdList.Contains(x.ID))).ToList();
            }
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDate.Value && x.Date <= ToDate.Value) && t.Capacity >= PeopleNum.Value).ToList();
            ResultsDataGridView.Rows.Clear();
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
            CountLabel.Text = $"Displaying {items.Count()} options from {items.GroupBy(x=>x.Title).Count()} properties";
            ResultsPanel.Visible = true;
        }
    }
}
