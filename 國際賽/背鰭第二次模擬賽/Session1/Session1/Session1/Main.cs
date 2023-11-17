using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Main : Form
    {
        /// <summary>
        /// InitializeComponent Main
        /// </summary>
        public Main()
        {
            InitializeComponent();
            Global.MainForm = this;
            Global.ShowLoginForm();
        }
        /// <summary>
        /// Close Log
        /// </summary>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var entities = new Session1Entities();
            entities.LogRecords.Add(new LogRecords
            {
                GUID= Guid.NewGuid(),
                FormName = "User exit",
                Task = "successful",
                UsersID = Global.userID,
                LogDT = DateTime.Now
            });
            entities.SaveChanges();
        }
    }
}
