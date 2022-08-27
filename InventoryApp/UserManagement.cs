using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;database=inventoryapp;uid=root;pwd=;");
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void userAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
