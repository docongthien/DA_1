﻿using System;
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
    public partial class MenuGV : Form
    {
        public MenuGV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin2 ttgv = new Admin2();
            ttgv.FormClosed += (a, b) => this.Show();
            ttgv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diem_SV diem = new Diem_SV();
            diem.FormClosed += (a, b) => this.Show();
            diem.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoTro hotro = new HoTro();
            hotro.FormClosed += (a, b) => this.Show();
            hotro.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
