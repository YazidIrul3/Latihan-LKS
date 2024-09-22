using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Dashboard
{
    class Koneksi
    {
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public static string connectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
        public DataTable dt = new DataTable();
        public void cud(string sql)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    cmd = new SqlCommand(sql);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();                    
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } finally
                {
                    conn.Close();
                }
            }
        }

        public void read(string query)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    dt.Clear();
                    cmd = new SqlCommand(query);
                    //cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } finally
                {
                    connection.Close();
                }
            }
        }
    }
}
