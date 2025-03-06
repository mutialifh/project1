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
    public partial class FormDashboard : Form
    {
        public FormDashboard(string role)
        {
            InitializeComponent();

            string namaUser = GlobalVariabel.nama; // Ambil nama dari global variabel

           lblWelcomeUser.Text = "Selamat Datang, " + namaUser + "!"; // Pastikan hanya nama yang ditampilkan

            if (role == "Administrator")
            {
                panelAdmin.Visible = true;
                panelCustomer.Visible = false;
            }
            else
            {
                panelAdmin.Visible = false;
                panelCustomer.Visible = true;
            }
        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormTransaksi formTransaksi = new FormTransaksi();
            formTransaksi.Show();
            this.Hide();
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            LihatKursus lk = new LihatKursus();
            lk.Owner = this;
            lk.Show();
            this.Hide();
        }

        private void btLogout_Click_1(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.Show();

            this.Close();
        }
    }
}
