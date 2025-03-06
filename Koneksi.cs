using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace project1
{
    internal class Koneksi
    {
        string source;
        public SqlConnection con;

        public Koneksi()
        {
            try
            {
                source = "Integrated Security=true;Initial Catalog = db_courseapp;Data Source=.";
                con = new SqlConnection(source);
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Eror : " + sqle.Message);
            }
        }
        public void bukaKoneksi()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error saat membuka koneksi: " + sqle.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void tutupKoneksi()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error saat menutup koneksi: " + sqle.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}