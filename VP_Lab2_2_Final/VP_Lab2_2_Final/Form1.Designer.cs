namespace VP_Lab2_2_Final
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Cena_Golema = new System.Windows.Forms.TextBox();
            this.tb_Cena_Sredna = new System.Windows.Forms.TextBox();
            this.tb_Cena_Mala = new System.Windows.Forms.TextBox();
            this.rb_Golema = new System.Windows.Forms.RadioButton();
            this.rb_Sredna = new System.Windows.Forms.RadioButton();
            this.rb_Mala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Cena_Sirenje = new System.Windows.Forms.TextBox();
            this.tb_Cena_Kecap = new System.Windows.Forms.TextBox();
            this.tb_Cena_Feferonki = new System.Windows.Forms.TextBox();
            this.cb_Kecap = new System.Windows.Forms.CheckBox();
            this.cb_Sirenje = new System.Windows.Forms.CheckBox();
            this.cb_Feferonki = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Vk_Pivo = new System.Windows.Forms.TextBox();
            this.tb_Vk_Negazirani = new System.Windows.Forms.TextBox();
            this.tb_Vk_gazirani = new System.Windows.Forms.TextBox();
            this.tb_Cena_Pivo = new System.Windows.Forms.TextBox();
            this.tb_Cena_Negazirani = new System.Windows.Forms.TextBox();
            this.tb_Cena_Gazirani = new System.Windows.Forms.TextBox();
            this.tb_Kol_Pivo = new System.Windows.Forms.TextBox();
            this.tb_Kol_Negazirani = new System.Windows.Forms.TextBox();
            this.tb_Kol_Gazirani = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Otkazi = new System.Windows.Forms.Button();
            this.btn_Naracaj = new System.Windows.Forms.Button();
            this.tb_Cena_Desert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Deserti = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Za_Vrakjanje = new System.Windows.Forms.TextBox();
            this.tb_Naplateno = new System.Windows.Forms.TextBox();
            this.tb_VkupnoZaNaplata = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Cena_Golema);
            this.groupBox1.Controls.Add(this.tb_Cena_Sredna);
            this.groupBox1.Controls.Add(this.tb_Cena_Mala);
            this.groupBox1.Controls.Add(this.rb_Golema);
            this.groupBox1.Controls.Add(this.rb_Sredna);
            this.groupBox1.Controls.Add(this.rb_Mala);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // tb_Cena_Golema
            // 
            this.tb_Cena_Golema.Location = new System.Drawing.Point(180, 74);
            this.tb_Cena_Golema.Name = "tb_Cena_Golema";
            this.tb_Cena_Golema.Size = new System.Drawing.Size(73, 20);
            this.tb_Cena_Golema.TabIndex = 5;
            this.tb_Cena_Golema.Text = "500";
            this.tb_Cena_Golema.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Cena_Sredna
            // 
            this.tb_Cena_Sredna.Location = new System.Drawing.Point(180, 47);
            this.tb_Cena_Sredna.Name = "tb_Cena_Sredna";
            this.tb_Cena_Sredna.Size = new System.Drawing.Size(73, 20);
            this.tb_Cena_Sredna.TabIndex = 4;
            this.tb_Cena_Sredna.Text = "300";
            this.tb_Cena_Sredna.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Cena_Mala
            // 
            this.tb_Cena_Mala.Location = new System.Drawing.Point(180, 20);
            this.tb_Cena_Mala.Name = "tb_Cena_Mala";
            this.tb_Cena_Mala.Size = new System.Drawing.Size(73, 20);
            this.tb_Cena_Mala.TabIndex = 3;
            this.tb_Cena_Mala.Text = "200";
            this.tb_Cena_Mala.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // rb_Golema
            // 
            this.rb_Golema.AutoSize = true;
            this.rb_Golema.Location = new System.Drawing.Point(6, 76);
            this.rb_Golema.Name = "rb_Golema";
            this.rb_Golema.Size = new System.Drawing.Size(63, 17);
            this.rb_Golema.TabIndex = 2;
            this.rb_Golema.TabStop = true;
            this.rb_Golema.Text = "Голема";
            this.rb_Golema.UseVisualStyleBackColor = true;
            this.rb_Golema.CheckedChanged += new System.EventHandler(this.rb_cb_CheckedChanged);
            // 
            // rb_Sredna
            // 
            this.rb_Sredna.AutoSize = true;
            this.rb_Sredna.Location = new System.Drawing.Point(6, 50);
            this.rb_Sredna.Name = "rb_Sredna";
            this.rb_Sredna.Size = new System.Drawing.Size(62, 17);
            this.rb_Sredna.TabIndex = 1;
            this.rb_Sredna.TabStop = true;
            this.rb_Sredna.Text = "Средна";
            this.rb_Sredna.UseVisualStyleBackColor = true;
            this.rb_Sredna.CheckedChanged += new System.EventHandler(this.rb_cb_CheckedChanged);
            // 
            // rb_Mala
            // 
            this.rb_Mala.AutoSize = true;
            this.rb_Mala.Location = new System.Drawing.Point(6, 22);
            this.rb_Mala.Name = "rb_Mala";
            this.rb_Mala.Size = new System.Drawing.Size(52, 17);
            this.rb_Mala.TabIndex = 0;
            this.rb_Mala.TabStop = true;
            this.rb_Mala.Text = "Мала";
            this.rb_Mala.UseVisualStyleBackColor = true;
            this.rb_Mala.CheckedChanged += new System.EventHandler(this.rb_cb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Cena_Sirenje);
            this.groupBox2.Controls.Add(this.tb_Cena_Kecap);
            this.groupBox2.Controls.Add(this.tb_Cena_Feferonki);
            this.groupBox2.Controls.Add(this.cb_Kecap);
            this.groupBox2.Controls.Add(this.cb_Sirenje);
            this.groupBox2.Controls.Add(this.cb_Feferonki);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // tb_Cena_Sirenje
            // 
            this.tb_Cena_Sirenje.Location = new System.Drawing.Point(142, 47);
            this.tb_Cena_Sirenje.Name = "tb_Cena_Sirenje";
            this.tb_Cena_Sirenje.Size = new System.Drawing.Size(100, 20);
            this.tb_Cena_Sirenje.TabIndex = 5;
            this.tb_Cena_Sirenje.Text = "30";
            this.tb_Cena_Sirenje.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Cena_Kecap
            // 
            this.tb_Cena_Kecap.Location = new System.Drawing.Point(142, 74);
            this.tb_Cena_Kecap.Name = "tb_Cena_Kecap";
            this.tb_Cena_Kecap.Size = new System.Drawing.Size(100, 20);
            this.tb_Cena_Kecap.TabIndex = 4;
            this.tb_Cena_Kecap.Text = "20";
            this.tb_Cena_Kecap.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Cena_Feferonki
            // 
            this.tb_Cena_Feferonki.Location = new System.Drawing.Point(142, 20);
            this.tb_Cena_Feferonki.Name = "tb_Cena_Feferonki";
            this.tb_Cena_Feferonki.Size = new System.Drawing.Size(100, 20);
            this.tb_Cena_Feferonki.TabIndex = 3;
            this.tb_Cena_Feferonki.Text = "40";
            this.tb_Cena_Feferonki.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // cb_Kecap
            // 
            this.cb_Kecap.AutoSize = true;
            this.cb_Kecap.Location = new System.Drawing.Point(6, 77);
            this.cb_Kecap.Name = "cb_Kecap";
            this.cb_Kecap.Size = new System.Drawing.Size(56, 17);
            this.cb_Kecap.TabIndex = 2;
            this.cb_Kecap.Text = "Кечап";
            this.cb_Kecap.UseVisualStyleBackColor = true;
            this.cb_Kecap.CheckedChanged += new System.EventHandler(this.rb_cb_CheckedChanged);
            // 
            // cb_Sirenje
            // 
            this.cb_Sirenje.AutoSize = true;
            this.cb_Sirenje.Location = new System.Drawing.Point(6, 50);
            this.cb_Sirenje.Name = "cb_Sirenje";
            this.cb_Sirenje.Size = new System.Drawing.Size(105, 17);
            this.cb_Sirenje.TabIndex = 1;
            this.cb_Sirenje.Text = "Екстра сирење";
            this.cb_Sirenje.UseVisualStyleBackColor = true;
            this.cb_Sirenje.CheckedChanged += new System.EventHandler(this.rb_cb_CheckedChanged);
            // 
            // cb_Feferonki
            // 
            this.cb_Feferonki.AutoSize = true;
            this.cb_Feferonki.Location = new System.Drawing.Point(6, 23);
            this.cb_Feferonki.Name = "cb_Feferonki";
            this.cb_Feferonki.Size = new System.Drawing.Size(87, 17);
            this.cb_Feferonki.TabIndex = 0;
            this.cb_Feferonki.Text = "Феферонки";
            this.cb_Feferonki.UseVisualStyleBackColor = true;
            this.cb_Feferonki.CheckedChanged += new System.EventHandler(this.rb_cb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_Vk_Pivo);
            this.groupBox3.Controls.Add(this.tb_Vk_Negazirani);
            this.groupBox3.Controls.Add(this.tb_Vk_gazirani);
            this.groupBox3.Controls.Add(this.tb_Cena_Pivo);
            this.groupBox3.Controls.Add(this.tb_Cena_Negazirani);
            this.groupBox3.Controls.Add(this.tb_Cena_Gazirani);
            this.groupBox3.Controls.Add(this.tb_Kol_Pivo);
            this.groupBox3.Controls.Add(this.tb_Kol_Negazirani);
            this.groupBox3.Controls.Add(this.tb_Kol_Gazirani);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(23, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 126);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количина";
            // 
            // tb_Vk_Pivo
            // 
            this.tb_Vk_Pivo.Location = new System.Drawing.Point(420, 88);
            this.tb_Vk_Pivo.Name = "tb_Vk_Pivo";
            this.tb_Vk_Pivo.ReadOnly = true;
            this.tb_Vk_Pivo.Size = new System.Drawing.Size(76, 20);
            this.tb_Vk_Pivo.TabIndex = 11;
            // 
            // tb_Vk_Negazirani
            // 
            this.tb_Vk_Negazirani.Location = new System.Drawing.Point(420, 62);
            this.tb_Vk_Negazirani.Name = "tb_Vk_Negazirani";
            this.tb_Vk_Negazirani.ReadOnly = true;
            this.tb_Vk_Negazirani.Size = new System.Drawing.Size(76, 20);
            this.tb_Vk_Negazirani.TabIndex = 10;
            // 
            // tb_Vk_gazirani
            // 
            this.tb_Vk_gazirani.Location = new System.Drawing.Point(420, 36);
            this.tb_Vk_gazirani.Name = "tb_Vk_gazirani";
            this.tb_Vk_gazirani.ReadOnly = true;
            this.tb_Vk_gazirani.Size = new System.Drawing.Size(76, 20);
            this.tb_Vk_gazirani.TabIndex = 9;
            // 
            // tb_Cena_Pivo
            // 
            this.tb_Cena_Pivo.Location = new System.Drawing.Point(310, 88);
            this.tb_Cena_Pivo.Name = "tb_Cena_Pivo";
            this.tb_Cena_Pivo.Size = new System.Drawing.Size(76, 20);
            this.tb_Cena_Pivo.TabIndex = 8;
            this.tb_Cena_Pivo.Text = "80";
            this.tb_Cena_Pivo.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Cena_Negazirani
            // 
            this.tb_Cena_Negazirani.Location = new System.Drawing.Point(310, 62);
            this.tb_Cena_Negazirani.Name = "tb_Cena_Negazirani";
            this.tb_Cena_Negazirani.Size = new System.Drawing.Size(76, 20);
            this.tb_Cena_Negazirani.TabIndex = 7;
            this.tb_Cena_Negazirani.Text = "70";
            this.tb_Cena_Negazirani.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Cena_Gazirani
            // 
            this.tb_Cena_Gazirani.Location = new System.Drawing.Point(310, 36);
            this.tb_Cena_Gazirani.Name = "tb_Cena_Gazirani";
            this.tb_Cena_Gazirani.Size = new System.Drawing.Size(76, 20);
            this.tb_Cena_Gazirani.TabIndex = 6;
            this.tb_Cena_Gazirani.Text = "60";
            this.tb_Cena_Gazirani.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Kol_Pivo
            // 
            this.tb_Kol_Pivo.Location = new System.Drawing.Point(198, 88);
            this.tb_Kol_Pivo.Name = "tb_Kol_Pivo";
            this.tb_Kol_Pivo.Size = new System.Drawing.Size(76, 20);
            this.tb_Kol_Pivo.TabIndex = 5;
            this.tb_Kol_Pivo.Text = "0";
            this.tb_Kol_Pivo.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Kol_Negazirani
            // 
            this.tb_Kol_Negazirani.Location = new System.Drawing.Point(198, 62);
            this.tb_Kol_Negazirani.Name = "tb_Kol_Negazirani";
            this.tb_Kol_Negazirani.Size = new System.Drawing.Size(76, 20);
            this.tb_Kol_Negazirani.TabIndex = 4;
            this.tb_Kol_Negazirani.Text = "0";
            this.tb_Kol_Negazirani.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_Kol_Gazirani
            // 
            this.tb_Kol_Gazirani.Location = new System.Drawing.Point(198, 36);
            this.tb_Kol_Gazirani.Name = "tb_Kol_Gazirani";
            this.tb_Kol_Gazirani.Size = new System.Drawing.Size(76, 20);
            this.tb_Kol_Gazirani.TabIndex = 3;
            this.tb_Kol_Gazirani.Text = "0";
            this.tb_Kol_Gazirani.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / Портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Otkazi);
            this.groupBox4.Controls.Add(this.btn_Naracaj);
            this.groupBox4.Controls.Add(this.tb_Cena_Desert);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lb_Deserti);
            this.groupBox4.Location = new System.Drawing.Point(12, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 134);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // btn_Otkazi
            // 
            this.btn_Otkazi.Location = new System.Drawing.Point(122, 105);
            this.btn_Otkazi.Name = "btn_Otkazi";
            this.btn_Otkazi.Size = new System.Drawing.Size(119, 23);
            this.btn_Otkazi.TabIndex = 22;
            this.btn_Otkazi.Text = "Откажи";
            this.btn_Otkazi.UseVisualStyleBackColor = true;
            this.btn_Otkazi.Click += new System.EventHandler(this.btn_Otkazi_Click);
            // 
            // btn_Naracaj
            // 
            this.btn_Naracaj.Location = new System.Drawing.Point(123, 62);
            this.btn_Naracaj.Name = "btn_Naracaj";
            this.btn_Naracaj.Size = new System.Drawing.Size(119, 23);
            this.btn_Naracaj.TabIndex = 21;
            this.btn_Naracaj.Text = "Нарачај";
            this.btn_Naracaj.UseVisualStyleBackColor = true;
            this.btn_Naracaj.Click += new System.EventHandler(this.btn_Naracaj_Click);
            // 
            // tb_Cena_Desert
            // 
            this.tb_Cena_Desert.Location = new System.Drawing.Point(122, 35);
            this.tb_Cena_Desert.Name = "tb_Cena_Desert";
            this.tb_Cena_Desert.Size = new System.Drawing.Size(120, 20);
            this.tb_Cena_Desert.TabIndex = 15;
            this.tb_Cena_Desert.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Цена на десерт:";
            // 
            // lb_Deserti
            // 
            this.lb_Deserti.FormattingEnabled = true;
            this.lb_Deserti.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lb_Deserti.Location = new System.Drawing.Point(6, 19);
            this.lb_Deserti.Name = "lb_Deserti";
            this.lb_Deserti.Size = new System.Drawing.Size(100, 108);
            this.lb_Deserti.TabIndex = 0;
            this.lb_Deserti.SelectedIndexChanged += new System.EventHandler(this.lb_Deserti_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tb_Za_Vrakjanje);
            this.groupBox5.Controls.Add(this.tb_Naplateno);
            this.groupBox5.Controls.Add(this.tb_VkupnoZaNaplata);
            this.groupBox5.Location = new System.Drawing.Point(277, 256);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 134);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "За враќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Наплатено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вкупно за наплата:";
            // 
            // tb_Za_Vrakjanje
            // 
            this.tb_Za_Vrakjanje.Location = new System.Drawing.Point(122, 90);
            this.tb_Za_Vrakjanje.Name = "tb_Za_Vrakjanje";
            this.tb_Za_Vrakjanje.Size = new System.Drawing.Size(120, 20);
            this.tb_Za_Vrakjanje.TabIndex = 18;
            // 
            // tb_Naplateno
            // 
            this.tb_Naplateno.Location = new System.Drawing.Point(122, 55);
            this.tb_Naplateno.Name = "tb_Naplateno";
            this.tb_Naplateno.Size = new System.Drawing.Size(120, 20);
            this.tb_Naplateno.TabIndex = 17;
            this.tb_Naplateno.Text = "0";
            this.tb_Naplateno.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_VkupnoZaNaplata
            // 
            this.tb_VkupnoZaNaplata.Location = new System.Drawing.Point(122, 19);
            this.tb_VkupnoZaNaplata.Name = "tb_VkupnoZaNaplata";
            this.tb_VkupnoZaNaplata.ReadOnly = true;
            this.tb_VkupnoZaNaplata.Size = new System.Drawing.Size(120, 20);
            this.tb_VkupnoZaNaplata.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 411);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Cena_Golema;
        private System.Windows.Forms.TextBox tb_Cena_Sredna;
        private System.Windows.Forms.TextBox tb_Cena_Mala;
        private System.Windows.Forms.RadioButton rb_Golema;
        private System.Windows.Forms.RadioButton rb_Sredna;
        private System.Windows.Forms.RadioButton rb_Mala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Cena_Sirenje;
        private System.Windows.Forms.TextBox tb_Cena_Kecap;
        private System.Windows.Forms.TextBox tb_Cena_Feferonki;
        private System.Windows.Forms.CheckBox cb_Kecap;
        private System.Windows.Forms.CheckBox cb_Sirenje;
        private System.Windows.Forms.CheckBox cb_Feferonki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Kol_Pivo;
        private System.Windows.Forms.TextBox tb_Kol_Negazirani;
        private System.Windows.Forms.TextBox tb_Kol_Gazirani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Vk_Pivo;
        private System.Windows.Forms.TextBox tb_Vk_Negazirani;
        private System.Windows.Forms.TextBox tb_Vk_gazirani;
        private System.Windows.Forms.TextBox tb_Cena_Pivo;
        private System.Windows.Forms.TextBox tb_Cena_Negazirani;
        private System.Windows.Forms.TextBox tb_Cena_Gazirani;
        private System.Windows.Forms.Button btn_Otkazi;
        private System.Windows.Forms.Button btn_Naracaj;
        private System.Windows.Forms.TextBox tb_Cena_Desert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_Deserti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Za_Vrakjanje;
        private System.Windows.Forms.TextBox tb_Naplateno;
        private System.Windows.Forms.TextBox tb_VkupnoZaNaplata;
    }
}

