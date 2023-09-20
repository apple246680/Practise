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
        }

        private void AdvancedSearchBtn_Click(object sender, EventArgs e)
        {
            AdvancedSearch advancedSearch = new AdvancedSearch();
            Visible = false;
            advancedSearch.ShowDialog();
            Visible = true;
        }
    }
}
