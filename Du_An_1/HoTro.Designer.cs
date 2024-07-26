namespace Du_An_1
{
    partial class HoTro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoTro));
            button2 = new Button();
            button3 = new Button();
            label13 = new Label();
            comboBox1 = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tb_ch = new TextBox();
            label17 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(113, 396);
            button2.Name = "button2";
            button2.Size = new Size(75, 22);
            button2.TabIndex = 35;
            button2.Text = "Gửi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(295, 396);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 26);
            button3.TabIndex = 34;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(429, 305);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(360, 136);
            label13.TabIndex = 33;
            label13.Text = resources.GetString("label13.Text");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DvSV", "Khảo Thí", "Đào Tạo ", "Hành Chính", "IT" });
            comboBox1.Location = new Point(532, 96);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 23);
            comboBox1.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(532, 272);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(124, 19);
            label14.TabIndex = 29;
            label14.Text = "Thông tin liên hệ ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(113, 148);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(64, 19);
            label15.TabIndex = 30;
            label15.Text = "Câu Hỏi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(532, 75);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(80, 19);
            label16.TabIndex = 31;
            label16.Text = "Danh mục ";
            // 
            // tb_ch
            // 
            tb_ch.Location = new Point(113, 169);
            tb_ch.Margin = new Padding(2);
            tb_ch.Multiline = true;
            tb_ch.Name = "tb_ch";
            tb_ch.Size = new Size(281, 181);
            tb_ch.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(371, 23);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(65, 21);
            label17.TabIndex = 27;
            label17.Text = "Hỗ Trợ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 75);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 37;
            label1.Text = "Mã SV , Mã GV";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 99);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 36;
            // 
            // HoTro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label13);
            Controls.Add(comboBox1);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(tb_ch);
            Controls.Add(label17);
            Name = "HoTro";
            Text = "HoTro";
            Load += HoTro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Label label13;
        private ComboBox comboBox1;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tb_ch;
        private Label label17;
        private Label label1;
        private TextBox textBox1;
    }
}