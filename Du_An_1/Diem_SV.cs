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
        private string Tk;
        private string Mk;
        public Diem_SV(string tK, string mk)
        {
            InitializeComponent();
            Tk = tK;
            Mk = mk;
        }
        private void Diem_SV_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            laoddiemsv();
            loadsv();
            datasv();
            datalopchitiet();
            datalopgv();
            loadthongke();
        }
        private void laoddiemsv()
        {
            string query = "select * from Qldiem";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView2.DataSource = ds.Tables[0];
            reader.Close();
        }
        private void loadsv()
        {
            string query2 = @"SELECT s.Masv, s.Ten
                            FROM SV s
                            LEFT JOIN Qldiem q ON s.Masv = q.Masv
                            WHERE q.Masv IS NULL;";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView1.DataSource = ds2.Tables[0];
            reader2.Close();
        }
        private void loadthongke()
        {
            string query = @"
            SELECT SV.Masv, SV.Ten AS TenSV, SV.Email, SV.Sdt, SV.Que_quan, SV.ngay_sinh,
                   Qldiem.Toan, Qldiem.Van, Qldiem.Anh, Qldiem.Su, Qldiem.Dia,
                   (Qldiem.Toan + Qldiem.Van + Qldiem.Anh + Qldiem.Su + Qldiem.Dia) / 5.0 AS DiemTrungBinh
            FROM SV
            INNER JOIN Qldiem ON SV.Masv = Qldiem.Masv";

            using (SqlCommand sqlmd = new SqlCommand(query, conn))
            {
                try
                {
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

                }
            }
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

                        string masv = textBox2.Text;
                        string tensv = textBox3.Text;
                        string toan = textBox4.Text;
                        string van = textBox5.Text;
                        string anh = textBox6.Text;
                        string su = textBox9.Text;
                        string dia = textBox8.Text;
                        float checktoan = float.Parse(toan);
                        float checkvan = float.Parse(van);
                        float checkanh = float.Parse(anh);
                        float checksu = float.Parse(su);
                        float checkdia = float.Parse(dia);
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
                                MessageBox.Show("Điểm không được để trống và điểm phải là một số.");
                                break;
                            }

                        }
                        if (check == 1 && checktoan >= 0 && checktoan <= 10 && checkvan >= 0 && checkvan <= 10 && checkanh >= 0 && checkanh <= 10 && checksu >= 0 && checksu <= 10 && checkdia >= 0 && checkdia <= 10)
                        {
                            string query1 = "insert into Qldiem(Masv,TenSV,Toan,Van,Anh,Su,Dia )" +
                            $"values('{masv}', N'{tensv}', '{toan}', {van}, '{anh}', '{su}', '{dia}')";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();

                            load();
                            Diem_SV_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Điểm Phải >=0 và <= 10");
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checkmasv = textBox2.Text;
            string query = $"select * from Qldiem where Masv = '{checkmasv}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Sinh viên có mã vừa nhập Không tồn tại!");
                    }
                    else
                    {
                        reader.Close();

                        string masv = textBox2.Text;
                        string tensv = textBox3.Text;
                        string toan = textBox4.Text;
                        string van = textBox5.Text;
                        string anh = textBox6.Text;
                        string su = textBox9.Text;
                        string dia = textBox8.Text;
                        float checktoan = float.Parse(toan);
                        float checkvan = float.Parse(van);
                        float checkanh = float.Parse(anh);
                        float checksu = float.Parse(su);
                        float checkdia = float.Parse(dia);
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
                                MessageBox.Show("Điểm không được để trống và điểm phải là một số.");
                                break;
                            }

                        }
                        if (check == 1 && checktoan >= 0 && checktoan <= 10 && checkvan >= 0 && checkvan <= 10 && checkanh >= 0 && checkanh <= 10 && checksu >= 0 && checksu <= 10 && checkdia >= 0 && checkdia <= 10)
                        {
                            string query1 = @$"UPDATE Qldiem
                                                SET TenSV = {tensv}, 
                                                    Toan = {toan}, 
                                                    Van = {van},
                                                    Anh = {anh},
                                                    Su = {su},
                                                    Dia = {dia}
                                                WHERE Masv = '{masv}';";

                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();

                            load();
                            Diem_SV_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Điểm Phải >=0 và <= 10");
                        }

                    }
                }
            }
        }


        public void load()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                load();
                textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex) { }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                load();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Masvs"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            }
            catch (Exception ex) { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }



        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                loadsv();
            }
            else
            {
                string query = $"select * from SV where Masv like '%{textBox10.Text}%' or Ten like N'%{textBox10.Text}%'";
                SqlCommand sqlmd = new SqlCommand(query, conn);

                SqlDataReader reader = sqlmd.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds.Tables.Add(dt);
                dataGridView1.DataSource = ds.Tables[0];
                reader.Close();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                laoddiemsv();
            }
            else
            {
                string query = $"select * from Qldiem where Masv like '%{textBox10.Text}%' or TenSV like N'%{textBox10.Text}%'";
                SqlCommand sqlmd = new SqlCommand(query, conn);

                SqlDataReader reader = sqlmd.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds.Tables.Add(dt);
                dataGridView2.DataSource = ds.Tables[0];
                reader.Close();
            }
        }
        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                laoddiemsv();
            }
            else
            {
                string query = $"select * from Qldiem where Masv like '%{textBox7.Text}%' or TenSV like N'%{textBox7.Text}%'";
                SqlCommand sqlmd = new SqlCommand(query, conn);

                SqlDataReader reader = sqlmd.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds.Tables.Add(dt);
                dataGridView2.DataSource = ds.Tables[0];
                reader.Close();
            }
        }

        private void Diem_SV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

            if (comboBox2.Text == "học sinh xuất sắc")
            {
                minDiemTb = 9;
                maxDiemTb = 10;
            }
            else if (comboBox2.Text == "học sinh giỏi")
            {
                minDiemTb = 8;
                maxDiemTb = 9;
            }
            else if (comboBox2.Text == "học sinh khá")
            {
                minDiemTb = 6.5;
                maxDiemTb = 8;
            }
            else if (comboBox2.Text == "học sinh trung bình")
            {
                minDiemTb = 5;
                maxDiemTb = 6.5;
            }
            else if (comboBox2.Text == "học sinh yếu")
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
        public void datalopchitiet()
        {
            string query = @$"SELECT 
                                lct.malopchitiet,l.malopgv, g.Magv,g.Ten TenGV, lct.Masv, SV.Ten TenSV
                            FROM Lopchitiet lct
							JOIN 
                                Lopgv l ON lct.malopgv = l.malopgv
							JOIN 
                                GV g ON l.Magv = g.Magv
                            JOIN 
                                TK t ON g.MaTK = t.MaTK
							JOIN 
                                SV ON lct.Masv = SV.Masv

                            WHERE 
                                t.Taikhoan = '{Tk}' AND t.Matkhau = '{Mk}';";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView3.DataSource = ds.Tables[0];
            reader.Close();
        }
        public void datasv()
        {
            string query2 = @"SELECT s.Masv, s.Ten
                            FROM SV s
                            LEFT JOIN Lopchitiet lc ON s.Masv = lc.Masv
                            WHERE lc.Masv IS NULL;";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView4.DataSource = ds2.Tables[0];
            reader2.Close();
        }
        public void datalopgv()
        {
            string query2 = @$"SELECT 
                                l.malopgv, g.Magv,g.Ten TenGV
                            FROM Lopgv l
							JOIN 
                                GV g ON l.Magv = g.Magv
                            JOIN 
                                TK t ON g.MaTK = t.MaTK
                            WHERE 
                                t.Taikhoan = '{Tk}' AND t.Matkhau = '{Mk}'";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView5.DataSource = ds2.Tables[0];
            reader2.Close();
        }
        private void cleards()
        {
            textBox1.Text = "";
            textBox11.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {

            string Malopgv = textBox1.Text.Trim();
            string Masv = textBox11.Text.Trim();

            if (Malopgv != "" && Masv != "")
            {
                string query1 = "insert into Lopchitiet(malopgv,Masv)" +
                $"values('{Malopgv}', '{Masv}')";
                SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                sqlCommand1.ExecuteNonQuery();
                cleards();
                datalopchitiet();
                datalopgv();
                datasv();
                MessageBox.Show("thêm thành công");
            }
            else
            {
                MessageBox.Show("Mã Lớp và mã sinh viên không được để trống.");
            }

        }
        private string malopct;
        private void button6_Click(object sender, EventArgs e)
        {
            string query = $@"select * from Lopchitiet where malopchitiet = '{malopct}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("xin mời chọn lớp để sửa");
                    }
                    else
                    {
                        reader.Close();
                        string Malopgv = textBox1.Text;
                        string Masv = textBox11.Text;

                        string query1 = @$"UPDATE Lopchitiet
                                                SET malopgv = '{Malopgv}',
                                                Masv = '{Masv}'
                                                WHERE malopchitiet = '{malopct}'";
                        SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                        sqlCommand1.ExecuteNonQuery();

                        cleards();
                        datalopchitiet();
                        datalopgv();
                        datasv();
                        MessageBox.Show("Sửa thành công");

                    }

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = $@"select * from Lopchitiet where malopchitiet = '{malopct}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("xin mời chọn lớp Có giáo viên để Xóa");
                    }
                    else
                    {
                        reader.Close();
                        string delete = @$"DELETE FROM Lopchitiet 
                                           WHERE malopchitiet = '{malopct}';";
                        SqlCommand cmd = new SqlCommand(delete, conn);
                        cmd.ExecuteNonQuery();

                        cleards();
                        datalopchitiet();
                        datalopgv();
                        datasv();
                        MessageBox.Show("Xóa thành công");

                    }

                }
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox11.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                malopct = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox11.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string timkiem = textBox12.Text;
            tksv(timkiem);
            tklop(timkiem);
        }
        private void tksv(string timkiem)
        {
            string query2 = @$"SELECT s.Masv, s.Ten
FROM SV s
LEFT JOIN Lopchitiet lc ON s.Masv = lc.Masv
WHERE lc.Masv IS NULL;";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView4.DataSource = ds2.Tables[0];
            reader2.Close();
        }
        private void tklop(string timkiem)
        {
            string query = @$"SELECT 
                                     lct.malopchitiet,l.malopgv, g.Magv,g.Ten TenGV, lct.Masv, SV.Ten TenSV
                                 FROM Lopchitiet lct
                                 JOIN 
                                     Lopgv l ON lct.malopgv = l.malopgv
                                 JOIN 
                                     GV g ON l.Magv = g.Magv
                                 JOIN 
                                     TK t ON g.MaTK = t.MaTK
                                 JOIN 
                                     SV ON lct.Masv = SV.Masv
                                 WHERE 
                                     t.Taikhoan = '{Tk}' AND t.Matkhau = '{Mk}'
                                 AND ( l.malopgv LIKE '%{timkiem}%'
                                 OR lct.malopchitiet LIKE '%{timkiem}%'
                                 OR l.malopgv LIKE '%{timkiem}%'
                                 OR  g.Magv LIKE '%{timkiem}%'
                                 OR g.Ten LIKE N'%{timkiem}%'
                                 OR  lct.Masv LIKE '%{timkiem}%'
                                 OR SV.Ten LIKE N'%{timkiem}%' );";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView3.DataSource = ds.Tables[0];
            reader.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadthongke();
        }
    }
}

