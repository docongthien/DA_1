using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Du_An_1
{
    public partial class Form1 : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string query = $"SELECT * FROM TK WHERE Taikhoan = '{username}' and Matkhau = '{password}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        string query2 = $"SELECT * FROM TK WHERE  Macv = 'CV2'";
                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            using (SqlDataReader render2 = cmd.ExecuteReader())
                            {
                                if (render2.HasRows)
                                {
                                    render2.Close();
                                    MessageBox.Show("Đăng nhập thành công!");
                                    Diem_SV diem = new Diem_SV();
                                    diem.FormClosed += (a, b) => this.Show();
                                    diem.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuenMK quenmk = new QuenMK();
            quenmk.FormClosed += (a, b) => this.Show();
            quenmk.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
