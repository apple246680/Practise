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
            SimpleSearchBtn_Click(null, null);
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
            var titledata = (entities.Items.Select(x => new { x.ID, Name = x.Title }).ToList());
            titledata.Insert(0, new { ID = (long)-1, Name = "" });
            TitleComboBox.DataSource = titledata;
            var typedata = (entities.ItemTypes.Select(x => new { x.ID, x.Name }).ToList());
            typedata.Insert(0, new { ID = (long)-1, Name = "" });
            TypeComboBox.DataSource = typedata;
            var amenities = (entities.Amenities.Select(x => new { x.ID, x.Name }).ToList());
            amenities.Insert(0, new { ID = (long)-1, Name = "" });
            AmenityComboBox1.DataSource = new List<object>(amenities);
            AmenityComboBox2.DataSource = new List<object>(amenities);
            AmenityComboBox3.DataSource = new List<object>(amenities);
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
            TopPanel.Visible = true;
            DownPanel.Visible = true;
            ToDatePanel.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 295);
            Size = new Size(1202, 602);
        }
        /// <summary>
        /// open simple search page
        /// </summary>
        private void SimpleSearchBtn_Click(object sender, EventArgs e)
        {
            TopPanel.Visible = false;
            ListBoxHint.Visible = false;
            DownPanel.Visible = false;
            ToDatePanel.Visible = false;
            SearchTextBox.Visible = true;
            SimpleSearchBtn.Visible = true;
            AdvanedFormBtn.Visible = true;
            SimpleAdvancedGroupBox.Size = new Size(1169, 170);
            Size = new Size(1202, 450);
        }
    }
}
