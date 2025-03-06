﻿using System;
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

                GlobalVariabel.email = obj.Email;
                GlobalVariabel.nama = hasil.Split('|')[0];

                MessageBox.Show("Role yang dikirim ke Dashboard: " + obj.Role);

                FormDashboard dashboard = new FormDashboard();
                dashboard.InitializeDashboard(obj.Role);
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