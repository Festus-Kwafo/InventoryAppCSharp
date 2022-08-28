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
                string sqlstatement = $"select product.id as ID, product.name as Name,  product.manufacturer as Manu, product.sku as SKU, product.purchase_price as Pur_Price, product.retail_price as Ret_Price, product.quantity as Qty, category.name as Category from product inner join category on category_id=category.id;";
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
            try
            {
                if (prodName.Text == "")
                {
                    MessageBox.Show("Select Product to delete");
                }
                else
                {
                    conn.Open();
                    string sqlstatement = $"delete from product where id={prodId.Text};";
                    MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Product Deleted Successfully");
                    conn.Close();
                    populate();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updtProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodName.Text == "" || prodMan.Text == "" || prodSku.Text == "" )
                {
                    MessageBox.Show("Missing Information");
                }
                conn.Open();
                string sqlstatement = $"update product set name='{prodName.Text}', sku='{prodSku.Text}', manufacturer='{prodMan.Text}', category_id='{prodCat.SelectedValue}', purchase_price={prodPurPrice.Text}, retail_price={prodRetPrice.Text}, quantity={prodQuant.Text}, stock_alert={prodStockAlert.Text}  where id={prodId.Text};";
                MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Product Updated Successfully");
                conn.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
