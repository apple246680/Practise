using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Session2
{
    public partial class AdvancedSearch : UserControl
    {
        /// <summary>
        /// InitializeComponent Advanced Search Form
        /// </summary>
        public AdvancedSearch()
        {
            InitializeComponent();
            var entities = new Session2Entities();
            StartPrice.ResetText();
            MaxPrice.ResetText();
            NightNum.Value = NightNum.Minimum;
            PeopleNum.Value = PeopleNum.Minimum;
            FromDate.MinDate = DateTime.Now.Date;
            FromDate.Value = DateTime.Now;
            var areadata = (entities.Areas.Select(x => new { x.ID, x.Name }).ToList());
            areadata.Insert(0, new { ID = (long)-1, Name = "" });
            AreaComboBox.DataSource = areadata;
            var typedata = (entities.ItemTypes.Select(x => new { x.ID, x.Name }).ToList());
            typedata.Insert(0, new { ID = (long)-1, Name = "" });
            TypeComboBox.DataSource = typedata;
            var amenities = (entities.Amenities.Select(x => new { x.ID, x.Name }).ToList());
            amenities.Insert(0, new { ID = (long)-1, Name = "" });
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
        /// <summary>
        /// Show Simple Search Form
        /// </summary>
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            Global.FromDate = FromDate.Value;
            Global.Night = (int)NightNum.Value;
            Global.People = (int)PeopleNum.Value;
            Global.ShowSimpleSearch();
        }
        /// <summary>
        /// Initialize ToDate
        /// </summary>
        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            ToDate.MinDate = FromDate.Value.Date;
        }
        /// <summary>
        /// Clear all filter item
        /// </summary>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AreaComboBox.SelectedIndex = 0;
            TitleComboBox.Text = "";
            FromDate.Value = FromDate.MinDate;
            ToDate.MinDate = FromDate.MinDate;
            ToDate.Value = FromDate.MinDate;
            NightNum.Value = 1;
            PeopleNum.Value = 1;
            StartPrice.ResetText();
            MaxPrice.ResetText();
            TypeComboBox.SelectedIndex = 0;
            ResultsPanel.Visible = false;
        }
        /// <summary>
        /// Select Area Add Title and Attraction
        /// </summary>
        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entities = new Session2Entities();
            if (AreaComboBox.Text == "")
            {
                TitleComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                TitleComboBox.DataSource = null;
                AttractionComboBox.DataSource = null;
                AttractionComboBox.DropDownStyle = ComboBoxStyle.DropDown;
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
            AttractionComboBox.DisplayMember = "Name";
            AttractionComboBox.ValueMember = "ID";
            AttractionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var titledata = item.Select(x => new { x.ID, Name = x.Title }).ToList();
            titledata.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DisplayMember = "Name";
            TitleComboBox.ValueMember = "ID";
            TitleComboBox.DataSource = titledata;
        }
        /// <summary>
        /// Using FIlter to Search Item data
        /// </summary>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var entities = new Session2Entities();
            if (FromDate.Value > ToDate.Value)
            {
                MessageBox.Show("From date can't over to date.");
                return;
            }
            if ((!string.IsNullOrWhiteSpace(StartPrice.Text)) && (!string.IsNullOrWhiteSpace(MaxPrice.Text)))
            {
                if (StartPrice.Value > MaxPrice.Value)
                {
                    MessageBox.Show("Starting oruce can't iver Maxinum price.");
                    return;
                }
            }
            var items = entities.Items.ToList();
            if (!string.IsNullOrWhiteSpace(AreaComboBox.Text))
            {
                var id = (long)AreaComboBox.SelectedValue;
                items = items.Where(x => x.AreaID == id).ToList();
            }
            if (!string.IsNullOrWhiteSpace(AttractionComboBox.Text))
            {
                items = items.Where(x => x.ItemAttractions.Any(y => y.AttractionID == (long)AttractionComboBox.SelectedValue)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(TitleComboBox.Text))
            {
                if (TitleComboBox.DropDownStyle == ComboBoxStyle.DropDown)
                {
                    items = items.Where(x => x.Title == TitleComboBox.Text).ToList();
                }
                else
                {
                    items = items.Where(x => x.ID == (long)TitleComboBox.SelectedValue).ToList();
                }
            }
            if (!string.IsNullOrWhiteSpace(TypeComboBox.Text))
            {
                items = items.Where(x => x.ItemTypeID == (long)TypeComboBox.SelectedValue).ToList();
            }
            var From = FromDate.Value;
            items = items.Where(t => t.ItemPrices.Any(x => x.Date >= FromDate.Value && x.Date <= ToDate.Value) && t.Capacity >= PeopleNum.Value).ToList();
            foreach (DataGridViewColumn Column in ResultsDataGridView.Columns)
            {
                Column.SortMode = DataGridViewColumnSortMode.NotSortable;
                Column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            ResultsDataGridView.Rows.Clear();
            foreach (var item in items.OrderBy(x=>x.Title))
            {
                var score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.0") : "";
                var totalconpate = item.ItemPrices.Any() ? item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund)) : 0;
                foreach (var x in item.ItemPrices.Where(x => x.Date >= FromDate.Value && x.Date <= ToDate.Value).ToList().OrderBy(x=>x.Date))
                {
                    decimal Amount = 0;
                    for (var i = 0; i < NightNum.Value; i++)
                    {
                        if (x.Date == x.Date.AddDays(i).Date)
                        {
                            Amount += x.Price;
                        }
                        else
                        {
                            Amount += item.ItemPrices.Where(y => y.Date <= x.Date.AddDays(i).Date).OrderBy(y => y.Date).Last().Price;
                        }
                    }
                    if ((!String.IsNullOrWhiteSpace(StartPrice.Text) && StartPrice.Value > Amount) || (!String.IsNullOrWhiteSpace(MaxPrice.Text) && MaxPrice.Value < Amount))
                    {
                        continue;
                    }
                    ResultsDataGridView.Rows.Add(item.Title, item.Area.Name, score == "" ? "No found score data" : score, totalconpate, Amount + "$", x.Date.ToString("dd/MM/yyyy"));
                }
            }
            CountLabel.Text = $"Displaying {ResultsDataGridView.Rows.Count} options from {ResultsDataGridView.Rows.Cast<DataGridViewRow>().GroupBy(x => x.Cells[0].Value.ToString()).Count()} properties";
            ResultsPanel.Visible = true;
        }
    }
}
