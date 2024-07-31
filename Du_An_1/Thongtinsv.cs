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
    public partial class Thongtinsv : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connect);
        private string Tk;
        private string Mk;
        public Thongtinsv(string tK, string mk)
        {
            InitializeComponent();
            Tk = tK;
            Mk = mk;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Thongtinsv_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = @$"SELECT 
                                SV.Masv, Sv.Ten, SV.Email,SV.Sdt,sv.Que_quan,ngay_sinh,Sv.Lop
                            FROM TK
                            INNER JOIN 
                                SV ON TK.MaTK = SV.MaTK
                            WHERE 
                               TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}';";
            SqlCommand sqlmd = new SqlCommand(query, conn);
            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dgvTTSinhVien.DataSource = ds.Tables[0];
            reader.Close();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTTSinhVien_CurrentCellChanged(object sender, EventArgs e)
        {
            txtEmail.Text = dgvTTSinhVien.Rows[0].Cells[2].Value.ToString();
            txtMasv.Text = dgvTTSinhVien.Rows[0].Cells[0].Value.ToString();
            txtLop.Text = dgvTTSinhVien.Rows[0].Cells[6].Value.ToString();
            txtTen.Text = dgvTTSinhVien.Rows[0].Cells[1].Value.ToString();
            txtSDT.Text = dgvTTSinhVien.Rows[0].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvTTSinhVien.Rows[0].Cells[5].Value);
            txtDiaChi.Text = dgvTTSinhVien.Rows[0].Cells[4].Value.ToString();
        }
    }
}
