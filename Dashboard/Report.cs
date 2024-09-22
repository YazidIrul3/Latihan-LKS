using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Report : Form
    {

        string noHP;
        public Report(string noHP)
        {
            InitializeComponent();
            label_noHP.Text = noHP;
        }

        private void CrystalReport24_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
