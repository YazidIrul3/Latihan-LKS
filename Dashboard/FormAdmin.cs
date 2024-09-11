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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
        }

        private void Btn_KelolaLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan();
            form.ShowDialog();
        }

        private void Btn_LogActivity_Click(object sender, EventArgs e)
        {
            
        }
    }
}
