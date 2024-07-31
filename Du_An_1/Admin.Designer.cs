namespace Du_An_1
{
    partial class Admin
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
            tabPage2 = new TabPage();
            bntThongKe = new Button();
            btnSapXep = new Button();
            rdoTb = new RadioButton();
            rdoKha = new RadioButton();
            rdoGioi = new RadioButton();
            rdoXuatSac = new RadioButton();
            rdoTruot = new RadioButton();
            dgvThongKe = new DataGridView();
            tabPage1 = new TabPage();
            comboBox1 = new ComboBox();
            label22 = new Label();
            txtMaTK = new TextBox();
            txtQueQuan = new TextBox();
            txtSDT = new TextBox();
            txtDiemDia = new TextBox();
            txtDiemSu = new TextBox();
            txtTimkiem = new TextBox();
            txtDiemVan = new TextBox();
            txtDiemTiengAnh = new TextBox();
            txtDiemToan = new TextBox();
            txtEmail = new TextBox();
            txtTenSv = new TextBox();
            txtMaSv = new TextBox();
            label21 = new Label();
            label11 = new Label();
            label10 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label12 = new Label();
            dgvDanhSachSV = new DataGridView();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Turquoise;
            tabPage2.Controls.Add(bntThongKe);
            tabPage2.Controls.Add(btnSapXep);
            tabPage2.Controls.Add(rdoTb);
            tabPage2.Controls.Add(rdoKha);
            tabPage2.Controls.Add(rdoGioi);
            tabPage2.Controls.Add(rdoXuatSac);
            tabPage2.Controls.Add(rdoTruot);
            tabPage2.Controls.Add(dgvThongKe);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(1038, 629);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thống kê";
            // 
            // bntThongKe
            // 
            bntThongKe.Location = new Point(533, 131);
            bntThongKe.Margin = new Padding(2, 3, 2, 3);
            bntThongKe.Name = "bntThongKe";
            bntThongKe.Size = new Size(150, 43);
            bntThongKe.TabIndex = 9;
            bntThongKe.Text = "Thống kê";
            bntThongKe.UseVisualStyleBackColor = true;
            bntThongKe.Click += bntThongKe_Click;
            // 
            // btnSapXep
            // 
            btnSapXep.Location = new Point(533, 47);
            btnSapXep.Margin = new Padding(2, 3, 2, 3);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(150, 55);
            btnSapXep.TabIndex = 8;
            btnSapXep.Text = "Sắp xếp theo điểm";
            btnSapXep.UseVisualStyleBackColor = true;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // rdoTb
            // 
            rdoTb.AutoSize = true;
            rdoTb.Location = new Point(322, 47);
            rdoTb.Margin = new Padding(2, 3, 2, 3);
            rdoTb.Name = "rdoTb";
            rdoTb.Size = new Size(161, 24);
            rdoTb.TabIndex = 3;
            rdoTb.TabStop = true;
            rdoTb.Text = "Sinh viên trung bình";
            rdoTb.UseVisualStyleBackColor = true;
            // 
            // rdoKha
            // 
            rdoKha.AutoSize = true;
            rdoKha.Location = new Point(110, 131);
            rdoKha.Margin = new Padding(2, 3, 2, 3);
            rdoKha.Name = "rdoKha";
            rdoKha.Size = new Size(116, 24);
            rdoKha.TabIndex = 4;
            rdoKha.TabStop = true;
            rdoKha.Text = "Sinh viên khá";
            rdoKha.UseVisualStyleBackColor = true;
            // 
            // rdoGioi
            // 
            rdoGioi.AutoSize = true;
            rdoGioi.Location = new Point(109, 83);
            rdoGioi.Margin = new Padding(2, 3, 2, 3);
            rdoGioi.Name = "rdoGioi";
            rdoGioi.Size = new Size(119, 24);
            rdoGioi.TabIndex = 5;
            rdoGioi.TabStop = true;
            rdoGioi.Text = "Sinh viên giỏi";
            rdoGioi.UseVisualStyleBackColor = true;
            // 
            // rdoXuatSac
            // 
            rdoXuatSac.AutoSize = true;
            rdoXuatSac.Location = new Point(109, 40);
            rdoXuatSac.Margin = new Padding(2, 3, 2, 3);
            rdoXuatSac.Name = "rdoXuatSac";
            rdoXuatSac.Size = new Size(146, 24);
            rdoXuatSac.TabIndex = 6;
            rdoXuatSac.TabStop = true;
            rdoXuatSac.Text = "Sinh viên xuất sắc";
            rdoXuatSac.UseVisualStyleBackColor = true;
            // 
            // rdoTruot
            // 
            rdoTruot.AutoSize = true;
            rdoTruot.Location = new Point(322, 92);
            rdoTruot.Margin = new Padding(2, 3, 2, 3);
            rdoTruot.Name = "rdoTruot";
            rdoTruot.Size = new Size(126, 24);
            rdoTruot.TabIndex = 7;
            rdoTruot.TabStop = true;
            rdoTruot.Text = "Sinh viên trượt";
            rdoTruot.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(5, 245);
            dgvThongKe.Margin = new Padding(2, 3, 2, 3);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 62;
            dgvThongKe.RowTemplate.Height = 33;
            dgvThongKe.Size = new Size(1030, 333);
            dgvThongKe.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Turquoise;
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(txtMaTK);
            tabPage1.Controls.Add(txtQueQuan);
            tabPage1.Controls.Add(txtSDT);
            tabPage1.Controls.Add(txtDiemDia);
            tabPage1.Controls.Add(txtDiemSu);
            tabPage1.Controls.Add(txtTimkiem);
            tabPage1.Controls.Add(txtDiemVan);
            tabPage1.Controls.Add(txtDiemTiengAnh);
            tabPage1.Controls.Add(txtDiemToan);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtTenSv);
            tabPage1.Controls.Add(txtMaSv);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(dgvDanhSachSV);
            tabPage1.Controls.Add(btnThoat);
            tabPage1.Controls.Add(btnXoa);
            tabPage1.Controls.Add(btnSua);
            tabPage1.Controls.Add(btnThem);
            tabPage1.Controls.Add(rdoNu);
            tabPage1.Controls.Add(rdoNam);
            tabPage1.Controls.Add(dtpNgaySinh);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(1038, 629);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin sinh viên";
            tabPage1.Click += tabPage1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "L01", "L02", "L03" });
            comboBox1.Location = new Point(115, 509);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 28);
            comboBox1.TabIndex = 118;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(413, 264);
            label22.Name = "label22";
            label22.Size = new Size(70, 20);
            label22.TabIndex = 117;
            label22.Text = "Tìm kiếm";
            // 
            // txtMaTK
            // 
            txtMaTK.Location = new Point(115, 301);
            txtMaTK.Margin = new Padding(2, 3, 2, 3);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.ReadOnly = true;
            txtMaTK.Size = new Size(198, 27);
            txtMaTK.TabIndex = 116;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(115, 590);
            txtQueQuan.Margin = new Padding(2, 3, 2, 3);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(199, 27);
            txtQueQuan.TabIndex = 112;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(114, 550);
            txtSDT.Margin = new Padding(2, 3, 2, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(199, 27);
            txtSDT.TabIndex = 110;
            // 
            // txtDiemDia
            // 
            txtDiemDia.Location = new Point(503, 501);
            txtDiemDia.Margin = new Padding(2, 3, 2, 3);
            txtDiemDia.Name = "txtDiemDia";
            txtDiemDia.Size = new Size(218, 27);
            txtDiemDia.TabIndex = 107;
            // 
            // txtDiemSu
            // 
            txtDiemSu.Location = new Point(503, 462);
            txtDiemSu.Margin = new Padding(2, 3, 2, 3);
            txtDiemSu.Name = "txtDiemSu";
            txtDiemSu.Size = new Size(218, 27);
            txtDiemSu.TabIndex = 106;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(503, 261);
            txtTimkiem.Margin = new Padding(2, 3, 2, 3);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(310, 27);
            txtTimkiem.TabIndex = 103;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged_1;
            // 
            // txtDiemVan
            // 
            txtDiemVan.Location = new Point(503, 419);
            txtDiemVan.Margin = new Padding(2, 3, 2, 3);
            txtDiemVan.Name = "txtDiemVan";
            txtDiemVan.Size = new Size(218, 27);
            txtDiemVan.TabIndex = 88;
            // 
            // txtDiemTiengAnh
            // 
            txtDiemTiengAnh.Location = new Point(503, 377);
            txtDiemTiengAnh.Margin = new Padding(2, 3, 2, 3);
            txtDiemTiengAnh.Name = "txtDiemTiengAnh";
            txtDiemTiengAnh.Size = new Size(218, 27);
            txtDiemTiengAnh.TabIndex = 87;
            // 
            // txtDiemToan
            // 
            txtDiemToan.Location = new Point(503, 337);
            txtDiemToan.Margin = new Padding(2, 3, 2, 3);
            txtDiemToan.Name = "txtDiemToan";
            txtDiemToan.Size = new Size(218, 27);
            txtDiemToan.TabIndex = 86;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 466);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 27);
            txtEmail.TabIndex = 83;
            // 
            // txtTenSv
            // 
            txtTenSv.Location = new Point(117, 342);
            txtTenSv.Margin = new Padding(2, 3, 2, 3);
            txtTenSv.Name = "txtTenSv";
            txtTenSv.Size = new Size(198, 27);
            txtTenSv.TabIndex = 90;
            // 
            // txtMaSv
            // 
            txtMaSv.Location = new Point(115, 260);
            txtMaSv.Margin = new Padding(2, 3, 2, 3);
            txtMaSv.Name = "txtMaSv";
            txtMaSv.Size = new Size(198, 27);
            txtMaSv.TabIndex = 81;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(38, 306);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(51, 20);
            label21.TabIndex = 115;
            label21.Text = "Mã TK";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(403, 567);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 114;
            label11.Text = "Điểm Trung bình:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(584, 562);
            label10.Name = "label10";
            label10.Size = new Size(64, 35);
            label10.TabIndex = 113;
            label10.Text = "       ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(15, 601);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(75, 20);
            label20.TabIndex = 111;
            label20.Text = "Quê Quán";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(48, 561);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 109;
            label19.Text = "SĐT";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(399, 511);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(72, 20);
            label18.TabIndex = 108;
            label18.Text = "Điểm Địa";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(403, 473);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 105;
            label12.Text = "Điểm Sử";
            // 
            // dgvDanhSachSV
            // 
            dgvDanhSachSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSV.Location = new Point(2, 5);
            dgvDanhSachSV.Margin = new Padding(2, 3, 2, 3);
            dgvDanhSachSV.Name = "dgvDanhSachSV";
            dgvDanhSachSV.RowHeadersWidth = 62;
            dgvDanhSachSV.RowTemplate.Height = 33;
            dgvDanhSachSV.Size = new Size(1033, 232);
            dgvDanhSachSV.TabIndex = 71;
            dgvDanhSachSV.CellClick += dgvDanhSachSV_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(918, 568);
            btnThoat.Margin = new Padding(2, 3, 2, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 33);
            btnThoat.TabIndex = 101;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Image = Properties.Resources.kisspng_computer_icons_clip_art_check_mark_x_mark_astrolog_filegartoon_actions_cancel_svg_wikimedia_common_5c53792fbb7cb5_625824561548974383768;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(840, 457);
            btnXoa.Margin = new Padding(2, 3, 2, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 35);
            btnXoa.TabIndex = 100;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.Image = Properties.Resources.kisspng_pencil_ico_icon_pencil_icon_png_5aa1fc84aca021_6696863715205653807071;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(840, 392);
            btnSua.Margin = new Padding(2, 3, 2, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 34);
            btnSua.TabIndex = 99;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Image = Properties.Resources.green_add_button_12023;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(840, 337);
            btnThem.Margin = new Padding(2, 3, 2, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 35);
            btnThem.TabIndex = 97;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(224, 426);
            rdoNu.Margin = new Padding(2, 3, 2, 3);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 96;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(117, 426);
            rdoNam.Margin = new Padding(2, 3, 2, 3);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 95;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(115, 384);
            dtpNgaySinh.Margin = new Padding(2, 3, 2, 3);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(198, 27);
            dtpNgaySinh.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(397, 430);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 79;
            label9.Text = "Điểm Văn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 387);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 78;
            label8.Text = "Điểm Tiếng Anh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 347);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 77;
            label7.Text = "Điểm Toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 517);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 76;
            label6.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 474);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 75;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 426);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 74;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 388);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 73;
            label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 350);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 80;
            label2.Text = "Tên SV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 265);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 72;
            label1.Text = "Mã SV";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 15);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1046, 662);
            tabControl1.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 679);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Button bntThongKe;
        private Button btnSapXep;
        private RadioButton rdoTb;
        private RadioButton rdoKha;
        private RadioButton rdoGioi;
        private RadioButton rdoXuatSac;
        private RadioButton rdoTruot;
        private DataGridView dgvThongKe;
        private TabPage tabPage1;
        private Label label22;
        private TextBox txtMaTK;
        private TextBox txtQueQuan;
        private TextBox txtSDT;
        private TextBox txtDiemDia;
        private TextBox txtDiemSu;
        private TextBox txtTimkiem;
        private TextBox txtDiemVan;
        private TextBox txtDiemTiengAnh;
        private TextBox txtDiemToan;
        private TextBox txtEmail;
        private TextBox txtTenSv;
        private TextBox txtMaSv;
        private Label label21;
        private Label label11;
        private Label label10;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label12;
        private DataGridView dgvDanhSachSV;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private DateTimePicker dtpNgaySinh;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private ComboBox comboBox1;
    }
}