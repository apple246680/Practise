using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Terms : UserControl
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void Terms_Load(object sender, EventArgs e)
        {
            File.ReadAllText(Application.StartupPath+@"");
        }
    }
}
