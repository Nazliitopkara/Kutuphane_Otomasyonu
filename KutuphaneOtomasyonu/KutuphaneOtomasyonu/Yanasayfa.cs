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
    public partial class Yanasayfa : Form
    {
        public Yanasayfa()
        {
            InitializeComponent();
        }

        public string tc;
        sqlBaglanti bgl = new sqlBaglanti();

        private void button4_Click(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Yanasayfa_Load(object sender, EventArgs e)
        {
            label6.Text = tc;

            SqlCommand komut = new SqlCommand("Select YoneticiAd,YoneticiSoyad From Yonetici Where YoneticiTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label6.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable ktp = new DataTable();
            SqlDataAdapter kt = new SqlDataAdapter("Select * From KitapKayit", bgl.baglanti());
            kt.Fill(ktp);
            dataGridView1.DataSource = ktp;

            DataTable odnc = new DataTable();
            SqlDataAdapter od = new SqlDataAdapter("Select * From KitapOdunc", bgl.baglanti());
            od.Fill(odnc);
            dataGridView2.DataSource = odnc;

            DataTable kllnci = new DataTable();
            SqlDataAdapter kl = new SqlDataAdapter("Select * From Kullanici", bgl.baglanti());
            kl.Fill(kllnci);
            dataGridView3.DataSource = kllnci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KtpEkle fr = new KtpEkle();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdncEkle fr = new OdncEkle();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YntcEkle fr = new YntcEkle();
            fr.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }
    }
}
