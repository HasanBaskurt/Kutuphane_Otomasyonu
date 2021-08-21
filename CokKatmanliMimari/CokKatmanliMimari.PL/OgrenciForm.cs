using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;  // BL katmanını kullandık
using Entity; // Entity katmanını kullandık

namespace CokKatmanliMimari.PL
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void OgrBilgiListesi()  //Ogrencinin bilgilerinin tutulduğu fonksiyon
        {
            OgrenciVeri ogrenci = new OgrenciVeri()  // Ogrenci veriden nesne oluşturuldu
            {
                OgrenciId = int.Parse(lblIdOgrenciForm.Text) //Id ogrenci ıd ' ye aktarıldı
            };

            //Ogrenci bilgileri labellara aktarıldı
            ogrenci = OgrenciBL.ogrenciIdBilgi(ogrenci);
            lblOgrenci.Text = "Hoşgeldin  " + ogrenci.OgrenciAd;
            lblAd.Text = ogrenci.OgrenciAd;
            lblSoyad.Text = ogrenci.OgrenciSoyad;
            lblNo.Text = ogrenci.OgrenciNo;
            lblSifre.Text = ogrenci.OgrenciSifre;
            lblCinsiyet.Text = ogrenci.OgrenciCinsiyet;
            lblCeza.Text = ogrenci.OgrenciCeza.ToString();
        }

        public void listeRenklendirme() //Tabloda teslim sürelerinin gecikme veya teslim edilme durumlarına göre renklendirme yapıldı
        {
            for (int i = 0; i < kitapAlimTeslimListe.Rows.Count; i++) // Tablo satırı kadar döndürüldü
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); //Nesne oluşturuldu

                if (Convert.ToBoolean(kitapAlimTeslimListe.Rows[i].Cells[4].Value) == true) // testlim edilme durumu kontrol edildi
                {
                    //Satır renklendirildi
                    renk.BackColor = Color.Green; 
                    renk.ForeColor = Color.White;
                }

                else
                {
                    //Teslim edilmeyen kitapların teslim tarihine ne kadar kaldığı öğrenildi
                    TimeSpan sonuc = DateTime.Now - Convert.ToDateTime(kitapAlimTeslimListe.Rows[i].Cells[2].Value);

                    // 15 gün ve üzeri ise satır kırmızı renk yapıldı
                    if (sonuc.TotalDays > 15) 
                    {
                        renk.BackColor = Color.Red;
                    }

                    // teslim süresine 2 gün kalmış ise satır sarı yapıldı
                    if (sonuc.TotalDays >= 13 && sonuc.TotalDays <= 15)
                    {
                        renk.BackColor = Color.Yellow;
                    }
                }
                kitapAlimTeslimListe.Rows[i].DefaultCellStyle = renk; // Satırlara renklendirme işlemi gerçekleştirildi

            }
        }
        private void OgrenciForm2_Load(object sender, EventArgs e)
        {

            OgrBilgiListesi(); // Ogrenci bilgilerinin tutulduğu fonksiyon çağrıldı

            AlinanKitapVeri alinanKitapVeri  = new AlinanKitapVeri()  // nesne oluşturuldu
            {
                OgrenciId = int.Parse(lblIdOgrenciForm.Text)  //id ataması yapıldı
            };
             kitapAlimTeslimListe.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık

             // Bir sütunu gizledik ve diğer sütunların başlıklarını düzenledik
             kitapAlimTeslimListe.Columns[0].Visible=false;
             kitapAlimTeslimListe.Columns[1].HeaderText = "Kitap Adı";
             kitapAlimTeslimListe.Columns[2].HeaderText = "Alınma Tarihi";
             kitapAlimTeslimListe.Columns[3].HeaderText = "Teslim Tarihi";
             kitapAlimTeslimListe.Columns[4].HeaderText = "Teslim Edilmiş mi ?";

            KitapIadeVeri iade = new KitapIadeVeri()  // nesne oluşturuldu
            {
                OgrenciId = int.Parse(lblIdOgrenciForm.Text)  // id ataması yapıldı
            };
            comboBoxAlinan.DataSource =KitapIadeBL.kitapAlinanLİste(iade); //Combobox a alinabilicek kitaplar aktarıldı
            comboBoxTeslim.DataSource =KitapIadeBL.kitapTeslimLİste(iade); // Combobox ateslim edilecek kitaplar aktarıldı
            listeRenklendirme();  // Tablodaki satırları renklendirme fonksiyounu çağrıldı

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciGirisForm ogrenci = new OgrenciGirisForm();  //  Ogrenci giriş formundan nesne üretildi
            this.Hide();                                       // Bulunduğumuz form ekranı kapatıldı
            ogrenci.Show();                                   // Ogrenci nesnesini kullanarak ogrenci giriş formu açıldı

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();  // Picturebox ' a tıklanınca uyguylamayı kapattık
        }

       
        private void alinanKitapListe_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            if (comboBoxAlinan.Text != "") //Text in doluluğu kontrol edildi
            {
                TimeSpan gecenSure = DateTime.Now - dateTimePickerAlim.Value.Date; //zaman farkı alındı
                if (gecenSure.TotalDays >= 0)  // Şuanki günden ileri olup olmadığı kontrol edildi
                {

                    KitapOgrenciVeri kitapId = new KitapOgrenciVeri() //nesne oluşturuldu
                    {
                        KitapAd = comboBoxAlinan.Text //Kitap adı aktarıldı
                    };

                    
                    KitapIadeVeri kitap = new KitapIadeVeri() // nesne oluşturuldu
                    {
                        KitapId = KitapIadeBL.kitapId(kitapId), // kitap id aktarıldı
                        OgrenciId = int.Parse(lblIdOgrenciForm.Text),  // ogrenci id aktarıldı
                        KitapAlinma = dateTimePickerAlim.Value.Date  // alinma tarihi aktarıldı
                    };

                    KitapIadeBL.kitapAlimIslemi(kitap); // Veri tabanında alma işlemi gerçekleştirildi


                    //Güncel liste oluştruuldu
                    AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()
                    {
                        OgrenciId = int.Parse(lblIdOgrenciForm.Text)
                    };
                    kitapAlimTeslimListe.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri);
                    listeRenklendirme();

                    //güncel kitaplar oluşturuldu
                    KitapIadeVeri iade = new KitapIadeVeri()
                    {
                        OgrenciId = int.Parse(lblIdOgrenciForm.Text)
                    };
                    comboBoxAlinan.DataSource = KitapIadeBL.kitapAlinanLİste(iade);
                    comboBoxTeslim.DataSource = KitapIadeBL.kitapTeslimLİste(iade);

                    MessageBox.Show("Kitap alındı.");
                }
                else
                {
                    MessageBox.Show("Alım tarihi bugünden ileri bir tarih olamaz !");
                }
            }
            else
            {
                MessageBox.Show("Alınabilir kitap mevcut değil.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KitapArama ogrenci = new KitapArama();  //  Kitap arama formundan nesne üretildi
            ogrenci.lblOgrenciId.Text = lblIdOgrenciForm.Text; //id ataması yapıldı
            this.Hide();                           // Bulunduğumuz form ekranı kapatıldı
            ogrenci.Show();                       // Ogrenci nesnesini kullanarak ogrenci giriş formu açıldı
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GrafikForm ogrenci = new GrafikForm();  //  Grafik formundan nesne üretildi
            ogrenci.lblOgrenciId.Text = lblIdOgrenciForm.Text; //id ataması yapıldı
            this.Hide();                           // Bulunduğumuz form ekranı kapatıldı
            ogrenci.Show();                       // Ogrenci nesnesini kullanarak grafik formu açıldı
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (txtOdeme.Text != "")  // text doluluğu kontrol edildi
            {
                KitapIadeVeri ogrenciId = new KitapIadeVeri()  // nesne oluşturuldu
                {
                    OgrenciId = int.Parse(lblIdOgrenciForm.Text) //id ataması yapıldı
                };
                KitapIadeBL.ogrenciCeza(ogrenciId); // Ceza bilgisi çekildi
                if (ogrenciId.OgrenciCeza != 0)  // ceza durumu 0 değil ise...
                {
                    float ceza = ogrenciId.OgrenciCeza - float.Parse(txtOdeme.Text); //ceza farkı atandı
                    if (ceza >= 0)  // cezanın eksi olmaması kontrol edildi
                    {
                        ogrenciId.OgrenciCeza = ceza; // Ogrenci cezasına aktarıldı
                        KitapIadeBL.ogrenciCezaIslemi(ogrenciId); //veri tabanı ile işlem gerçekleşti
                        OgrBilgiListesi(); //Güncel liste çağrıldı
                        MessageBox.Show(txtOdeme.Text + " Tl ödendi.");
                        txtOdeme.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ödenecek tutar cezadan büyük olamaz!");
                    }
                }

                else
                {
                    MessageBox.Show("Borcunuz Bulunmamaktadır.");
                    txtOdeme.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödenecek tutarı giriniz!");
            }
            
        }

        private void txtOdeme_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (comboBoxTeslim.Text != "")  // text doluluğu kontrol edildi
            {

                KitapOgrenciVeri kitapId = new KitapOgrenciVeri() // nesne oluşturuldu
                {
                    KitapAd = comboBoxTeslim.Text //kitap adı aktarıldı
                };


                KitapIadeVeri kitap = new KitapIadeVeri() // nesne oluşturuldu ve bilgiler aktarıldı
                {
                    KitapId = KitapIadeBL.kitapId(kitapId),
                    OgrenciId = int.Parse(lblIdOgrenciForm.Text),
                    KitapTeslim = dateTimePickerTeslim.Value.Date,
                    KitapKontrol = true
                };
                KitapIadeBL.kitapTarih(kitap); //alinma tarihi çekildi
                TimeSpan sonuc = kitap.KitapTeslim - kitap.KitapAlinma; // zaman farkı alındı
                if (sonuc.TotalDays >= 0) //zaman farkını eksi olamaması kontrol edildi
                {
                    KitapIadeBL.kitapTeslimIslemi(kitap); //teslim işlemi gerçekleştirildi

                    //Güncel liste
                    AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()
                    {
                        OgrenciId = int.Parse(lblIdOgrenciForm.Text)
                    };
                    kitapAlimTeslimListe.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri);
                    listeRenklendirme();  // tablo satırları renklendirildi

                    //Güncel  Kitap
                    KitapIadeVeri iade = new KitapIadeVeri()
                    {
                        OgrenciId = int.Parse(lblIdOgrenciForm.Text)
                    };
                    comboBoxAlinan.DataSource = KitapIadeBL.kitapAlinanLİste(iade);
                    comboBoxTeslim.DataSource = KitapIadeBL.kitapTeslimLİste(iade);

                    if (sonuc.TotalDays > 15)  // teslim süresi 15 günü geçmiş ise ceza işlemi uygulandı
                    {
                        float ceza = float.Parse(sonuc.TotalDays.ToString()) - 15;  //15 gün teslim süresini aşanlara hergün için 1 tl kesildi
                        KitapIadeBL.ogrenciCeza(iade); //Ceza bilgisi çekildi
                        iade.OgrenciCeza += ceza; //üzerine ekleme yapıldı
                        KitapIadeBL.ogrenciCezaIslemi(iade); // Veri tabanında ceza işlemi gerçekleşti
                        OgrBilgiListesi(); // Güncel liste 
                    }

                    MessageBox.Show("Teslim edildi");
                    
                }

                else
                {
                    MessageBox.Show("Teslim tarihi alım tarihinden önce olamaz!");
                }

            }

            else
            {
                MessageBox.Show("Teslim edilecek kitabın yok !");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
