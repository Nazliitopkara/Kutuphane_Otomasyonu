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
    public partial class EGITIM : Form
    {
        public EGITIM()
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
            label4.Text = "Diksiyon";

            label6.Text = "Mobbing";

            label8.Text = "Stres Yönetimi";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "DİKSİYON";
            label3.Text = "" +
                "Diksiyon Eğitimi: Diksiyon kısaca; güzel ve etkileyici konuşmak, dili etkin bir biçimde kullanmak, sesin yapısını irdeleyerek konuşma ve hitabet sanatının gerekliliklerini yerine getirmek olarak tanımlanabilir.\n" +
                "Diksiyon, eğitici bir uzman eşliğinde, duyarak, konuşarak ve pratik yaparak düzeltilir. Diksiyon Eğitimi, sesin düzgün bir şekilde kullanılmasını, güzel ve etkili konuşulmasını ve kelimelerin doğru bir şekilde doğru bir tonlama ile konuşulmasını sağlar.\n" +
                "Diksiyon Eğitimi, doğru nefes alıp verilmesini, uygun bir tonlama, vurgu ve üslubun aktarılmasını sağlar. Diksiyon Eğitimi sayesinde, etkili hitabet, konuşma, dinleme, ses, vurgu, tonlama, artikülasyon, nefes, boğumlama ve iletişim teknikleri uygulanarak akıcı ve üsluba uygun konuşma becerisi kazandırılır.\n\n" +
                "KAZANIMLAR\n" +
                "+ Diksiyon Eğitimi ile konuşma esnasında yapılan temel hataları ortadan kaldırırsınız.\n" +
                "+ Diksiyon Eğitimi sonunda; uzun ve kısa hecelerin yanlış söylenmesi, ünlü ve ünsüz harflerin doğru söylenmemesi gibi doğru bilinen yanlışları gidererek, doğru bir konuşma becerisi kazanırsınız.\n" +
                "+ Düşüncelerinizi ve hislerinizi, çekinmeden rahat bir şekilde karşı tarafa iletirsiniz.\n" +
                "+ Etkili bir konuşma ve hitabet ile özgüveninizi artırırsınız.\n" +
                "+ Ses tonunuzu, doğru zamanda doğru yerde etkin bir şekilde nasıl kullanabileceğinizi öğrenirsiniz.\n" +
                "+ Sesletim, ses geliştirme teknikleri ve fonetik çalışmaları ile ses bilgisi becerilerinizi diksiyon Eğitimi sayesinde geliştirirsiniz.";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "MOBBİNG";
            label3.Text = "" +
                "Mobbing ya da bezdiri (Yıldırma), bir grup insanın, bir kimseye veya başka bir gruba sosyal kabadayılık yapmasıdır.\n" +
                "Latince kökenli sözcük; psikolojik şiddet, baskı, kuşatma, taciz, rahatsız etme veya sıkıntı vermek anlamlarına gelir. En iyi ifade eden anlamıyla yıldırma veya iş yerinde psikolojik terör anlamlarıdır. Özellikle hiyerarşik yapılanmış gruplarda ve kontrolün zayıf olduğu örgütlerde, gücü elinde bulunduran kişinin ya da grubun, diğerlerine psikolojik yollardan, uzun süreli sistematik baskı uygulamasıdır. Son dönemde sosyoloji ve hukuk başta olmak üzere çeşitli alanlarda disiplinler arası çalışılan bir konu haline gelmiştir.\n" +
                "Ters Mobbing (Reverse Mobbing), bir astın veya grup olarak astların üstlerine, kendilerine yapılan mobbing sonucunda, kişisel anlaşmazlıklar sonucunda veya politik oyunlar sonucunda kasıtlı olarak psikolojik tacizde bulunarak, işten ayrılmadan ziyade üstün hiyerarşik pozisyonunu bozmayı hedeflediği bir yıldırma eylemidir. Ters mobbingin uygulanmasında en yaygın olarak asttan üste; sabote etme, talimatlara uymama, kasti yanlış işlem yapma, asılsız söylentiler çıkarma ve bilgi saklama gibi eylemler gerçekleştirilmektedir.\n\n" +
                "Mobbinge karşı ne yapılmalı?\n" +
                "1. Hukuksal haklarını kullanmalı.\n " +
                "2. Yanında güvenilir bir arkadaş varken, mobbing uygulayan kişinin karşısına çıkıp bu tacizin farkında olduğu, tekrarlanırsa yasal hakları kullanacağı yüksek sesle söylenmelidir.\n" +
                "3. Mobbing uygulayan kişinin yaptıklarını, haksız emir ve iş yükü cep telefonuyla kaydedilmeli, gerekirse tek tek yazılmalıdır.\n" +
                "4. Mobbing uygulayan kişi, kendisinden daha yetkili birine hem yazılı hem de sözlü olarak şikayet edilmeli. Bu durum da kesinlikle rapor haline getirilmeli, elde evraklar, tutanaklar, belgeler bulunmalıdır.\n" +
                "5. Tıbbi ve psikolojik yardım alınmalıdır. Bu sayede hem durum, sorun daha kolay atlatılır hem de dava ya da şikayet durumunda elde kanıt bulunur.\n" +
                "6. Çalışılan kurumda daha önceki benzer şikayetlerde nasıl bir yol izlenmiş, önlem alınmış mı diye araştırılmalı, ona göre bir yol izlenmelidir.\n" +
                "7. Yaşanılan sorun mutlaka diğer iş arkadaşlarıyla da paylaşılmalı. Çünkü mobbing uygulayan kişi muhtemelen bunu bir değil, birçok kişiye yapıyordur ve aslında çoğunluk korktuğu, çekindiği için ses çıkaramıyordur. İşte böyle bir durumda önce olmak demek, hem kendinizi hem de pek çok kişiyi dertten kurtarmak demektir. Zaten örgütlü olmak, grup olarak şikayette bulunmak da başarı elde etmekte önemli bir unsurdur.";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "STRES YÖNETİMİ";
            label3.Text = "STRES YÖNETİMİ İÇİN ÖNCE STRES KAYNAKLARINIZI BELİRLEYİN\n\n" +
                "STRES YÖNETİMİ İÇİN EYLEM PLANINIZI HAZIRLAYIN\n\n" +
                "Değiştirilebilecek kaynaklar için eylem planınızı hazırlayın: Üzerinde değişiklik yapabileceğiniz veya ortadan kaldırabileceğiniz kaynaklar için nasıl bir yol haritası izleyeceğinizi belirleyin. Bunu yaparken kısa-orta-uzun vadeli bir plan hazırlayabilirsiniz. Küçük küçük adımlarla başlamanın bile bir başlangıç olduğunu ve sizi sonuca ulaştıracağını unutmayın. Ayrıca bu planı yazarak veya çizerek yapmak harekete geçmeniz için sizi motive edecektir.\n" +
                "ALET ÇANTANIZI GÜÇLENDİRİN\n\n" +
                "Değiştirilemeyecek kaynaklarla mücadele için alet çantanızı güçlendirin: Bazı stres kaynaklarını ortadan kaldırmak veya onlardan uzak kalmak mümkün olmayabiliyor. Bu durumda yapılacak şey, kendi mücadele araçlarınızı artırmak ve güçlendirmektir. Fiziksel, bireysel ve işinize ait örgütsel değiştirilemez stres faktörlerinizi belirleyip, onlarla barışmaya ve beraber yaşamaya hazır olun.\n" +
                "KENDİNİZİ TANIYIN VE ÖZEL REÇETENİZİ OLUŞTURUN\n\n" +
                "Uzman Psikolog Simru Kavak “Stresi yönetebilmenin en etkili yollarından biri de, kendinize özel reçete hazırlamak. Bunun için, strese karşı dayanıklılığı artırdığı bilinen standart yöntemlerden faydalanabilirsiniz. Aşağıdaki sorulara yanıtlarınızı verin ve bu cevaplar üzerine düşünün: Beni neler mutlu ediyor? Nelere tutku duyuyorum? En çok ne yapmaktan hoşlanıyorum? Bunu kiminle, kimlerle yapmak hoşuma gidiyor? Zamanımı kiminle veya kimlerle daha fazla geçirmek istiyorum? Kim beni gülümsetiyor, mutlu ediyor? Denemek ve yapmaya başlamak istediğim şeyler neler? Sonrasında yapacağınız şey ise, verdiğiniz cevaplardaki aktivitelere ve kişilere günlük hayatta ayırdığınız zamanı yavaş yavaş artırmak” diyor.\n" +
                "STRES YÖNETİMİNDE HAREKETSİZLİKTEN KAÇININ\n\n" +
                "Değiştirilemeyen stres kaynakları söz konusu olduğunda pek çok araştırma, açık havada tempolu yürüyüş, yoga gibi fiziksel aktivitenin stresle mücadeledeki etkisinden bahsediyor. Ancak hoşlanmadan ve zorla yapacağınız her şey sizi daha fazla strese sokacağından kendinize uygun olan fiziksel aktiviteyi keşfedin. Yüzme, bisiklet, pilates ya da tenis gibi mutlaka hoşlanacağınız bir faaliyette bulunun.\n" +
                "STRESİ YÖNETMENİN ÖNEMLİ UNSURU: ZAMANI İYİ PLANLANLAMAK\n\n" +
                "Değiştirilemeyen stres kaynaklarından birisi de, zamanı doğru yönetememek sonucu biriken işler. Zamanla rekabet etmeyin, onu takım arkadaşınız haline getirin. Günlük planınızda öncelikli ve önemli işlerle, bekleyebilecek olanları belirleyin. Bunları yazılı olarak hoşunuza giden bir ajandada veya telefonunuzda görmek, yönetmenizi kolaylaştıracaktır. Olabildiğince plana sadık kalın. Elinizde olmayan ve planı aksatacak işler devreye girdiğinde de, nefes egzersizlerinden faydalanın.\n" +
                "SABIRLI OLUN\n\n" +
                "Uzman Psikolog Simru Kavak “Hiç bir yöntemin sihirli değnek olmadığını bilin. En önemlisi, bu yolculukta kendinize karşı sabırlı olun, süreklilik gerektiren bir gelişim sürecinde olduğunuzu unutmayın. Kilo vermek istediğiniz zaman, sadece bir gün spor yaparsanız, vücudunuzda hiçbir gözlenebilir değişim olamaz. Psikolojik beceriler de böyledir. Çabanızın etkilerini görmek ve davranış değişikliği yapabilmek için önünüzde sabırla ilerlemeniz gereken bir süreç olduğunu unutmayın ve kendinizdeki en ufak gelişimi bile takdirle karşılayın. İşler istediğinizden yavaş ilerlediğinde, kendinize karşı nazik olun” diyor.\n";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
