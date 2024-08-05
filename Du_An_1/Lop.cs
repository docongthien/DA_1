using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class Lop : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        public Lop()
        {
            InitializeComponent();
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            load();
        }
        private void load()
        {

        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string checkmalop = textBox1.Text;
            string query = $"select * from Lop where Malop = '{checkmalop}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Lớp có mã vừa nhập đã tồn tại!");
                    }
                    else
                    {
                        reader.Close();

                        string MaLop = textBox1.Text;
                        string TenLop = textBox1.Text;

                        if (MaLop != null && TenLop != null)
                        {
                            string query1 = "insert into Lop(Malop,Tenlop)" +
                            $"values('{MaLop}', N'{TenLop}')";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();

                            string query2 = "select * from Lop";
                            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

                            SqlDataReader reader2 = sqlmd2.ExecuteReader();
                            DataSet ds = new DataSet();
                            DataTable dt = new DataTable();
                            dt.Load(reader2);
                            ds.Tables.Add(dt);
                            dataGridView1.DataSource = ds.Tables[0];
                            reader2.Close();
                            MessageBox.Show("Lưu thành công");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Mã Lớp và tên lớp không được để trống.");
                        }
                    }

                }
            }
        }

        private void Lop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checkmalop = textBox1.Text;
            string query = $@"select * from Lop where Malop = '{checkmalop}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Không tìm thấy mã lớp");
                    }
                    else
                    {
                        reader.Close();

                        string MaLop = textBox1.Text;
                        string TenLop = textBox1.Text;

                        if (MaLop != null && TenLop != null)
                        {
                            string query1 = @$"UPDATE Lop
                                                SET Tenlop = N'{textBox2.Text}'
                                                WHERE Malop = '{textBox1.Text}'";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();

                            string query2 = "select * from Lop";
                            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

                            SqlDataReader reader2 = sqlmd2.ExecuteReader();
                            DataSet ds = new DataSet();
                            DataTable dt = new DataTable();
                            dt.Load(reader2);
                            ds.Tables.Add(dt);
                            dataGridView1.DataSource = ds.Tables[0];
                            reader2.Close();
                            MessageBox.Show("Lưu thành công");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Điểm không được để trống.");
                        }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string delete = @$"delete from Lopchitiet 
                                where Malop = {textBox1.Text}
                               delete from Lop 
                                where Malop = {textBox1.Text}";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();

            string query2 = "select * from sach";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView1.DataSource = ds.Tables[0];
            reader.Close();
        }
    }
}
