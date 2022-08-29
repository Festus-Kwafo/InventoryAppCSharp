
namespace InventoryApp
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.panel3 = new System.Windows.Forms.Panel();
            this.userGridDataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userId = new System.Windows.Forms.TextBox();
            this.dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userDelete = new System.Windows.Forms.Button();
            this.userUpdate = new System.Windows.Forms.Button();
            this.userAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userGridDataView);
            this.panel3.Controls.Add(this.userId);
            this.panel3.Controls.Add(this.dob);
            this.panel3.Controls.Add(this.email);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lastname);
            this.panel3.Controls.Add(this.last_name);
            this.panel3.Controls.Add(this.confirm_password);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.first_name);
            this.panel3.Controls.Add(this.product_name);
            this.panel3.Location = new System.Drawing.Point(240, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 595);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // userGridDataView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userGridDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGridDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userGridDataView.ColumnHeadersHeight = 4;
            this.userGridDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGridDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userGridDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGridDataView.Location = new System.Drawing.Point(48, 331);
            this.userGridDataView.Name = "userGridDataView";
            this.userGridDataView.RowHeadersVisible = false;
            this.userGridDataView.RowHeadersWidth = 51;
            this.userGridDataView.RowTemplate.Height = 24;
            this.userGridDataView.Size = new System.Drawing.Size(775, 261);
            this.userGridDataView.TabIndex = 35;
            this.userGridDataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userGridDataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userGridDataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userGridDataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userGridDataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userGridDataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userGridDataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGridDataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userGridDataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userGridDataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGridDataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userGridDataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userGridDataView.ThemeStyle.HeaderStyle.Height = 4;
            this.userGridDataView.ThemeStyle.ReadOnly = false;
            this.userGridDataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userGridDataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userGridDataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGridDataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGridDataView.ThemeStyle.RowsStyle.Height = 24;
            this.userGridDataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGridDataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGridDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridDataView_CellContentClick_1);
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(48, 228);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(100, 22);
            this.userId.TabIndex = 34;
            this.userId.Visible = false;
            // 
            // dob
            // 
            this.dob.Checked = true;
            this.dob.FillColor = System.Drawing.Color.White;
            this.dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(48, 109);
            this.dob.MaxDate = new System.DateTime(2022, 8, 27, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(352, 34);
            this.dob.TabIndex = 33;
            this.dob.Value = new System.DateTime(2022, 8, 27, 0, 0, 0, 0);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(436, 110);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(352, 22);
            this.email.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Email";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(436, 43);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(352, 22);
            this.lastname.TabIndex = 30;
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(432, 15);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(110, 24);
            this.last_name.TabIndex = 29;
            this.last_name.Text = "Last Name";
            // 
            // confirm_password
            // 
            this.confirm_password.Location = new System.Drawing.Point(436, 183);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(352, 22);
            this.confirm_password.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(432, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Confirm Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(48, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(352, 22);
            this.password.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(730, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 36);
            this.button4.TabIndex = 21;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(48, 43);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(352, 22);
            this.first_name.TabIndex = 1;
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(44, 15);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(112, 24);
            this.product_name.TabIndex = 0;
            this.product_name.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 706);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(13, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Categories";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(13, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Product";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "User Management";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.userDelete);
            this.panel2.Controls.Add(this.userUpdate);
            this.panel2.Controls.Add(this.userAdd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 59);
            this.panel2.TabIndex = 25;
            // 
            // userDelete
            // 
            this.userDelete.BackColor = System.Drawing.Color.Red;
            this.userDelete.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userDelete.Location = new System.Drawing.Point(829, 11);
            this.userDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDelete.Name = "userDelete";
            this.userDelete.Size = new System.Drawing.Size(88, 36);
            this.userDelete.TabIndex = 35;
            this.userDelete.Text = "Delete";
            this.userDelete.UseVisualStyleBackColor = false;
            this.userDelete.Click += new System.EventHandler(this.userDelete_Click);
            // 
            // userUpdate
            // 
            this.userUpdate.BackColor = System.Drawing.Color.Orange;
            this.userUpdate.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userUpdate.Location = new System.Drawing.Point(721, 12);
            this.userUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userUpdate.Name = "userUpdate";
            this.userUpdate.Size = new System.Drawing.Size(101, 36);
            this.userUpdate.TabIndex = 34;
            this.userUpdate.Text = "Update";
            this.userUpdate.UseVisualStyleBackColor = false;
            // 
            // userAdd
            // 
            this.userAdd.BackColor = System.Drawing.Color.Orange;
            this.userAdd.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userAdd.Location = new System.Drawing.Point(622, 12);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(93, 36);
            this.userAdd.TabIndex = 33;
            this.userAdd.Text = "Add";
            this.userAdd.UseVisualStyleBackColor = false;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(314, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Attendant User";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button userAdd;
        private System.Windows.Forms.Button userDelete;
        private System.Windows.Forms.Button userUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DateTimePicker dob;
        private System.Windows.Forms.TextBox userId;
        private Guna.UI2.WinForms.Guna2DataGridView userGridDataView;
    }
}