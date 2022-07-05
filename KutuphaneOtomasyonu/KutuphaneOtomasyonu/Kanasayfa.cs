using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class Kanasayfa : Form
    {
        public Kanasayfa()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        public string ktc;

        private void button1_Click(object sender, EventArgs e)
        {
            ArastirmaBilim fr = new ArastirmaBilim();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TarihCografya fr = new TarihCografya();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ansiklopedi fr = new Ansiklopedi();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TIP fr = new TIP();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FELSEFE fr = new FELSEFE();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EDEBIYAT fr = new EDEBIYAT();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EGITIM fr = new EGITIM();
            fr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GAZETEVEDERGI fr = new GAZETEVEDERGI();
            fr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            INANC fr = new INANC();
            fr.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }

        private void Kanasayfa_Load(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
                groupBox1.Visible = false;
            
            label6.Text = ktc;

            SqlCommand komut = new SqlCommand("Select KullaniciAd,KullaniciSoyad From Kullanici Where KullaniciTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label6.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            if (textBox1.Text == "uzay")
            {
                label4.Text = "ARAŞTIRMA-BİLİM";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Uzay";
                label7.Text = "Uzay Bilimi Nedir?";
                label10.Text = "Güneş Sistemimizdeki Gezegenler";
                label11.Text = "Gezegenler Hakkında İlginç Bilgiler";
            }
            if (textBox1.Text == "teknoloji")
            {
                label4.Text = "ARAŞTIRMA-BİLİM";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Teknoloji";
                label7.Text = "Teknoloji Nedir?";
                label10.Text = "Teknolojinin Yararları";
                label11.Text = "Teknolojinin Zararları";
            }
            if (textBox1.Text == "eski türk tarihi")
            {
                label4.Text = "TARİH-COĞRAFYA";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Eski Türk Tarihi";
                label7.Text = "İslamiyet Öncesi Türk Tarihi";
                label10.Text = "Uygurlar";
                label11.Text="";
            }
            if (textBox1.Text == "coğrafya")
            {
                label4.Text = "TARİH-COĞRAFYA";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Coğrafya";
                label7.Text = "";
                label10.Text= "Jeomorfoloji Nedir?";
                label11.Text="";
            }
            if (textBox1.Text == "mitoloji")
            {
                label4.Text = "ANSİKLOPEDİ";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Mitoloji";
                label7.Text = "Roma Mitolojisi";
                label10.Text = "Yunan Mitolojisi";
                label11.Text = "İskandinav Mitolojisi";
            }
            if (textBox1.Text == "siyaset")
            {
                label4.Text = "ANSİKLOPEDİ";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Siyaset";
                label7.Text = "Metodoloji";
                label10.Text = "Uluslararası İlişkiler";
                label11.Text = "Tarihi";
            }
            if (textBox1.Text == "sistemler")
            {
                label4.Text = "TIP";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Sistemler";
                label7.Text = "Dolaşım Sistemi";
                label10.Text = "Bağışıklık sistemi";
                label11.Text = "Sinir sistemi";
            }
            if (textBox1.Text == "hormonlar")
            {
                label4.Text = "TIP";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Hormonlar";
                label7.Text = "Hormon Nedir?";
                label10.Text = "Hormonların Önemi";
                label11.Text = "Bazı Hormon Türleri";
            }
            if (textBox1.Text == "felsefe")
            {
                label4.Text = "FELSEFE";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Felsefe";
                label7.Text = "";
                label10.Text = "Felsefe Nedir?";
                label11.Text = "";
            }
            if (textBox1.Text == "şiir")
            {
                label4.Text = "EDEBİYAT";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Şiir";
                label7.Text = "Sessiz Gemi";
                label10.Text = "Hikaye";
                label11.Text = "Gidişini Anlatıyorum";
            }
            if (textBox1.Text == "kişisel gelişim")
            {
                label4.Text = "EĞİTİM";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Kişisel Gelişim";
                label7.Text = "Diksiyon";
                label10.Text = "Mobbing";
                label11.Text = "Stres Yönetimi";
            }
            if (textBox1.Text == "gazete")
            {
                label4.Text = "GAZETE VE DERGİ";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Gazete";
                label7.Text = "Magazin";
                label10.Text = "Spor";
                label11.Text = "Siyaset";
            }
            if (textBox1.Text == "dergi")
            {
                label4.Text = "GAZETE VE DERGİ";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Dergi";
                label7.Text = "D Vitamini Eksikliği";
                label10.Text = "Müzik Dünyasının Gizemli Kadını";
                label11.Text = "Üniversite Okuma Oranı";
            }
            if (textBox1.Text == "kutsal dinler")
            {
                label4.Text = "İNANÇ";
                label5.BackColor = Color.DarkSalmon;
                label5.Text = "Kutsal Dinler";
                label7.Text = "Müslümanlık";
                label10.Text = "Hristiyanlık";
                label11.Text = "Yahudilik";
            }
        }
    }
}
