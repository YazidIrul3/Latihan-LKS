using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class FormKasir : Form
    {

        string userId, tipeUser, namaKasir;
        string idTransaksi;
        string connectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        string namaBarang, kodeBarang, hargaSatuan, satuan, namaPelanggan, total_harga, idPelanggan,idBarang;
        Koneksi conn = new Koneksi();


        public FormKasir(string userId, string tipeUser, string nama)
        {
            InitializeComponent();
            this.userId = userId.ToString();
            this.tipeUser = tipeUser.ToString();
            this.namaKasir = nama.ToString();


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
            FormKasir form = new FormKasir(userId, tipeUser, namaKasir);
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_Quantitias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_TotalHarga_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            FormReport form = new FormReport(idTransaksi);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Txt_PilihMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataFormTextBoxBarang();
            Txt_HargaSatuan.Text = hargaSatuan;

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

        private void Txt_Telepon_TextChanged(object sender, EventArgs e)
        {
            dataFormTextBoxPelanggan();
            Txt_NamaPelanggan.Text = namaPelanggan;

        }

        private void Txt_Telepon_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_Quantitias_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Quantitias.Text != "")
            {
                int harga = Convert.ToInt32(Txt_Quantitias.Text) * Convert.ToInt32(Txt_HargaSatuan.Text);
                Txt_TotalHarga.Text = harga.ToString();
            }
        }

        private void dataGridView1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            long kembali = Convert.ToInt32(Txt_cash.Text) - Convert.ToInt32(total_harga);
            label_kembalian.Text = "Rp. " + kembali.ToString();

        }

        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            tambahPelanggan();
            transaksi();
            MessageBox.Show("simpan data berhasil");
        }

        private void Txt_Telepon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, kodeBarang, namaBarang, Txt_HargaSatuan.Text, Txt_Quantitias.Text, Txt_TotalHarga.Text);
            totalHarga();
            dataClear();

        }


        private void dataFormTextBoxBarang()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    SqlCommand cmd = new SqlCommand("select kode_barang,nama_barang,harga_satuan,satuan,id_barang from tbl_barang where kode_barang = '" + Txt_PilihMenu.Text + "'");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.ExecuteReader();


                    foreach (DataRow row in dt.Rows)
                    {
                        kodeBarang = row[0].ToString();
                        namaBarang = row[1].ToString();
                        hargaSatuan = row[2].ToString();
                        satuan = row[3].ToString();
                        idBarang = row[4].ToString();
                    }

                    Txt_HargaSatuan.Text = hargaSatuan;



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

        private void dataFormTextBoxPelanggan()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    SqlCommand cmd = new SqlCommand("select nama,id_pelanggan from tbl_pelanggan where telepon='" + Txt_Telepon.Text + "'");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.ExecuteReader();

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            namaPelanggan = row[0].ToString();
                            idPelanggan = row[1].ToString();
                        }
                        Txt_NamaPelanggan.Text = namaPelanggan;

                    }

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

        private void totalHarga()
        {
            total_harga = Convert.ToString(Convert.ToInt32(total_harga) + Convert.ToInt32(Txt_TotalHarga.Text));
            labelTotal.Text = "Rp. " + total_harga;
        }

        private void dataClear()
        {

            Txt_PilihMenu.Text = "";
            Txt_HargaSatuan.Text = "";
            Txt_Quantitias.Text = "";
            Txt_TotalHarga.Text = "";
        }

        private void tambahPelanggan()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    SqlCommand cmd = new SqlCommand("select nama from tbl_pelanggan where telepon='" + Txt_Telepon.Text + "'");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.ExecuteReader();

                    if (dt.Rows.Count < 0)
                    {
                        conn.cud("insert into tbl_pelanggan (nama,telepon) values ('" + Txt_NamaPelanggan.Text + "','" + Txt_Telepon.Text + "')");

                    }
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

        private void transaksi()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    String no = DateTime.Now.ToString("yyyyMMddHHmmss");
                    conn.cud("insert into tbl_tranksaksi (no_tranksaksi,tgl_tranksaksi,nama_kasir,total_bayar,id_user,id_barang) values ('" + no + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + namaKasir + "','" + total_harga + "','" + userId + "','"+idBarang+"')");

                    SqlCommand cmd = new SqlCommand("select max(id_tranksaksi) from tbl_tranksaksi");
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.ExecuteReader();

                    foreach (DataRow row in dt.Rows)
                    {
                        idTransaksi = row[0].ToString();
                    }


                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if(row.IsNewRow)
                        {
                        conn.cud("insert into tbl_detailTranksaksi (id_tranksaksi,qty,harga_satuan,subtotal,pembayaran,nomer_hp) values ('" + idTransaksi + "', '" + row.Cells[4].Value.ToString() + "', '" + row.Cells[3].Value.ToString() + "','" + row.Cells[5].Value.ToString() + "','" + total_harga + "','" + Txt_Telepon.Text.ToString() + "') ");
                        }
                    }
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
