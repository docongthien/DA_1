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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Du_An_1
{
    public partial class Diem_SV : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        public Diem_SV()
        {
            InitializeComponent();
        }
        private void Diem_SV_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "select * from Qldiem";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView2.DataSource = ds.Tables[0];
            reader.Close();

            string query2 = "select * from SV";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView1.DataSource = ds2.Tables[0];
            reader2.Close();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkmasv = textBox2.Text;
            string query = $"select * from Qldiem where Masv = '{checkmasv}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Sinh viên có mã vừa nhập đã tồn tại!");
                    }
                    else
                    {
                        reader.Close();
                        string magv = textBox1.Text;
                        string masv = textBox2.Text;
                        string tensv = textBox3.Text;
                        string toan = textBox4.Text;
                        string van = textBox5.Text;
                        string anh = textBox6.Text;
                        string su = textBox9.Text;
                        string dia = textBox8.Text;

                        string[] diem = { toan, van, anh, su, dia };
                        int check = 0;
                        foreach (string diemMon in diem)
                        {
                            float diemSo;
                            if (float.TryParse(diemMon, out diemSo))
                            {
                                check = 1;
                            }
                            else
                            {
                                check = 0;
                                MessageBox.Show("Điểm không phải là một số.");
                                break;
                            }

                        }
                        if (check == 1)
                        {
                            string query1 = "insert into Qldiem(Magv,Masv,TenSV,Toan,Van,Anh,Su,Dia )" +
                            $"values('{magv}', '{masv}', N'{tensv}', '{toan}', {van}, '{anh}', '{su}', '{dia}')";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();

                            string query2 = "select * from Qldiem";
                            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

                            SqlDataReader reader2 = sqlmd2.ExecuteReader();
                            DataSet ds = new DataSet();
                            DataTable dt = new DataTable();
                            dt.Load(reader2);
                            ds.Tables.Add(dt);
                            dataGridView1.DataSource = ds.Tables[0];
                            reader2.Close();
                            MessageBox.Show("Lưu thành công");
                            Diem_SV_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Điểm không phải là một số.");
                        }

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string checkmasv = textBox2.Text;
                string query = $"select * from Qldiem where Masv = '{checkmasv}'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        if (reader.HasRows)
                        {
                            reader.Close();
                            string masv = textBox2.Text;
                            string query1 = $"delete from Qldiem where Masv = '{masv}'";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();

                            string query2 = "select * from Qldiem";
                            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

                            SqlDataReader reader2 = sqlmd2.ExecuteReader();
                            DataSet ds = new DataSet();
                            DataTable dt = new DataTable();
                            dt.Load(reader2);
                            ds.Tables.Add(dt);
                            dataGridView1.DataSource = ds.Tables[0];
                            reader2.Close();
                            MessageBox.Show("Xóa thành công");
                            Diem_SV_Load(sender, e);
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Không tìm thấy sinh viên bạn muốn xóa!");
                        }

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Bạn phải chọn sinh viên để xóa"); }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Close();
            Form1 form = new Form1();
            form.FormClosed += (a, b) => this.Show();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masv = textBox2.Text;
            string toan = textBox4.Text;
            string van = textBox5.Text;
            string anh = textBox6.Text;
            string su = textBox9.Text;
            string dia = textBox8.Text;

            string[] diem = { toan, van, anh, su, dia };
            int check = 0;
            foreach (string diemMon in diem)
            {
                float diemSo;
                if (float.TryParse(diemMon, out diemSo))
                {
                    check = 1;
                }
                else
                {
                    check = 0;
                    break;

                }             
            }
            if (check == 1)
            {
                string query1 = "update Qldiem " +
                               $"set Toan = '{toan}',Van = '{van}',Anh = '{anh}',Su = '{su}',Dia = '{dia}' " +
                               $"where Masv = '{masv}' ";
                SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                sqlCommand1.ExecuteNonQuery();

                string query2 = "select * from Qldiem";
                SqlCommand sqlmd2 = new SqlCommand(query2, conn);

                SqlDataReader reader2 = sqlmd2.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader2);
                ds.Tables.Add(dt);
                dataGridView1.DataSource = ds.Tables[0];
                reader2.Close();
                MessageBox.Show("sửa thành công");
                Diem_SV_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Điểm không phải là một số.");
            }
        }
    }
}

