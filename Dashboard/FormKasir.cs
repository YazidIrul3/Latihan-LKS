using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataTable dt = new DataTable();
        string connectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        string namaBarang, kodeBarang, hargaSatuan, satuan;

        public FormKasir(string userId,string tipeUser)
        {
            InitializeComponent();
            this.userId = userId.ToString();
            this.tipeUser = tipeUser.ToString();

            Txt_NamaPelanggan.Text = namaBarang;
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
            // TODO: This line of code loads data into the 'fOODXYZDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.fOODXYZDataSet.tbl_barang);
            if (tipeUser != "Kasir")
            {
                MessageBox.Show("Login akun yang tipe user nya Kasir");
                Login form = new Login();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            dataFormTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_Quantitias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { 
                e.Handled = true;
            }
        }

        private void Txt_TotalHarga_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Txt_Quantitias_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            Txt_PilihMenu.Text = "";
            Txt_HargaSatuan.Text = "";
            Txt_NamaPelanggan.Text = "";
            Txt_Quantitias.Text = "";
            Txt_Telepon.Text = "";
            Txt_TotalHarga.Text = "";
        }


        private void dataFormTextBox()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("select kode_barang,nama_barang,harga_satuan,satuan from tbl_barang where kode_barang = '"+Txt_PilihMenu.Text+"'");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.ExecuteReader();

                  
                        foreach(DataRow row in dt.Rows)
                        {
                            kodeBarang = row[0].ToString();
                            namaBarang = row[1].ToString();
                            hargaSatuan = row[2].ToString();
                            satuan = row[3].ToString();
                        }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } finally
                {
                    connection.Close();
                }
            }
            {

            }
        }
    }
}
