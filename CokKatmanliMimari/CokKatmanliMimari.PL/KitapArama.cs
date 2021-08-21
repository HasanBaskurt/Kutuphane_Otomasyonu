using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;        // BL katmanını kullanacağımız için ekledik.
using Entity;   // Entity katmanını kullanacağımız için ekledik.

namespace CokKatmanliMimari.PL
{
    public partial class KitapArama : Form
    {
        public KitapArama()
        {
            InitializeComponent();
        }

        private void KitapArama_Load(object sender, EventArgs e)
        {
            lblOgrenciId.Visible = false;
            idKitapListe.DataSource = KitapBL.kitapListe(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            //Bazı sütunların tabloda görünümünü kapattık
            idKitapListe.Columns[2].Visible = false;
            idKitapListe.Columns[3].Visible = false;
            idKitapListe.Columns[4].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OgrenciForm ogrenci = new OgrenciForm();             //  Ogrenci  formundan nesne üretildi
            ogrenci.lblIdOgrenciForm.Text = lblOgrenciId.Text;  // Ogrenci Id yi aktardık
            this.Hide();                                       // Bulunduğumuz form ekranı kapatıldı
            ogrenci.Show();                                   // Ogrenci nesnesini kullanarak ogrenci formu açıldı

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();  // Picturebox ' a tıklanınca uyguylamayı kapattık
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (kitapId.Text != "")  //text doluluğu kontrol edildi
            {
                KitapVeri kitap = new KitapVeri()  //Kitap veriden nesne oluşturuldu
                {
                    KitapId = int.Parse(kitapId.Text)  // Id aktarıldı
                };

                kitap = KitapBL.kitapIdBilgi(kitap);  // Id bilgisi nesneye aktarıldı
                kitapAd.Text = kitap.KitapAd;
                kitapTuru.Text = kitap.KitapTuru;
                kitapSayfa.Text = kitap.KitapSayfa;
                kitapYazar.Text = kitap.KitapYazar;

                KitapOgrenciVeri kitapogrenci = new KitapOgrenciVeri()  // Kitap öğrenci veriden nesne oluşturuldu
                {
                    KitapId = int.Parse(kitapId.Text)  // Kitap ıd 'si aktarıldı
                };

                if (KitapBL.kitapSorgu_BL(kitap) != false)  // Kitabın mevcut olup olmadığı kontrol edildi
                {
                    kitapAlimTeslimListe.DataSource = KitapIadeBL.kitapOgrenciListe(kitapogrenci);  // Lİste datagride aktarıldı
                    //Sütun başlıkları düzenlendi
                    kitapAlimTeslimListe.Columns[1].HeaderText = "Ad";
                    kitapAlimTeslimListe.Columns[2].HeaderText = "Soyad";
                    kitapAlimTeslimListe.Columns[6].HeaderText = "Teslim Edilmiş mi?";
                }

                else
                    MessageBox.Show("Girilen id'ye ait kitap mevcut değil !");
            }

            else
                MessageBox.Show("Lütfen kitap id giriniz");
        }

        private void kitapId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
