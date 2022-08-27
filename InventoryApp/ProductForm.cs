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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;database=inventoryapp;uid=root;pwd=;");
        private void fillcombo()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select name, id from category", conn);
                MySqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                //dt.Columns.Add("id", typeof(string));
                dt.Load(rdr);
                prodCat.ValueMember = "id";
                prodCat.DisplayMember = "name";
                prodCat.DataSource = dt;
                conn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void populate()
        {
            try
            {
                conn.Open();
                string sqlstatement = $"select id, name,  manufacturer, sku, purchase_price, retail_price, quantity from product;";
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlstatement, conn);
                var ds = new DataSet();
                sda.Fill(ds);
                prodDataGridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
              
                string sqlStatement = $"INSERT INTO product (name, manufacturer, sku, purchase_price, retail_price, quantity, stock_alert, category_id ) VALUES ('{prodName.Text}', '{prodMan.Text}', '{prodSku.Text}', {prodPurPrice.Text}, {prodRetPrice.Text}, {prodQuant.Text}, {prodStockAlert.Text}, {prodCat.SelectedValue});";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"{prodName.Text} has been Added Successfully to Product catalog");
                conn.Close();
                prodName.Clear();
                prodStockAlert.Clear();
                prodPurPrice.Clear();
                prodMan.Clear();
                prodRetPrice.Clear();
                prodSku.Clear();
                populate();

            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void prodCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId.Text = prodDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            prodName.Text = prodDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            prodMan.Text = prodDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            prodSku.Text = prodDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            prodPurPrice.Text = prodDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            prodRetPrice.Text = prodDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            prodQuant.Text = prodDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
