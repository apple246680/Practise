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
        /// InitializeComponent simple search and advanced search
        /// </summary>
        public Main()
        {
            InitializeComponent();
            SimpleSearchFormBtn_Click(null, null);
            init();
        }
        List<ComboBox> amenityComboBoxList;
        /// <summary>
        /// init all object
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
        }
        /// <summary>
        /// open advanced search page
        /// </summary>
        private void AdvanedFormBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.Visible = false;
            ListBoxHint.Visible = false;
            SimpleSearchBtn.Visible = false;
            AdvanedFormBtn.Visible = false;
            SearchResultsGroupBox.Visible = false;
            amenityComboBoxList.Skip(1).ToList().ForEach(x =>x.Enabled=false);
            ResultsDataGridView.Columns[5].Visible = true;
            TopPanel.Visible = true;
            ToDatePanel.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 295);
            Size = new Size(1202, 602);
            ClearBtn_Click(null,null);
            DownPanel.Visible = true;
            FromDateTimePicker_ValueChanged(null,null);
        }

        /// <summary>
        /// open simple search page
        /// </summary>
        private void SimpleSearchFormBtn_Click(object sender, EventArgs e)
        {
            TopPanel.Visible = false;
            ListBoxHint.Visible = false;
            DownPanel.Visible = false;
            ToDatePanel.Visible = false;
            SearchResultsGroupBox.Visible = false;
            ResultsDataGridView.Columns[5].Visible = false;
            SearchTextBox.Visible = true;
            SimpleSearchBtn.Visible = true;
            AdvanedFormBtn.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 170);
            Size = new Size(1202, 500);
        }
        /// <summary>
        /// searchtextbox hint
        /// </summary>
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter area name, attraction, property title, property type, amenities ...")
            {
                SearchTextBox.Text = "";
            }
        }
        /// <summary>
        /// searchtextbox hint
        /// </summary>
        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
            }
        }
        /// <summary>
        /// using like keyword to search item
        /// </summary>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter area name, attraction, property title, property type, amenities ...")
            {
                return;
            }
            ListBoxHint.Items.Clear();
            ListBoxHint.Visible = false;
            if (SearchTextBox.Text.Length < 3)
            {
                return;
            }
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
        /// <summary>
        /// using filter to simple search
        /// </summary>
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            Text = "Seoul Stay - Search Results";
            using (var entities = new Session3Entities())
            {
                var items = entities.Items.ToList();
                var nights = (int)NightsNumber.Value;
                var people = (int)PeopleNumber.Value;
                var from = FromDateTimePicker.Value;
                var to = from.AddDays(nights);
                items = items.Where(x => x.ItemPrices.Any(y => y.Date >= from && y.Date <= to)
                    && x.Capacity >= people).OrderBy(x => x.Title).ToList();
                if (!String.IsNullOrEmpty(SearchTextBox.Text) && SearchTextBox.Text != "Enter area name, attraction, property title, property type, amenities ...")
                    items = items.Where(x => x.Areas.Name.Trim() == SearchTextBox.Text || x.Title.Trim() == SearchTextBox.Text || x.ItemAttractions.Any(y => y.Attractions.Name.Trim() == SearchTextBox.Text) || x.ItemTypes.Name.Trim() == SearchTextBox.Text || x.ItemAmenities.Any(y => y.Amenities.Name.Trim() == SearchTextBox.Text)).ToList();
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
        // <summary>
        /// ListBoxHint have item can click to keyword to search textbox
        /// </summary>
        private void ListBoxHint_MouseClick(object sender, MouseEventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchTextBox.Text = ListBoxHint.Text.Replace("      ", "@").Split('@').First();
        }
        /// <summary>
        /// From and To DateTime Reset
        /// </summary>
        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FromDateTimePicker.Value.ToString("yyyy/MM/dd")!=DateTime.Now.ToString("yyyy/MM/dd"))
            {
                ToDateTimePicker.MinDate=FromDateTimePicker.Value;
            }
            else
            {
                ToDateTimePicker.MinDate=DateTime.Now;
                ToDateTimePicker.Value = DateTime.Now;
            }
        }
        /// <summary>
        /// Clear Advanced search all item data
        /// </summary>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AreaComboBox.SelectedIndex = 0;
            AttractionComboBox.SelectedIndex = 0;
            TitleComboBox.DropDownStyle=ComboBoxStyle.DropDown;
            ToDateTimePicker.MinDate = DateTime.Now;
            ToDateTimePicker.Value = DateTime.Now;
            if (DownPanel.Visible)
            {
                FromDateTimePicker.MinDate = DateTime.Now;
                FromDateTimePicker.Value = DateTime.Now;
            }
            NightsNumber.Value =1;
            PeopleNumber.Value = 1;
            TypeComboBox.SelectedIndex = 0;
            StartPrice.ResetText();
            MaxPrice.ResetText();
            SearchResultsGroupBox.Visible=false;    
        }
        /// <summary>
        /// All AmenityComboBox No duplicate data can appear
        /// </summary>
        private void AmenityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tag = int.Parse(((ComboBox)(sender)).Tag.ToString());
            amenityComboBoxList.ForEach(x =>
            {
                x.Enabled = int.Parse(x.Tag.ToString()) <= tag+1;
            });
            if (AmenityComboBox1.Text=="")
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
        /// <summary>
        /// using advanced search to filter to search data
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
        /// The content of Area ComboBox will be changed according to the data filtered by Area.
        /// </summary>
        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entities = new Session3Entities();
            if (AreaComboBox.Text==""&&AttractionComboBox.Text=="")
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
            var AttractionData=item.SelectMany(x=>x.ItemAttractions).Select(x => new { x.Attractions.ID, x.Attractions.Name }).Distinct().ToList();
            AttractionData.Insert(0, new { ID = (long)-1, Name = "" });
            AttractionComboBox.DataSource = AttractionData;
            TitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var titledata = item.Select(x => new { x.ID, Name = x.Title }).ToList();
            titledata.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DisplayMember = "Name";
            TitleComboBox.ValueMember = "ID";
            TitleComboBox.DataSource = titledata;
            var match = AttractionData.SingleOrDefault(x=>x.ID==att&&att!=0);
            if (match!=null)
            {
                AttractionComboBox.SelectedValue = att;
            }
        }
        long att = 0;
        /// <summary>
        /// The content of Attraction ComboBox will be changed according to the data filtered by Attraction.
        /// </summary>
        private void AttractionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entities = new Session3Entities();
            if (AreaComboBox.Text == "" && AttractionComboBox.Text == "")
            {
                TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                TitleComboBox.DataSource = null;
                var Attractiondata = (entities.Attractions.Select(x => new { x.ID, x.Name }).ToList());
                Attractiondata.Insert(0, new { ID = (long)-1, Name = "" });
                AttractionComboBox.DataSource = Attractiondata;
            }
            if (AttractionComboBox.Text=="")
            {
                AreaComboBox_SelectedIndexChanged(null, null);
                return;
            }
            var item = entities.Items.ToList();
            if (AttractionComboBox.Text != "")
            {
                var data = entities.Attractions.Find((long)AttractionComboBox.SelectedValue).ItemAttractions.Select(x=>x.Items).ToList();
                if (AreaComboBox.Text!="")
                {
                    data = data.Where(x=>x.Areas.ID== (long)AreaComboBox.SelectedValue).ToList();
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
        /// <summary>
        /// All AmenityComboBox No duplicate data can appear
        /// </summary>
        private void AmenityComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            List<Amenities> aa = new List<Amenities>();
            aa = new Session3Entities().Amenities.ToList();
            if (AmenityComboBox1.Text == "")
            {
                var amenities = (aa.Select(x => new { x.ID, x.Name }).ToList());
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
            var result = aa.Select(x => x.Name).Except(bb).ToList();
            List<Amenities> dd = new List<Amenities>();
            foreach (var item in result)
            {
                dd.Add(aa.First(x => x.Name == item));
            }
            var amenitiess = (dd.Select(x => new { x.ID, x.Name }).ToList());
            amenitiess.Insert(0, new { ID = (long)-1, Name = "" });
            ((ComboBox)(sender)).DataSource = new List<object>(amenitiess);
        }
    }
}
