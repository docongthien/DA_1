using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class thongtingv : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);

        public thongtingv()
        {
            InitializeComponent();
        }

        private void thongtingv_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            conn.Open();
            string query = @"SELECT * FROM GV";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dgvGiangVien.DataSource = ds.Tables[0];
            reader.Close();
            conn.Close();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TbxMaTK.Text = dgvGiangVien.Rows[e.RowIndex].Cells["MaTK"].Value.ToString();
                TbxMaGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Magv"].Value.ToString();
                TbxTenGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                TbxSDT.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Sdt"].Value.ToString();
                TbxEmail.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgvGiangVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);

                string gioitinh = dgvGiangVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                if (gioitinh.ToLower() == "nam")
                {
                    radioButton1.Checked = true;
                }
                if (gioitinh.ToLower() == "nữ")
                {
                    radioButton2.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txbtimkiem.Text == "")
            {
                LoadData();
            }
            else
            {
                string query = @$"SELECT * FROM GV
			                    WHERE MaTK like '%{txbtimkiem.Text}%' 
								or Magv like '%{txbtimkiem.Text}%' 
                                or Ten like N'%{txbtimkiem.Text}%'";
                SqlCommand sqlmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = sqlmd.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds.Tables.Add(dt);
                dgvGiangVien.DataSource = ds.Tables[0];
                reader.Close();
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO GV (MaTK, Magv, Ten, Sdt, Email, NgaySinh, GioiTinh)
                                 VALUES (@MaTK, @Magv, @Ten, @Sdt, @Email, @NgaySinh, @GioiTinh)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", TbxMaTK.Text);
                cmd.Parameters.AddWithValue("@Magv", TbxMaGV.Text);
                cmd.Parameters.AddWithValue("@Ten", TbxTenGV.Text);
                cmd.Parameters.AddWithValue("@Sdt", TbxSDT.Text);
                cmd.Parameters.AddWithValue("@Email", TbxEmail.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", radioButton1.Checked ? "Nam" : "Nữ");
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE GV
                                 SET Ten = @Ten, Sdt = @Sdt, Email = @Email, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh
                                 WHERE MaTK = @MaTK AND Magv = @Magv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", TbxMaTK.Text);
                cmd.Parameters.AddWithValue("@Magv", TbxMaGV.Text);
                cmd.Parameters.AddWithValue("@Ten", TbxTenGV.Text);
                cmd.Parameters.AddWithValue("@Sdt", TbxSDT.Text);
                cmd.Parameters.AddWithValue("@Email", TbxEmail.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", radioButton1.Checked ? "Nam" : "Nữ");
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM GV WHERE MaTK = @MaTK AND Magv = @Magv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTK", TbxMaTK.Text);
                cmd.Parameters.AddWithValue("@Magv", TbxMaGV.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }
    }
}
