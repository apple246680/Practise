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
        /// <summary>
        /// Shiw Simple Search Form
        /// </summary>
        public static void ShowSimpleSearch()
        {
            main.Text = "Seoul Stay - Search Properties or Listings";
            main.Controls.Clear();
            main.Controls.Add(new SimpleSearch { Dock = DockStyle.Fill });
        }
        /// <summary>
        /// Shiw Advanced Search Form
        /// </summary>
        public static void ShowAdvancedSearch()
        {
            main.Text = "Seoul Stay - Search Properties or Listings(Advanced)";
            main.Controls.Clear();
            main.Controls.Add(new AdvancedSearch {Dock=DockStyle.Fill});
        }
    }
}
