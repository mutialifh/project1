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
using System.Windows.Forms.VisualStyles;

namespace project1
{
    public partial class FormLihatTransaksi : Form
    {

        Koneksi koneksi = new Koneksi();
        SqlConnection conn;
    private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT ID_Transaksi, ID_User, ID_Kursus, Tanggal_Transaksi, Metode_Pembayaran, Total_Harga, Status FROM transactions";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idTransaksi = dataGridView1.SelectedRows[0].Cells["ID_Transaksi"].Value.ToString();
                string newStatus = cmbStatus.SelectedItem.ToString();

                try
                {
                    conn.Open();
                    string query = "UPDATE transactions SET Status = @status WHERE ID_Transaksi = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", idTransaksi);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Status transaksi diperbarui!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Pilih transaksi yang ingin diperbarui!");
            }
        }

        private void FormLihatTransaksi_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            conn = koneksi.con;
            this.Load += FormLihatTransaksi_Load;
        }
    }
}
        
