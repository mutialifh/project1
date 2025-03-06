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

namespace project1
{
    public partial class FormKelolaKursus : Form
    {
        Koneksi koneksi = new Koneksi();

        public FormKelolaKursus()
        {
            InitializeComponent();
            TampilkanDataKursus();
        }

        private void TampilkanDataKursus()
        {
            try
            {
                koneksi.bukaKoneksi();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CourseID, CourseName, Price FROM Courses", koneksi.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKursus.DataSource = dt;
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaKursus.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Nama kursus dan harga tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Courses (CourseName, Price) VALUES (@CourseName, @Price)";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@CourseName", txtNamaKursus.Text);
                cmd.Parameters.AddWithValue("@Price", harga);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kursus berhasil ditambahkan.");
                TampilkanDataKursus();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewKursus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih kursus yang ingin diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaKursus.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Nama kursus dan harga tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE Courses SET CourseName = @CourseName, Price = @Price WHERE CourseID = @CourseID";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@CourseID", dataGridViewKursus.SelectedRows[0].Cells["CourseID"].Value);
                cmd.Parameters.AddWithValue("@CourseName", txtNamaKursus.Text);
                cmd.Parameters.AddWithValue("@Price", harga);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kursus berhasil diperbarui.");
                TampilkanDataKursus();
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewKursus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih kursus yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus kursus ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    koneksi.bukaKoneksi();
                    string query = "DELETE FROM Courses WHERE CourseID = @CourseID";
                    SqlCommand cmd = new SqlCommand(query, koneksi.con);
                    cmd.Parameters.AddWithValue("@CourseID", dataGridViewKursus.SelectedRows[0].Cells["CourseID"].Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kursus berhasil dihapus.");
                    TampilkanDataKursus();
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
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup FormKelolaKursus dan kembali ke dashboard
        }

        private void dataGridViewKursus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewKursus.Rows[e.RowIndex];
                txtNamaKursus.Text = row.Cells["CourseName"].Value.ToString();
                txtHarga.Text = row.Cells["Price"].Value.ToString();
            }
        }
    }
}