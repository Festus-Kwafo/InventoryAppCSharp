
namespace InventoryApp
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delProduct = new System.Windows.Forms.Button();
            this.updtProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectCat = new System.Windows.Forms.ComboBox();
            this.refProduct = new System.Windows.Forms.Button();
            this.prodQuant = new System.Windows.Forms.TextBox();
            this.prodRetPrice = new System.Windows.Forms.TextBox();
            this.prodStockAlert = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.prodPurPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prodCat = new System.Windows.Forms.ComboBox();
            this.prodMan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prodSku = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodId = new System.Windows.Forms.TextBox();
            this.prodDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Categories);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 706);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sales";
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Categories.Location = new System.Drawing.Point(20, 145);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(125, 24);
            this.Categories.TabIndex = 2;
            this.Categories.Text = "Categories";
            this.Categories.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.delProduct);
            this.panel2.Controls.Add(this.updtProduct);
            this.panel2.Controls.Add(this.addProduct);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 59);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // delProduct
            // 
            this.delProduct.BackColor = System.Drawing.Color.Red;
            this.delProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delProduct.Location = new System.Drawing.Point(821, 14);
            this.delProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delProduct.Name = "delProduct";
            this.delProduct.Size = new System.Drawing.Size(88, 36);
            this.delProduct.TabIndex = 3;
            this.delProduct.Text = "Delete";
            this.delProduct.UseVisualStyleBackColor = false;
            this.delProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // updtProduct
            // 
            this.updtProduct.BackColor = System.Drawing.Color.Orange;
            this.updtProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updtProduct.Location = new System.Drawing.Point(713, 15);
            this.updtProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updtProduct.Name = "updtProduct";
            this.updtProduct.Size = new System.Drawing.Size(101, 36);
            this.updtProduct.TabIndex = 2;
            this.updtProduct.Text = "Update";
            this.updtProduct.UseVisualStyleBackColor = false;
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.Orange;
            this.addProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addProduct.Location = new System.Drawing.Point(629, 14);
            this.addProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(83, 36);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(381, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Product";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.prodDataGridView);
            this.panel3.Controls.Add(this.prodId);
            this.panel3.Controls.Add(this.selectCat);
            this.panel3.Controls.Add(this.refProduct);
            this.panel3.Controls.Add(this.prodQuant);
            this.panel3.Controls.Add(this.prodRetPrice);
            this.panel3.Controls.Add(this.prodStockAlert);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.prodPurPrice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.prodCat);
            this.panel3.Controls.Add(this.prodMan);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.prodSku);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.prodName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(253, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 594);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // selectCat
            // 
            this.selectCat.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCat.ForeColor = System.Drawing.Color.Orange;
            this.selectCat.FormattingEnabled = true;
            this.selectCat.Location = new System.Drawing.Point(536, 288);
            this.selectCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectCat.Name = "selectCat";
            this.selectCat.Size = new System.Drawing.Size(169, 28);
            this.selectCat.TabIndex = 23;
            this.selectCat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // refProduct
            // 
            this.refProduct.BackColor = System.Drawing.Color.Orange;
            this.refProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refProduct.Location = new System.Drawing.Point(731, 284);
            this.refProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refProduct.Name = "refProduct";
            this.refProduct.Size = new System.Drawing.Size(93, 36);
            this.refProduct.TabIndex = 21;
            this.refProduct.Text = "Refresh";
            this.refProduct.UseVisualStyleBackColor = false;
            // 
            // prodQuant
            // 
            this.prodQuant.Location = new System.Drawing.Point(560, 201);
            this.prodQuant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodQuant.Name = "prodQuant";
            this.prodQuant.Size = new System.Drawing.Size(223, 23);
            this.prodQuant.TabIndex = 20;
            // 
            // prodRetPrice
            // 
            this.prodRetPrice.Location = new System.Drawing.Point(295, 201);
            this.prodRetPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodRetPrice.Name = "prodRetPrice";
            this.prodRetPrice.Size = new System.Drawing.Size(223, 23);
            this.prodRetPrice.TabIndex = 19;
            // 
            // prodStockAlert
            // 
            this.prodStockAlert.Location = new System.Drawing.Point(48, 284);
            this.prodStockAlert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodStockAlert.Name = "prodStockAlert";
            this.prodStockAlert.Size = new System.Drawing.Size(223, 23);
            this.prodStockAlert.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Stock Alert";
            // 
            // prodPurPrice
            // 
            this.prodPurPrice.Location = new System.Drawing.Point(48, 201);
            this.prodPurPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodPurPrice.Name = "prodPurPrice";
            this.prodPurPrice.Size = new System.Drawing.Size(223, 23);
            this.prodPurPrice.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Stock Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(291, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Retail Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Purchase Price";
            // 
            // prodCat
            // 
            this.prodCat.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCat.FormattingEnabled = true;
            this.prodCat.Location = new System.Drawing.Point(48, 114);
            this.prodCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodCat.Name = "prodCat";
            this.prodCat.Size = new System.Drawing.Size(352, 32);
            this.prodCat.TabIndex = 8;
            this.prodCat.SelectedIndexChanged += new System.EventHandler(this.prodCat_SelectedIndexChanged);
            // 
            // prodMan
            // 
            this.prodMan.Location = new System.Drawing.Point(468, 114);
            this.prodMan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodMan.Name = "prodMan";
            this.prodMan.Size = new System.Drawing.Size(313, 23);
            this.prodMan.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Product Manufacturer";
            // 
            // prodSku
            // 
            this.prodSku.Location = new System.Drawing.Point(468, 43);
            this.prodSku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodSku.Name = "prodSku";
            this.prodSku.Size = new System.Drawing.Size(313, 23);
            this.prodSku.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "SKU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Product Category";
            // 
            // prodName
            // 
            this.prodName.Location = new System.Drawing.Point(48, 43);
            this.prodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(352, 23);
            this.prodName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product name";
            // 
            // prodId
            // 
            this.prodId.Location = new System.Drawing.Point(310, 284);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(100, 23);
            this.prodId.TabIndex = 24;
            this.prodId.Visible = false;
            // 
            // prodDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.prodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDataGridView.Location = new System.Drawing.Point(48, 332);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersVisible = false;
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.RowTemplate.Height = 24;
            this.prodDataGridView.Size = new System.Drawing.Size(776, 243);
            this.prodDataGridView.TabIndex = 25;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.prodDataGridView.ThemeStyle.ReadOnly = false;
            this.prodDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.prodDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodMan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prodSku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox prodCat;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox prodStockAlert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox prodPurPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button delProduct;
        private System.Windows.Forms.Button updtProduct;
        private System.Windows.Forms.ComboBox selectCat;
        private System.Windows.Forms.Button refProduct;
        private System.Windows.Forms.TextBox prodQuant;
        private System.Windows.Forms.TextBox prodRetPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prodId;
        private Guna.UI2.WinForms.Guna2DataGridView prodDataGridView;
    }
}