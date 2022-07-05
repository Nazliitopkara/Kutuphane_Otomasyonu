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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Yonetici Where YoneticiTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MaskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Yanasayfa fr = new Yanasayfa();
                fr.tc = MaskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı TC");

            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Kullanici Where KullaniciTC=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", MaskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Kanasayfa fr = new Kanasayfa();
                fr.ktc = MaskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı TC");

            bgl.baglanti().Close();
        }
    }
}
