namespace CokKatmanliMimari.PL
{
    partial class OgrenciIslemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciIslemForm));
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IdSil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.comboBox_gCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_gSifre = new System.Windows.Forms.TextBox();
            this.txt_gNo = new System.Windows.Forms.TextBox();
            this.txt_gSoyad = new System.Windows.Forms.TextBox();
            this.txt_gAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ogrenciListe = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOgrenci.Location = new System.Drawing.Point(481, 32);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(323, 32);
            this.lblOgrenci.TabIndex = 12;
            this.lblOgrenci.Text = "ÖĞRENCİ  İŞLEMLERİ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.ImageKey = "reply.png";
            this.button2.Location = new System.Drawing.Point(32, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 34);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.comboBoxCinsiyet);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 316);
            this.panel1.TabIndex = 29;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(154, 223);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCinsiyet.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FloralWhite;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(170, 264);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 27);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(154, 188);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(154, 149);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 22);
            this.txtNo.TabIndex = 8;
            this.txtNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNo_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(154, 108);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 7;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(154, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 6;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(69, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Okul No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ EKLE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_IdSil);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(32, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 123);
            this.panel2.TabIndex = 30;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(241, 64);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 24);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(-4, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Öğrenci Id : ";
            // 
            // txt_IdSil
            // 
            this.txt_IdSil.Location = new System.Drawing.Point(124, 66);
            this.txt_IdSil.Name = "txt_IdSil";
            this.txt_IdSil.Size = new System.Drawing.Size(100, 22);
            this.txt_IdSil.TabIndex = 2;
            this.txt_IdSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdSil_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(81, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "ÖĞRENCİ SİL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lblBilgilendirme);
            this.panel3.Controls.Add(this.comboBox_gCinsiyet);
            this.panel3.Controls.Add(this.btnGuncelle);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_gSifre);
            this.panel3.Controls.Add(this.txt_gNo);
            this.panel3.Controls.Add(this.txt_gSoyad);
            this.panel3.Controls.Add(this.txt_gAd);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(388, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 216);
            this.panel3.TabIndex = 31;
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.White;
            this.lblBilgilendirme.Location = new System.Drawing.Point(99, 168);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(641, 36);
            this.lblBilgilendirme.TabIndex = 26;
            this.lblBilgilendirme.Text = "Not: Güncellemek istediğiniz öğrencinin listeden üzerine tıklayınız.\r\n \r\n";
            // 
            // comboBox_gCinsiyet
            // 
            this.comboBox_gCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gCinsiyet.FormattingEnabled = true;
            this.comboBox_gCinsiyet.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox_gCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.comboBox_gCinsiyet.Location = new System.Drawing.Point(595, 86);
            this.comboBox_gCinsiyet.Name = "comboBox_gCinsiyet";
            this.comboBox_gCinsiyet.Size = new System.Drawing.Size(100, 24);
            this.comboBox_gCinsiyet.TabIndex = 25;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(386, 129);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(597, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Cinsiyet ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(492, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Şifre ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(356, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Okul No ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(238, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Soyad ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(132, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ad ";
            // 
            // txt_gSifre
            // 
            this.txt_gSifre.Location = new System.Drawing.Point(472, 87);
            this.txt_gSifre.Name = "txt_gSifre";
            this.txt_gSifre.Size = new System.Drawing.Size(100, 22);
            this.txt_gSifre.TabIndex = 17;
            // 
            // txt_gNo
            // 
            this.txt_gNo.Location = new System.Drawing.Point(349, 87);
            this.txt_gNo.Name = "txt_gNo";
            this.txt_gNo.Size = new System.Drawing.Size(100, 22);
            this.txt_gNo.TabIndex = 16;
            this.txt_gNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gNo_KeyPress);
            // 
            // txt_gSoyad
            // 
            this.txt_gSoyad.Location = new System.Drawing.Point(224, 87);
            this.txt_gSoyad.Name = "txt_gSoyad";
            this.txt_gSoyad.Size = new System.Drawing.Size(100, 22);
            this.txt_gSoyad.TabIndex = 15;
            // 
            // txt_gAd
            // 
            this.txt_gAd.Location = new System.Drawing.Point(99, 87);
            this.txt_gAd.Name = "txt_gAd";
            this.txt_gAd.Size = new System.Drawing.Size(100, 22);
            this.txt_gAd.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(312, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "ÖĞRENCİ GÜNCELLE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(312, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.ogrenciListe);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(388, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 228);
            this.panel4.TabIndex = 32;
            // 
            // ogrenciListe
            // 
            this.ogrenciListe.AllowUserToAddRows = false;
            this.ogrenciListe.AllowUserToDeleteRows = false;
            this.ogrenciListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenciListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ogrenciListe.BackgroundColor = System.Drawing.Color.White;
            this.ogrenciListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciListe.Location = new System.Drawing.Point(15, 46);
            this.ogrenciListe.Name = "ogrenciListe";
            this.ogrenciListe.ReadOnly = true;
            this.ogrenciListe.RowHeadersWidth = 51;
            this.ogrenciListe.RowTemplate.Height = 24;
            this.ogrenciListe.Size = new System.Drawing.Size(758, 164);
            this.ogrenciListe.TabIndex = 2;
            this.ogrenciListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenciListe_CellContentClick);
            this.ogrenciListe.SelectionChanged += new System.EventHandler(this.ogrenciListe_SelectionChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1132, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // OgrenciIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciIslemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciIslemForm";
            this.Load += new System.EventHandler(this.OgrenciIslemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IdSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_gSifre;
        private System.Windows.Forms.TextBox txt_gNo;
        private System.Windows.Forms.TextBox txt_gSoyad;
        private System.Windows.Forms.TextBox txt_gAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView ogrenciListe;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBox_gCinsiyet;
        private System.Windows.Forms.Label lblBilgilendirme;
    }
}