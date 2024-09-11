using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class FormGudang : Form
    {
        int id;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LKSMart; Integrated Security=True";
        public FormGudang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGudang_Load(object sender, EventArgs e)
        {
            ClassConnection.GetConnection();
            // TODO: This line of code loads data into the 'lKSMartDataSet1.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.lKSMartDataSet1.tbl_barang);

        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            if (Txt_ExpireDate.Text == "" || Txt_HargaSatuan.Text == "" || Txt_JumlahBarang.Text == "" || Txt_KodeBarang.Text == "" || Txt_NamaBarang.Text == "" || Txt_Satuan.Text == "")
            {
                MessageBox.Show("Data ada yang belum di isi");
            } else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_barang(kode_barang,nama_barang,expired_date,jumlah_barang,satuan,harga_satuan) values (@kode_barang,@nama_barang,@expired_date,@jumlah_barang,@satuan,@harga_satuan)");

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@kode_barang",Txt_KodeBarang.Text);
                    cmd.Parameters.AddWithValue("@nama_barang",Txt_NamaBarang.Text);
                    cmd.Parameters.AddWithValue("@expired_date",Txt_ExpireDate.Value);
                    cmd.Parameters.AddWithValue("@jumlah_barang",Txt_JumlahBarang.Text);
                    cmd.Parameters.AddWithValue("@satuan",Txt_Satuan.Text);
                    cmd.Parameters.AddWithValue("@harga_satuan",Txt_HargaSatuan.Text);

                    try
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.ExecuteReader();

                        MessageBox.Show("Data berhasil ditambahkan");

                        Txt_ExpireDate.Text = "";
                        Txt_KodeBarang.Text = "";
                        Txt_NamaBarang.Text = "";
                        Txt_Satuan.Text = "";
                        Txt_HargaSatuan.Text = "";
                        Txt_JumlahBarang.Text = "";
                    } catch
                    {
                        MessageBox.Show("Data gagal ditambahkan");

                    }
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Hapus_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_barang where id_barang=@id");
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");
                } catch
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                if (Txt_ExpireDate.Text == "" || Txt_HargaSatuan.Text == "" || Txt_JumlahBarang.Text == "" || Txt_KodeBarang.Text == "" || Txt_NamaBarang.Text == "" || Txt_Satuan.Text == "")
                {
                    MessageBox.Show("Data ada yang belum di isi");
                } else
                {
                    SqlCommand cmd = new SqlCommand("update tbl_barang set kode_barang=@kode_barang, nama_barang=@nama_barang, expired_date=@expired_date, jumlah_barang=@jumlah_barang, satuan=@satuan, harga_satuan=@harga_satuan where id_barang=@id");

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@kode_barang", Txt_KodeBarang.Text);
                    cmd.Parameters.AddWithValue("@nama_barang", Txt_NamaBarang.Text);
                    cmd.Parameters.AddWithValue("@expired_date", Txt_ExpireDate.Value);
                    cmd.Parameters.AddWithValue("@jumlah_barang", Txt_JumlahBarang.Text);
                    cmd.Parameters.AddWithValue("@satuan", Txt_Satuan.Text);
                    cmd.Parameters.AddWithValue("@harga_satuan", Txt_HargaSatuan.Text);
                    
                    try
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil diedit");

                        Txt_KodeBarang.Text = "";
                        Txt_NamaBarang.Text = "";
                        Txt_ExpireDate.Text = "";
                        Txt_Satuan.Text = "";
                        Txt_HargaSatuan.Text = "";
                        Txt_JumlahBarang.Text = "";
                    } catch
                    {
                        MessageBox.Show("Data gagal diedit");
                    }
                }
            }
         }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            id = Convert.ToInt16(row.Cells[0].Value);
                                   
            Txt_KodeBarang.Text = row.Cells[1].Value.ToString();
            Txt_JumlahBarang.Text = row.Cells[2].Value.ToString();
            Txt_NamaBarang.Text = row.Cells[3].Value.ToString();
            Txt_Satuan.Text = row.Cells[4].Value.ToString();
            Txt_HargaSatuan.Text = row.Cells[6].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
