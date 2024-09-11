using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Dashboard
{
    class ClassConnection
    {
        public static SqlConnection GetConnection()
        {
            string str;
            SqlConnection conn;
            str = "Data Source=(localdb)\\MSSQLLocalDB;" +
                " Initial Catalog=LKSMart; " +
                "Integrated Security=True";
            conn = new SqlConnection(str);

            try
            {
                conn.Open();
                MessageBox.Show("Koneksi berhasil");
            } catch
            {
                MessageBox.Show("Koneksi gagal");
            }

            return conn;
        }
    }
}
