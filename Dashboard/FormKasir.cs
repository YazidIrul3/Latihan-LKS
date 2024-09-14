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
    public partial class FormKasir : Form
    {

        string userId, tipeUser;
        public FormKasir(string userId,string tipeUser)
        {
            InitializeComponent();
            this.userId = userId.ToString();
            this.tipeUser = tipeUser.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            FormKasir form = new FormKasir(userId,tipeUser);
            this.Hide();
            form.ShowDialog();
            this.Hide();
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            if (tipeUser != "Kasir")
            {
                MessageBox.Show("Login akun yang tipe user nya Kasir");
                Login form = new Login();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi conn = new Koneksi();
            conn.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Logout','" + userId.ToString() + "')");

            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
