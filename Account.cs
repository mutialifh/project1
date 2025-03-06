using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Account
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        Koneksi koneksi = new Koneksi(); // Gunakan koneksi instance

        public string doLogin()
        {
            koneksi.bukaKoneksi();

            string query = "SELECT FullName, Role FROM Users WHERE Email=@Email AND Password=@Password";
            using (SqlCommand cmd = new SqlCommand(query, koneksi.con))
            {
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Password", this.Password);

                SqlDataReader reader = cmd.ExecuteReader();
                string fullName = "";
                string role = "";

                if (reader.Read())
                {
                    fullName = reader["FullName"].ToString();
                    string roleDB = reader["Role"].ToString();
                    role = roleDB.Trim();
                }

                reader.Close();
                koneksi.tutupKoneksi();

                if (!string.IsNullOrEmpty(fullName))
                {
                    return fullName + "|" + role; // Gabungkan nama & role pakai "|"
                }
                return ""; // Jika tidak ditemukan, return kosong
            }
        }
    }
}