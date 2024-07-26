namespace Du_An_1
{
    partial class Admin2
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
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dgvGiangVien = new DataGridView();
            txbMatk = new DataGridViewTextBoxColumn();
            txbMagv = new DataGridViewTextBoxColumn();
            Txbsdt = new DataGridViewTextBoxColumn();
            txbemail = new DataGridViewTextBoxColumn();
            txbNgaysinh = new DataGridViewTextBoxColumn();
            txbTengv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(241, 42);
            label1.Name = "label1";
            label1.Size = new Size(293, 37);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Giảng Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 114);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Mã TK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 185);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "TênGV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 251);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 11;
            label3.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 114);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 185);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(558, 251);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 14;
            label7.Text = "MãGV";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 131);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 202);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 268);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(476, 131);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(207, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(476, 202);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(207, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(476, 268);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(207, 23);
            textBox6.TabIndex = 20;
            // 
            // dgvGiangVien
            // 
            dgvGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiangVien.Columns.AddRange(new DataGridViewColumn[] { txbMatk, txbMagv, Txbsdt, txbemail, txbNgaysinh, txbTengv });
            dgvGiangVien.Location = new Point(12, 298);
            dgvGiangVien.Margin = new Padding(3, 2, 3, 2);
            dgvGiangVien.Name = "dgvGiangVien";
            dgvGiangVien.RowHeadersWidth = 51;
            dgvGiangVien.RowTemplate.Height = 29;
            dgvGiangVien.Size = new Size(776, 141);
            dgvGiangVien.TabIndex = 21;
            // 
            // txbMatk
            // 
            txbMatk.DataPropertyName = "Ma TK";
            txbMatk.HeaderText = "Mã TK";
            txbMatk.MinimumWidth = 6;
            txbMatk.Name = "txbMatk";
            txbMatk.Width = 125;
            // 
            // txbMagv
            // 
            txbMagv.DataPropertyName = "Magv";
            txbMagv.HeaderText = "Mã GV";
            txbMagv.MinimumWidth = 6;
            txbMagv.Name = "txbMagv";
            txbMagv.Width = 125;
            // 
            // Txbsdt
            // 
            Txbsdt.DataPropertyName = "Sdt";
            Txbsdt.HeaderText = "SĐT";
            Txbsdt.MinimumWidth = 6;
            Txbsdt.Name = "Txbsdt";
            Txbsdt.Width = 125;
            // 
            // txbemail
            // 
            txbemail.DataPropertyName = "Email";
            txbemail.HeaderText = "Email";
            txbemail.MinimumWidth = 6;
            txbemail.Name = "txbemail";
            txbemail.Width = 125;
            // 
            // txbNgaysinh
            // 
            txbNgaysinh.DataPropertyName = "Ngaysinh";
            txbNgaysinh.HeaderText = "Ngày sinh";
            txbNgaysinh.MinimumWidth = 6;
            txbNgaysinh.Name = "txbNgaysinh";
            txbNgaysinh.Width = 125;
            // 
            // txbTengv
            // 
            txbTengv.DataPropertyName = "Ten";
            txbTengv.HeaderText = "TênGV";
            txbTengv.MinimumWidth = 6;
            txbTengv.Name = "txbTengv";
            txbTengv.Width = 125;
            // 
            // Admin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGiangVien);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Admin2";
            Text = "Admin2";
            Load += Admin2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dgvGiangVien;
        private DataGridViewTextBoxColumn txbMatk;
        private DataGridViewTextBoxColumn txbMagv;
        private DataGridViewTextBoxColumn Txbsdt;
        private DataGridViewTextBoxColumn txbemail;
        private DataGridViewTextBoxColumn txbNgaysinh;
        private DataGridViewTextBoxColumn txbTengv;
    }
}