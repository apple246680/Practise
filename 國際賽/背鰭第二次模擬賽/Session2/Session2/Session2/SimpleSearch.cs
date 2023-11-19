using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class SimpleSearch : UserControl
    {
        public SimpleSearch()
        {
            InitializeComponent();
            Global.SimpleSearchDataGridView = ResultDataGridView;
            FromDateTimePicker.MinDate = DateTime.Now.Date;
            FromDateTimePicker.Value = DateTime.Now.Date;
            if (Global.FromDate.HasValue)
            {
                FromDateTimePicker.Value = Global.FromDate.Value;
            }
            if (Global.Night.HasValue)
            {
                NightsNumber.Value = Global.Night.Value;
            }
            if (Global.People.HasValue)
            {
                PeopleNumber.Value = Global.People.Value;
            }
        }

        private void AdvanedBtn_Click(object sender, EventArgs e)
        {
            Global.FromDate = FromDateTimePicker.Value;
            Global.Night = (int)NightsNumber.Value;
            Global.People = (int)PeopleNumber.Value;
            Global.ShowAdvancedSearch();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Enter area name, attraction, property title, property type, amenities ...";
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "Enter area name, attraction, property title, property type, amenities ...")
            {
                SearchTextBox.Text = "";
            }
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ListBoxHint.Visible = false;
            SearchFilterPanel.Visible = true;
            if (SearchTextBox.Text != "Enter area name, attraction, property title, property type, amenities ..." && SearchTextBox.Text.Length >= 3)
            {
                var entities = new Session2Entities();
                var SearchText = SearchTextBox.Text;
                if (entities.Areas.Any(x => x.Name == SearchText) || entities.Items.Any(x => x.Title == SearchText) || entities.ItemTypes.Any(x => x.Name == SearchText) || entities.Amenities.Any(x => x.Name == SearchText))
                {
                    return;
                }
                SearchText = SearchText.ToLower();
                var area = entities.Areas.ToList().Where(x => x.Name.ToLower().Contains(SearchText)).Select(x => new { ID = x.Name, Name = $"{x.Name}\tArea" }).ToList();
                var attraction = entities.Attractions.ToList().Where(x => x.Name.Contains(SearchText)).Select(x => new { ID = x.Name, Name = $"{x.Name}\tAttractions" }).ToList();
                area.AddRange(attraction);
                var Title = entities.Items.ToList().Where(x => x.Title.ToLower().Contains(SearchText)).Select(x => new { ID = x.Title, Name = $"{x.Title}\tListing" }).ToList();
                area.AddRange(Title);
                var Type = entities.ItemTypes.ToList().Where(x => x.Name.ToLower().Contains(SearchText)).Select(x => new { ID = x.Name, Name = $"{x.Name}\tType" }).ToList();
                area.AddRange(Type);
                var amenities = entities.Amenities.ToList().Where(x => x.Name.ToLower().Contains(SearchText)).Select(x => new { ID = x.Name, Name = $"{x.Name}\tAmenities" }).ToList();
                area.AddRange(amenities);
                SearchFilterPanel.Visible = false;
                ListBoxHint.DataSource = area;
                ListBoxHint.SelectedIndex = -1;
                ListBoxHint.Visible = true;
            }
        }

        private void ListBoxHint_Click(object sender, EventArgs e)
        {
            if (ListBoxHint.SelectedIndex == -1)
            {
                return;
            }
            ListBoxHint.Visible = false;
            SearchFilterPanel.Visible = true;
            SearchTextBox.Text = (string)ListBoxHint.SelectedValue;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var entities = new Session2Entities();
            var Night = (int)NightsNumber.Value;
            var People = (int)PeopleNumber.Value;
            var From = FromDateTimePicker.Value;
            var SearchText = SearchTextBox.Text;
            var To = From.AddDays(Night - 1);
            var items = entities.Items.Where(x => x.ItemPrices.Any(y => /*y.Date >= From &&*/ y.Date <= To) && x.Capacity >= People).ToList();
            if (!string.IsNullOrWhiteSpace(SearchTextBox.Text) && SearchTextBox.Text != "Enter area name, attraction, property title, property type, amenities ...")
            {
                items = items.Where(x => x.Area.Name.Trim() == SearchText || x.Title == SearchText || x.ItemType.Name == SearchText || x.ItemAmenities.Any(y => y.Amenity.Name == SearchText)).ToList();
            }
            foreach (DataGridViewColumn Column in ResultDataGridView.Columns)
            {
                Column.SortMode = DataGridViewColumnSortMode.NotSortable;
                Column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            ResultDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                var Score = item.ItemScores.Any() ? item.ItemScores.Average(x => x.Value).ToString("0.00") : "";
                var TotalComplate = item.ItemPrices.Count(x => x.BookingDetails.Any(y => !y.isRefund));
                decimal Amount = 0;
                for (int i = 0; i < NightsNumber.Value; i++)
                {
                    if (item.ItemPrices.Any(x => x.Date == From.AddDays(i).Date))
                    {
                        Amount += item.ItemPrices.Where(x => x.Date == From.AddDays(i).Date).Sum(x => x.Price);
                    }
                    else
                    {
                        Amount+=item.ItemPrices.Where(x => x.Date < From.AddDays(i).Date).OrderBy(x => x.Date).Last().Price;
                    }
                }
                ResultDataGridView.Rows.Add(item.Title, item.Area.Name, Score, TotalComplate, Amount+"$");
            }
            CountLabel.Text = $"Displaying {ResultDataGridView.RowCount} options";
            ResultsPanel.Visible = true;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            StringBuilder csvContent = new StringBuilder();
            for (int i = 0; i < ResultDataGridView.Columns.Count; i++)
            {
                csvContent.Append(ResultDataGridView.Columns[i].HeaderText);
                if (i < ResultDataGridView.Columns.Count - 1)
                    csvContent.Append("|");
            }
            csvContent.AppendLine();
            foreach (DataGridViewRow row in ResultDataGridView.Rows)
            {
                for (int i = 0; i < ResultDataGridView.Columns.Count; i++)
                {
                    if (row.Cells[i].Value != null)
                        csvContent.Append(row.Cells[i].Value.ToString());
                    else
                        csvContent.Append("");

                    if (i < ResultDataGridView.Columns.Count - 1)
                        csvContent.Append("|");
                }
                csvContent.AppendLine();
            }
            File.WriteAllText(@"./Report.txt", csvContent.ToString());
            var pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.DefaultPageSettings.PaperSize = new PaperSize("B4",10,14);
            pd.PrinterSettings.PrintToFile = true;
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings.PrintToFile = true;
                pd.PrinterSettings.PrintFileName = saveFileDialog.FileName;
                pd.PrintPage += new PrintPageEventHandler(PrintPage);
                pd.Print();
            }
        }
        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            var text = File.ReadAllLines($@"{Application.StartupPath}/Report.txt");
            ev.Graphics.DrawString(text[0], new Font("Gotham Bold", 10), Brushes.Black, 10, 25);
            int y = 40;
            foreach (var item in text.Skip(1))
            {
                ev.Graphics.DrawString(item, new Font("Gotham Thin", 10), Brushes.Black, 10, y);
                y += 15;
            }
        }
    }
}
