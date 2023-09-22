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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SearchListBox.Visible = false;
        }

        private void AdvancedSearchBtn_Click(object sender, EventArgs e)
        {
            AdvancedSearch advancedSearch = new AdvancedSearch();
            Visible = false;
            advancedSearch.ShowDialog();
            Visible = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchListBox.Visible = false;
            SearchListBox.Items.Clear();
            if (SearchTextBox.Text.Length >= 3)
            {
                Session3Entities entities = new Session3Entities();
                var searchResults = entities.Areas
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "Area" })
                .Concat(entities.Attractions
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "Attraction" }))
                .Concat(entities.Items
                .Where(t => t.Title.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Title, Type = "Listing" }))
                .Concat(entities.ItemTypes
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "ItemType" }))
                .Concat(entities.Amenities
                .Where(t => t.Name.Contains(SearchTextBox.Text))
                .Select(x => new { Name = x.Name, Type = "Amenities" }))
                .ToList();
                foreach (var result in searchResults)
                    SearchListBox.Items.Add($"{result.Name}      {result.Type}");
                SearchListBox.Visible=true;
            }
        }
        private void PromptWordLabel_Click(object sender, EventArgs e)
        {
            PromptWordLabel.SendToBack();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                PromptWordLabel.BringToFront();
                SearchListBox.Visible=false;
            }
        }
    }
}
