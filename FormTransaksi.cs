using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace project1
{
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        SqlConnection conn;
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            txtID.Text = GenerateTransactionID();
            txtNama.Text = GlobalVariabel.nama;
            txtEmail.Text = GlobalVariabel.email;
            LoadKursus();
        }
        private string GenerateTransactionID()
        {
            return "TRX" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        private void LoadKursus()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT Title, Price FROM dbo.Courses";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow newRow = dt.NewRow();
                newRow["Title"] = "Silahkan Dipilih";
                newRow["Price"] = 0; 
                dt.Rows.InsertAt(newRow, 0);

                cmbKursus.DataSource = dt;
                cmbKursus.DisplayMember = "Title";
                cmbKursus.ValueMember = "Price";

                cmbKursus.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        private void cmbKursus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKursus.SelectedIndex == 0)
            {
                txtHarga.Text = "";
            }
            else
            {
                if (cmbKursus.SelectedValue != null)
                {
                    txtHarga.Text = cmbKursus.SelectedValue.ToString();
                }
            }
            HitungTotal();
        }
        private void numJumlah_ValueChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }
        private void HitungTotal()
        {
            if (decimal.TryParse(txtHarga.Text, out decimal harga) && numJumlah.Value > 0)
            {
                decimal total = harga * numJumlah.Value;
                txtTotal.Text = total.ToString("N0");
            }
            else
            {
                txtTotal.Text = "0";
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.bukaKoneksi(); // Gunakan koneksi dari objek 'koneksi'

                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Transactions (UserName, Email, CourseName, CoursePrice, Quantity, TotalPrice, PaymentMethod) " +
                                "VALUES (@nama, @email, @kursus, @harga, @jumlah, @total, @metode)", koneksi.con);


                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@kursus", cmbKursus.Text);
                cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(txtHarga.Text));
                cmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(numJumlah.Value));
                cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));
                cmd.Parameters.AddWithValue("@metode", cmbMetode.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaksi berhasil disimpan!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi(); // Gunakan metode dari 'koneksi' bukan 'conn.Close();'
            }
        }
        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard("Customer"); // Buat instance FormDashboard
            formDashboard.Show(); // Tampilkan FormDashboard
            this.Close(); // Tutup FormTransaksi
        }
    }
}