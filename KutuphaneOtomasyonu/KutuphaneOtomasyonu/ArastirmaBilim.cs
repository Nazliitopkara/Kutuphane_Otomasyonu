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
    public partial class ArastirmaBilim : Form
    {
        public ArastirmaBilim()
        {
            InitializeComponent();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "UZAY BİLİMİ NEDİR?";
            label3.Text = "" +
                "Astronominin başlıca kategorilerinden birisini oluşturan uzay bilimi: Uzay bilimi, gökbiliminin alt kategorilerinden sadece birisidir. Aynı zamanda başlıktan da anlaşılacağı gibi en geniş kapsamlı bilim dalı arasına girmektedir. Uzay bilimi bir anlamda, tıpkı zincirin halkasına benzer, iç içe geçerek birbirlerini oluştururlar. Bununla birlikte uzay, çok eski dönemlerden beri insanlığın büyük ilgi odağı halindedir." +
                "Uzay bilimi bir başka tanımla, uzayda bulunan gök cisimlerini araştıran bilim dalı olarak adlandırılabilir. Aynı zamanda Güneş, Ay, yıldızlar ve birçok gezegen uzay biliminin araştırmalarına dair kapsamı alanına girmektedir. Uzay bilimleri, bu astronomi olayları çerçevesinde bilimsel çalışmalardan destek almaktadır. Bu astronomi dalında yapılmak istenen amaç, kimsenin bilmediği alanlarda araştırma yaparak Dünya dışında bulunan ve aynı zamanda insanlığa tehdit oluşturabilecek bilgilere ulaşabilmektir." +
                "Uzay çalışmaları, insanlı ve insansız uzay araçları aracılığıyla gerçekleştirilir. Bu çalışmalar, Dünya ve Dünya atmosferi dışarısında gerçekleştirilmektedir. Bu araştırmaları konu edinen bilim dalına da uzay bilimleri denilmektedir. Uzay bilimlerini konuları bakımından iki farklı şekilde alt başlıklarına ayırmak mümkündür. Birincisi, gözlemsel astronomi, ikincisi ise teorik astrofiziktir." +
                "Gözlemsel astronomi, gök cisimlerinin uzay teleskopları aracılığı ile gözlemlenmesine denmektedir. Aynı zamanda bu gözlem tekniğinde gökyüzünde gerçekleşen olaylar da dâhil olmaktadır. Bu gözlemsel astronomiye örnek olarak astronometriyi örnek verebiliriz." +
                "Teorik astrofizik ise, gökyüzünde gerçekleşen bu olayların fiziksel olarak incelenmesini ve modellenmesini konu almaktadır. Teorik astrofizikçiler, gözlemlerini test etmek için verilerden yararlanırlar. Bununla birlikte uzay bilimi hakkında bu iki ana alt dal birbirlerini tamamlayan yaklaşımlardır." +
                "Konuları bakımından uzay bilimlerini de beş ana maddeye ayrılmaktadır. Bu bilimler ise sırasıyla, yıldız astronomisi diğer adıyla yıldız bilimi, gezegen bilimi, galaktik astronomi, Ekstragalaktik astronomi ve kozmolojidir. Aynı zamanda uzay bilimleri disiplinler arası çalışmalardan da faydalanmaktadır.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "GÜNEŞ SİSTEMİNDEKİ GEZEGENLER";
            label3.Text = "KARASAL GEZEGENLER\n" +
               "İç gezegenler olarak da adlandırılan dört gezegen -Merkür, Venüs, Dünya, Mars- aynı zamanda karasal gezegenlerdir. Çünkü yüzeylerinin çoğu karalardan oluşur.\n" +
               "JOVİAN GEZEGENLERİ\n" +
               "Dış gezegenler olarak da adlandırılan – Jüpiter, Satürn, Uranüs ve Neptün – Jovian gezegenleri olarak bilinir (Jüpiter benzeri anlamına gelir). Çünkü hepsi karasal gezegenlere kıyasla çok büyüktür ve gazdan oluşurlar. (Bazıları ya da hepsinin katı çekirdeğe sahip olabilecekleri söyleniyor.)\n" +
               "CÜCE GEZEGENLER\n" +
               "Uluslararası Astronomi Birliği ‘nin cüce gezegen tanımı şu şekildedir: Başka bir nesnenin uydusu olmadan Güneş’in etrafında dönmesi, kendi yerçekimi ile dönebilecek kadar büyük olması ve temiz bir yörüngeye sahip olması." +
               "Plüton’un cüce gezegen olma sebebi ise, küçük boyutu ve sıra dışı yörüngesinin yanı sıra, birçok başka nesneyle yörüngesini paylaşmasıdır. Yine de, Plüton’un gezegen olma konusu tartışmalıdır.\n" +
               "GEZEGEN SIRALAMALARI\n" +
               "1.MERKÜR\n" +
               "Güneşe en yakın olan Merkür, Ay’dan sadece biraz daha büyük. Gündüz Güneş’e dönük tarafı 450 Santigrat’a kadar ulaşabilir ancak gece tarafında sıcaklıklar donma derecesinin altında yüzlerce dereceye düşer. Merkür, meteor etkilerini emecek bir atmosfere sahip değildir, bu yüzden yüzeyi tıpkı Ay gibi kraterlerle doludur.\n" +
               "2.VENÜS\n" +
               "İkinci gezegen olan Venüs Merkür’den daha sıcaktır. Atmosferi toksik yani zehirlidir. Yüzeydeki baskı sizi ezer ve öldürür. Büyüklüğü ve yapısı Dünya’ya benzer. İşin garibi, Venüs çoğu gezegenin tersi yönünde ve yavaşça döner.\n" +
               "3.DÜNYA\n" +
               "Üçüncü gezegen olan Dünya’mız üçte ikisinin okyanusla kaplı bir su dünyasıdır. Hayatı barındırdığı bilinen tek gezegendir. Dünyanın atmosferi, yaşamı sürdürmeyi sağlayan azot ve oksijen bakımından zengindir.\n" +
               "4.MARS\n" +
               "Dördüncü gezegen olan Mars, soğuk ve tozlu bir yer. Demir oksit olan bu toz, gezegene kırmızımsı rengini verir. Bilim insanları, bugün soğuk ve çöl benzeri olsa da, bir zamanlar Mars’ın ıslak ve sıcak olduğunu düşünüyorlar.\n" +
               "5.JÜPİTER\n" +
               "Beşinci gezegen olan Jüpiter, Güneş sistemimizdeki en büyük gezegendir. Çoğunlukla gazdan -hidrojen ve helyum- oluşur. En büyük bir özelliği, artık Jüpiter ‘in karakteristik bir özelliği haline gelen ve büyük kırmızı bir leke olarak görünen fırtınasıdır.Bu fırtına yaklaşık 350 yıldır devam etmektedir. Ayrıca Jüpiter, güçlü bir manyetik alana sahiptir ve düzinelerce uydu ile minyatür bir Güneş sistemine benzetilir.\n" +
               "6.SATÜRN\n" +
               "Altıncı gezegen olan Satürn, halkaları ile bilinir. Bu halkalar buzlardan ve kayalardan meydana gelir.\n" +
               "7.URANÜS\n" +
               "Yedinci gezegen olan Uranüs biraz gariptir. Ekvatoru, yörüngesine neredeyse dik açı yapan tek dev gezegendir. Yani ilk bakışta yan duran bir gezegen diyebiliriz. Gökbilimciler, gezegenin uzun zaman önce başka bir gezegen boyutunda bir cisimle çarpıştığını ve eğilmeye neden olduğunu düşünüyor.Bu eğim, 20’den fazla yıl süren mevsimlere neden olur. Uranüs, Neptün ile aynı boyuttadır. Atmosferindeki metan, Uranüs’e mavi-yeşil tonunu verir. Çok sayıda Ay’a ve soluk halkalara sahiptir.\n" +
               "8.NEPTÜN\n" +
               "Sekizinci gezegen olan Neptün, bazen ses hızından daha hızlı olan kuvvetli rüzgarlarıyla tanınır. Neptün, tespit edilmeden önce matematik kullanarak var olduğu tahmin edilen ilk gezegendir. Dünya’dan çok uzak ve çok soğuktur. Neptün, Dünya’nın yaklaşık 17 katı büyüklüğündedir.\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "GEZEGENLER HAKKINDA İLGİNÇ BİLGİLER";
            label3.Text = "* Teleskopla uzaya bakan ilk kişi yaklaşık 400 yıl önce İtalyan astronom, fizikçi, mühendis, filozof ve matematikçi Galileo Galilei’dir.\n" +
               "* Uzay esnektir. Zamanın başlangıcından beri ölçülebilir bir oranda genişlemektedir.\n" +
               "* Star Wars filmi The Empire Strikes Back’de Han Solo, tıka basa asteroitle dolu bir bölgeden geçmektedir. Gerçekte bir asteroit tek başına 400.000 mil kare boyutundadır. Bu nedenle, bir uzay gemisinin bir asteroid ile çarpışma şansı bir milyarda birdir.\n" +
               "* Uzay boşluğunda ses yoktur.\n" +
               "* Su Dünya’da kaynarken, binlerce küçük kabarcık oluşturur. Ancak, uzayda, kaynayan su bir dev gibi ve dalgalı bir balon üretir. Bilim adamları bunun, yerçekimine eşlik eden konveksiyon ve yüzdürme eksikliğinden kaynaklandığına inanıyorlar.\n" +
               "* Uzaydaki ilk Amerikalı, 5 Mayıs 1961’de Merkür 3 ile uzaya fırlatılan Alan Shepard’tı. Merkür 3 gemisi, yörüngeye oturamamıştır. Ancak 116 mil (185 km) yüksekliğe çıkmış ve 303 mil (484 km) uzayda uçmuş ve Atlantik Okyanusu’na güvenli bir şekilde iniş yapmıştır.\n" +
               "* Uzaya çıkan ilk Afrikalı Amerikalı, 1983’te uzay mekiği Challenger’da görevli Guion “Guy” Bluford, Jr. idi. Mae Jemison 12 Eylül 1992’de Endeavour ile uzaya çıkan ilk Afrikalı Amerikalı kadın oldu.\n" +
               "* Uzayda yerçekimi olmadığı için, doğal bir konveksiyon (ısınan gazın yükselmesi) yoktur, bu da vücut ısısının cildin üstünden yayılmayacağı anlamına gelir. Bu nedenle, vücut kendini sürekli serinletme ihtiyacı hisseder ve terler, fakat ne yazık ki, ter uzayda damlamaz ya da buharlaşmaz – sadece birikir.\n" +
               "* Uzayda yerçekimi olmadığı için, hiçbir kaldırma kuvveti de yoktur, bu da hiçbir gazlı içeceğin kabarcıklarını yukarı ve dışarı itmediği anlamına gelir. Bu nedenle, içtikten sonra bir kolanın gazını çıkarmak yani geğirmek imkansızdır.\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            button3.BackColor = Color.LightBlue;

            label4.Text = "Uzay Bilimi Nedir?";

            label6.Text = "Güneş Sistemimizdeki \nGezegenler";

            label8.Text = "Gezegenler Hakkında \nİlginç Bilgiler";

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

            label4.Text = "Teknoloji Nedir?";

            label6.Text = "Teknolojinin Yararları";

            label8.Text = "Teknolojinin Zararları";

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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "TEKNOLOJİ NEDİR?";
            label3.Text = "" +
                "   Teknoloji bir insan etkinliğidir. İnsanlık tarihinde bilimden ve mühendislikten önce var olmuş olan bir kavramdır. Pek çok yönden bilimin uygulamaya geçirilmiş hali olarak görülmektedir. Teknoloji sayesinde insanların hayatta kalabilmesi için gerekli olan araç ve gereçlerin üretilmesi sağlanır. Ayrıca üretim yöntemlerinin, yeteneklerin bir araya gelmesini sağlayan bilgi bütününe de teknoloji olarak nitelendirilmektedir. Günümüzde hayatın her alanında varlık gösteren teknolojik ürünler sayesinde yaşam oldukça kolaylaşmıştır. Teknoloji sayesinde üretim artmış, mesafeler kısalmış, bilgi tüm dünyaya yayılmış, gelişmiş düzeyi artmış, kişilerin yaşamları kolaylaşmıştır. \n" +
                "TEKNOLOJİ NE ANLAMA GELİR? \n" +
                "   Teknolojinin kelime kökeni Yunancadan gelmektedir. Yunanca sanat ve bilmek sözcüklerinin bir araya gelmesi sonucunda teknoloji kelimesi ortaya çıkmıştır. Teknoloji insanların ihtiyaçlarının karşılanması için aletlerin yapılması, üretimin gerçekleşmesini sağlayan bilgi, teknik ve yetenekler bütünü olarak adlandırılmaktadır. Bilim günlük yaşama aktarılmış hali teknoloji olarak nitelendirilebilir. \n" +
                "Bilimi gelişim göstermesiyle birlikte yapılan çalışmalar sayesinde teknik yönden kaydedilen gelişmeler teknoloji olarak nitelendirilir. İnsanlığın ürettiği bilgi birikimi sayesinde bilim sürekli gelişerek var olur. Bilimin gelişmesi ve teknik bilgilerin artması sayesinde de teknolojik ürünler üretilir. Bilim ilerledikçe teknoloji de aynı oranda gelişir. \n" +
                "TEKNOLOJİNİN ÖNEMİ NEDİR?\n" +
                "  Teknoloji insan hayatı için son derece önemli bir yer tutmaktadır. İnsanlığın var olma mücadelesi başladığından beri teknoloji de hayatın vazgeçilmez bir unsuru haline gelmiştir. İnsanları hayatını kolaylaştırması, zamandan tasarruf edilmesini sağlaması nedeniyle teknoloji günlük yaşamın olmazsa olmaz, tamamlayıcı bir parçasıdır.\n " +
                "Akıllı ev sistemleri, mutfak gereçleri, toplu taşıma, otomobiller, akıllı telefonlar, tabletler, bilgisayarlar günlük hayatta insanların karşısına sürekli çıkan teknolojik ürünlerden bazılarıdır. Bu teknolojik ürünler sayesinde insanlar ilkellikten kurtularak daha çağdaş koşullarda hayatını devam ettirebilmektedir. Teknolojinin sunduğu avantajlar sayesinde insanlar yorulmadan günlük yaşamlarını sürdürür. Günlük yaşamı tamamen etkisi altına alan bir diğer teknolojik unsur ise internettir. İnternet sayesinde alışveriş yapma, bilgi edinme, eğitim alma, ödeme yapma, eğlenme, iletişim kurma gibi pek çok faaliyet kolaylıkla yerine getirilebilmektedir. İnternet kişilerde bağımlılık yaratacak kadar günlük hayata dahil olmuş durumdadır. Bir ülkenin gelişmişlik düzeyi sahip olduğu teknolojik olanaklar ve üretebildiği teknolojik ürünler ile ölçülebilir. Teknoloji sayesinde üretim kolaylaşır, bayındırlık düzeyi artar, sanayileşme elde edilir. Ülkenin refah düzeyi yükselir. Pek çok teknolojik başarı beraberinde ekonomik başarıyı da getirmektedir. Ülkeler teknoloji satarak iktisadi olarak dışa olan bağımlılıktan kurtulabilir.";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.IndianRed;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "TEKNOLOJİNİN YARARLARI";
            label3.Text = "" +
                "● Teknoloji sürekli gelişim gösteren, hiçbir zaman durağan olmayan bir unsurdur. Hemen hemen her gün kişilerin hayatına yeniliklere ve kolaylık getiren bir teknolojik gelişme ortaya çıkar. \n" +
                "● Teknolojik ürünler ve icatlar günlük hayata olumlu katkı sağlayan unsurlardır. Bu sayede eğitim, sağlık, üretim, ulaşım, beslenme, ticaret, sanayileşme gibi hayatın pek çok alanında iyileşmeler kaydedilir, yaşam kolaylaşır. \n" +
                "● Teknoloji sayesinde bazı alışkanlıklar değişime uğramıştır. Önceden mağaza gezmek suretiyle yapılan alışveriş yerini internet üzerinden evden çıkmaya gerek kalmaksızın yapılan alışverişe bırakmıştır. Bu durum yeterli zamanı olmayanlar, yaşlılar, evden çıkmaya elverişli sağlık koşullarına sahip olmayan kişiler için önemli bir avantaj teşkil eder.\n" +
                "● Teknolojik gelişmeler sayesinde sağlık sorunlarının bertaraf edilmesi için ameliyat teknikleri gelişim göstermiştir, erken tanı koyulması kolaylaşmıştır. Kişilerin daha sağlıklı ve uzun ömürlü bir hayat sürmelerine olanak tanınmıştır.\n" +
                "● Teknoloji sayesinde ulaşım kolaylaşarak mesafeler kısalmıştır. Eskiden uzun zaman süren yolculuklar uçak teknolojisi sayesinde saatlere indirgenmiştir. Mesafelerin azalması sosyal hayatı kolaylaştırmış, ticaretin de gelişmesine katkı sağlamıştır.\n" +
                "● Teknolojinin insanlara sunduğu en önemli kazanım bilgiye ulaşma kolaylığıdır. Teknolojik imkanlar sayesinde bilgiye istenilen zamanda, istenilen yerden ulaşılabilmektedir. Bilgi çeşitliliği ve paylaşımı önemli ölçüde artış göstermiştir. Bu da toplumların kalkınması için oldukça yararlı bir husustur. \n" +
                "● Teknolojik gelişmeler sayesinde bir ürünün pazarlanması, geniş kitlelere duyurulması, mesafelerin kolayca aşılarak kişilere ulaştırılması kolaylaşmıştır. Bu durum da şirketlerin büyümesine ve ekonomik kalkınmaya oldukça olumlu katkılar sağlamaktadır. \n" +
                "● Teknoloji sayesinde eğitim olanakları artar. Eğitim artık yalnızca okulda yürütülen bir faaliyetten çok kişilerin internet vasıtasıyla dilediği an ulaşabildiği bir hale kavuşmuştur. Bu da insanların gelişmesine, bilimin ve icatların ilerlemesine önemli bir katkı sağlamaktadır.\n" +
                "● Teknolojik gelişmeler sanayiciliğin de çağ atlamasına neden olmuştur. Üretimde makineleşme artmış, insan gücüne olan ihtiyaç azalmıştır. Teknoloji sayesinde kısa zamanda daha fazla üretim yapılabilir hale gelmiş, verimlilik artmıştır. Böylece ekonomik ve toplumsal kalkınma elde edilmiştir.  \n" +
                "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "TEKNOLOJİNİN ZARARLARI";
            label3.Text = "" +
                "● Teknolojik ürünler nedeniyle insanlar daha pasif, hareketsiz ve tembel bir yaşam tarzı sürmeye başlamıştır.  \n" +
                "● Teknolojik gelişmeler nedeniyle yüksek kapasiteyle çalışan fabrikalar doğal kaynakların tükenmesine ve çevre kirliliğine neden olmaktadır. Küresel ısınma, hava kirliliği, ormanların katledilmesi teknolojik gelişmelere bağlı olarak ortaya çıkan sorunlardan bazılarıdır. \n" +
                "● Teknoloji nedeniyle insanlar asosyal birer varlık haline gelmiştir, yüz yüze iletişim azalmıştır. Sanal ortam insanların aktif olduğu bir alan haline gelmiştir. Bu nedenle uykusuzluk, depresyon, hareketsizliğe bağlı çeşitli metabolik rahatsızlıklar baş göstermiştir.\n" +
                "●Her bir teknolojik ürün elektrik enerjisi ile çalışır. Bu durumda insanların maruz kaldığı elektromanyetik alanların artmasına yol açar. Elektromanyetik alanların genişlemesi insanların sinir sistemi üzerinde oldukça fazla olumsuz etkiye sahiptir. \n" +
                "● Teknolojik gelişmeler toplum tarafından yakından takip edilmektedir. Bu durumda her teknolojik yenilikten haberdar olan kişiler söz konusu son teknoloji ürünlerini satın almayı hedefler. Bu durumda insanın üreten değil tüketen bir konumda olmasına yol açar. \n" +
                "● Önceden lüks tüketim maddesi olarak görülen ürünler günümüzde birer zorunluluk haline gelmiştir.  Bu da kişileri daha fazla harcamaya iten bir unsurdur. Daha fazla harcama beraberinde ekonomik sıkıntıları ve tüketim çılgınlığını getirmektedir. \n" +
                "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ArastirmaBilim_Load(object sender, EventArgs e)
        {

        }
    }
}
