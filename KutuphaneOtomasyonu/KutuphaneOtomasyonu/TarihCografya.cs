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
    public partial class TarihCografya : Form
    {
        public TarihCografya()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            button3.BackColor = Color.LightBlue;

            label4.Text = "İslamiyet Öncesi\n Türk Tarihi";

            label6.Text = "Uygurlar";


            if (button1.Visible)
                button1.Visible = false;
            else
                button4.Visible = true;

            if (button5.Visible)
                button5.Visible = true;

            else
                button5.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "İSLAMİYET ÖNCESİ TÜRK TARİHİ";
            label3.Text = "" +
                "✴ Orta Asya’nın Tarih Öncesi Devirlere ait ilk kültür merkezleri; Anav, Kelteminar, Afanasyeva, Andronova, Karasuk ve Tagar’dır.\n" +
                "✴ Türk kelimesinin devlet adıyla tarihte ilk kez kullanılması 6. asrın içerisinde başlamıştır (Göktürkler). Coğrafi bir ad olarak Türkiye – Türkia şeklinde ilk defa Bizans kaynaklarında Orta Asya için kullanılmıştır.\n" +
                "✴ Tarihteki ilk atlı göçebe Türk topluluğu İskitler (Sakalar)’dır.\n" +
                "✴ Tarihte Türkler tarafından kurulduğu bilinen ilk devlet Büyük (Asya) Hun Devleti’dir.\n" +
                "✴ Asya Hunları’nın bilinen ilk hükümdarları Teoman’dır (Çin Seddi Teoman Dönemi’nde yapılmıştır.)\n" +
                "✴ Tarihte ilk defa Türkleri tek bayrak altında toplayan Türk Devleti, Asya Hun (Büyük Hun) Devleti’dir (Orta Asya’da ilk siyasi birlik sağlandı)\n" +
                "✴ Çin’le yapılan M.Ö. 318 tarihli antlaşma Asya Hun Devleti hakkındaki ilk antlaşmadır (Türkler hakkındaki ilk belge).\n" +
                "✴ Mete Han Dönemi Asya Hunları’nın en parlak dönemidir (M.Ö. 209-74).\n" +
                "✴ Mete Han orduda “onluk sistemi” ve yönetimde “veraset sistemi”ni getirmiştir (ilk kez).\n" +
                "✴ Asya Hunları’nın kolu olan Kuzey Hunları ilk kez Avrupa’ya göç ederek Kavimler göçü’nü başlatmıştır (375).\n" +
                "✴ Anadolu’ya ilk Türk akınları Avrupa (Batı Hun) Hunları tarafından yapılmıştır. İkinci akın Sibirler tarafından yapılmıştır.\n" +
                "✴ Avrupa’da kurulan ilk Türk Devleti Avrupa Hunları’dır (Kuzey Hunları).\n" +
                "✴ Avrupa Hunları en parlak dönemlerini Atilla Dönemi’nde yaşamışlardır (434 -453).\n" +
                "✴ Türklerle Bizanslılar arasında imzalanan ilk antlaşma Margus Barışıdır (Avrupa Hun Dönemi).\n" +
                "✴ İkili devlet teşkilatını ilk uygulayan devlet I. Göktürk Devleti’dir (Bumin Kağan – İstemi Yabgu).\n" +
                "✴ Türk tarihinin bilinen en eski Türkçe yazılı belgeleri Orhun Kitabeleri’dir. NOT: Kitabelerin konusu; Türklerin siyasi yaşantıları ve Türk hükümdarlarının halka karşı sorumluluklarıdır (Sosyal Devlet anlayışı). Kitabeler Yolluğ Tigin tarafından dikilmiştir. Danimarkalı W. Thomson tarafından okunmuştur..\n";
        }

        private void TarihCografya_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "UYGURLAR";
            label3.Text = "" +
                "    Uygurlar, Asya Hun Devleti ne bağlı olarak Orhun ve Selenga nehirleri kıyılarında yaşamışlardır. II. Kök Türk Devleti’nin son zamanlarında Basmiller ve Karluklarla birleşen Uygurlar, bu devlete son vererek kendi devletlerini kurmuşlardır (744). Uygurların merkezi Ötüken’dir." +
                "Kutluk Bilge Kül Kağan Dönemi:\n Uygurların ilk hakanı, Kutluk Bilge Kül Kağan’dır (744-747). Onun döneminde başkent Ötüken’den Orhun Nehri kıyısındaki Ordubalıg’a (Karabalgasun) taşınmış, devletin sınırları Amur Irmağı boylarından Altay Dağları’na kadar uzanmıştır. Kutluk Bilge Kül Kağan’ın ölümünden sonra yerine Uygurların en parlak dönemini oluşturan oğlu Moyen-Çur (747-759) geçmiştir.\n" +
                "Moyen-Çur (Bayan-Çur) Dönemi:\n Moyen-Çur başa geçtiğinde Çin’de büyük bir karışıklık yaşanmaktaydı. Talas Savaşı (751) nedeniyle Çin imparatoruna karşı isyanlar çıktı. Zor durumda kalan imparator, MoyenÇur’dan yardım istedi. Moyen-Çur imparatorun arzusunu yerine getirmekten kaçınmayarak harekete geçti. İmparator bu yardımından dolayı kızını eş olarak MoyenÇur’a verdi. Bu durum Türk-Çin yakınlığını sağlamıştır.Moyen-Çur komşu Türk boyları üzerine seferler yapıp onları yönetimi altına aldı. Ülke sınırlarını genişletti. Moyen-Çur’un ölümünden sonra yerine oğlu Bögü Kağan geçmiştir.\n" +
                "Bögü Kağan Dönemi:\n Bögü Kağan (759-780) zamanında da Çin karışıklık içindeydi. Bögü Kağan, ayaklananlara karşı Çin imparatorunu tutmuş, ayaklanmalarla müdahale etmiştir. Fakat bir süre sonra Çin’e karşı uyguladığı korumacı politikadan vazgeçti. Çin’in içinde bulunduğu karışıklıktan yararlanmak isteyen Bögü Kağan bu ülkeyi ele geçirmek istedi ve Çin’in birçok şehrini işgal etti. Bu işgaller sırasında pek çok ganimet elde edildi. Uygur Devleti, Bögü Kağan zamanında oldukça zenginleşmiştir. Büyük saraylar onun döneminde yapılmıştır.\n" +
                "Baga Tarkan Dönemi:\n Baga Tarkan, ülkede düzeni sağlamak için bazı kanunlar çıkarmıştır. Uygurlar içinde bulunan Dokuz Oğuzlara karşı olumsuz tutum sergilemiştir. Onun bu tutumu devlet içinde büyük karışıklıklara sebep olmuştur. Baga Tarkan ve daha sonraki kağanlar zamanında ortaya çıkan açlık, kıtlık ve salgın hastalıklar devleti iyice zayıflattı. 840 yılında Kırgızlar, Uygur ülkesine girdiler, başkenti alarak hakanı öldürdüler ve Uygur Devleti’ne son verdiler.\n" +
                "Kansu Uygur Devleti (Sarı Uygurlar):\n Uygur Devleti yıkıldıktan sonra Uygurların bir kısmı, Çin’in kuzeyindeki Kansu bölgesine gelerek burada Kansu Uygur Devleti’ni kurdular. Kansu Uygurları Çin’le ticari ilişkilerde bulundular. Bu ilişkileri akrabalık bağları ile de güçlendirdiler. X. yüzyıldan itibaren bağımsız yaşamaya başladılarsa da siyasi ve askerî bakımdan güçlenemediler. 940 yılında, önce Kuzey Çin’e hâkim olan Kitanların, sonra Tangutların, daha sonra da Cengiz Han idaresindeki Moğolların egemenliğini kabul ettiler (1226).";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.IndianRed;
            button2.BackColor = Color.LightBlue;

            label4.Text = "Jeomorfoloji Nedir?";

            label6.Text = "";


            if (button4.Visible)
                button4.Visible = false;
            else
                button1.Visible = true;

            if (button5.Visible)
                button5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "JEOMORFOLOJİ";
            label3.Text = "" +
                "   Jeomorfoloji, yüzey bilimi ya da yerbiçim bilimi de denir) yardımcı dalı yerbilim olan ve yerin yüzey şekillerinin tanımlanmasını ve oluşum süreçlerinin açıklanmasını konu edinen bilim dalıdır.Jeomorfoloji , karalar üzerinde ve denizaltında yer kabuğunun yüzeyinde görülen şekilleri inceleyen, oluşum ve evrimlerini açıklayan, bunları kendi yöntembilimi içerisinde sınıflandıran, coğrafî dağılım ve gruplandırmalarını, nedenleriyle birlikte araştıran bir bilim dalıdır.[1] Bu tanım doğrultusunda çok disiplinli bir bilim dalı olan yer bilimleri topluluğunun bir dalını oluşturur.\n" +
                "   Jeomorfoloji konusu bakımından bazı ülkelerde (ABD, Kanada) yer bilimleri içerisinde, yer kabuğunun yapısı ve dinamiğiyle ilgili jeolojinin, bazılarında ise (Türkiye, Fransa) insan-doğal çevre koşulları arasındaki ilişkiyi inceleyen fiziki coğrafyanın alt dalıdır. Fiziksel coğrafik yaklaşımda jeomorfolojinin konusu olan yer şekilleri iklim, sular ve doğal canlılarla birlikte değerlendirilir. Jeolojik açıdan ise Yerkürenin cansız elemanları olan yer yapısı, yer şekli, iklim ve sular (fizyografya) jeomorfolojinin konusunu oluşturur. Jeoloji, jeofizik, haritacılık, toprak bilimi ve taş bilimi jeomorfolojinin yararlandığı başlıca bilim dallarıdır. Jeomorfoloji incelediği konulara göre alt dallara ayrılır. 'Akışkan jeomorfoloji' akarsuların oluşturduğu yeryüzü şekillerini, 'karst jeomorfolojisi' kireçtaşları üzerinde oluşan şekilleri, 'kıyı jeomorfolojisi' deniz ve göl kıyılarındaki şekilleri, 'buzul jeomorfolojisi' buzullar tarafından oluşturulan yeryüzü şekillerini inceler." +
                "Yukarıdaki tanımdan da anlaşılabileceği gibi jeomorfoloji, yer kabuğunda güncel olarak süregiden yer şekillenmesi süreçleri ile uğraşır ve nihai olarak jenetik yaklaşımla bu şekillenmenin tarihçesini ortaya koymaya çalışır. Yer kabuğu ve yer yapısında güncel olarak meydana gelen olay ve değişimler aynı zamanda jeolojinin de konusudur ve jeoloji bilimi bunlardan topladığı bulgularla Yerküre'nin zaman içerisinde geçirdiği evrimi aydınlatmayı hedefler. Bu kapsamda jeomorfoloji bugünün jeolojisi, jeoloji ise geçmişin jeomorfolojisi olarak değerlendirilebilir. Jeomorfoloji bilimi fiziksel coğrafya ve jeoloji araştırma yöntemlerinin her ikisini birden kullanır. Jeomorfolojik araştırma ve anlatımlar genelde sistematik ve analitik olmak üzere iki türde yapılır. Uygulamalı jeomorfoloji araştırmalarında ise jeolojideki mühendislik alt disiplini araştırmalarına benzer yöntemler uygulanır. Sistematik yaklaşımda (İngilizce: systematic approach) yer şekilleri görünüm ve büyüklüklerine göre ana yerşekili gruplarından başlanarak en küçük şekillere kadar taksonomik bir sınıflandırmaya tabi tutulur ve tanımlanır. Analitik yaklaşımda (İngilizce: analytic approach) ise yerşekilleri oluşum süreçlerine göre ayırt edilir.";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
