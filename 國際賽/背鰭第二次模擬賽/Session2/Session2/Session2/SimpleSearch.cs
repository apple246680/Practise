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
    public partial class SimpleSearch : UserControl
    {
        public SimpleSearch()
        {
            InitializeComponent();
        }

        private void AdvanedBtn_Click(object sender, EventArgs e)
        {
            Global.ShowAdvancedSearch();
        }
    }
}
