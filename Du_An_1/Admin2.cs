using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class Admin2 : Form
    {
        static string connect = @"Data Source=TRONG2K5\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);

        public Admin2()
        {
            InitializeComponent();
        }
       

        private void Admin2_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from GV";
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
               
                textBox1.Text = dgvGiangVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dgvGiangVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dgvGiangVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dgvGiangVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dgvGiangVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dgvGiangVien.Rows[e.RowIndex].Cells[5].Value.ToString();
             
            }
            catch (Exception ex) { }

        }

    }
}
