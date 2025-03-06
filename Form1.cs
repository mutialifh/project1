using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account obj = new Account();
            obj.Email = email;
            obj.Password = password;
            obj.Role = (role == "Administrator") ? "Administrator" : "Customer";


            string hasil = obj.doLogin();

            if (!string.IsNullOrEmpty(hasil))
            {
                MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string[] data = hasil.Split('|'); // Pisahkan nama & role
                GlobalVariabel.nama = data[0]; // Simpan hanya nama
                GlobalVariabel.email = obj.Email;

                string userRole = data[1]; // Gunakan nama variabel berbeda

                MessageBox.Show("Role yang dikirim ke Dashboard: " + userRole);

                FormDashboard dashboard = new FormDashboard(userRole);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Akun tidak ditemukan. Ingin mendaftar sekarang?",
                                       "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormRegister register = new FormRegister();
                    register.Show();
                    this.Hide();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Menampilkan password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Menyembunyikan password
            }
        }
    }
}