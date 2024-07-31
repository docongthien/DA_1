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
            conn.Open();
            string query = @$"SELECT * FROM GV";
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
            TbxMaTK.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbMaTK"].Value.ToString();
            TbxMaGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbMatk"].Value.ToString();
            TbxTenGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbTengv"].Value.ToString();
            TbxSDT.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Txbsdt"].Value.ToString();
            TbxEmail.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbemail"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvGiangVien.Rows[e.RowIndex].Cells["txbNgaysinh"].Value);
        
            string gioitinh = dgvGiangVien.Rows[e.RowIndex].Cells["Gioi_tinh"].Value.ToString();
            if(gioitinh.ToLower() == "nam")
            {
                radioButton1.Checked = true;
            }
            if (gioitinh.ToLower() == "nữ")
            {
                radioButton2.Checked = true;
            }
        }
    }
}
