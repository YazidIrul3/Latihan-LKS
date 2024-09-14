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

    public partial class Label_date : Form
    {
        string ConnectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        DataTable dt = new DataTable();
        SqlDataAdapter adp;
        string userId, tipeUser;
        Koneksi koneksi = new Koneksi();
        public Label_date(string tipeUser,string userId)
        {
            this.userId = userId.ToString();
            this.tipeUser = tipeUser.ToString();
            InitializeComponent();
            dgv();

            date_label.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy");
            waktu_label.Text = DateTime.Now.ToString("hh:m:s");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDGV();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (tipeUser != "Admin")
            {
                MessageBox.Show("Login akun yang tipe user nya Admin");
                Login form = new Login();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
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
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Id LOG";
            dataGridView1.Columns[1].HeaderText = "Waktu";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Aktivitas";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            koneksi.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Logout','" + userId.ToString() + "')");

            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
                adp = new SqlDataAdapter(cmd);
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
