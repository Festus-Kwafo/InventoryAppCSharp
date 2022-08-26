using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace InventoryApp

{

    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            populate();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCart_Click(object sender, EventArgs e)
        {

            try
            {
                if (catName.Text == "")
                {
                    MessageBox.Show("Enter A Valid Category Name");
                }
                else
                {
                    string myConnectionString = "server=localhost;database=inventoryapp;uid=root;pwd=;";
                    MySqlConnection conn = new MySqlConnection(myConnectionString);
                    conn = new MySqlConnection(myConnectionString);
                    conn.Open();
                    string sqlStatement = $"INSERT INTO category (name, description) VALUES ('{catName.Text}', '{catDescription.Text}');";
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{catName.Text} has been Added Successfully to category catalog");
                    conn.Close();
                    catName.Clear();
                    catDescription.Clear();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            try
            {
                string myConnectionString = "server=localhost;database=inventoryapp;uid=root;pwd=;";
                MySqlConnection conn = new MySqlConnection(myConnectionString);
                conn = new MySqlConnection(myConnectionString);
                string sqlstatement = $"select id, name, description from category;";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlstatement, conn);
                var ds = new DataSet();
                sda.Fill(ds);
                catDataGridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catId.Text = catDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            catName.Text = catDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            catDescription.Text = catDataGridView.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (catName.Text == "")
                {
                    MessageBox.Show("Select Category to delete");
                }
                else
                {
                    string myConnectionString = "server=localhost;database=inventoryapp;uid=root;pwd=;";
                    MySqlConnection conn = new MySqlConnection(myConnectionString);
                    conn = new MySqlConnection(myConnectionString);
                    conn.Open();
                    string sqlstatement = $"delete from category where name='{catName.Text}';";
                    MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Category Deleted Successfully");
                    conn.Close();
                    populate();

                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void catUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(catName.Text == "" || catDescription.Text == ""|| catId.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                string myConnectionString = "server=localhost;database=inventoryapp;uid=root;pwd=;";
                MySqlConnection conn = new MySqlConnection(myConnectionString);
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                string sqlstatement = $"update category set name='{catName.Text}', description='{catDescription.Text}' where id={catId.Text};";
                MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Category Updated Successfully");
                conn.Close();
                populate();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
