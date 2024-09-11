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
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_KelolaUser_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
        }

        private void Btn_LogActivity_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            form.ShowDialog();
        }
    }
}
