using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CokKatmanliMimari.PL
{
    public partial class BaslangicForm : Form
    {
        public BaslangicForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnOgrenciLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGorevliLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOgrenciLogin_Click_1(object sender, EventArgs e)
        {
            OgrenciGirisForm ogrGiris = new OgrenciGirisForm(); // Geçiş yapılacak formdan nesne oluşturuldu
            this.Hide();                                       // Şuan bulunduğumuz form ekranı kapatıldı
            ogrGiris.Show();                                  // Geçiş yapılan form ekranı açıldı
        }

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            GorevliGirisForm grvGiris = new GorevliGirisForm(); // Gorevli giris formundan nesne oluşturuldu
            this.Hide();                                       // Bulunan form kapatıldı
            grvGiris.Show();                                  //Gorevli giris formu açıldı
        }

        private void BaslangicForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Kapatma pictureBox ına tıklayınca uygulamayı kapatmasını sağladık.
        }
    }
}
