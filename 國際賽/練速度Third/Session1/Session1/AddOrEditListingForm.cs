﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Session1
{
    public partial class AddOrEditListingForm : Form
    {
        /// <summary>
        /// InitializeComponent AddOrEditListingForm
        /// </summary>
        public AddOrEditListingForm(long? itemID)
        {
            InitializeComponent();
            foreach (DataGridViewColumn item in DistanceDataGridView.Columns)
            {
                item.Width = (DistanceDataGridView.Width / DistanceDataGridView.Columns.Count) - 1;
            }
            ItemID = itemID;
            beforeIndex = 0;
            Text = ItemID.HasValue ? $"Seoul Stay - Edit Listing" : $"Seoul Stay - Add Listing";
        }
        long? ItemID;
        int beforeIndex;
        /// <summary>
        /// Button style
        /// </summary>
        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229, 26, 46);
        }
        /// <summary>
        /// Button style
        /// </summary>
        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }
        /// <summary>
        /// Init all data
        /// </summary>
        private void AddOrEditListingForm_Load(object sender, EventArgs e)
        {
            var entities = new Session1Entities();
            TypeComboBox.DataSource = entities.ItemTypes.Select(x => new { x.ID, x.Name }).ToList();
            TypeComboBox.ValueMember = "ID";
            TypeComboBox.DisplayMember = "Name";
            AttractionComboBox.DataSource = entities.Attractions.Select(x => new { x.ID, x.Name }).ToList();
            AttractionComboBox.ValueMember = "ID";
            AttractionComboBox.DisplayMember = "Name";
            if (ItemID.HasValue)
            {
                var items = entities.Items.SingleOrDefault(t => t.ID == ItemID);
                TypeComboBox.Text = items.ItemTypes.Name;
                TitleTextBox.Text = items.Title;
                ApproximateAddressTextBox.Text = items.ApproximateAddress;
                ExactAddressTextBox.Text = items.ExactAddress;
                DescriptionTextBox.Text = items.Description;
                HostRulesTextBox.Text = items.HostRules;
                CapacityyNum.Value = items.Capacity;
                BedsNum.Value = items.NumberOfBeds;
                BedroomNum.Value = items.NumberOfBedrooms;
                BathroomNum.Value = items.NumberOfBathrooms;
                MinNum.Value = items.MinimumNights;
                MaxNum.Value = items.MaximumNights;
                items.ItemAttractions.ToList().ForEach(t =>
                {
                    DistanceDataGridView.Rows.Add(t.AttractionID, t.Attractions.Name,
                        t.Attractions.Areas.Name,
                        t.Distance.ToString(),
                        t.DurationOnFoot.HasValue ? t.DurationOnFoot.Value.ToString() : "",
                        t.DurationByCar.HasValue ? t.DurationByCar.Value.ToString() : "");
                });
                CloseBtn.Text = "Close";
            }
            else
            {
                NextBtn.Visible = true;
                CloseBtn.Text = "Cancel";
            }
            entities.Amenities.Select(t => new { t.ID, t.Name }).ToList().ForEach(t =>
            {
                bool check = false;
                if (ItemID.HasValue)
                {
                    var items = entities.Items.SingleOrDefault(x => x.ID == ItemID);
                    check = items.ItemAmenities.Any(x => x.AmenityID == t.ID);
                }
                AmenitiesDataGridView.Rows.Add(t.ID, t.Name, check);
            });
        }
        /// <summary>
        /// pause the button can jump to next page
        /// </summary>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (ListingTabControl.SelectedIndex != 2)
            {
                if (ListingTabControl.SelectedIndex == 0)
                {
                    if (String.IsNullOrWhiteSpace(TitleTextBox.Text)
                        || String.IsNullOrWhiteSpace(ApproximateAddressTextBox.Text)
                        || String.IsNullOrWhiteSpace(ExactAddressTextBox.Text)
                        || String.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                        || String.IsNullOrWhiteSpace(HostRulesTextBox.Text))
                    {
                        MessageBox.Show("Input can't be empty.");
                        ListingTabControl.SelectedIndex = beforeIndex;
                        return;
                    }
                    if (MinNum.Value > MaxNum.Value)
                    {
                        MessageBox.Show("Nights minmum can't over maximum");
                        ListingTabControl.SelectedIndex = beforeIndex;
                        return;
                    }
                }
                ListingTabControl.SelectedIndex++;
            }
        }
        /// <summary>
        /// button text =cancel return text =close save all data to database
        /// </summary>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (CloseBtn.Text == "Cancel")
            {
                Close();
                return;
            }
            if (String.IsNullOrWhiteSpace(TitleTextBox.Text)
                    || String.IsNullOrWhiteSpace(ApproximateAddressTextBox.Text)
                    || String.IsNullOrWhiteSpace(ExactAddressTextBox.Text)
                    || String.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                    || String.IsNullOrWhiteSpace(HostRulesTextBox.Text))
            {
                MessageBox.Show("Input can't be empty.");
                return;
            }
            if (MinNum.Value > MaxNum.Value)
            {
                MessageBox.Show("Nights minmum can't over maximum");
                return;
            }
            if (DistanceDataGridView.Rows.Count < 2)
            {
                MessageBox.Show("Attraction distance need least two.");
                return;
            }
            using (Session1Entities entities = new Session1Entities())
            {
                var items = new Items
                {
                    ID = entities.Items.OrderByDescending(t => t.ID).First().ID + 1,
                    GUID = Guid.NewGuid(),
                    UserID = Global.accountID.Value
                };
                if (ItemID.HasValue)
                {
                    items = entities.Items.SingleOrDefault(t => t.ID == ItemID.Value);
                    entities.ItemAttractions.RemoveRange(entities.ItemAttractions.Where(t => t.ItemID == items.ID));
                    entities.ItemAmenities.RemoveRange(entities.ItemAmenities.Where(t => t.ItemID == items.ID));
                }
                items.ItemTypeID = (long)TypeComboBox.SelectedValue;
                items.Title = TitleTextBox.Text;
                items.AreaID = entities.Areas.First().ID;
                items.Capacity = (int)CapacityyNum.Value;
                items.NumberOfBeds = (int)BedsNum.Value;
                items.NumberOfBedrooms = (int)BedroomNum.Value;
                items.NumberOfBathrooms = (int)BathroomNum.Value;
                items.ApproximateAddress = ApproximateAddressTextBox.Text;
                items.ExactAddress = ExactAddressTextBox.Text;
                items.Description = DescriptionTextBox.Text;
                items.HostRules = HostRulesTextBox.Text;
                items.MinimumNights = (int)MinNum.Value;
                items.MaximumNights = (int)MaxNum.Value;
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
                foreach (DataGridViewRow row in DistanceDataGridView.Rows)
                {
                    int? onFoot = null;
                    int? bycar = null;
                    if (row.Cells[4].Value.ToString() != "")
                    {
                        onFoot = Convert.ToInt32(row.Cells[4].Value);
                    }
                    if (row.Cells[5].Value.ToString() != "")
                    {
                        bycar = Convert.ToInt32(row.Cells[5].Value);
                    }
                    entities.ItemAttractions.Add(new ItemAttractions
                    {
                        GUID = Guid.NewGuid(),
                        ItemID = items.ID,
                        AttractionID = Convert.ToInt64(row.Cells[0].Value),
                        Distance = Convert.ToDecimal(row.Cells[3].Value),
                        DurationOnFoot = onFoot,
                        DurationByCar = bycar,
                    });
                }
                entities.SaveChanges();
            }
            MessageBox.Show("Success!");
            Close();
        }
        /// <summary>
        /// Avoid data errors
        /// </summary>
        private void ListingTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CloseBtn.Text == "Finish"
               && ListingTabControl.SelectedIndex != 2)
            {
                ListingTabControl.SelectedIndex = 2;
                beforeIndex = ListingTabControl.SelectedIndex;
                return;
            }
            if (this.beforeIndex == 0)
            {
                if (String.IsNullOrWhiteSpace(TitleTextBox.Text)
                    || String.IsNullOrWhiteSpace(ApproximateAddressTextBox.Text)
                    || String.IsNullOrWhiteSpace(ExactAddressTextBox.Text)
                    || String.IsNullOrWhiteSpace(DescriptionTextBox.Text)
                    || String.IsNullOrWhiteSpace(HostRulesTextBox.Text))
                {
                    MessageBox.Show("Input can't be empty.");
                    ListingTabControl.SelectedIndex = beforeIndex;
                    return;
                }
                if (MinNum.Value > MaxNum.Value)
                {
                    MessageBox.Show("Nights minmum can't over maximum");
                    ListingTabControl.SelectedIndex = beforeIndex;
                    return;
                }
            }
            if (beforeIndex == 2)
            {
                if (DistanceDataGridView.Rows.Count < 2)
                {
                    MessageBox.Show("Attraction distance need least two.");
                    ListingTabControl.SelectedIndex = beforeIndex;
                    return;
                }
            }
            if (NextBtn.Visible)
            {
                if (ListingTabControl.SelectedIndex == 2)
                {
                    NextBtn.Visible = false;
                    CloseBtn.Text = "Finish";
                }
                else
                {
                    CloseBtn.Text = "Cancel";
                }
            }
            beforeIndex = ListingTabControl.SelectedIndex;
        }
        /// <summary>
        /// add the item attraction
        /// </summary>
        private void AddAttractionBtn_Click(object sender, EventArgs e)
        {
            if (DistanceNum.Value == 0)
            {
                MessageBox.Show("Distance need over zero.");
                return;
            }
            foreach (DataGridViewRow row in DistanceDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == AttractionComboBox.SelectedValue.ToString())
                {
                    MessageBox.Show("Attraction is exists.");
                    return;
                }
            }
            using (Session1Entities entities = new Session1Entities())
            {
                var attraction = entities.Attractions.SingleOrDefault(t => t.ID == (long)AttractionComboBox.SelectedValue);
                DistanceDataGridView.Rows.Add(attraction.ID, attraction.Name, attraction.Areas.Name,
                    DistanceNum.Value.ToString(),
                    OnfootNum.Value == 0 ? "" : OnfootNum.Value.ToString(),
                    BycarNum.Value == 0 ? "" : BycarNum.Value.ToString());
            }
        }
    }
}
