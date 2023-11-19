using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public static class Global
    {
        public static Main main {  get; set; }
        public static DataGridView SimpleSearchDataGridView { get; set; }
        public static DateTime? FromDate { get; set; }
        public static int? Night {  get; set; }
        public static int? People {  get; set; }
        public static void ShowSimpleSearch()
        {
            main.Controls.Clear();
            main.Controls.Add(new SimpleSearch { Dock = DockStyle.Fill });
        }
        public static void ShowAdvancedSearch()
        {
            main.Controls.Clear();
            main.Controls.Add(new AdvancedSearch {Dock=DockStyle.Fill});
        }
    }
}
