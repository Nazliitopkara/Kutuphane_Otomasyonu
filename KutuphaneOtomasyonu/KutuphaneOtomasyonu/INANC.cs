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
    public partial class INANC : Form
    {
        public INANC()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            label4.Text = "Müslümanlık";

            label6.Text = "Hristiyanlık";

            label8.Text = "Yahudilik";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "İSLAM";
            label3.Text = "" +
                "Müslümanlık Nedir?\n" +
                "Müslüman'ın dini ölçülerle yaşamasını ifade eden bir terimdir.Müslüman bir kimse eğer dininin gerektirdiği şeyleri yerine getirmekte hata ve yanlışlıklar yaparsa diğer bütün müslümanlığın suçu değil, o kişinin müslümanlığında bir sorun var demektir. Her müslüman, müslümanlığını en iyi şekilde yerine getirmeye çalışmalı ve gayret göstermelidir." +
                "\n\n" +
                "Nasıl Müslüman Olunur ?\n" +
                "Müslümanlık büyük bir şereftir. Kimisi anne babasının müslümanlığından dolayı müslüman olur. Kimisi de sonradan müslüman olur. Önemli olan bu dine girip Allah'a ve emirlerine inanarak, ebedi hayata hazırlanmaktan ibarettir." +
                "Müslüman olmak için, Allah'ın BİR ve TEK olduğuna inanmak, Onun yarattığı meleklerine inanmak, Onun indirdiği kitaplara inanmak, Dini tebliğ etmek için gönderdiği peygamberlere inanmak, ölümden sonra tekrar dirileceğimize ve hesap vereceğimize inanmak, Kaza ve Kader'in Allah'ın dilemesiyle olduğuna inanmak ilk şartlardır. Bunlara İMANIN ŞARTLARI diyoruz. Bunlara inanmak farzdır." +
                "İman ettiğini (yani inandığını) kalp ile tasdik dil ile tekrar etmek gerekir. Kalp ile tasdik demek, Yukarıda sayılan İMANIN ŞARTLARI'na kesin olarak kalben inanmak, şüphe duymamaktır. Dil ile tekrar ise Kelime-i Şahadet'tir.\n" +
                "Eşhedü en-lâa ilâhe illallâah. Ve Eşhedü enne Muhammeden Abduhû ve Rasûluhû.\n" +
                "Anlamı: Ben Şahitlik ederim ki Allah'tan başka ilah yoktur. Ve yine şahitlik ederim ki Muhammed (sallallâhu aleyhi vesellem) Allah'ın kulu ve rasulüdur.\n" +
                "Eğer İmanın Şartlarına kalben inanıp, Kelime-i Şahadet'i de söylerseniz, İnşallah Müslüman oldunuz demektir.\n" +
                "Müslümanın İlk Yapması Gereken Şeyler Nelerdir ?\n\n" +
                "Müslüman olan kişi, İslam dinine girmiş olur. İlk yapması gereken şeylerden en önemlisi dinini öğrenmesidir. İkincisi öğrendiğini uygulaması, Üçüncüsü ise, samimiyettir. İslam dininde bir takım farzlar (emirler) vardır. Bu emirler herhangi bir insan veya varlık tarafından değil, bir ve tek olan Allah tarafındandır. (Yani kısacası, Allah'ın emirlerine Farz Denir)\n" +
                "Müslümanlar ilk olarak FARZ'ları öğrenip uygulamaya koyulmalıdır. \n" +
                "";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "HRİSTİYANLIK";
            label3.Text = "" +
                "Hristiyanlık,Nasıralı İsa'nın yaşamına, öğretilerine ve vaazlarına dayanan, tek tanrılı bir İbrahimî dindir. 2,4 milyarı aşkın takipçisi ile dünyanın en büyük dinidir. Takipçilerine 'Mesihçi' anlamına gelen Hristiyan denir ve Kitâb-ı Mukaddes'e inanan takipçileri, Tanah'ta kehanet edilen İsa'nın Mesih olarak gelişinin Yeni Ahit (Yeni Antlaşma) olduğuna inanırlar." +
                "Hristiyanlar İsa'nın Tanrı'nın Oğlu ve Eski Ahit'te geleceği müjdelenen Mesih olduğuna inanırlar. Hristiyanlık teslis inancı üzerine kuruludur. Bu inanca göre Tanrı'nın kendini açıkladığı üç kimliği vardır: Baba (Peder), Oğul ve Kutsal Ruh (Rûhu'l-Kudüs). Hristiyanlığın inanç sistemi ve ibadetleri İsa tarafından; 1. yüzyılda, Roma İmparatoru Tiberius'un iktidarında Filistin'de ortaya konulmuş, havarileri ve diğer takipçileri tarafından öğretilerek yayılmıştır. Bir kişi Hristiyanlık inancına, Kitâb-ı Mukaddes'teki ayetlerden biri olan Romalılar 10:9 ayetinin yönlendirmesini uygulayarak geçebilmektedir." +
                "Hristiyanlığın kökenleri en azından, MS 1. yüzyılda Roma İmparatorluğu yönetimindeki İsrail'e değin uzanır. Hristiyanlık, temel olarak Yahudilik üzerine kurulmuş ve daha sonraları Tarsuslu Pavlus'un da etkisiyle müstakil bir din olarak gelişmiştir.Hristiyanlığın kutsal kitabı olan Kitâb-ı Mukaddes'in Yahudiliğin kutsal kitabı olan Tanah'ı içinde barındırdığı göz önüne alınırsa Hristiyanlığın erken döneminde Hristiyanlık ve Yahudilik arasındaki bağ daha net anlaşılacaktır.";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "YAHUDİLİK";
            label3.Text = "" +
                "Yahudilik Yahudi milletinin kolektif inancını, kültürünü, hukuki kurallarını ve medeniyetini içeren etnik bir dindir. İlk İbrahimî din olmasının yanı sıra insanlık tarihindeki en eski dinler arasında da yer alan Yahudilik, monoteizm temelli dinlerin ilk örneğidir. Yahudilik, riayetkâr Yahudiler tarafından ,'Avraham'ın YHVH ile yaptıkları sözleşmenin bir ifadesi' olarak yorumlanır. Geniş metinleri ve uygulamaları, çeşitli teolojik pozisyonları ve örgütlenme biçimlerini kapsayan Yahudilik, bir İbrani felsefi görüşü olmakla birlikte aynı zamanda bir dünya görüşüdür. Torah, Tanah'ın bir parçasıdır ve Midraş ile Talmud gibi ikincil metinlerle birlikte temsil edilen tamamlayıcı bir sözlü geleneğin parçasıdır. Dünya çapındaki toplam 14 ila 15 milyon takipçisi ile Yahudilik, en büyük onuncu dindir." +
                "Yahudilik, 'evrenin yaratıcısı, ebedi güç sahibi, her şeye gücü yeten, her yerde olan, adil, merhametli, doğmamış veya doğurmamış' bir varlığın her şeyi yarattığı inancı temeline kuruludur; O varlığın (Tanrı) ismi inanışa göre o kadar mukaddestir ki, nihai telaffuzunun sonsuza dek bilinememesi için Tanah'ta יהוה‎ (YHVH) harfleriyle kodlanmıştır. İnanca göre YHVH'nin, Y’israil'in büyükbabası Avraham Avinu'yu ve ulusunu 'tüm milletler arasında en üstünü' yapma ve 'onlara özel bir toprak verme' sözünü vermesiyle isimsiz bir din olarak kurulur; bu din ismini, gelecek yıllarda dünyaya gelecek olan Yehuda'dan alacaktır." +
                "Yahudilikte, Tanrı'nın Sina Dağı'ndaki Musa'ya hem yazılı hem de sözlü şekilde vahyettiği kanun ve emirlere dayanan, çoğu Rabbânî Yahudilikten ortaya çıkmış bir dizi dinî hareket vardır.Tarihsel olarak bu savunmaların tamamına veya bir kısmına, İkinci Tapınak dönemindeki Sadukiler veya Helenistik Yahudilik üyeleri gibi çeşitli gruplar tarafından meydan okundu; daha sonra Orta Çağ'daki Karaiteler ve modern Ortodoks olmayan mezhepler arasında bu fikir akımı devam etti. Hümanistik Yahudilik gibi Yahudiliğin bazı modern dalları, seküler veya nonteist olarak kabul edilebilir. Günümüzde en büyük Yahudi dinî hareketleri, Ortodoks Yahudilik (Haredi Yahudilik ve Modern Ortodoks Yahudilik), Muhafazakar Yahudilik ve Reform Yahudiliğidir. Bu gruplar arasındaki en önemli fark Yahudi hukukuna, Rabbânîk geleneğin otoritesine ve İsrail Devleti'ne olan fikirsel yaklaşım farklılıklarından kaynaklanır.";
        }
    }
}
