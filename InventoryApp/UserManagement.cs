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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;database=inventoryapp;uid=root;pwd=;Convert Zero Datetime=True");
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populate()
        {
            try
            {
                conn.Open();
                string sqlstatement = $"select id as ID, first_name as FirstName, last_name as LastName,  email as Email, dob as DOB from users;";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlstatement, conn);
                var ds = new DataSet();
                sda.Fill(ds);
                userGridDataView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            populate();
        }
        //Create Hashed password
        public class HashSalt
        {
            public string Hash { get; set; }
            public string Salt { get; set; }
        }
        
        public static HashSalt GenerateSaltedHash(int size, string password)
        {
            var saltBytes = new byte[size];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            var salt = Convert.ToBase64String(saltBytes);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };
            return hashSalt;
        }

        private void userAdd_Click(object sender, EventArgs e)

        {
            try
            {
                if (password.Text == confirm_password.Text)
                {

                    HashSalt hashSalt = GenerateSaltedHash(64, password.Text);
                    conn.Open();

                    string sqlStatement = @"INSERT INTO users (first_name, last_name, dob, email, hash, salt, password) VALUES (@first_name, @last_name, @dob, @email, @hash, @salt, @password);";
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, conn);
                    
                    cmd.Parameters.AddWithValue("@hash", hashSalt.Hash);
                    cmd.Parameters.AddWithValue("@salt", hashSalt.Salt);
                    cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                    cmd.Parameters.AddWithValue("@last_name", lastname.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.Parameters.AddWithValue("@dob", dob.Value.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"User {first_name.Text} has been Created Successfully");
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Password does not Match!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void userGridDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void userGridDataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            userId.Text = userGridDataView.SelectedRows[0].Cells[0].Value.ToString();
            first_name.Text = userGridDataView.SelectedRows[0].Cells[1].Value.ToString();
            lastname.Text = userGridDataView.SelectedRows[0].Cells[2].Value.ToString();
            email.Text = userGridDataView.SelectedRows[0].Cells[3].Value.ToString();
            //dob.Text = userGridDataView.SelectedRows[0].Cells[3].;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void userDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (userId.Text == "")
                {
                    MessageBox.Show("Select User to delete");
                }
                else
                {
                    conn.Open();
                    string sqlstatement = $"delete from users where id={userId.Text};";
                    MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"User Deleted Successfully");
                    conn.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            UserManagement manUser = new UserManagement();
            manUser.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
    }
}
