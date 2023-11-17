using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Listing : UserControl
    {
        long? ItemID;
        int beforeIndex = 0;
        /// <summary>
        /// InitializeComponent Listing Form
        /// </summary>
        public Listing(long? itemID)
        {
            InitializeComponent();
            ItemID = itemID;
            if (itemID != null )
            {
                NextBtn.Visible= false;
                CloseBtn.Text = "Close";
            }
            else
            {
                NextBtn.Visible=true;
                CloseBtn.Text = "Cancel";
            }
            init();
        }
        /// <summary>
        /// init Listing Form
        /// </summary>
        public void init()
        {
            var entities = new Session1Entities();
            TypeComboBox.DataSource = entities.ItemTypes.Select(x=>new {x.ID,x.Name}).ToList();
            entities.Amenities.ToList().ForEach(x =>
            {
                AmenitiesDataGridView.Rows.Add(x.ID,x.Name,false);
            });
            if (ItemID != null)
            {
                var items = entities.Items.Find(ItemID);
                TypeComboBox.SelectedValue=items.ItemTypeID;
                TitleTextBox.Text=items.Title;
                CapacityNumericUpDown.Value = items.Capacity;
                BedNumericUpDown.Value = items.NumberOfBeds;
                BedroomNumericUpDown.Value = items.NumberOfBedrooms;
                BathroomNumericUpDown.Value = items.NumberOfBathrooms;
                ApproximateAddressTextBox.Text= items.ApproximateAddress;   
                ExactAddressTextbox.Text= items.ExactAddress;
                DescriptionTextBox.Text = items.Description;
                HostRulesTextBox.Text = items.HostRules;
                MinimumNumericUpDown.Value=items.MinimumNights;
                MaximumNumericUpDown.Value=items.MaximumNights;
                var men=items.ItemAmenities.Select(x => x.AmenityID).ToList();
                foreach (DataGridViewRow item in AmenitiesDataGridView.Rows)
                {
                    if (men.Any(x=> x== (long)item.Cells[0].Value))
                    {
                        item.Cells[2].Value = true;
                    }
                }
            }
        }
        /// <summary>
        /// Go to Next page
        /// </summary>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 1)
            {
                if (tabControl.SelectedIndex == 0)
                {
                    if (String.IsNullOrWhiteSpace(TitleTextBox.Text)
                        || String.IsNullOrWhiteSpace(ApproximateAddressTextBox.Text)
                        || String.IsNullOrWhiteSpace(ExactAddressTextbox.Text)
                        || String.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                        || String.IsNullOrWhiteSpace(HostRulesTextBox.Text))
                    {
                        MessageBox.Show("Input can't be empty.");
                        tabControl.SelectedIndex = beforeIndex;
                        return;
                    }
                    if (MinimumNumericUpDown.Value > MaximumNumericUpDown.Value)
                    {
                        MessageBox.Show("Nights minmum can't over maximum");
                        tabControl.SelectedIndex = beforeIndex;
                        return;
                    }
                }
                tabControl.SelectedIndex++;
            }
        }
        /// <summary>
        /// Close and save data
        /// </summary>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (CloseBtn.Text == "Cancel")
            {
                Global.ShowManagementForm();
                return;
            }
            if (String.IsNullOrWhiteSpace(TitleTextBox.Text)
                    || String.IsNullOrWhiteSpace(ApproximateAddressTextBox.Text)
                    || String.IsNullOrWhiteSpace(ExactAddressTextbox.Text)
                    || String.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                    || String.IsNullOrWhiteSpace(HostRulesTextBox.Text))
            {
                MessageBox.Show("Input can't be empty.");
                return;
            }
            if (MinimumNumericUpDown.Value > MaximumNumericUpDown.Value)
            {
                MessageBox.Show("minmum can't over maximum");
                return;
            }
            using (Session1Entities entities = new Session1Entities())
            {
                var items = new Items
                {
                    ID = entities.Items.OrderByDescending(t => t.ID).First().ID + 1,
                    GUID = Guid.NewGuid(),
                    UserID = Global.userID.Value
                };
                if (ItemID.HasValue)
                {
                    items = entities.Items.SingleOrDefault(t => t.ID == ItemID.Value);
                    entities.ItemAttractions.RemoveRange(entities.ItemAttractions.Where(t => t.ItemID == items.ID));
                }
                items.ItemTypeID = (long)TypeComboBox.SelectedValue;
                items.Title = TitleTextBox.Text;
                items.AreaID = entities.Areas.First().ID;
                items.Capacity = (int)CapacityNumericUpDown.Value;
                items.NumberOfBeds = (int)BedNumericUpDown.Value;
                items.NumberOfBedrooms = (int)BedroomNumericUpDown.Value;
                items.NumberOfBathrooms = (int)BathroomNumericUpDown.Value;
                items.ApproximateAddress = ApproximateAddressTextBox.Text;
                items.ExactAddress = ExactAddressTextbox.Text;
                items.Description = DescriptionTextBox.Text;
                items.HostRules = HostRulesTextBox.Text;
                items.MinimumNights = (int)MinimumNumericUpDown.Value;
                items.MaximumNights = (int)MinimumNumericUpDown.Value;
                entities.Items.AddOrUpdate(items);
                foreach (DataGridViewRow row in AmenitiesDataGridView.Rows)
                {
                    if ((bool)row.Cells[2].Value)
                    {
                        entities.ItemAmenities.Add(new ItemAmenities
                        {
                            GUID = Guid.NewGuid(),
                            ItemID = items.ID,
                            AmenityID = (long)row.Cells[0].Value
                        });
                    }
                }
                entities.SaveChanges();
                Global.ShowManagementForm();
                MessageBox.Show("Successful");
            }
        }
        /// <summary>
        /// tabControl go to next page
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CloseBtn.Text == "Finish"
              && tabControl.SelectedIndex != 1)
            {
                tabControl.SelectedIndex = 1;
                beforeIndex = tabControl.SelectedIndex;
                return;
            }
            if (this.beforeIndex == 0)
            {
                if (String.IsNullOrWhiteSpace(TitleTextBox.Text)
                    || String.IsNullOrWhiteSpace(ApproximateAddressTextBox.Text)
                    || String.IsNullOrWhiteSpace(ExactAddressTextbox.Text)
                    || String.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                    || String.IsNullOrWhiteSpace(HostRulesTextBox.Text))
                {
                    MessageBox.Show("Input can't be empty.");
                    tabControl.SelectedIndex = beforeIndex;
                    return;
                }
                if (MinimumNumericUpDown.Value > MaximumNumericUpDown.Value)
                {
                    MessageBox.Show("Nights minmum can't over maximum");
                    tabControl.SelectedIndex = beforeIndex;
                    return;
                }
            }
            if (NextBtn.Visible)
            {
                if (tabControl.SelectedIndex == 2)
                {
                    NextBtn.Visible = false;
                    CloseBtn.Text = "Finish";
                }
                else
                {
                    CloseBtn.Text = "Cancel";
                }
            }
            beforeIndex = tabControl.SelectedIndex;
        }
    }
}
