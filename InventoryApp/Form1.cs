using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;database=inventoryapp;uid=root;pwd=;");
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            Console.WriteLine($"inputhash {Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256))}");
            Console.WriteLine($"storedhash {storedHash}");
            bool bEqual = false;
            if (Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)).Length == storedHash.Length)
            {
                int i = 0;
                while ((i < Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)).Length) && (Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256))[i] == storedHash[i]))
                {
                    i += 1;
                }
                if (i == Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)).Length)
                {
                    bEqual = true;
                }
            }

            if (bEqual)
                Console.WriteLine("The two hash values are the same");
            else
                Console.WriteLine("The two hash values are not the same");
            return bEqual;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlstatement = $"Select email, salt, hash from users WHERE email = '{username.Text}'";
                MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                string role = usertypeCombo.GetItemText(usertypeCombo.SelectedItem);
                while (reader.Read())
                {
                    if (role == "Attendant")
                    {
                        if (reader["email"].ToString() == username.Text)
                        {
                            string hash = reader["hash"].ToString();
                            string salt = reader["salt"].ToString();
                            bool isPasswordMatched = VerifyPassword(password.Text, hash, salt);
                            Console.WriteLine(VerifyPassword(password.Text, hash, salt));
                            if (isPasswordMatched)
                            {
                                MessageBox.Show("Login Successful");
                            }
                            else
                            {
                                MessageBox.Show("Login Unsuccessful");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email does not match");
                        }
                        //bool isPasswordMatched = VerifyPassword(password.Text, user.Hash, user.Salt);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void usertypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
