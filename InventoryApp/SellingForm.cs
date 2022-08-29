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
    public partial class SellingForm : Form
    {
        private string SellerName;
        private string SellerId;
        public SellingForm(string sellerName, string sellerId)
        {
            InitializeComponent();
            SellerName = sellerName;
            SellerId = sellerId;
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;database=inventoryapp;uid=root;pwd=;");
        private void MB(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title,
                    MessageBoxButtons.OKCancel,
                    ICON);
        }
        private void populate()
        {
            try
            {
                conn.Open();
                string sqlstatement = $"select product.name as Name, product.retail_price as Ret_Price, product.quantity as Qty, category.name as Category from product inner join category on category_id=category.id;";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void prodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodName.Text = prodDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            prodPrice.Text = prodDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            prodQuant.Text = prodDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            datetime.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            seller_name.Text = SellerName;
            seller_id.Text = SellerId;
        }

        private void OrderDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int n = 0;
        float Grdtotal = 0;
        private void addProduct_Click(object sender, EventArgs e)
        {

            if (prodName.Text=="" || prodQuant.Text == "")
            {
                MB("Missing Values", "Order Product", MessageBoxIcon.Error);  
            }
            else
            {
                float total = float.Parse(prodQuant.Text) * float.Parse(prodPrice.Text);
                DataGridViewRow row = (DataGridViewRow)OrderDataGridView1.Rows[0].Clone();
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = prodName.Text;
                row.Cells[2].Value = prodPrice.Text;
                row.Cells[3].Value = prodQuant.Text;
                row.Cells[4].Value = float.Parse(prodQuant.Text) * float.Parse(prodPrice.Text);
                OrderDataGridView1.Rows.Add(row);
                n++;
                Grdtotal = Grdtotal + total;
                amount_pay.Text = "GHS " + Grdtotal;
            }
            
        }

        private void orderAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlstatement = $"insert into orders (seller_id, total_amt) values ({seller_id.Text}, {amount_pay.Text});";
                MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                cmd.ExecuteNonQuery();
                MB("Order Added Succesfully", "Order", MessageBoxIcon.Information );
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
