namespace CokKatmanliMimari.PL
{
    partial class KitapArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapArama));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.kitapId = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.kitapYazar = new System.Windows.Forms.Label();
            this.kitapSayfa = new System.Windows.Forms.Label();
            this.kitapTuru = new System.Windows.Forms.Label();
            this.kitapAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.idKitapListe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapAlimTeslimListe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOgrenciId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idKitapListe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1111, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.button2.Location = new System.Drawing.Point(22, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 34);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenci.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOgrenci.Location = new System.Drawing.Point(493, 12);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(321, 40);
            this.lblOgrenci.TabIndex = 40;
            this.lblOgrenci.Text = "Kitap Bilgileri";
            // 
            // kitapId
            // 
            this.kitapId.Location = new System.Drawing.Point(143, 103);
            this.kitapId.Name = "kitapId";
            this.kitapId.Size = new System.Drawing.Size(100, 22);
            this.kitapId.TabIndex = 43;
            this.kitapId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitapId_KeyPress);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.OldLace;
            this.btnGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGetir.Location = new System.Drawing.Point(296, 101);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 27);
            this.btnGetir.TabIndex = 45;
            this.btnGetir.Text = "Göster";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(37, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "Kitap ID:";
            // 
            // kitapYazar
            // 
            this.kitapYazar.AutoSize = true;
            this.kitapYazar.BackColor = System.Drawing.Color.Transparent;
            this.kitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapYazar.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapYazar.Location = new System.Drawing.Point(910, 218);
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Size = new System.Drawing.Size(51, 20);
            this.kitapYazar.TabIndex = 52;
            this.kitapYazar.Text = "------";
            // 
            // kitapSayfa
            // 
            this.kitapSayfa.AutoSize = true;
            this.kitapSayfa.BackColor = System.Drawing.Color.Transparent;
            this.kitapSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapSayfa.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapSayfa.Location = new System.Drawing.Point(625, 218);
            this.kitapSayfa.Name = "kitapSayfa";
            this.kitapSayfa.Size = new System.Drawing.Size(51, 20);
            this.kitapSayfa.TabIndex = 51;
            this.kitapSayfa.Text = "------";
            // 
            // kitapTuru
            // 
            this.kitapTuru.AutoSize = true;
            this.kitapTuru.BackColor = System.Drawing.Color.Transparent;
            this.kitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapTuru.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapTuru.Location = new System.Drawing.Point(910, 161);
            this.kitapTuru.Name = "kitapTuru";
            this.kitapTuru.Size = new System.Drawing.Size(51, 20);
            this.kitapTuru.TabIndex = 50;
            this.kitapTuru.Text = "------";
            // 
            // kitapAd
            // 
            this.kitapAd.AutoSize = true;
            this.kitapAd.BackColor = System.Drawing.Color.Transparent;
            this.kitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAd.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapAd.Location = new System.Drawing.Point(625, 161);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(51, 20);
            this.kitapAd.TabIndex = 49;
            this.kitapAd.Text = "------";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Yellow;
            this.lblSifre.Location = new System.Drawing.Point(825, 218);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(75, 20);
            this.lblSifre.TabIndex = 56;
            this.lblSifre.Text = "Yazar : ";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblNo.Location = new System.Drawing.Point(480, 218);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(131, 20);
            this.lblNo.TabIndex = 55;
            this.lblNo.Text = "Sayfa Sayısı : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Yellow;
            this.lblSoyad.Location = new System.Drawing.Point(834, 161);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(65, 20);
            this.lblSoyad.TabIndex = 54;
            this.lblSoyad.Text = "Türü : ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Yellow;
            this.lblAd.Location = new System.Drawing.Point(506, 161);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(103, 20);
            this.lblAd.TabIndex = 53;
            this.lblAd.Text = "Kİtap Adı : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.idKitapListe);
            this.panel1.Location = new System.Drawing.Point(22, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 368);
            this.panel1.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(116, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "ID LİSTESİ";
            // 
            // idKitapListe
            // 
            this.idKitapListe.AllowUserToAddRows = false;
            this.idKitapListe.AllowUserToDeleteRows = false;
            this.idKitapListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idKitapListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.idKitapListe.BackgroundColor = System.Drawing.Color.White;
            this.idKitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idKitapListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idKitapListe.Location = new System.Drawing.Point(18, 42);
            this.idKitapListe.Name = "idKitapListe";
            this.idKitapListe.ReadOnly = true;
            this.idKitapListe.RowHeadersWidth = 51;
            this.idKitapListe.RowTemplate.Height = 24;
            this.idKitapListe.Size = new System.Drawing.Size(312, 310);
            this.idKitapListe.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.kitapAlimTeslimListe);
            this.panel2.Location = new System.Drawing.Point(392, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 248);
            this.panel2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "KİTABI ALANLARIN LİSTESİ";
            // 
            // kitapAlimTeslimListe
            // 
            this.kitapAlimTeslimListe.AllowUserToAddRows = false;
            this.kitapAlimTeslimListe.AllowUserToDeleteRows = false;
            this.kitapAlimTeslimListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapAlimTeslimListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kitapAlimTeslimListe.BackgroundColor = System.Drawing.Color.White;
            this.kitapAlimTeslimListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapAlimTeslimListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapAlimTeslimListe.Location = new System.Drawing.Point(20, 37);
            this.kitapAlimTeslimListe.Name = "kitapAlimTeslimListe";
            this.kitapAlimTeslimListe.ReadOnly = true;
            this.kitapAlimTeslimListe.RowHeadersWidth = 51;
            this.kitapAlimTeslimListe.RowTemplate.Height = 24;
            this.kitapAlimTeslimListe.Size = new System.Drawing.Size(726, 195);
            this.kitapAlimTeslimListe.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(585, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 60;
            this.label2.Text = "Kitap Detaylı Bilgi";
            // 
            // lblOgrenciId
            // 
            this.lblOgrenciId.AutoSize = true;
            this.lblOgrenciId.Location = new System.Drawing.Point(182, 280);
            this.lblOgrenciId.Name = "lblOgrenciId";
            this.lblOgrenciId.Size = new System.Drawing.Size(0, 17);
            this.lblOgrenciId.TabIndex = 61;
            // 
            // KitapArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.lblOgrenciId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.kitapYazar);
            this.Controls.Add(this.kitapSayfa);
            this.Controls.Add(this.kitapTuru);
            this.Controls.Add(this.kitapAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.kitapId);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapArama";
            this.Load += new System.EventHandler(this.KitapArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idKitapListe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.TextBox kitapId;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label kitapYazar;
        private System.Windows.Forms.Label kitapSayfa;
        private System.Windows.Forms.Label kitapTuru;
        private System.Windows.Forms.Label kitapAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView idKitapListe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView kitapAlimTeslimListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblOgrenciId;
    }
}