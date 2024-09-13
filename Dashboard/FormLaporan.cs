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
    public partial class FormLaporan : Form
    {
        string userId, tipeUser;
        public DataTable dt = new DataTable();
        string ConnectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        Koneksi conn = new Koneksi();
        public FormLaporan(string tipeUser,string userId)
        {
            this.tipeUser = tipeUser.ToString();
            this.userId = userId.ToString();
            InitializeComponent();
            DGV();
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
            FormUser form = new FormUser(tipeUser,userId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_LogActivity_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin(tipeUser,userId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        
    }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOODXYZDataSet.tbl_tranksaksi' table. You can move, or remove it, as needed.
            this.tbl_tranksaksiTableAdapter.Fill(this.fOODXYZDataSet.tbl_tranksaksi);

        }

        private void DGV()
        {
            dt.Clear();
            dataGridView1.Refresh();

            showDGV();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "No Transaksi";
            dataGridView1.Columns[1].HeaderText = "Tanggal Transaksi";
            dataGridView1.Columns[2].HeaderText = "Total Penjualan";
            dataGridView1.Columns[3].HeaderText = "Nama Kasir";
            dataGridView1.Columns[4].HeaderText = "Nama Pelanggan";

            dataGridView1.DataSource = dt;
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            showDGV();
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            foreach(DataRow dtr in dt.Rows)
            {
                chart1.Series["Omset"].Points.AddXY(dtr[1].ToString(),Convert.ToInt32(dtr[2]));
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Logout','" + userId.ToString() + "')");

            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void showDGV()
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    dt.Clear();
                    SqlCommand cmd = new SqlCommand("select tt.no_tranksaksi,tt.tgl_tranksaksi,tt.total_bayar,tt.nama_kasir,tp.nama from tbl_tranksaksi as tt inner join tbl_pelanggan as tp on tt.id_pelanggan = tp.id_pelanggan where tt.tgl_tranksaksi between '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"' and '"+dateTimePicker4.Value.ToString("yyyy-MM-dd")+"'");
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } finally {
                    conn.Close();
                }
            }
        }
    }
}
