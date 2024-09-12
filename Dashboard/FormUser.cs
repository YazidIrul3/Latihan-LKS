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
        string tipeUser, userId;
        Koneksi conn = new Koneksi();

        public FormUser(string tipeUser,string userId)
        {
            this.tipeUser = tipeUser.ToString();
            this.userId = userId.ToString();
            InitializeComponent();
        }

        private void Btn_LogActivity_Click(object sender, EventArgs e)
        {

        }


        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOODXYZDataSet.tbl_user' table. You can move, or remove it, as needed.
            this.tbl_userTableAdapter1.Fill(this.fOODXYZDataSet.tbl_user);
            // TODO: This line of code loads data into the 'lKSMartDataSet.tbl_user' table. You can move, or remove it, as needed.
            this.tbl_userTableAdapter.Fill(this.lKSMartDataSet.tbl_user);

        }

        private void Btn_KelolaLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan(tipeUser,userId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_LogActivity_Click_1(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin(tipeUser, userId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            if (Txt_Alamat.Text == "" || Txt_Nama.Text == "" || Txt_Telepon.Text == "" || Txt_TipeUser.Text == "" || Txt_Username.Text == "") {
                MessageBox.Show("Data ada yang belum di isi");
            } else
            {
                try
                    {
                    conn.cud("insert into tbl_user(tipe_user, nama, alamat, username,telepon,password) values ('"+Txt_TipeUser.Text+"','"+Txt_Nama.Text+"','"+Txt_Alamat.Text+"','"+Txt_Username.Text+"','"+Txt_Telepon.Text+"','"+Txt_Password.Text+"')");

                        MessageBox.Show("Data berhasil ditambahkan");

                    dataRefresh();
                    } catch {
                        MessageBox.Show("Data gagal ditambahkan");
                    }
                }
            
        }

        private void Txt_TipeUser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Hapus_Click(object sender, EventArgs e)
        {
            
                try
                {
                    conn.cud("delete from tbl_user where id_user='" + id + "'");

                    MessageBox.Show("Data berhasil dihapus");

                    dataRefresh();
                } catch
                {
                    MessageBox.Show("Data gagal dihapus");
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
                    try
                    {
                        conn.cud("update tbl_user set nama='"+Txt_Nama.Text+"', tipe_user='"+Txt_TipeUser.Text+"', alamat='"+Txt_Alamat.Text+"', username='"+Txt_Username.Text+"', password='"+Txt_Password.Text+"' where id_user='"+id+"' ");
                        MessageBox.Show("Data berhasil diedit");

                        dataRefresh();

                    } catch
                    {
                        MessageBox.Show("Data gagal diedit");
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
            Txt_Alamat.Text = row.Cells[3].Value.ToString();
            Txt_Username.Text = row.Cells[4].Value.ToString();
            Txt_Telepon.Text = row.Cells[5].Value.ToString();
            Txt_Password.Text = row.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Logout','" + userId.ToString() + "')");
        }

        private void dataRefresh()
        {
            Txt_Alamat.Text = "";
            Txt_Nama.Text = "";
            Txt_Password.Text = "";
            Txt_Telepon.Text = "";
            Txt_TipeUser.Text = "";
            Txt_Username.Text = "";

            this.Hide();
            FormUser form = new FormUser(tipeUser, userId);
            form.ShowDialog();
            this.Close();
        }
    }
}
