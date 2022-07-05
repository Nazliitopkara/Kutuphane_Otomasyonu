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
    public partial class TIP : Form
    {
        public TIP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            button3.BackColor = Color.LightBlue;

            label4.Text = "Dolaşım Sistemi";

            label6.Text = "Bağışıklık sistemi";

            label8.Text = "Sinir sistemi ";

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

            label4.Text = "Hormon Nedir?";

            label6.Text = "Hormonların Önemi";

            label8.Text = "Bazı Hormon Türleri";

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

        private void button9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "BAZI HORMON TÜRLERİ";
            label3.Text = "" +
                "Oksitosin\n" +
                "Oksitosin, primer olarak beyinde nöromodülatör görevi olan bir memeli hormonudur. Beyinde hipotalamusta sentez edilir ve arka hipofizden salınır. Oksitosin en fazla üremedeki rolü ile bilinir. Özellikle doğum esnasındaki ve doğum sonrasındaki rolü önemlidir. Doğum esnasında serviks ve uterusun gerilmesi ile çok miktarlarda salınır, rahim kaslarının kasılmasını uyarır ve doğumu kolaylaştırır. Doğumdan sonra ise meme başı uyarısı ile sütün salınımını sağlayarak emzirmeye yardımcı olur.\n" +
                "Tiroksin\n" +
                "Tiroksin veya T4; tiroid bezi tarafından salgılanan, tirozin aminoasitlerinden üretilen, iyot atomları içeren bir hormondur.T4, iki adet tirozin aminoasitine toplam 4 tane iyot atomunun bağlanmasıyla oluşur. Bazal metabolizma hızını arttırır, protein sentezine etki eder ve vücudun katekolaminlere (adrenalin vs.) olan duyarlılığını arttırır. Bazal metabolizma hızının artması, hücre reaksiyonlarının hızlanması, böylece daha hızlı ve yüksek oranda enerji açığa çıkması nedeniyle vücut ısısı yükselir. Soğuk iklimli bölgelerde yaşayan insan topluluklarının daha sıcak iklimde yaşayanlara oranla daha fazla T4 salgıladığı bilinmektedir.\n" +
                "Büyüme hormonu\n" +
                "Büyüme hormonu, Growth hormon (GH) veya Somatotropin; ön hipofizden salgılanan, peptit yapılı, insanlarda ve hayvanlarda büyüme, hücre üretimi ve yenilenmesini uyaran hormondur. Ön hipofizin somatotropik (asidofilik) hücrelerinde 191 aminoasitlik tek bir polipeptit zincir şeklinde üretilmektedir. GH sentez ve salınımı, hipotalamustan salgılanan büyüme hormonu salgılatıcı hormon (GHRH) tarafından kontrol altında tutulmaktadır.\n" +
                "İnsülin\n" +
                "İnsülin, moleküler ağırlığı 5,8 kilodalton (kDa) olan, polipeptit yapılı ve vücuttaki karbonhidrat özüştürmesinin düzenlenmesinde glukagon ile birlikte rol alan bir hormondur. Kan şekerini düşürücü etki yapar.\n" +
                "Glukagon\n" +
                "Glukagon, pankreasın α-hücreleri tarafından sentez edilen bir polipeptit hormondur. Glukagon molekülü, 29 amino asitten kurulmuştur. Glukagon, bağırsak hormonları olan sekretin, vazoaktif intestinal polipeptit ve gastrik inhibitör polipeptit ile yapısal benzerlik gösterir. Glukogonun son zamanlarda memeli beyninde de bulunması, bir nörotransmitter olarak işlev görüyor olabileceğini düşündürmektedir.\n" +
                "Adrenalin\n" +
                "Adrenalin (Epinefrin), böbreküstü bezlerinin iç kısımları tarafından öz bölgede salgılanan bir hormondur.Doğada bu hormonun görevi, organizmayı acil harekete hazırlamaktır. Etkisini, nabzın atışı, kanın iç organlar ve deriden kaslara sevk edilmesi, karaciğerdeki glikojenin glikoza değişmesi ve böylelikle, acil bir enerji kaynağı sağlanması şeklinde gösterir. Heyecan ve korku durumunda adrenalin salgılanması artar. Kan damarlarını genişletir. Acı hissini azaltır. Göz bebeklerinin büyümesiyle göze alınan ışık artar, daha net ve hızlı görüş sağlanır.\n" +
                "Testosteron\n" +
                "Testosteron androjen grubundan bir steroid hormondur. Memelilerde testosteron birincil olarak, erkeklerde testisler, dişilerde yumurtalıklarda üretilir. Çok az bir oranda da böbreküstü bezlerinden salgılanır. Erkek cinsiyet hormonudur.\n" +
                "Östrojen\n" +
                "Östrojen, kadınların adet döngüsünde ve diğer memeli hayvanların dişilerinde estrus döngüsünde önemli rol oynayan bir grup steroid hormondur.Östrojenler hem erkek hem kadınlarda bulunmakla beraber, üreme yaşında kadınlarda seviyeleri çok daha yüksektir. Bu hormonlar kadınlarda göğüs gibi ikincil cinsiyet özelliklerinin gelişimini sağlarlar ve adet döngüsüyle ilişkili olan endometrium kalınlaşması ve diğer süreçleri düzenlerler. ";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "DOLAŞIM SİSTEMİ";
            label3.Text = "" +
                "Dolaşım sistemi veya kardiyovasküler sistem maddelerin vücuttaki dolaşımını sağlayan organ sistemidir.\n" +
                "Dolaşım sisteminin olmaması:\n" +
                "Dolaşım sistemine sahip olmayan canlılara örnek olarak yassı solucan (Platyhelminthes filumu) verilebilir. Bu canlının vücut boşluğunda herhangi bir kaplayıcı tabaka veya sıvı bulunmamaktadır. Sindirim sistemine açılan bir ağza sahiptirler.\n" +
                "Açık dolaşım sistemi:\n" +
                "Bu tip dolaşım sistemi yumuşakçalar ve eklembacaklılar gibi omurgasızların büyük bir kısmında görülür. Bu canlılarda hemosöl olarak adlandırılan vücut boşluklarında dolaşım sıvısı organları doğrudan sarar (yıkar) ve kan (dolaşım sıvısı) ile interstisyel sıvı (doku sıvısı) arasında ayrışma yoktur. Bu birleşik sıvıya hemolenf denir. Hayvan hareket ederken oluşan kas hareketleri hemolenf hareketini sağlar fakat sıvı akışını bir bölümden diğerine yönlendirilmesi kısıtlıdır. Kalp gevşediğinde kan açık gözenekler (por) aracılığıyla kalbe döner.Hemolenf vücudun içini (hemosöl) tamamen kapsar ve tüm hücreleri sarar. Hemolenf su, inorganik tuzlar ve organik bileşiklerden oluşur. Birincil oksijen taşıyıcı molekül ise hemosiyanindir. Kılcal kan damarları bulunmaz.Ayrıca, hemosit olarak adlandırılan hücreler vardır ki bunlar hemolenfte bağımsız bir şekilde gezer ve antropod bağışıklık sisteminde rol alırlar. Kanın damarlardan geçerek vücut boşluğuna aktıktan sonra toplanarak kalbe dönmesidir. Açık dolaşım derisi dikenlilerde (denizkestanesi, denizyıldızı vb.), eklem bacaklılarda (örümcek, arı, sinek vb.) ve yumuşakçalarda (deniz anası, istiridye, midye vb.) görülür.\n" +
                "Kapalı dolaşım sistemi:\n" +
                "Kapalı dolaşım sisteminin ana yapıları kalp, kan ve kan damarlarıdır.Tüm omurgalıların ve halkalı solucanlar (Annelida filumu) ile kafadanbacaklıların (Cephalopoda sınıfı) dolaşım sistemleri kapalıdır; yani kan, kan damarlarından oluşan sistemden çıkmaz - bu damarlar sisteminin içinde dolaşır. Kan damarları arter (atardamar), kapiler (kılcaldamar) ve venlerden (toplardamar) oluşur. Arterler oksijenlenmiş kanı dokulara taşırken, venler oksijenlenmemiş kanı geri kalbe taşır . Kan arterlerden venlere kılcal damarlar yoluyla geçer ki kılcal damarlar en ince ve en çok sayıdaki kan damarlarıdır . Kan damarları genişleyerek (vazodilasyon) veya daralarak (vazokonstriksiyon) kanın gerekli bölgelere yönlendirilmesini sağlayabilir. Örneğin, yoğun egzersiz sırasında kan bağırsaklardan, o anda yoğun bir şekilde besin ve oksijene ihtiyaç duyan iskelet kaslarına yönlendirilebilir.Memelilerin dolaşım sistemlerinde kan bir tam dolaşımda kalpten iki kez geçer. Pulmoner dolaşım yani küçük dolaşım, kanı kalp ile akciğer arasında taşır; sistemik dolaşım yani büyük dolaşım da kanı kalp ile vücudun diğer bölümleri arasında taşır.Balıkların dolaşım sistemlerinde ise kan bir tam dolaşımda kalpten bir kez geçer. Kan kalpten solungaçlara pompalanır ve sonra doğrudan vücudun kalanına akar. Kan solungaçları terk ettikten sonra basıncı büyük oranda düşer; bu nedenle, memelerin dolaşım sistemine oranla, hayatî organlara kan akışı hem daha yavaş hem de daha az basınçlıdır. Bu tip bir dolaşım sistemi memelilere uygun değildir, zira bu kadar düşük basınçta böbrekler etkili biçimde çalışamaz.[1]Kısacası kanın kalp ve damarlar sistemiyle çalışmasıdır. Kapalı dolaşım ilk kez toprak solucanında görülmüştür. Omurgalıların tamamında kapalı dolaşım vardır. Balıklarda kalp 2 odacıklıdır ve vücutlarında kirli kan dolaşır. Kurbağalarda kalp 3 odacıklıdır ve vücutlarında kirli kan dolaşır. Sürüngenlerde kalp 3 odacıklıdır ve kalp karıncığında yarım perde vardır. Timsahlarda perde tamdır, kirli ve temiz kan panizza adı verilen bir kanalda karışır.";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "BAĞIŞIKLIK SİSTEMİ";
            label3.Text = "" +
                "Bağışıklık sistemi, bir canlıdaki hastalıklara karşı koruma yapan, patojenleri ve tümör hücrelerini tanıyıp onları yok eden işleyişlerin toplamıdır. Sistem, canlı vücudunda geniş bir çeşitlilikte, virüslerden parazitik solucanlara, vücuda giren veya vücutla temasta bulunan her yabancı maddeye kadar tarama yapar ve onları, canlının sağlıklı vücut hücrelerinden ve dokularından ayırt eder. Bağışıklık sistemi, çok benzer özellikteki maddeleri bile birbirinden ayırabilir, örneğin; bir amino asidi farklı olan proteinleri bile birbirinden ayırabilecek özelliğe sahiptir. Bu ayrım, patojenlerin konak canlıdaki savunma sistemine rağmen enfeksiyon yapmaları için yeni yollar bulmalarına, bazı uyumlar sağlamalarına neden olacak kadar karmaşıktır. Bu mücadelede hayatta kalmak için patojenleri tanıyan ve onları etkisizleştiren bazı mekanizmalar gelişmiştir. Doğadaki tüm canlılar kendilerinden olmayan doku, hücre ve moleküllere karşı savunma sistemlerine sahiptirler. Hatta bakteriler gibi basit tek hücreli canlılarda da onları viral enfeksiyonlara karşı koruyan enzim sistemleri bulunur. Yüksek canlılardaysa çok daha karmaşık bir bağışıklık sistemi vardır. Omurgalılarda bağışıklık sistemi özel işlevlere sahip çok sayıda farklı hücre ve molekül içermektedir.\nGeçmiş çağlardaki ökaryotik canlılarda diğer basit bağışıklık mekanizmaları gelişmiş ve günümüzdeki bitkiler, balıklar, sürüngenler ve böcekler gibi torunlarına miras kalmıştır. Bu mekanizmalar, defensinler olarak adlandırılan antimikrobiyal peptidleri, fagositleri ve kompleman sistemi kapsar. Daha tecrübeli sistemler omurgalıların evrimiyle, nispeten yakın zamanda gelişmiştir. İnsan gibi omurgalılardaki bağışıklık sistemleri dinamik işleyiş sırasında birbirlerini etkileyen, seçilmiş proteinlerin, hücrelerin, organların ve dokuların bazı çeşitlerinden oluşur. Daha karmaşık bağışıklık yanıtının bir parçası olan omurgalıların sistemi, zamanla patojenleri daha etkili tanımaya uyum sağlamıştır. Uyum süreci bağışıklık belleğini yaratmış ve bu da patojenlerle gelecek karşılaşmalarda daha etkili bir koruma sağlamaya izin vermiştir. Edinilmiş bağışıklığın bu süreci aşılamanın temelini oluşturmaktadır.\nBağışıklık sistemindeki bozukluklar hastalıklara neden olabilir. Bağışıklık yetmezliği hastalıkları, bağışıklık sistemi normalden daha az etkin olduğunda meydana gelir, tekrarlayan ve yaşamı tehdit eden enfeksiyonlarla sonuçlanır. Bağışıklık yetmezliği ayrıca X-SCID gibi genetik hastalıkların bir sonucu ya da farmosötikler veya HIV retrovirüsünün neden olduğu AIDS gibi bir enfeksiyonun sonucu olarak da görülebilir. Buna zıt olarak, kendinebağışık (otoimmün) hastalıklar, normalden fazla etkin olan bir bağışıklık sisteminin, vücudun kendi dokularını yabancı olarak algılayıp, onlara saldırmasıyla sonuçlanır. Yaygın kendine bağışık hastalıklar; romatoid artrit, diyabet tip 1 ve sistemik lupus eritematozus'dur.\nBağışıklık sistemi, eski çağlardan bu yana ilgi çeken bir konu olmuş, insanlar tarih boyunca bazı bağışıklık yöntemleri bile geliştirilmiştir.\nGünümüzde bağışıklık sisteminin çok geniş ölçüde aydınlatılabildiği söylenebilir, bu sistemi oluşturan unsurlardan, hastalıkların tanı ve tedavisinde geniş ölçüde yararlanılmaktadır. Günümüzde 'bağışıklık bilimi' olarak bilinen 'immünoloji', Eski Roma’da askerlikten muaf (korunmuş) asillere denilen immunitas sözcüğünden gelmektedir. İmmünoloji günümüzdeki rolüyle bilimsel çalışmalarının oldukça önemli alanlarını oluşturmaktadır.";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "SİNİR SİSTEMİ";
            label3.Text = "" +
                "Sinir sistemi veya sinir ağı, canlıların içsel ve dışsal çevresini algılamasına yol açan, bilgi elde eden ve elde edilen bilgiyi işleyen, vücut içerisinde hücreler ağı sayesinde sinyallerin farklı bölgelere iletimini sağlayan, organların, kasların aktivitelerini düzenleyen bir organ sistemidir. Sinir sistemi iki bölümden oluşur. Merkezi sinir sistemi (MSS) ve çevresel sinir sistemi (ÇSS). MSS, beyin ve omurilikten oluşur. ÇSS, MSS'yi vücudun diğer tüm kısımları ile bağlayan uzun fiberlerden oluşur. ÇSS, motor nöronları, dolaylı istemli hareket, otonom sinir sistemi, sempatik sinir sistemi, parasempatik sinir sistemi, düzenli istemsiz işlevler ve enterik sinir sisteminden oluşur.\nİnsan türü için Beyin diğer beyin organına sahip canlı türlerine göre dikkate değer biçimde, düşünce ve hormonal sistemle birlikte çalışarak duygu üretir. Sinir sistemi, süngerler dışında çoğu çok hücreli hayvanlarda bulunur. Fakat çok karmaşık yapıya sahiptir. Sinir sistemi olmayan çok hücreli organizmalar, süngerler, placozoalar ve mesozoalar çok basit vücut yapısına sahiptir. Taraklılar ve knidliler (örn, anemones, hydras, corals ve denizanalarındaki) sinir sisteminde farklı bir sinir ağı vardır. Birkaç solucan türü hariç, diğer tüm hayvan türlerinde, bir beyin ve bir omurilikten (veya paralel çalışan iki omurdan) oluşan sinir sistemi vardır. Bunlardaki sinirler, beyin ve omurilikten dağılır. En basit solucanlarda sinir sistemi, birkaç yüz hücreden oluşurken, insanlarda 100 milyarlarca sinir hücresi (nöron) bulunur.\nSinir sisteminin en basit işlevi, bir hücreden diğerine veya vücudun bir parçasından diğerlerine sinyal iletmektir. Sinir sisteminin işlev bozukluğu çok çeşitli biçimlerde olabilir. Bunlara genetik bozukluk, travma, zehirlenme, fiziksel yaralanma, enfeksiyon veya erken yaşlanma (progeria) örnek verilebilir. Ayrıca sinir sistemi ile ilgili menenjit, şizofreni, Alzheimer hastalığı, kortikal görme bozukluğu, Parkinson hastalığı, epilepsi (sara), multipl skleroz (MS) gibi hastalıklar vardır. Tıpın nöroloji ihtisas alanı sinir sistemi bozukluğunun nedenleri ile ilgilenir ve bozukluğu önlemek için araştırma ve müdahale yapar. Çevresel sinir sisteminde, en yaygın meydana gelen problem türü, çeşitli nedenlerden dolayı ortaya çıkan sinir iletimi arızasıdır. Bunlara diyabet nöropati ile sinir hücreleri kaybına neden olan multipl skleroz ve amyotrofik lateral skleroz örnek verilebilir.\nNörobilim, sinir sistemi ile ilgilenen bir bilim dalıdır.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "HORMON NEDİR?";
            label3.Text = "" +
                "Hormon, Yunanca kökenden gelmektedir; ὁρμῶν yani uyarmak, canlandırmak anlamındadır. İç salgı bezlerinden kana geçen ve organların işlemesini düzenleyen adrenalin, insülin, tiroksin vb. fizyolojik etkisi olan maddelerin genel adı olarak tanımlanmaktadır.[1] Hormonlar; klasik anlamda endokrin organlar diye bilinen hipofiz, böbrek üstü bezleri, tiroit, paratiroit, gonatlar gibi kanalsız iç salgı bezlerinde sentez edilen ve kanla taşınarak gittikleri belli hedef doku hücrelerinde etki gösteren organik bileşiklerdir. Fakat klasik hormon tanımına uymayan, ama hormon etkisi gösteren bileşikler de vardır. Hipotalamik düzenleyici hormonlar, antidiüretik hormon, oksitosin, prostaglandinler, gastrin, sekretin, somatostatin, anjiotensin örnek verilebilir.Hormonların kimyasal yapıları heterojendir. Kimyasal yapılarına göre dörde ayrılırlar; peptid veya protein yapısındaki hormonlar, amino asit türevi hormonlar, steroid hormonlar, eikozanoidler.Hormonların, biyolojik etkinlikleri için düşük konsantrasyonları yeterlidir; serumda nmol, pmol düzeylerinde bulunurlar; serum düzeyleri ancak çok hassas metotlarla ölçülebilir. Serum hormon düzeyini ölçmek için sık kullanılan bir metot RIA’dir. Hormonların hepsi uyarıcı değildir; bazıları inhibitör etkilidir. Örneğin somatostatin, diğer bazı hormonların sekresyonunu azaltır; adrenalin, bazen stimulatör bazen inhibitör etkilidir. Hormonların sekresyon hızı sabit değildir; hormona duyulan gereksinim ve hormonun inaktivasyon hızı ile düzenlenir.Hormonların bazıları depolanma özelliği gösterir. Katekolaminler (adrenalin ve noradrenalin), adrenal medulla ve sinir uçlarında hormon-kromogranin a-ATP kompleksi şeklinde depolanırlar; tiroit hormonları, tiroit bezinde depolanırlar. Steroid hormonlar depolanma özelliği göstermezler. Hormonlar, dolaşımda serbest veya transport proteinlere bağlı olarak bulunurlar; peptit yapıda hormonlar ve katekolaminler serbest formdadırlar, steroidler ve tiroit hormonları transport proteinlere bağlı olarak taşınırlar. Hormonun sadece serbest formu biyolojik olayları regüle edebilir. Hormonların bazı etkileri, büyüme faktörleri, histamin, serotonin gibi bazı biyolojik aktif maddeler tarafından gösterilebilir ki endokrin organlardan salgılanmayan fakat hormon etkisi gösteren böyle maddeler doku hormonları olarak adlandırılırlar.Hormonların başlattıkları yanıt uzun sürelidir; hormon ortadan kaybolduktan sonra da devam eder.Hedef dokuların hormona fizyolojik yanıtı, yaş ve genetik yapıya bağlıdır.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.IndianRed;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "HORMONLARIN ÖNEMİ";
            label3.Text = "" +
                "Hormonlar; metabolizmanın, su ve elektrolit alışverişinin, büyümenin, seksüel gelişimin ve seksüel fonksiyonların regülatörleri olarak hayati öneme sahiptirler. Hormonların yokluk, azlık ve fazlalıkları çeşitli hastalık belirtilerine yol açar; bazılarının yokluğu ölüme neden olur. Bu nedenle hekimlikte bir endokrin organın hipofonksiyonunu veya bir hormonun eksikliğini zamanında saptayarak eksik hormonu yerine koymak önemlidir.Bir endokrin organın hiperfonksiyonu da hastalık belirtilerine neden olabilir. Hormon üretiminde patoloji, kandaki hormon miktarının veya karakteristik hormon yıkılım ürünlerinin kantitatif tayini ile saptanabilir. Ayrıca kan plazmasındaki inorganik veya organik maddelerin normal konsantrasyonlarında değişiklik de ilgili maddenin metabolizması üzerine etkili hormonun etkisindeki patolojileri tanımaya yardımcı olur.Bir hormonun azlığında veya yokluğunda, buna karşı gelen hayvansal organdan saf halde hazırlanan hormonun verilmesi suretiyle tedavi mümkündür. Bu durumda genellikle hayat boyunca süren devamlı tedavi yapılması gerekir. Hormon tedavisinde, protein yapısındaki hormonların parenteral yani enjeksiyon gibi sindirim yolu dışı bir yoldan verilmesi zorunluluğu vardır; çünkü, protein yapısındaki hormonların ağız yoluyla alınması halinde, sindirim kanalında parçalanmaları ve emilmemeleri söz konusudur.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
