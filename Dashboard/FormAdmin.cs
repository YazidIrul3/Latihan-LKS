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

    public partial class FormAdmin : Form
    {
        string ConnectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        DataTable dt = new DataTable();
        string userId, tipeUser;
        Koneksi koneksi = new Koneksi();
        public FormAdmin(string tipeUser,string userId)
        {
            this.userId = userId.ToString();
            this.tipeUser = tipeUser.ToString();
            InitializeComponent();
            dgv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDGV();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOODXYZDataSet.tbl_log' table. You can move, or remove it, as needed.
            this.tbl_logTableAdapter.Fill(this.fOODXYZDataSet.tbl_log);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser(tipeUser, userId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_KelolaLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan(tipeUser,userId);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_LogActivity_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv()
        {
            dt.Clear();
            dataGridView1.Refresh();

            showDGV();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Id LOG";
            dataGridView1.Columns[1].HeaderText = "Waktu";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Aktivitas";

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Logout','" + userId.ToString() + "')");

        }

        private void showDGV()
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    dt.Clear();
                SqlCommand cmd = new SqlCommand("select tl.id_log,tl.waktu, tu.username ,tl.aktivitas from tbl_log as tl inner join tbl_user as tu on tl.id_user = tu.id_user where tl.waktu between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd")+ "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd")+"' ");
                cmd.Connection = conn;
                conn.Open();

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } finally
                {
                    conn.Close();
                }
            }
        }
    }
}
