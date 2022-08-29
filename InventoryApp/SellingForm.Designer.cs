
namespace InventoryApp
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.product_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delProduct = new System.Windows.Forms.Button();
            this.updtProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.prodDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.datetime = new System.Windows.Forms.Label();
            this.seller_name = new System.Windows.Forms.Label();
            this.OrderDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.total_amt = new System.Windows.Forms.Label();
            this.amount_pay = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.orderAdd = new System.Windows.Forms.Button();
            this.seller_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.seller_id);
            this.panel1.Controls.Add(this.orderAdd);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.amount_pay);
            this.panel1.Controls.Add(this.total_amt);
            this.panel1.Controls.Add(this.OrderDataGridView1);
            this.panel1.Controls.Add(this.seller_name);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.prodDataGridView);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.prodQuant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prodPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.product_name);
            this.panel1.Location = new System.Drawing.Point(-4, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 654);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product_name.Location = new System.Drawing.Point(52, 50);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(125, 20);
            this.product_name.TabIndex = 0;
            this.product_name.Text = "Product Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.delProduct);
            this.panel2.Controls.Add(this.updtProduct);
            this.panel2.Controls.Add(this.addProduct);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-4, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 59);
            this.panel2.TabIndex = 2;
            // 
            // delProduct
            // 
            this.delProduct.BackColor = System.Drawing.Color.Red;
            this.delProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delProduct.Location = new System.Drawing.Point(1024, 9);
            this.delProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delProduct.Name = "delProduct";
            this.delProduct.Size = new System.Drawing.Size(88, 36);
            this.delProduct.TabIndex = 3;
            this.delProduct.Text = "Delete";
            this.delProduct.UseVisualStyleBackColor = false;
            // 
            // updtProduct
            // 
            this.updtProduct.BackColor = System.Drawing.Color.Orange;
            this.updtProduct.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updtProduct.Location = new System.Drawing.Point(916, 10);
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
            this.addProduct.Location = new System.Drawing.Point(832, 9);
            this.addProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(83, 36);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(508, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sell Product";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // prodName
            // 
            this.prodName.Enabled = false;
            this.prodName.Font = new System.Drawing.Font("Inter", 10.2F);
            this.prodName.Location = new System.Drawing.Point(184, 47);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(151, 28);
            this.prodName.TabIndex = 1;
            // 
            // prodPrice
            // 
            this.prodPrice.Enabled = false;
            this.prodPrice.Font = new System.Drawing.Font("Inter", 10.2F);
            this.prodPrice.Location = new System.Drawing.Point(184, 94);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(151, 28);
            this.prodPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Price";
            // 
            // prodQuant
            // 
            this.prodQuant.Font = new System.Drawing.Font("Inter", 10.2F);
            this.prodQuant.Location = new System.Drawing.Point(184, 144);
            this.prodQuant.Name = "prodQuant";
            this.prodQuant.Size = new System.Drawing.Size(151, 28);
            this.prodQuant.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.Orange;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(56, 191);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(172, 28);
            this.category.TabIndex = 6;
            this.category.Text = "Select Category";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Orange;
            this.refresh.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresh.Location = new System.Drawing.Point(234, 188);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(101, 36);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // prodDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.prodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.prodDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.prodDataGridView.Location = new System.Drawing.Point(56, 248);
            this.prodDataGridView.Name = "prodDataGridView";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.RowTemplate.Height = 24;
            this.prodDataGridView.Size = new System.Drawing.Size(347, 379);
            this.prodDataGridView.TabIndex = 7;
            this.prodDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Orange;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.prodDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.prodDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.prodDataGridView.ThemeStyle.ReadOnly = false;
            this.prodDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.prodDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.prodDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.prodDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.prodDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Font = new System.Drawing.Font("Inter", 10.2F);
            this.datetime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datetime.Location = new System.Drawing.Point(970, 15);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(47, 20);
            this.datetime.TabIndex = 8;
            this.datetime.Text = "Date";
            // 
            // seller_name
            // 
            this.seller_name.AutoSize = true;
            this.seller_name.Font = new System.Drawing.Font("Inter", 10.2F);
            this.seller_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seller_name.Location = new System.Drawing.Point(844, 17);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(57, 20);
            this.seller_name.TabIndex = 9;
            this.seller_name.Text = "Name";
            // 
            // OrderDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.OrderDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.orderName,
            this.proPrice,
            this.orderQuant,
            this.orderTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDataGridView1.Location = new System.Drawing.Point(477, 50);
            this.OrderDataGridView1.Name = "OrderDataGridView1";
            this.OrderDataGridView1.RowHeadersVisible = false;
            this.OrderDataGridView1.RowHeadersWidth = 51;
            this.OrderDataGridView1.RowTemplate.Height = 24;
            this.OrderDataGridView1.Size = new System.Drawing.Size(635, 233);
            this.OrderDataGridView1.TabIndex = 10;
            this.OrderDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrderDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView1.ThemeStyle.HeaderStyle.Height = 19;
            this.OrderDataGridView1.ThemeStyle.ReadOnly = false;
            this.OrderDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.OrderDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridView1_CellContentClick);
            // 
            // total_amt
            // 
            this.total_amt.AutoSize = true;
            this.total_amt.Font = new System.Drawing.Font("Inter", 10.2F);
            this.total_amt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total_amt.Location = new System.Drawing.Point(856, 291);
            this.total_amt.Name = "total_amt";
            this.total_amt.Size = new System.Drawing.Size(133, 20);
            this.total_amt.TabIndex = 11;
            this.total_amt.Text = "Amount to Pay:";
            // 
            // amount_pay
            // 
            this.amount_pay.Enabled = false;
            this.amount_pay.Location = new System.Drawing.Point(1012, 291);
            this.amount_pay.Name = "amount_pay";
            this.amount_pay.Size = new System.Drawing.Size(100, 22);
            this.amount_pay.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // orderName
            // 
            this.orderName.HeaderText = "Name";
            this.orderName.MinimumWidth = 6;
            this.orderName.Name = "orderName";
            // 
            // proPrice
            // 
            this.proPrice.HeaderText = "Price";
            this.proPrice.MinimumWidth = 6;
            this.proPrice.Name = "proPrice";
            // 
            // orderQuant
            // 
            this.orderQuant.HeaderText = "Quantity";
            this.orderQuant.MinimumWidth = 6;
            this.orderQuant.Name = "orderQuant";
            // 
            // orderTotal
            // 
            this.orderTotal.HeaderText = "Total";
            this.orderTotal.MinimumWidth = 6;
            this.orderTotal.Name = "orderTotal";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(477, 321);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(635, 230);
            this.guna2DataGridView1.TabIndex = 13;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // orderAdd
            // 
            this.orderAdd.BackColor = System.Drawing.Color.Orange;
            this.orderAdd.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderAdd.Location = new System.Drawing.Point(501, 556);
            this.orderAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderAdd.Name = "orderAdd";
            this.orderAdd.Size = new System.Drawing.Size(83, 36);
            this.orderAdd.TabIndex = 4;
            this.orderAdd.Text = "Add";
            this.orderAdd.UseVisualStyleBackColor = false;
            this.orderAdd.Click += new System.EventHandler(this.orderAdd_Click);
            // 
            // seller_id
            // 
            this.seller_id.Location = new System.Drawing.Point(693, 558);
            this.seller_id.Name = "seller_id";
            this.seller_id.Size = new System.Drawing.Size(100, 22);
            this.seller_id.TabIndex = 14;
            this.seller_id.Visible = false;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delProduct;
        private System.Windows.Forms.Button updtProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView prodDataGridView;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox prodQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label seller_name;
        private Guna.UI2.WinForms.Guna2DataGridView OrderDataGridView1;
        private System.Windows.Forms.TextBox amount_pay;
        private System.Windows.Forms.Label total_amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotal;
        private System.Windows.Forms.Button orderAdd;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.TextBox seller_id;
    }
}