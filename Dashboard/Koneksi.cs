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
        public void cud(string sql)
        {
        string connectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";
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
    }
}
