﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Du_An_1
{
    public partial class Admin : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connect);
        public Admin()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string query = @"
            SELECT SV.Masv, TK.MaTK, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh, SV.Gioi_tinh, SV.Lop,
            Qldiem.Toan, Qldiem.Van, Qldiem.Anh, Qldiem.Su, Qldiem.Dia,
            (Qldiem.Toan + Qldiem.Van + Qldiem.Anh + Qldiem.Su + Qldiem.Dia) / 5.0 AS DiemTrungBinh
            FROM TK
			LEFT JOIN SV ON TK.MaTK = SV.MaTK
            LEFT JOIN Qldiem ON SV.Masv = Qldiem.Masv
			WHERE TK.Macv = 'CV3';";

            using (SqlCommand sqlmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = sqlmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvDanhSachSV.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void AddStudent(string masv, string matk, string ten, string email, string sdt, string que_quan, DateTime ngay_sinh, string lop, string gioitinh)
        {
            conn.Open();
            string querycheckmasv = $"select * from SV where Masv = '{txtMaSv.Text}'";
            using (SqlCommand command = new SqlCommand(querycheckmasv, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mã SV đã tồn tại");
                    }
                    else
                    {
                        reader.Close();
                        string query = @"
                                        INSERT INTO SV (Masv, MaTK, Ten, Email, Sdt, Que_quan, ngay_sinh, Lop, Gioi_tinh)
                                        VALUES (@Masv, @MaTK, @Ten, @Email, @Sdt, @Que_quan, @Ngay_sinh, @Lop, @Gioi_tinh)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Masv", masv);
                            cmd.Parameters.AddWithValue("@MaTK", matk);
                            cmd.Parameters.AddWithValue("@Ten", ten);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Sdt", sdt);
                            cmd.Parameters.AddWithValue("@Que_quan", que_quan);
                            cmd.Parameters.AddWithValue("@Ngay_sinh", ngay_sinh);
                            cmd.Parameters.AddWithValue("@Gioi_tinh", gioitinh);
                            cmd.Parameters.AddWithValue("@Lop", lop);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                }
            }

            }

            LoadData(); // Refresh data after adding
        }

        private void UpdateStudent(string masv, string ten, string email, string sdt, string que_quan, DateTime ngay_sinh, string lop, string gioitinh)
        {
            string query = @"
            UPDATE SV
            SET Ten = @Ten, Email = @Email, Sdt = @Sdt, Que_quan = @Que_quan, ngay_sinh = @Ngay_sinh, Lop = @Lop, Gioi_tinh = @Gioi_tinh
            WHERE Masv = @Masv";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Masv", masv);
                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sdt", sdt);
                cmd.Parameters.AddWithValue("@Que_quan", que_quan);
                cmd.Parameters.AddWithValue("@Ngay_sinh", ngay_sinh);
                cmd.Parameters.AddWithValue("@Gioi_tinh", gioitinh);

                cmd.Parameters.AddWithValue("@Lop", lop);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData(); // Refresh data after updating
        }
        private void UpdatediemStudent(float toan, float van, float anh, float su, float dia, string masv)
        {
            conn.Open();
            string querycheckmasv = $"select * from SV where Masv = '{txtMaSv.Text}'";
            using (SqlCommand command = new SqlCommand(querycheckmasv, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        string query = @"
                            update Qldiem 
                            SET Toan = @Toan ,Van = @Van ,Anh = @Anh ,Su = @Su ,Dia = @Dia  
                            WHERE Masv = @Masv ";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Masv", masv);
                            cmd.Parameters.AddWithValue("@Toan", toan);
                            cmd.Parameters.AddWithValue("@Van", van);
                            cmd.Parameters.AddWithValue("@Anh", anh);
                            cmd.Parameters.AddWithValue("@Su", su);
                            cmd.Parameters.AddWithValue("@dia", dia);

                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên có mã vừa nhập Không tồn tại!");

                    }
                }
            }



            LoadData(); // Refresh data after updating
        }
        private void DeleteStudent(string masv)
        {
            string query = @"
            DELETE FROM SV
            WHERE Masv = @Masv";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Masv", masv);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData(); // Refresh data after deleting
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                string masv = txtMaSv.Text;
                string matk = txtMaTK.Text;
                string ten = txtTenSv.Text;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string que_quan = txtQueQuan.Text;
                DateTime ngay_sinh = dtpNgaySinh.Value;
                string gioitinh = "";
                if (rdoNam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                if (rdoNu.Checked == true)
                {
                    gioitinh = "Nữ";
                }

                string lop = comboBox1.Text;

                AddStudent(masv, matk, ten, email, sdt, que_quan, ngay_sinh, lop, gioitinh);
                clear();
                MessageBox.Show("Thêm thành công");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput() && validatediem())
            {
                string masv = txtMaSv.Text;
                string ten = txtTenSv.Text;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string que_quan = txtQueQuan.Text;
                DateTime ngay_sinh = dtpNgaySinh.Value;
                string gioitinh = "";
                if (rdoNam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                if (rdoNu.Checked == true)
                {
                    gioitinh = "Nữ";
                }
                string lop = comboBox1.Text;

                UpdateStudent(masv, ten, email, sdt, que_quan, ngay_sinh, lop, gioitinh);

                float toan = float.Parse(txtDiemToan.Text);
                float van = float.Parse(txtDiemVan.Text);
                float anh = float.Parse(txtDiemTiengAnh.Text);
                float su = float.Parse(txtDiemSu.Text);
                float dia = float.Parse(txtDiemDia.Text);
                UpdatediemStudent(toan, van, anh, su, dia, masv);
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa Thất bại");
            }
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masv = txtMaSv.Text;

            if (string.IsNullOrWhiteSpace(masv))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để xóa.");
                return;
            }

            // Thực hiện kiểm tra thêm nếu cần

            DeleteStudent(masv);
            clear();
            MessageBox.Show("Xóa thành công");
        }

        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem người dùng có nhấp vào hàng không
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin sinh viên từ hàng đã chọn
                DataGridViewRow row = dgvDanhSachSV.Rows[e.RowIndex];

                txtMaSv.Text = row.Cells["Masv"].Value.ToString();
                txtMaTK.Text = row.Cells["MaTk"].Value.ToString();
                txtTenSv.Text = row.Cells["TenSV"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["Sdt"].Value.ToString();
                txtQueQuan.Text = row.Cells["Que_quan"].Value.ToString();
                txtDiemToan.Text = row.Cells["Toan"].Value.ToString();
                txtDiemVan.Text = row.Cells["Van"].Value.ToString();
                txtDiemTiengAnh.Text = row.Cells["Anh"].Value.ToString();
                txtDiemSu.Text = row.Cells["Su"].Value.ToString();
                txtDiemDia.Text = row.Cells["Dia"].Value.ToString();
                label10.Text = row.Cells["DiemTrungBinh"].Value.ToString();

                string checkngaysinh = row.Cells["ngay_sinh"].Value.ToString();
                if (checkngaysinh == "")
                {
                    dtpNgaySinh.Value = DateTime.Now;
                }
                else
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngay_sinh"].Value);
                }
                string gioitinh = row.Cells["Gioi_tinh"].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                if (gioitinh == "Nữ")
                {
                    rdoNu.Checked = true;
                }

                comboBox1.Text = row.Cells["Lop"].Value.ToString();
            }


        }
        private bool ValidateStudentInput()
        {
            // Kiểm tra các trường thông tin cần thiết
            if (string.IsNullOrWhiteSpace(txtMaSv.Text) ||

                string.IsNullOrWhiteSpace(txtTenSv.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtQueQuan.Text) ||

                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường thông tin.");
                return false;
            }

            // Kiểm tra định dạng email
            try
            {
                var mail = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.");
                return false;
            }

            // Kiểm tra định dạng số điện thoại (ví dụ: 10 chữ số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số.");
                return false;
            }

            // Thực hiện các kiểm tra khác nếu cần

            return true;
        }
        private bool validatediem()
        {
            if (string.IsNullOrEmpty(txtMaSv.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống.");
                txtMaSv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiemToan.Text)
                && string.IsNullOrEmpty(txtDiemVan.Text)
                && string.IsNullOrEmpty(txtDiemTiengAnh.Text)
                && string.IsNullOrEmpty(txtDiemSu.Text)
                && string.IsNullOrEmpty(txtDiemDia.Text))
            {
                txtDiemToan.Text = "0";
                txtDiemVan.Text = "0";
                txtDiemTiengAnh.Text = "0";
                txtDiemSu.Text = "0";
                txtDiemDia.Text = "0";
                return true;
            }

            if (float.TryParse(txtDiemToan.Text, out float diemtoan)
                && float.TryParse(txtDiemVan.Text, out float diemvan)
                && float.TryParse(txtDiemTiengAnh.Text, out float diemanh)
                && float.TryParse(txtDiemSu.Text, out float diemsu)
                && float.TryParse(txtDiemDia.Text, out float diemdia))
            {
                if (diemtoan >= 0 && diemtoan <= 10
                    && diemvan >= 0 && diemvan <= 10
                    && diemanh >= 0 && diemanh <= 10
                    && diemsu >= 0 && diemsu <= 10
                    && diemdia >= 0 && diemdia <= 10)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Điểm phải từ 0 đến 10.");
                    txtDiemToan.Focus();
                    txtDiemVan.Focus();
                    txtDiemTiengAnh.Focus();
                    txtDiemSu.Focus();
                    txtDiemDia.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show($"Điểm phải là số.");
                txtDiemToan.Focus();
                txtDiemVan.Focus();
                txtDiemTiengAnh.Focus();
                txtDiemSu.Focus();
                txtDiemDia.Focus();
                return false;
            }


        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimkiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ dữ liệu
                LoadData();
            }
            else
            {
                // Thực hiện tìm kiếm
                SearchStudent(searchTerm);
            }
        }

        private void SearchStudent(string searchTerm)
        {
            string query = @"
            SELECT SV.Masv, SV.MaTK, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh, SV.Lop
            FROM SV
            WHERE SV.Ten LIKE @SearchTerm OR 
                  SV.Email LIKE @SearchTerm OR 
                  SV.Sdt LIKE @SearchTerm OR 
                  SV.Que_quan LIKE @SearchTerm OR 
                  SV.Lop LIKE @SearchTerm";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvDanhSachSV.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimkiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ dữ liệu
                LoadData();
            }
            else
            {
                // Thực hiện tìm kiếm
                SearchStudent(searchTerm);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntThongKe_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT SV.Masv AS ID, 
                   SV.Ten AS HoTen, 
                   SV.ngay_sinh AS NgaySinh, 
                   CASE 
                       WHEN (YEAR(GETDATE()) - YEAR(SV.ngay_sinh)) % 2 = 0 THEN 'Nam'
                       ELSE 'Nu'
                   END AS GioiTinh,
                   SV.Email, 
                   SV.Lop,
                   QL.Toan, 
                   QL.Van, 
                   QL.Anh, 
                   QL.Su, 
                   QL.Dia,
                   (QL.Toan + QL.Van + QL.Anh + QL.Su + QL.Dia) / 5 AS DiemTrungBinh
            FROM SV
            INNER JOIN Qldiem QL ON SV.Masv = QL.Masv
            WHERE (QL.Toan + QL.Van + QL.Anh + QL.Su + QL.Dia) / 5 >= @MinDiemTb
            AND (QL.Toan + QL.Van + QL.Anh + QL.Su + QL.Dia) / 5 < @MaxDiemTb";

            double minDiemTb = 0;
            double maxDiemTb = 10;

            if (rdoXuatSac.Checked)
            {
                minDiemTb = 9;
                maxDiemTb = 10;
            }
            else if (rdoGioi.Checked)
            {
                minDiemTb = 8;
                maxDiemTb = 9;
            }
            else if (rdoKha.Checked)
            {
                minDiemTb = 6.5;
                maxDiemTb = 8;
            }
            else if (rdoTb.Checked)
            {
                minDiemTb = 5;
                maxDiemTb = 6.5;
            }
            else if (rdoTruot.Checked)
            {
                minDiemTb = 0;
                maxDiemTb = 5;
            }
            else
            {
                MessageBox.Show("Chọn loại bạn muốn thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connect))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MinDiemTb", minDiemTb);
                    command.Parameters.AddWithValue("@MaxDiemTb", maxDiemTb);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvThongKe.DataSource = dataTable;
                }
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT SV.Masv, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh, SV.Lop,
                   Qldiem.Toan, Qldiem.Van, Qldiem.Anh, Qldiem.Su, Qldiem.Dia,
                   (Qldiem.Toan + Qldiem.Van + Qldiem.Anh + Qldiem.Su + Qldiem.Dia) / 5.0 AS DiemTrungBinh
            FROM SV
            INNER JOIN Qldiem ON SV.Masv = Qldiem.Masv
            ORDER BY DiemTrungBinh DESC"; // Sắp xếp theo điểm trung bình từ cao đến thấp

            using (SqlCommand sqlmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = sqlmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvThongKe.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi sắp xếp dữ liệu: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txtMaSv.Text = "";
            txtMaTK.Text = "";
            txtTenSv.Text = "";
            txtEmail.Text = "";
            comboBox1.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text = "";
            txtDiemToan.Text = "";
            txtDiemVan.Text = "";
            txtDiemTiengAnh.Text = "";
            txtDiemSu.Text = "";
            txtDiemDia.Text = "";
            label10.Text = "";
            rdoNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                LoadData();
            }
            else
            {
                string query = @$"SELECT SV.Masv, TK.MaTK, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh, SV.Gioi_tinh, SV.Lop,
                                Qldiem.Toan, Qldiem.Van, Qldiem.Anh, Qldiem.Su, Qldiem.Dia,
                                (Qldiem.Toan + Qldiem.Van + Qldiem.Anh + Qldiem.Su + Qldiem.Dia) / 5.0 AS DiemTrungBinh
                                FROM TK
			                    LEFT JOIN SV ON TK.MaTK = SV.MaTK
                                LEFT JOIN Qldiem ON SV.Masv = Qldiem.Masv
			                    WHERE TK.Macv = 'CV3'
                                and TK.MaTK like '%{txtTimkiem.Text}%' 
								or SV.Masv like '%{txtTimkiem.Text}%' 
                                or TenSV like N'%{txtTimkiem.Text}%' ";
                SqlCommand sqlmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = sqlmd.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds.Tables.Add(dt);
                dgvDanhSachSV.DataSource = ds.Tables[0];
                reader.Close();
                conn.Close();
            }
        }
    }
}
