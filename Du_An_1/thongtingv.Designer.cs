namespace Du_An_1
{
    partial class thongtingv
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
            dateTimePicker1 = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            dgvGiangVien = new DataGridView();
            txbMatk = new DataGridViewTextBoxColumn();
            txbMagv = new DataGridViewTextBoxColumn();
            txbTengv = new DataGridViewTextBoxColumn();
            txbNgaysinh = new DataGridViewTextBoxColumn();
            Gioi_tinh = new DataGridViewTextBoxColumn();
            txbemail = new DataGridViewTextBoxColumn();
            Txbsdt = new DataGridViewTextBoxColumn();
            TbxMaGV = new TextBox();
            TbxEmail = new TextBox();
            TbxSDT = new TextBox();
            TbxTenGV = new TextBox();
            TbxMaTK = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label9 = new Label();
            txbtimkiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(395, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(820, 151);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 41;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(706, 151);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 40;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(760, 125);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 39;
            label8.Text = "Giới tính";
            // 
            // dgvGiangVien
            // 
            dgvGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiangVien.Columns.AddRange(new DataGridViewColumn[] { txbMatk, txbMagv, txbTengv, txbNgaysinh, Gioi_tinh, txbemail, Txbsdt });
            dgvGiangVien.Location = new Point(46, 370);
            dgvGiangVien.Name = "dgvGiangVien";
            dgvGiangVien.RowHeadersWidth = 51;
            dgvGiangVien.RowTemplate.Height = 29;
            dgvGiangVien.Size = new Size(887, 188);
            dgvGiangVien.TabIndex = 38;
            dgvGiangVien.CellClick += dgvGiangVien_CellClick;
            // 
            // txbMatk
            // 
            txbMatk.DataPropertyName = "MaTK";
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
            // txbTengv
            // 
            txbTengv.DataPropertyName = "Ten";
            txbTengv.HeaderText = "TênGV";
            txbTengv.MinimumWidth = 6;
            txbTengv.Name = "txbTengv";
            txbTengv.Width = 125;
            // 
            // txbNgaysinh
            // 
            txbNgaysinh.DataPropertyName = "Ngaysinh";
            txbNgaysinh.HeaderText = "Ngày sinh";
            txbNgaysinh.MinimumWidth = 6;
            txbNgaysinh.Name = "txbNgaysinh";
            txbNgaysinh.Width = 125;
            // 
            // Gioi_tinh
            // 
            Gioi_tinh.DataPropertyName = "Gioi_tinh";
            Gioi_tinh.HeaderText = "Giới tính";
            Gioi_tinh.MinimumWidth = 6;
            Gioi_tinh.Name = "Gioi_tinh";
            Gioi_tinh.Width = 125;
            // 
            // txbemail
            // 
            txbemail.DataPropertyName = "Email";
            txbemail.HeaderText = "Email";
            txbemail.MinimumWidth = 6;
            txbemail.Name = "txbemail";
            txbemail.Width = 125;
            // 
            // Txbsdt
            // 
            Txbsdt.DataPropertyName = "Sdt";
            Txbsdt.HeaderText = "SĐT";
            Txbsdt.MinimumWidth = 6;
            Txbsdt.Name = "Txbsdt";
            Txbsdt.Width = 125;
            // 
            // TbxMaGV
            // 
            TbxMaGV.Location = new Point(84, 315);
            TbxMaGV.Name = "TbxMaGV";
            TbxMaGV.ReadOnly = true;
            TbxMaGV.Size = new Size(211, 27);
            TbxMaGV.TabIndex = 37;
            // 
            // TbxEmail
            // 
            TbxEmail.Location = new Point(395, 148);
            TbxEmail.Name = "TbxEmail";
            TbxEmail.ReadOnly = true;
            TbxEmail.Size = new Size(211, 27);
            TbxEmail.TabIndex = 36;
            // 
            // TbxSDT
            // 
            TbxSDT.Location = new Point(395, 315);
            TbxSDT.Name = "TbxSDT";
            TbxSDT.ReadOnly = true;
            TbxSDT.Size = new Size(211, 27);
            TbxSDT.TabIndex = 35;
            // 
            // TbxTenGV
            // 
            TbxTenGV.Location = new Point(84, 231);
            TbxTenGV.Name = "TbxTenGV";
            TbxTenGV.ReadOnly = true;
            TbxTenGV.Size = new Size(211, 27);
            TbxTenGV.TabIndex = 34;
            // 
            // TbxMaTK
            // 
            TbxMaTK.Location = new Point(84, 148);
            TbxMaTK.Name = "TbxMaTK";
            TbxMaTK.ReadOnly = true;
            TbxMaTK.Size = new Size(211, 27);
            TbxMaTK.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 292);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 32;
            label7.Text = "MãGV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 208);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 31;
            label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 292);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 29;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 208);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 28;
            label2.Text = "TênGV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 27;
            label4.Text = "Mã TK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(307, 29);
            label1.Name = "label1";
            label1.Size = new Size(370, 47);
            label1.TabIndex = 26;
            label1.Text = "Thông Tin Giảng Viên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(775, 292);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 43;
            label9.Text = "Tìm kiếm";
            // 
            // txbtimkiem
            // 
            txbtimkiem.Location = new Point(706, 315);
            txbtimkiem.Name = "txbtimkiem";
            txbtimkiem.Size = new Size(211, 27);
            txbtimkiem.TabIndex = 44;
            txbtimkiem.TextChanged += txbtimkiem_TextChanged;
            // 
            // thongtingv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(979, 587);
            Controls.Add(txbtimkiem);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(dgvGiangVien);
            Controls.Add(TbxMaGV);
            Controls.Add(TbxEmail);
            Controls.Add(TbxSDT);
            Controls.Add(TbxTenGV);
            Controls.Add(TbxMaTK);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "thongtingv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "thongtingv";
            Load += thongtingv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private DataGridView dgvGiangVien;
        private DataGridViewTextBoxColumn txbMatk;
        private DataGridViewTextBoxColumn txbMagv;
        private DataGridViewTextBoxColumn txbTengv;
        private DataGridViewTextBoxColumn txbNgaysinh;
        private DataGridViewTextBoxColumn Gioi_tinh;
        private DataGridViewTextBoxColumn txbemail;
        private DataGridViewTextBoxColumn Txbsdt;
        private TextBox TbxMaGV;
        private TextBox TbxEmail;
        private TextBox TbxSDT;
        private TextBox TbxTenGV;
        private TextBox TbxMaTK;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private TextBox txbtimkiem;
    }
}