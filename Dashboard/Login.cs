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
    public partial class Login : Form
    {
        string ConnectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        Koneksi koneksi = new Koneksi();

        DataTable dt = new DataTable();
        string userId, tipeUser, namaUser;
        public Login()
        {
            InitializeComponent();
            Txt_Username.Text = "adam55";
            Txt_Password.Text = "12345";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txt_Username.Text = "";
            Txt_Password.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    if(Txt_Username.Text == "" || Txt_Password.Text == "")
                    {
                        MessageBox.Show("Username or passqord is required");
                    }

                    SqlCommand cmd = new SqlCommand("select * from tbl_user where username='"+Txt_Username.Text+"' and password='"+Txt_Password.Text+"'");
                    cmd.Connection = conn;
                    conn.Open();


                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                   adp.Fill(dt);
                    cmd.ExecuteReader();



                    if(dt.Rows.Count > 0)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            userId = row[0].ToString();
                            tipeUser = row[1].ToString();
                        }
                    koneksi.cud("insert into tbl_log (waktu,aktivitas,id_user) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "','Login','" + userId.ToString() + "')");

                        if(tipeUser == "Admin")
                        {
                            FormAdmin formAdmin = new FormAdmin();
                            this.Hide();
                            formAdmin.ShowDialog();
                            this.Close();
                        }

                        if(tipeUser == "Gudang")
                        {
                            FormGudang formGudang = new FormGudang();
                            this.Hide();
                            formGudang.ShowDialog();
                            this.Close();
                        }

                        if(tipeUser == "Kasir")
                        {
                            FormKasir form = new FormKasir();
                            this.Hide();
                            form.ShowDialog();
                            this.Close();
                        }
                    } else
                    {
                        MessageBox.Show("Gagal login");
                    }
                    

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
