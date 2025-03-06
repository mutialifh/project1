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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace project1
{
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();

        public FormRegister()
        {
            InitializeComponent();
        }
        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();  // Ambil nilai Full Name
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Role = (cmbRole.SelectedItem?.ToString() == "Administrator") ? "Admin" : "Customer";

            try
            {
                koneksi.con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (FullName, Email, Password, Role) VALUES (@fullName, @email, @password, @role)", koneksi.con);
                cmd.Parameters.AddWithValue("@fullName", fullName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password); // Bisa dienkripsi pakai hashing
                cmd.Parameters.AddWithValue("@role", Role);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.con.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
