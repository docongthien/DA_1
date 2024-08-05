namespace Du_An_1
{
    partial class Thongtinsv
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
            txtDiaChi = new TextBox();
            label8 = new Label();
            datNgaySinh = new Label();
            dgvTTSinhVien = new DataGridView();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            txtLop = new TextBox();
            txtEmail = new TextBox();
            txtMasv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTTSinhVien).BeginInit();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(690, 224);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(236, 27);
            txtDiaChi.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(775, 202);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 69;
            label8.Text = "Dia Chi";
            // 
            // datNgaySinh
            // 
            datNgaySinh.AutoSize = true;
            datNgaySinh.Location = new Point(787, 107);
            datNgaySinh.Name = "datNgaySinh";
            datNgaySinh.Size = new Size(76, 20);
            datNgaySinh.TabIndex = 68;
            datNgaySinh.Text = "Ngay Sinh";
            // 
            // dgvTTSinhVien
            // 
            dgvTTSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTTSinhVien.Location = new Point(26, 352);
            dgvTTSinhVien.Name = "dgvTTSinhVien";
            dgvTTSinhVien.RowHeadersWidth = 51;
            dgvTTSinhVien.RowTemplate.Height = 29;
            dgvTTSinhVien.Size = new Size(887, 188);
            dgvTTSinhVien.TabIndex = 67;
            dgvTTSinhVien.CurrentCellChanged += dgvTTSinhVien_CurrentCellChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(383, 224);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(236, 27);
            txtSDT.TabIndex = 65;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(383, 130);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(236, 27);
            txtTen.TabIndex = 64;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(56, 312);
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = true;
            txtLop.Size = new Size(244, 27);
            txtLop.TabIndex = 63;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(56, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 62;
            // 
            // txtMasv
            // 
            txtMasv.Location = new Point(56, 130);
            txtMasv.Name = "txtMasv";
            txtMasv.ReadOnly = true;
            txtMasv.Size = new Size(244, 27);
            txtMasv.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 202);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 59;
            label6.Text = "So Dien Thoai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 107);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 58;
            label5.Text = "Ten HS";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 290);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 57;
            label3.Text = "Lop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 202);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 56;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 107);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 55;
            label4.Text = "Ma HS";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(293, 33);
            label1.Name = "label1";
            label1.Size = new Size(337, 47);
            label1.TabIndex = 54;
            label1.Text = "Thông Tin Học Sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(705, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 72;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(819, 290);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 73;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Thongtinsv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(953, 572);
            Controls.Add(btnThoat);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtDiaChi);
            Controls.Add(label8);
            Controls.Add(datNgaySinh);
            Controls.Add(dgvTTSinhVien);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(txtLop);
            Controls.Add(txtEmail);
            Controls.Add(txtMasv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Thongtinsv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thongtinsv";
            Load += Thongtinsv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTTSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiaChi;
        private Label label8;
        private Label datNgaySinh;
        private DataGridView dgvTTSinhVien;
        private TextBox txtSDT;
        private TextBox txtTen;
        private TextBox txtLop;
        private TextBox txtEmail;
        private TextBox txtMasv;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnThoat;
    }
}