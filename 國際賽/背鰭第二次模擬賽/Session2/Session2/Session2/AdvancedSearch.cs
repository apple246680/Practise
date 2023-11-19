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
            FromDate.MinDate = DateTime.Now.Date;
            FromDate.Value = DateTime.Now;
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
    }
}
