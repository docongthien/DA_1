using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_An_1
{
    public partial class MenuSV : Form
    {
        public MenuSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thongtinsv ttsv = new Thongtinsv();
            ttsv.FormClosed += (a, b) => this.Show();
            ttsv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diemsv diemsv = new Diemsv();
            diemsv.FormClosed += (a, b) => this.Show();
            diemsv.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
