using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class HoTro : Form
    {
        public HoTro()
        {
            InitializeComponent();
        }

        private void HoTro_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
