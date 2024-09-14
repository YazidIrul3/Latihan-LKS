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
        string connectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        Koneksi conn = new Koneksi();
        DataTable dt = new DataTable();
        string userId, tipeUser;
        public FormGudang(string userId,string TipeUser)
        {
            InitializeComponent();
            this.userId = userId.ToString();
            this.tipeUser = TipeUser.ToString();
            dgv();

            Btn_Edit.Enabled = false;
            Btn_Hapus.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGudang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOODXYZDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter1.Fill(this.fOODXYZDataSet.tbl_barang);
            // TODO: This line of code loads data into the 'lKSMartDataSet1.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.lKSMartDataSet1.tbl_barang);

        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            if (expire_date.Text == "" || Txt_HargaSatuan.Text == "" || Txt_JumlahBarang.Text == "" || Txt_KodeBarang.Text == "" || Txt_NamaBarang.Text == "" || Txt_Satuan.Text == "")
            {
                MessageBox.Show("Data ada yang belum di isi");
            } else
            {
                try
                    {
                        conn.cud("insert into tbl_barang (kode_barang,nama_barang,expired_date,jumlah_barang,satuan,harga_satuan) values ('" +Txt_KodeBarang.Text + "','" + Txt_NamaBarang.Text + "','" + expire_date.Value.ToString("yyyy-MM-dd") + "','" + Txt_JumlahBarang.Text + "','" + Txt_Satuan.Text + "','" + Txt_HargaSatuan.Text + "')");
                        MessageBox.Show("Data berhasil ditambahkan");
                        refreshData();
                    } catch
                    {
                        MessageBox.Show("Data gagal ditambahkan");

                    }
                }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Hapus_Click(object sender, EventArgs e)
        {

                try
                {
                    conn.cud("delete from tbl_barang where id_barang='" + id + "'");
                    MessageBox.Show("Data berhasil dihapus");
                    refreshData();
                } catch
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                if (expire_date.Text == "" || Txt_HargaSatuan.Text == "" || Txt_JumlahBarang.Text == "" || Txt_KodeBarang.Text == "" || Txt_NamaBarang.Text == "" || Txt_Satuan.Text == "")
                {
                    MessageBox.Show("Data ada yang belum di isi");
                } else
                {
                    try
                    {
                        conn.cud("update tbl_barang set kode_barang='"+Txt_KodeBarang.Text+"', nama_barang='"+Txt_NamaBarang.Text+"', expired_date='"+expire_date.Value.ToString("yyyy-MM-dd")+"', jumlah_barang='"+Txt_JumlahBarang.Text+"', satuan='"+Txt_Satuan.Text+"', harga_satuan='"+Txt_HargaSatuan.Text+"' where id_barang='"+id+"'");
                        MessageBox.Show("Data berhasil diedit");
                        refreshData();
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
            Txt_NamaBarang.Text = row.Cells[2].Value.ToString();
            expire_date.Value = Convert.ToDateTime(row.Cells[3].Value);
            Txt_JumlahBarang.Text = row.Cells[4].Value.ToString();
            Txt_Satuan.Text = row.Cells[5].Value.ToString();
            Txt_HargaSatuan.Text = row.Cells[6].Value.ToString();

            Btn_Hapus.Enabled = true;
            Btn_Edit.Enabled = true;
            Btn_Tambah.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshData()
        {
            Txt_KodeBarang.Text = "";
            Txt_NamaBarang.Text = "";
            Txt_Satuan.Text = "";
            Txt_HargaSatuan.Text = "";
            Txt_JumlahBarang.Text = "";
            FormGudang form = new FormGudang(userId,tipeUser);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Logout','" + userId.ToString() + "')");

            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void dgv()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    dt.Clear();
                    dataGridView2.Refresh();

                    SqlCommand cmd = new SqlCommand("select * from tbl_barang");
                    cmd.Connection = connection;

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[0].HeaderText = "Id Barang";
                    dataGridView2.Columns[1].HeaderText = "Kode Barang";
                    dataGridView2.Columns[2].HeaderText = "Nama Barang";
                    dataGridView2.Columns[3].HeaderText = "Expired Date";
                    dataGridView2.Columns[4].HeaderText = "Jumlah Barang";
                    dataGridView2.Columns[5].HeaderText = "Satuan";
                    dataGridView2.Columns[6].HeaderText = "Harga Satuan";

                } catch(Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                } finally
                {
                    connection.Close();
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    dt.Clear();
                    dataGridView2.Refresh();

                    SqlCommand cmd = new SqlCommand("select * from tbl_barang where kode_barang like '"+ Txt_Search.Text +"%' or nama_barang like '"+Txt_Search.Text+"%'");
                    cmd.Connection = connection;

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    dataGridView2.DataSource = dt;

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.Columns[0].HeaderText = "Id Barang";
                    dataGridView2.Columns[1].HeaderText = "Kode Barang";
                    dataGridView2.Columns[2].HeaderText = "Nama Barang";
                    dataGridView2.Columns[3].HeaderText = "Expired Date";
                    dataGridView2.Columns[4].HeaderText = "Jumlah Barang";
                    dataGridView2.Columns[5].HeaderText = "Satuan";
                    dataGridView2.Columns[6].HeaderText = "Harga Satuan";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
