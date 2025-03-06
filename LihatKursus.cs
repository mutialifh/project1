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
    public partial class LihatKursus : Form
    {
        Koneksi koneksi = new Koneksi();
        SqlConnection conn;

        public LihatKursus()
        {
            InitializeComponent();
        }
        private void LoadCourses(string keyword = "")
        {
            try
            {
                koneksi.bukaKoneksi();

                string query = "SELECT Title, Description, Price FROM Courses";
                SqlCommand cmd = new SqlCommand(query, koneksi.con); 
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    query = "SELECT Title, Description, Price FROM Courses";
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCourses.DataSource = dt;

                dataGridViewCourses.AutoGenerateColumns = false;
                dataGridViewCourses.Columns.Clear();

                // Tambahkan kolom secara manual
                dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Title", HeaderText = "Nama Kursus", DataPropertyName = "Title" });
                dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Deskripsi", DataPropertyName = "Description" });
                dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Harga (Rp)", DataPropertyName = "Price" });

                // Baru setelah itu, set DataSource
                dataGridViewCourses.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi(); // Tutup koneksi setelah query
            }
        }

        private void LihatKursus_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            if (this.Owner != null) 
            {
                this.Owner.Show(); 
            }
            this.Close(); 
        }
    }
}
