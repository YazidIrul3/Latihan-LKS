﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class FormReport : Form
    {

        string idTransaksi,tanggal,noHP,harga;
        SqlDataAdapter adp;
        string connectionString = "Data Source=MYBOOKZSERIES;Initial Catalog=FOODXYZ;Integrated Security=True;";

        public FormReport(string idTransaksi)
        {
            InitializeComponent();
            this.idTransaksi = idTransaksi.ToString();
            labelData();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();

                    dt.Clear();
                    dataGridView1.Refresh();
                    SqlCommand cmd = new SqlCommand("select tb.nama_barang,td.qty,td.subTotal from tbl_detailTranksaksi as td inner join tbl_tranksaksi as tt on td.id_tranksaksi = tt.id_tranksaksi inner join tbl_barang as tb on tt.id_barang = tb.id_barang where td.id_tranksaksi = '"+idTransaksi+"'");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns[0].HeaderText = "Nama Barang";
                    dataGridView1.Columns[1].HeaderText = "Jumlah beli";
                    dataGridView1.Columns[2].HeaderText = "Sub Total";

                    print(panelPrint);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                } finally
                {
                    connection.Close();
                }
            }
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void print(Panel pnl)
        {
            try
            {
                PrinterSettings ps = new PrinterSettings();
                panelPrint = pnl;
                getPrintArea(pnl);
                printPreviewDialog1.Document = printDocument1;
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printPreviewDialog1.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private Bitmap memoryImg;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg,(pageArea.Width/2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void getPrintArea(Panel pnl)
        {
            try
            {
                memoryImg = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(memoryImg,new Rectangle(0, 0, pnl.Width, pnl.Height));
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void labelData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();

                    dt.Clear();
                    SqlCommand cmd = new SqlCommand("select tt.tgl_tranksaksi,td.nomer_hp from tbl_detailTranksaksi as td inner join tbl_tranksaksi as tt on td.id_tranksaksi = tt.id_tranksaksi where td.id_tranksaksi = '" + idTransaksi + "'");
                    cmd.Connection = connection;
                    connection.Open();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    cmd.ExecuteReader();

                    if(dt.Rows.Count > 0) {
                        foreach(DataRow row in dt.Rows)
                        {
                            tanggal = row[0].ToString();
                            noHP = row[1].ToString();
                            
                        }

                        label_tanggal.Text = tanggal;
                        label_noTransaksi.Text = noHP;
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
