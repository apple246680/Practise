using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            AreaComboBox.Items.AddRange(entities.Areas.Select(x => new {ID=x.ID,Name=x.Name}).ToArray());
            AreaComboBox.DisplayMember = "Name";
            AreaComboBox.ValueMember = "ID";
            AttractionComboBox.Items.AddRange(entities.Attractions.Select(x => new {ID=x.ID,Name=x.Name}).ToArray());
            AttractionComboBox.DisplayMember = "Name";
            AttractionComboBox.ValueMember = "ID";
            TitleComboBox.Items.AddRange(entities.Items.Select(x => new {ID=x.ID,Name=x.Title}).ToArray());
            TitleComboBox.DisplayMember = "Name";
            TitleComboBox.ValueMember = "ID";
            TypeComboBox.Items.AddRange(entities.ItemTypes.Select(x => new {ID=x.ID,Name=x.Name}).ToArray());
            TypeComboBox.DisplayMember = "Name";
            TypeComboBox.ValueMember = "ID";
            AmenityComboBox1.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AmenityComboBox1.DisplayMember = "Name";
            AmenityComboBox1.ValueMember = "ID";
            AmenityComboBox2.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AmenityComboBox2.DisplayMember = "Name";
            AmenityComboBox2.ValueMember = "ID";
            AmenityComboBox3.Items.AddRange(entities.Amenities.Select(x => new { ID = x.ID, Name = x.Name }).ToArray());
            AmenityComboBox3.DisplayMember = "Name";
            AmenityComboBox3.ValueMember = "ID";
        }
    }
}
