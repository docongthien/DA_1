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
                    string path = @$"E:\OneDrive - Đại học FPT- FPT University\floly\c#2_2\thithu2\{textBox1.Text}.txt";
                    FileStream fr = new FileStream(path, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fr);

                    try
                    {
                        sw.Write(textBox1.Text);
                        sw.Write(comboBox1.Text);
                        sw.Write(tb_ch.Text);
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
            else
            {
                MessageBox.Show(" Các Trường dữ liệu không được để trống");
            }
            
        }
    }
}
