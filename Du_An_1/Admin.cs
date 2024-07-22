using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_An_1
{
    public partial class Admin : Form
    {
        static string connect = @"Server=XUANTRUONG\\SQLEXPRESS;Catalog=QLSVDA1;User ID=sa;Password=123456;TrustServerCertificate=True";
        static SqlConnection conn = new SqlConnection(connect);
        public Admin()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string query = @"
            SELECT SV.Masv, SV.MaTK, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh, SV.Img, SV.Lop
            FROM SV";

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

        private void AddStudent(string masv, string ten, string email, string sdt, string que_quan, DateTime ngay_sinh, string lop)
        {
            string query = @"
            INSERT INTO SV (Masv, Ten, Email, Sdt, Que_quan, ngay_sinh, Img, Lop)
            VALUES (@Masv, @MaTK, @Ten, @Email, @Sdt, @Que_quan, @Ngay_sinh, @Img, @Lop)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Masv", masv);

                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sdt", sdt);
                cmd.Parameters.AddWithValue("@Que_quan", que_quan);
                cmd.Parameters.AddWithValue("@Ngay_sinh", ngay_sinh);

                cmd.Parameters.AddWithValue("@Lop", lop);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadData(); // Refresh data after adding
        }

        private void UpdateStudent(string masv, string ten, string email, string sdt, string que_quan, DateTime ngay_sinh, string lop)
        {
            string query = @"
            UPDATE SV
            SET Ten = @Ten, Email = @Email, Sdt = @Sdt, Que_quan = @Que_quan, ngay_sinh = @Ngay_sinh, Img = @Img, Lop = @Lop
            WHERE Masv = @Masv";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Masv", masv);
                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sdt", sdt);
                cmd.Parameters.AddWithValue("@Que_quan", que_quan);
                cmd.Parameters.AddWithValue("@Ngay_sinh", ngay_sinh);

                cmd.Parameters.AddWithValue("@Lop", lop);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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
                
                string ten = txtTenSv.Text;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string que_quan = txtQueQuan.Text;
                DateTime ngay_sinh = dtpNgaySinh.Value;
                
                string lop = txtLop.Text;

                AddStudent(masv, ten, email, sdt, que_quan, ngay_sinh, lop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                string masv = txtMaSv.Text;
                string ten = txtTenSv.Text;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string que_quan = txtQueQuan.Text;
                DateTime ngay_sinh = dtpNgaySinh.Value;
                
                string lop = txtLop.Text;

                UpdateStudent(masv, ten, email, sdt, que_quan, ngay_sinh, lop);
            }
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
        }

        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Kiểm tra xem người dùng có nhấp vào hàng không
                if (e.RowIndex >= 0)
                {
                    // Lấy thông tin sinh viên từ hàng đã chọn
                    DataGridViewRow row = dgvDanhSachSV.Rows[e.RowIndex];

                    txtMaSv.Text = row.Cells["Masv"].Value.ToString();
                    
                    txtTenSv.Text = row.Cells["TenSV"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtSDT.Text = row.Cells["Sdt"].Value.ToString();
                    txtQueQuan.Text = row.Cells["Que_quan"].Value.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngay_sinh"].Value);
                    
                    txtLop.Text = row.Cells["Lop"].Value.ToString();
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
                
                string.IsNullOrWhiteSpace(txtLop.Text))
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
        SELECT SV.Masv, SV.MaTK, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh, SV.Img, SV.Lop
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

    }
}
