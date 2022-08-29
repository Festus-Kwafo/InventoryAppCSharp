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
        private void MB(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title,
                    MessageBoxButtons.OKCancel,
                    ICON);
        }

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
        public static bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            bool bEqual = false;
            if (enteredPassword.Length == storedPassword.Length)
            {
                int i = 0;
                while ((i < enteredPassword.Length) && (enteredPassword[i] == storedPassword[i]))
                {
                    i += 1;
                }
                if (i == enteredPassword.Length)
                {
                    bEqual = true;
                }
            }
            return bEqual;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string role = usertypeCombo.GetItemText(usertypeCombo.SelectedItem);
                bool checkRole = true;
                while (checkRole)
                {

                    if (role == "Attendant")
                    {
                        string sqlstatement = $"Select id, first_name, email, password from users WHERE email = '{username.Text}'";
                        MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        
                        if (reader.Read() && reader["email"].ToString() == username.Text)
                        {
                            bool isPasswordMatched = VerifyPassword(password.Text, reader["password"].ToString()); 
                            if (isPasswordMatched)
                            {
                                string sellerName = reader["first_name"].ToString();
                                string sellerId = reader["id"].ToString();
                                SellingForm sell = new SellingForm(sellerName, sellerId);
                                sell.Show();
                                this.Hide();

                            }
                            else
                            {
                                MB("Wrong Password", "Attendant Login", MessageBoxIcon.Error);
                            }
                            checkRole = false;
                        }
                        else
                        {

                            MB("User does not exist", "User Login", MessageBoxIcon.Error);
                            checkRole = false;
                            
                        }
                        //bool isPasswordMatched = VerifyPassword(password.Text, user.Hash, user.Salt);
                    }
                    else if(role == "Admin")
                    {
                        string sqlstatementAdmin = $"Select username, password from admin WHERE username = '{username.Text}'";
                        MySqlCommand cmdAdmin = new MySqlCommand(sqlstatementAdmin, conn);
                        MySqlDataReader readerAdmin = cmdAdmin.ExecuteReader();
                        
                        if (readerAdmin.Read() && readerAdmin["username"].ToString() == username.Text)
                        {
                            bool isPassMatched = VerifyPassword(password.Text, readerAdmin["password"].ToString());
                            if (isPassMatched)
                            {
                                ProductForm prod = new ProductForm();
                                prod.Show();
                                this.Hide();
                                checkRole = false;
                            }
                            else
                            {
                                MB("Wrong Password", "Attendant Login", MessageBoxIcon.Error);
                                checkRole = false;
                            }
                        }
                        else
                        {
                            MB("User does not exist", "User Login", MessageBoxIcon.Error);
                            checkRole = false;
                        }
                    }
                    else
                    {
                        MB("Select Role", "Login", MessageBoxIcon.Error);
                        checkRole = false;
                    }
                    conn.Close();
                }                

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
