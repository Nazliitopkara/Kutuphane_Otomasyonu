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
    public partial class Ansiklopedi : Form
    {
        public Ansiklopedi()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            button3.BackColor = Color.LightBlue;

            label4.Text = "Roma Mitolojisi";

            label6.Text = "Yunan Mitolojisi";

            label8.Text = "İskandinav Mitolojisi";

            if (button1.Visible)
                button1.Visible = false;
            else
                button4.Visible = true;

            if (button8.Visible)
                button8.Visible = false;
            else
                button5.Visible = true;

            if (button9.Visible)
                button9.Visible = false;
            else
                button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.IndianRed;
            button2.BackColor = Color.LightBlue;

            label4.Text = "Metodoloji";

            label6.Text = "Uluslararası İlişkiler";

            label8.Text = "Tarihi";

            if (button4.Visible)
                button4.Visible = false;
            else
                button1.Visible = true;

            if (button5.Visible)
                button5.Visible = false;
            else
                button8.Visible = true;

            if (button6.Visible)
                button6.Visible = false;
            else
                button9.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "METODOLOJİ";
            label3.Text = "" +
                "Siyaset bilimi metodolojik olarak çeşitlidir ve psikoloji, sosyal araştırma ve bilişsel sinirbilimden kaynaklanan birçok yöntemi benimser. Yaklaşımlar pozitivizm, yorumculuk [en], rasyonel seçim teorisi, davranışçılık, yapısalcılık, postyapısalcılık, felsefi gerçekçilik, tarihsel kurumsallık [en] ve çoğulculuğu içerir. Siyaset bilimi, sosyal bilimlerden biri olarak, araştırmalarında ihtiyaç duyduğu yöntem ve teknikleri kullanır: Tarihsel belgeler ve resmi kayıtlar gibi birincil kaynaklar, bilimsel dergi makaleleri, araştırma anketleri, istatistiksel analiz, vaka çalışmaları, deneysel araştırma ve model oluşturma gibi ikincil kaynaklardan yararlanılır.\n" +
                "Siyaset bilimi, esasen siyasetin herhangi bir yönüyle insan davranışı üzerine bir çalışma olduğu için, kontrollü ortamlarda gözlemlerin yeniden üretilmesi veya kopyalanması çoğu zaman zordur, ancak yine de deneysel yöntemler giderek yaygınlaşmaktadır. Amerikan Siyaset Bilimi Derneği eski başkanı Abbott Lawrence Lowell, 'Deney yapmanın olanaksızlığı ile sınırlıyız.Politika deneysel bir bilim değil, gözlemsel bir bilimdir.' diyerek bu zorluğa atıfta bulunmuştur.[2] Bu nedenle siyaset bilimcileri, kalıpları belirlemek, genellemeler yapmak ve siyaset kuramları oluşturmak için tarihsel olarak siyasal seçkinleri, kurumları, birey ve grup davranışlarını gözlemlemişlerdir.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.IndianRed;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "ULUSLARARASI İLİŞKİLER";
            label3.Text = "" +
                "Uluslararası alanda faaliyet gösteren aktörler arasındaki ilişkileri inceleyen bilim dalıdır. Uluslararası ilişkiler bir bilim olarak 1919'da, Galler'in Aberystwyth kentinde doğmakla birlikte ilk yıllarında Britanya'da gelişmiştir. Bu dönemde disipline hakim ekol, idealizmdir. Savaş sonrası ağırlık merkezi ABD'ye kaymış, hakim paradigma da realizm olmuştur. 1960'lardaki davranışsalcı devrimden etkilenen disiplin daha sonraları pek çok altdala ayrılmıştır. Günümüzde postmodern yaklaşım tarzının benimsenmesiyle uluslararası ilişkiler farklı bir boyut kazanmış, devletler politika üretirken bireysel açılımlara yer vermeye başlamıştır. Liberalizm ve neo-realizmden sonra konstrüktivizm, postyapısalcılık ve bağımlılık çalışmaları en önemli ekolleri ortaya çıkarmıştır. Ayrıca Neo-Gramscian okulunda uluslararası ilişkiler kritik bir bakış açısıyla incelenmektedir.\n" +
                "Siyasal geçişler teorisinin analiz ve krizleri tahmin etme yöntemleri, siyaset biliminin önemli bir bölümünü oluşturur. Kritik geçişleri tahmin etmek için çeşitli genel kriz göstergeleri ve yöntemler önerilmiştir. Bunlar arasında, kriz beklentisi için krizin istatistiksel bir göstergesi, eş zamanlı varyans artışı ve korelasyonlar önerilmiştir ve çeşitli alanlarda başarılı bir şekilde kullanılabilmektedir. Siyasi krizlerin erken teşhisi için uygulanabilirliği, 2014 Ukrayna ekonomik ve siyasi krizinden önceki uzun süren stres döneminin analizi ile kanıtlanmıştır. Kriz öncesi yıllarda Ukrayna toplumundaki 19 adet büyük halk korkusu arasındaki toplam korelasyonda (yaklaşık %64 oranında) ve ayrıca istatistiksel dağılımında (%29 oranında) eşzamanlı bir artış oldu. Bazı büyük devrimlerin paylaştığı bir özellik, tahmin edilememeleri olmakla birlikte, krizlerin ve devrimlerin kaçınılmazlığının görünmesi teorisi de geliştirildi.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "TARİHİ";
            label3.Text = "" +
                "'siyaset bilimi' terimi sosyal bilimlerin ayrı bir alanı olarak geç kavramlaşmış bir alan olsa da siyasal iktidarı ve tarih üzerindeki etkilerini analiz etmek için Antik Çağ'dan beri var olan bir olgudur. Bununla birlikte 'siyaset bilimi' konuları, siyaset felsefesi içinde incelenmiştir. Modern disiplinin içinde ahlakî felsefe, siyasi ekonomi, siyasi teoloji, tarih, olması gerekenlerin normatif olarak belirlenmesi ile ideal devletin özelliklerinin ve işlevlerinin tümdengelimiyle uğraşan diğer alanlar olmak üzere bir dizi öncüleri bulunmaktadır.\n" +
                "Siyaset bilimi geçmişte dar anlamda devlet ve iktidar kavramları üzerine araştırmalar yapmaktayken günümüzde, siyasi kararların tahlili, sosyal grupların karar ve etki ilişkilerindeki rolü, siyasi katılma, toplumsal yapı ve iktidar ilişkisi, devletin kökeni, siyasi değişme ve gelişme gibi konuları da incelemektedir.\n" +
                "Siyaset bilimi, karşılaştırmalı siyaset, siyasi ekonomi, uluslararası ilişkiler, siyaset teorisi, kamu yönetimi, kamu politikası ve siyasal metodoloji dahil olmak üzere çok sayıda alt alanı kapsar. Ayrıca, ekonomi, hukuk, sosyoloji, tarih, felsefe, beşeri coğrafya, gazetecilik, siyasal antropoloji ve sosyal politika alanlarıyla da ilgilidir ve bunlardan yararlanır.\n";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "ROMA MİTOLOJİSİ";
            label3.Text = "" +
                "Roma mitolojisi, Antik Roma'da yaşayan insanların mitolojik inançlarının bütününe verilen isimdir. Genelde iki ana bölümü olduğu düşünülür; ilk bölüm ki daha sonraları etkin olmuştur ve edebidir, genellikle Etrüsk mitolojisindeki öğelerin Romalılaştırılmış hallerinden meydana gelir, ikinci bölüm ise daha erken dönemlerde etkin olmuş olan ve daha çok kültik olan farklı uygulama ve inançlara sahip daha özerk bir bölümdür.\n" +
                "Reski rahiplik, roma ayinsel ibadet ve uygulamalarını iki tanrı sınıfına ayırmaktadır: di indigetes ve de novensides veya novensiles. İndigetes Roma devletinin, şehrinin, özgün tanrılarıydılar ve böyle yaklaşık 30 tanrıya adanmış özel bayramlar (festivaller) mevcuttu. Novensides ise kültleri tarihi süreçte daha sonraları şehre gelmiş tanrılardır ki bunların ortaya çıkışları genellikle belirli bir kriz veya ihtiyacın doğduğu bilinen, belirli tarihlerdir." +
                "Erken Roma tanrılarına, di indigetes'e, ilaveten çeşitli etkinlik ve eylemlerde çağrılan özelleşmiş veya uzmanlaşmış küçük tanrılar da mevcuttu. Bu tür eylemlere ayinsel bir boyut kazandırılmıştı, örneğin ekini ekerken belli bir tanrı ismiyle çağrılır, hasat ederkense bir başkası çağrıldı. Aslında bu yoğun ayin kültürünün ve küçük tanrı anlayışının temelinde politeizmden çok bir tür polidemonizm yatmaktaydı; zira bu küçük tanrıların güçleri ancak uzmanlaştıkları/özelleştikleri eyleme yetmekteydi, diğer eylemlerde herhangi bir güçleri bulunmuyor ve bu nedenle de tanrıdan çok bir tür ilahi ruh kavramına yakındılar." +
                "Roma devleti etrafındaki bölgeleri fethettikçe komşu kültür ve toplulukların yerel tanrıları da Roma mitolojisine giriş yapmıştır. Romalılar geleneksel olarak yeni fethedilen yerlerin tanrılarına da kendi özgün tanrıları ile bir tutmuş aynı saygı ve onuru bahşetmişlerdir. Birçok seferde yeni fethedilen bölgenin tanrılarının da Roma'da yeni tapınaklarda yer almaları için davette bulunulmuştur. Bu nedenle Roma'ya özgü olmayan birçok farklı kült, tanrı ve tanrıça Roma mitolojisine giriş yapmış kimi zaman bu yeni tanrı ve tanrıçalar hali hazırda Roma mitolojisinde var olan belirli tanrı ve tanrıçalarla özdeşleştirilmiştir.";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "YUNAN MİTOLOJİSİ";
            label3.Text = "" +
                "   Yunan mitolojisi, Antik Yunan'da dünyanın yaratılışı, tanrı, tanrıça ve kahramanların hayatı hakkındaki söylence ve öğretileri içermekle kalmayıp aynı zamanda Eski Yunan dininin gövdesini oluşturmaktadır. Günümüzde, bu mitoloji hakkındaki bilgilerimizi bu sözlü edebiyatın yazılı hâllerinden alıyoruz. Tarihçiler, mitoloji hakkında daha ayrıntılı bilgi almak için o dönemin sanatındaki ipuçlarını bile toplar.\n" +
                "Genel olarak Yunan mitolojisi Yakın Doğu ve birçok Avrupa mitolojisini etkilemiştir. Yunan Tanrılarının her biri Romalılar tarafından kabul görmüş ve farklı isimler kullanılmıştır. Roma mitolojisi neredeyse tamamen Yunan mitolojisini baz almıştır. Yunan mitolojisindeki çoğu efsaneler de insan şeklindedir. Yunan tanrılarının yaratılış hikâyeleri seçilmiş 12 tanrı (bu 12 tanrı, 4 kadın ve 8 erkekten oluşmaktadır.) Olimpos Dağı'nda otururlar, her şey Olymposlu Tanrılarla Titanların savaşlarıyla başlar ve Olymposluların zaferiyle son bulur. Savaştan sonra Titanlar cezalandırılır. Gaia, Khaos (Khaos zaten Titanlar tarafından yok edilmişti.), Phoebe ve Kronos (bkz.: Titan) gibi Titanlar Tartarus'a gönderilir (Tartoros bir titan fakat Tartarus sonsuzluğa kadar giden bir yeraltı yeridir.). Tartarus'ta sonsuza kadar süren bir cezaya Olimpos Tanrıları tarafından bırakılır. Yerküreyi taşımak ile cezalandırılan Atlas gibi, bununla birlikte Titanlardan Olimposluların yanına geçen Titan tanrıları da vardır Prometheus gibi,Yunan Tanrıları dünyayı Olympos Dağının tepesindeki bulutların üzerinden idare ederler. Toplamda 12 Tanrı bulunur. Bu 12 sayısı hiç bozulmaz, bir tanrı eklenirse bir başkası bu listeden çıkar. Örneğin Dionysos pantheona dahil olduğunda Hestia Olimpos'tan ayrılmıştır. Şimşeklerin efendisi Zeus nice savaşlar vererek yönetimi babası Kronos ve onun yardakçıları titanların elinden almış, 3 erkek kardeşiyle dünyayı bölüşmüştür. Çekilen kuraya göre gökyüzü Zeus'a, denizler Poseidon'a, yeraltı da Hades'e düşer. Herkes görev dağılımından sonra Olimpos'a çıkar ve dünyayı yönetmeye başlarlar ama Olimpos'un ve Olimpos tanrılarının kralı Zeus'tur.\n" +
                "Tarihçiler Herodot ve Diodorus Siculus ve coğrafyacılar Pausanias ve Strabo, Yunan dünyasında dolaşıp ve duydukları hikâyeleri kayıt ederek, birçok yerel mitoloji ve efsaneleri genellikle az bilinen alternatif versiyonlar vererek sundu. Özellikle Herodot, çeşitli gelenekleri araştırdı ve Yunanistan ile doğu arasındaki çatışmalarda tarihi ya da mitolojik kökenleri buldu. Herodot, kökeni ve farklı kültürel kavramların harmanlanmasını bağdaştırmaya çalıştı.";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "İSKANDİNAV MİTOLOJİSİ";
            label3.Text = "" +
                "   Nors veya İskandinav mitolojisi, İskandinavya'da yaşamış Kuzey Cermen halklarının Hristiyanlık öncesi dinleri, inanışları ve efsaneleri. Cermen mitolojisinin bir parçası olan İskandinav mitolojisi, Anglosakson mitolojisi ve Kıtasal Cermen mitolojisi ile yakından ilişkilidir. Öyle ki Cermen halklarının dinî ritüellerinin çoğunu Kuzey Cermenlerinden (İskandinavlar) öğreniyoruz, bunun sebebi diğer Cermen halklarından kalan belgelerin sayısının yeterli olmamasıdır.\n" +
                "KÖKENLER: MÖ 1000 yıllarında Avrupa'nın büyük bir kısmına Hint-Avrupa dilleri ve kültürü yayılmıştı. MÖ ilk bin yılın ortalarında Cermen kabilelerinden Güney İskandinavya ve Kuzey Almanya bölgesinde yaşamışlardı. Bu halkların yayılmaları ve ilerlemeleri MÖ 2. yüzyılla kadar devam etti. Bu nedenle İskandinav ve Kıtasal Cermen mitolojileri aynı temeller üzerindedir ve birçok ortak noktası vardır. Snorri Sturluson'un Eddası (1179-1241) bu efsanelerin çoğunu içerir. Mitolojinin yaratılış detaylarını çok çeşitli kaynaklara dayanarak sadece Snorri kaleme almıştır.\n" +
                "BAŞLANGIÇ: Başlangıçta boşluk vardı (Ginnungagap). Dünya daha var olmadan önce 11 nehir akan Niflheim'da ölüm var oldu. Niflheim'ın güneyinde başka bir sıcak dünya daha oluştu; Muspell; Devlerin koruduğu yer. Devler buraya Stur yani Siyah dediler. Niflheim'ın nehirleri donmuştu. Bu nehirlere Ginnungagap dendi. Günün birinde Muspell'deki kıvılcımlar nehirlerin üzerine düştü ve nehirleri eritti. Erimiş nehirlerden oluşan damlacıklar Ymir'i şekillendirdi ve Ymir'in terinden diğer dişi ve erkek devler oluştu.";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
