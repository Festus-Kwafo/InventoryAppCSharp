
namespace InventoryApp
{
    partial class CategoryForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.catDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refreshCat = new System.Windows.Forms.Button();
            this.catDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.catName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.catDelete = new System.Windows.Forms.Button();
            this.catUpdate = new System.Windows.Forms.Button();
            this.addCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catId = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.catId);
            this.panel3.Controls.Add(this.catDataGridView);
            this.panel3.Controls.Add(this.refreshCat);
            this.panel3.Controls.Add(this.catDescription);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.catName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(183, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 483);
            this.panel3.TabIndex = 3;
            // 
            // catDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.catDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.catDataGridView.ColumnHeadersHeight = 4;
            this.catDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.catDataGridView.GridColor = System.Drawing.Color.Orange;
            this.catDataGridView.Location = new System.Drawing.Point(2, 261);
            this.catDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.catDataGridView.Name = "catDataGridView";
            this.catDataGridView.RowHeadersVisible = false;
            this.catDataGridView.RowHeadersWidth = 51;
            this.catDataGridView.RowTemplate.Height = 24;
            this.catDataGridView.Size = new System.Drawing.Size(634, 220);
            this.catDataGridView.TabIndex = 22;
            this.catDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.catDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.catDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.catDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.catDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.catDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.catDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Orange;
            this.catDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.catDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.catDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.catDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.catDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.catDataGridView.ThemeStyle.ReadOnly = false;
            this.catDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.catDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.catDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.catDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.catDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.catDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.catDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // refreshCat
            // 
            this.refreshCat.BackColor = System.Drawing.Color.Orange;
            this.refreshCat.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshCat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshCat.Location = new System.Drawing.Point(548, 231);
            this.refreshCat.Margin = new System.Windows.Forms.Padding(2);
            this.refreshCat.Name = "refreshCat";
            this.refreshCat.Size = new System.Drawing.Size(70, 29);
            this.refreshCat.TabIndex = 21;
            this.refreshCat.Text = "Refresh";
            this.refreshCat.UseVisualStyleBackColor = false;
            this.refreshCat.Click += new System.EventHandler(this.button4_Click);
            // 
            // catDescription
            // 
            this.catDescription.Location = new System.Drawing.Point(36, 103);
            this.catDescription.Margin = new System.Windows.Forms.Padding(2);
            this.catDescription.Name = "catDescription";
            this.catDescription.Size = new System.Drawing.Size(236, 20);
            this.catDescription.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Product Description";
            // 
            // catName
            // 
            this.catName.Location = new System.Drawing.Point(36, 35);
            this.catName.Margin = new System.Windows.Forms.Padding(2);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(265, 20);
            this.catName.TabIndex = 1;
            this.catName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.catDelete);
            this.panel2.Controls.Add(this.catUpdate);
            this.panel2.Controls.Add(this.addCart);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(142, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 48);
            this.panel2.TabIndex = 4;
            // 
            // catDelete
            // 
            this.catDelete.BackColor = System.Drawing.Color.Red;
            this.catDelete.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.catDelete.Location = new System.Drawing.Point(616, 11);
            this.catDelete.Margin = new System.Windows.Forms.Padding(2);
            this.catDelete.Name = "catDelete";
            this.catDelete.Size = new System.Drawing.Size(66, 29);
            this.catDelete.TabIndex = 3;
            this.catDelete.Text = "Delete";
            this.catDelete.UseVisualStyleBackColor = false;
            this.catDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // catUpdate
            // 
            this.catUpdate.BackColor = System.Drawing.Color.Orange;
            this.catUpdate.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.catUpdate.Location = new System.Drawing.Point(535, 12);
            this.catUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.catUpdate.Name = "catUpdate";
            this.catUpdate.Size = new System.Drawing.Size(76, 29);
            this.catUpdate.TabIndex = 2;
            this.catUpdate.Text = "Update";
            this.catUpdate.UseVisualStyleBackColor = false;
            this.catUpdate.Click += new System.EventHandler(this.catUpdate_Click);
            // 
            // addCart
            // 
            this.addCart.BackColor = System.Drawing.Color.Orange;
            this.addCart.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCart.Location = new System.Drawing.Point(472, 11);
            this.addCart.Margin = new System.Windows.Forms.Padding(2);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(62, 29);
            this.addCart.TabIndex = 1;
            this.addCart.Text = "Add";
            this.addCart.UseVisualStyleBackColor = false;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(286, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 574);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // catId
            // 
            this.catId.Location = new System.Drawing.Point(361, 35);
            this.catId.Name = "catId";
            this.catId.Size = new System.Drawing.Size(100, 20);
            this.catId.TabIndex = 23;
            this.catId.Visible = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refreshCat;
        private System.Windows.Forms.TextBox catName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button catDelete;
        private System.Windows.Forms.Button catUpdate;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox catDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView catDataGridView;
        private System.Windows.Forms.TextBox catId;
    }
}