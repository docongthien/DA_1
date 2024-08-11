using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Du_An_1
{
    public partial class HoTro : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        private string Tk;
        private string Mk;
        public HoTro(string tK, string mk)
        {
            InitializeComponent();
            Tk = tK;
            Mk = mk;
        }

        private void HoTro_Load(object sender, EventArgs e)
        {

            checktk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && comboBox1.Text.Trim() != "" && tb_ch.Text.Trim() != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn thực sự muốn thao tác", "Xác nhận", MessageBoxButtons.YesNo))
                {
                    string path = @$"E:\OneDrive - Đại học FPT- FPT University\floly\Dự án 1\DA_1\DA_1\Help\{textBox1.Text}.txt";
                    if (File.Exists(path))
                    {
                        FileStream fr = new FileStream(path, FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fr);

                        try
                        {
                            sw.WriteLine("Ngày gửi:" + DateTime.Now);
                            sw.WriteLine("Mã GV,SV: " + textBox1.Text);
                            sw.WriteLine("Loại hỗ trợ: " + comboBox1.Text);
                            sw.WriteLine("Câu hỏi hỗ trợ: " + tb_ch.Text);
                            sw.WriteLine("");
                            MessageBox.Show("Ghi thành công");
                            sw.Close();
                            fr.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ghi thất bại");
                        }
                    }
                    else
                    {
                        FileStream fr = new FileStream(path, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fr);

                        try
                        {
                            sw.WriteLine("Ngày gửi:" + DateTime.Now);
                            sw.WriteLine("Mã GV,SV: " + textBox1.Text);
                            sw.WriteLine("Loại hỗ trợ: " + comboBox1.Text);
                            sw.WriteLine("Câu hỏi hỗ trợ: " + tb_ch.Text);
                            sw.WriteLine("");
                            MessageBox.Show("Ghi thành công");
                            sw.Close();
                            fr.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ghi thất bại");
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show(" Các Trường dữ liệu không được để trống");
            }

        }
        private void checktk()
        {
            conn.Open();
            string query2 = $"SELECT * FROM TK WHERE Taikhoan = '{Tk}' and Matkhau = '{Mk}' and Macv = 'CV2'";
            using (SqlCommand cmd = new SqlCommand(query2, conn))
            {
                using (SqlDataReader render2 = cmd.ExecuteReader())
                {
                    if (render2.HasRows)
                    {
                        render2.Close();
                        conn.Close();
                        LoadGV();
                    }
                    else
                    {
                        render2.Close();
                        conn.Close();
                    }
                }
            }
            conn.Open();
            string query3 = $"SELECT * FROM TK WHERE Taikhoan = '{Tk}' and Matkhau = '{Mk}' and Macv = 'CV3'";
            using (SqlCommand cmd3 = new SqlCommand(query3, conn))
            {
                
                using (SqlDataReader render3 = cmd3.ExecuteReader())
                {
                    if (render3.HasRows)
                    {
                        render3.Close();
                        conn.Close();
                        LoadHS();
                    }
                    else
                    {
                        render3.Close();
                        conn.Close();
                    }
                }
            }
        }
        private void LoadHS()
        {
            conn.Open();
            string query = @$"select Masv from SV
                            join TK on SV.MaTK = TK.MaTK
                            where TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}'";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlDataReader reader4 = cmd.ExecuteReader();

                    while (reader4.Read())
                    {

                        string columnName1 = reader4["Masv"].ToString();
                        textBox1.Text = columnName1;
                    }
                    reader4.Close();
                    conn.Close() ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void LoadGV()
        {
            conn.Open();
            string query = @$"select Magv from gv
                            join TK on GV.MaTK = TK.MaTK
                            where TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}'";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlDataReader reader4 = cmd.ExecuteReader();

                    while (reader4.Read())
                    {

                        string columnName1 = reader4["Magv"].ToString();
                        textBox1.Text = columnName1;
                    }
                    reader4.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoTro_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
