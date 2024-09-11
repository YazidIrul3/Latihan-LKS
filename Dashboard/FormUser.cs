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
    public partial class FormUser : Form
    {
        int id;
        public FormUser()
        {
            InitializeComponent();
        }

        private void Btn_LogActivity_Click(object sender, EventArgs e)
        {

        }


        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lKSMartDataSet.tbl_user' table. You can move, or remove it, as needed.
            this.tbl_userTableAdapter.Fill(this.lKSMartDataSet.tbl_user);
            ClassConnection.GetConnection();

        }

        private void Btn_KelolaLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan();
            form.ShowDialog();
        }

        private void Btn_LogActivity_Click_1(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            form.ShowDialog();
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            if (Txt_Alamat.Text == "" || Txt_Nama.Text == "" || Txt_Telepon.Text == "" || Txt_TipeUser.Text == "" || Txt_Username.Text == "") {
                MessageBox.Show("Data ada yang belum di isi");
            } else
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LksMart;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_user(tipe_user, nama, alamat, username,telepon,password) values (@tipe_user,@nama,@alamat,@username,@telepon,@password)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@tipe_user", Txt_TipeUser.Text);
                    cmd.Parameters.AddWithValue("@nama", Txt_Nama.Text);
                    cmd.Parameters.AddWithValue("@alamat", Txt_Alamat.Text);
                    cmd.Parameters.AddWithValue("@username", Txt_Username.Text);
                    cmd.Parameters.AddWithValue("@telepon", Txt_Telepon.Text);
                    cmd.Parameters.AddWithValue("@password", Txt_Password.Text);

                    try
                    {
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil ditambahkan");

                        Txt_Alamat.Text = "";
                        Txt_Nama.Text = "";
                        Txt_Password.Text = "";
                        Txt_Telepon.Text = "";
                        Txt_TipeUser.Text = "";
                        Txt_Username.Text = "";
                    } catch {
                        MessageBox.Show("Data gagal ditambahkan");
                    }
                }
            }
        }

        private void Txt_TipeUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Hapus_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LksMart;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_user where id_user=@id");
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");

                    Txt_Alamat.Text = "";
                    Txt_Nama.Text = "";
                    Txt_Password.Text = "";
                    Txt_Telepon.Text = "";
                    Txt_TipeUser.Text = "";
                    Txt_Username.Text = "";
                } catch
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_Alamat.Text == "" || Txt_Nama.Text == "" || Txt_Telepon.Text == "" || Txt_TipeUser.Text == "" || Txt_Username.Text == "")
            {
                MessageBox.Show("Data ada yang belum di isi");
            }
            else
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LksMart;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("update tbl_user set nama=@nama, tipe_user=@tipe_user, alamat=@alamat, username=@username, password=@password where id_user=@id");
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tipe_user", Txt_TipeUser.Text);
                    cmd.Parameters.AddWithValue("@nama", Txt_Nama.Text);
                    cmd.Parameters.AddWithValue("@alamat", Txt_Alamat.Text);
                    cmd.Parameters.AddWithValue("@username", Txt_Username.Text);
                    cmd.Parameters.AddWithValue("@telepon", Txt_Telepon.Text);
                    cmd.Parameters.AddWithValue("@password", Txt_Password.Text);

                    try
                    {

                        cmd.Connection = connection;
                        connection.Open();
                        cmd.ExecuteReader();
                        MessageBox.Show("Data berhasil diedit");

                        Txt_Alamat.Text = "";
                        Txt_Nama.Text = "";
                        Txt_Password.Text = "";
                        Txt_Telepon.Text = "";
                        Txt_TipeUser.Text = "";
                        Txt_Username.Text = "";

                    } catch
                    {
                        MessageBox.Show("Data gagal diedit");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[indexRow];
            id = Convert.ToInt16(row.Cells[0].Value);

            Txt_TipeUser.Text = row.Cells[1].Value.ToString();
            Txt_Nama.Text = row.Cells[2].Value.ToString();
            Txt_Telepon.Text = row.Cells[3].Value.ToString();
            Txt_Alamat.Text = row.Cells[4].Value.ToString();
            Txt_Username.Text = row.Cells[5].Value.ToString();
            Txt_Password.Text = row.Cells[6].Value.ToString();
        }
    }
}
