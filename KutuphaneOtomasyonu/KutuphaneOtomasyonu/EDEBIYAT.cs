using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class EDEBIYAT : Form
    {
        public EDEBIYAT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            label4.Text = "Sessiz Gemi";

            label6.Text = "Hikaye";

            label8.Text = "Gidişini Anlatıyorum";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "SESSİZ GEMİ";
            label3.Text = "" +
                "Artık demir almak günü gelmişse zamandan,\nMeçhule giden bir gemi kalkar bu limandan.\nHiç yolcusu yokmuş gibi sessizce alır yol;\nSallanmaz o kalkışta ne mendil ne de bir kol.\nRıhtımda kalanlar bu seyahatten elemli,\nGünlerce siyah ufka bakar gözleri nemli.\nBiçare gönüller! Ne giden son gemidir bu!\nHicranlı hayatın ne de son matemidir bu!\nDünyada sevilmiş ve seven nafile bekler;\nBilmez ki giden sevgililer dönmeyecekler.\nBirçok gidenin her biri memnun ki yerinden,\nBirçok seneler geçti; dönen yok seferinden.\n\n\n\n\nYahya Kemal Beyatlı";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "HİKAYE";
            label3.Text = "" +
                "Senin dudakların pembe\n" +
                "Ellerin beyaz,\n" +
                "Al tut ellerimi bebek\n" +
                "Tut biraz!\n" +
                "\n" +
                "Benim doğduğum köylerde\n" +
                "Ceviz ağaçları yoktu,\n" +
                "Ben bu yüzden serinliğe hasretim\n" +
                "Okşa biraz!\n" +
                "\n" +
                "Benim doğduğum köylerde\n" +
                "Buğday tarlaları yoktu,\n" +
                "Dağıt saçlarını bebek\n" +
                "Savur biraz!\n" +
                "\n" +
                "Benim doğduğum köyleri\n" +
                "Akşamları eşkıyalar basardı.\n" +
                "Ben bu yüzden yalnızlığı hiç sevmem\n" +
                "Konuş biraz!\n" +
                "\n" +
                "Benim doğduğum köylerde\n" +
                "Kuzey rüzgârları eserdi,\n" +
                "Ve bu yüzden dudaklarım çatlaktır\n" +
                "Öp biraz!\n" +
                "\n" +
                "Sen Türkiye gibi aydınlık ve güzelsin!\n" +
                "Benim doğduğum köyler de güzeldi,\n" +
                "Sen de anlat doğduğun yerleri,\n" +
                "Anlat biraz!\n\n\n" +
                "Cahit Külebi";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "GİDİŞİNİ ANLATIYORUM";
            label3.Text = "" +
                "Sen gidiyorsun ya işine yetişmek için\n" +
                "Saçlarını, gözlerini, ellerini\n" +
                "Neyin varsa toplayıp gidiyorsun ya\n" +
                "Her seferinde bir şey unutuyorsun sıcak\n" +
                "Termometrede yükselen çizgi çizgi\n" +
                "Kim bilir nerelerde soğuyorsun\n" +
                "\n" +
                "Senin gözbebeklerin var ya kadın kadın gülen\n" +
                "İnsan insan bakan gözbebeklerin\n" +
                "Beni tutsa tutsa gözlerin tutar ayakta\n" +
                "Beni yıksa yıksa gözlerin yerle bir eder\n" +
                "\n" +
                "Ne gelirse onlardan gelir bana\n" +
                "Çalışma gücü yaşama direnci\n" +
                "Mutluluk gibi kazanılması zor\n" +
                "Mutluluk gibi yitirilmesi kolay\n" +
                "\n" +
                "Bir açarsın ki mutluyum\n" +
                "Bir kaparsın her şey elimden gitmiş\n\n\n\n" +
                "Rıfat Ilgaz";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
