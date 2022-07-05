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
    public partial class GAZETEVEDERGI : Form
    {
        public GAZETEVEDERGI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            button3.BackColor = Color.LightBlue;

            label4.Text = "Magazin";

            label6.Text = "Spor";

            label8.Text = "Siyaset";

            if (button3.Visible)
                button3.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;
            button2.BackColor = Color.LightBlue;

            label4.Text = "D Vitamini Eksikliğini\nGösteren 10 Belirti";

            label6.Text = "Müzik Dünyasının\nGizemli Kadını Sia\nHakkında Bilinmeyenler";

            label8.Text = "Üniversite Okuma\nOranının En Yüksek\nOlduğu Ülkeler";

            if (button4.Visible)
                button4.Visible = false;
            else
                button3.Visible = true;

            if (button5.Visible)
                button5.Visible = false;
            else
                button8.Visible = true;

            if (button6.Visible)
                button6.Visible = false;
            else
                button9.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.IndianRed;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "FÜSUN ÖNAL RÖPORTAJI";
            label3.Text = "" +
                "Müzik dünyamızın sevimli şarkıcısı Füsun Önal son günlerde dertli mi dertli.\n" +
                "Bakın neden: Çeşitli çevreler dur durak bilmeden Önal’ın çok konuştuğunu söyleyip duruyor. Önal ise şöyle cevap veriyor. “Gerektiğinden fazla konuşmam.”\n\n" +
                "Füsun Önal Dertli\n" +
                "“İnanın bir yerde oturup da şöyle sohbet etmeye çekiniyorum. Adım öyle bir gevezeye çıktı ki. İnkar etmemek lazım. Konuşmayı severim. Hele neşeli olduğum zaman bol bol konuşurum. Ama emin olun kimseleri rahatsız edecek kadar değil”\n" +
                "Peki nereden çıktı bu çok konuştuğunuz konusunda söylenenler?\n" +
                "“İnanın her şey bir televizyon programıyla başladı. Hani şu seçim gecesi yayınlanan programda. Tüm takdim işi bana verilmişti. Ortada senaryo namına tek bir kelime yoktu. Her kafadan bir ses çıkıyor. Her sanatçı kendisine bir şeyler sormamı istiyordu. Bu arada durumu idare etmek için uzun uzun konuşmuştum. Sen misin o gece konuşan. Adım bir gevezeye çıktı ki bir türlü silemiyorum. Diyorum ya konuşmaya çekinir oldum.”\n\n" +
                "Füsun Önal sustu. Bir an düşündü. Yüzünde dertli bir ifade vardı.\n" +
                "“N’olur doğru söyleyin çok mu gevezeyim? Lüzumsuz mu konuşuyorum” diye sordu.\n" +
                "“Yoo bilmem. Düşünmedim hiç.”\n" +
                "Aldığı cevaptan tatmin olmamıştı. Yeniden anlatmaya başladı.\n" +
                "“Hani insana bir şeyi kırk gün söylersen kendisini o konuda bayağı suçlu görmeye başlıyor. Öyle çok konuşmamla alay eden, çok konuşuyorsun diyen oldu ki, telefonda bile artık üç dakikadan fazla konuşmuyorum. İnsanların canını sıkmak, üzmek istemem ben. Sonra biliyor musunuz konuşurken karşımdakinin devamlı yüzüne bakarım. Eğer anlattığımla ilgilenmiyorsa keserim konuşmamı. Tabii şimdi daha çok dikkat ediyorum. Çok zaman canım konuşmak istese bile “Söz gümüşse sükut altındır deyip susmayı tercih ediyorum.”\n\n" +
                "Ya eşiniz ne diyor bu konuda?\n" +
                "“Atilla’yla uzun zaman flört ederek evlendik. Benden sıkılsa yüzüme söylerdi eminim. Evlenirken kusurlarımızı hiç saklamadan söyleyeceğimize dair birbirimize söz verdik. Bugüne kadar Atilla bana çok konuştuğum konusunda tek bir kelime söylemedi.”\n" +
                "Son olarak yine ilave etti Füsun Önal;\n" +
                "“Okurlarınıza lütfen iletin. Tenkitlere her zaman açığım. Eğer beğenmedikleri taraflarımı yazarlarsa inanın hepsini düzeltmeye hazırım.”\n" +
                "Haziran 1974 – SES Dergisi Arşivi";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.IndianRed;
            button6.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "SERGEN YALÇIN İSTANBULSPOR'DA";
            label3.Text = "" +
                "İstanbulspor, Beşiktaş’ın yıldızı Sergen Yalçın’ı 1.3 trilyona renklerine bağladı.\n\n\n" +
                "Üç sezondur ligin en gözde futbolcularını kadrosuna katan İstanbulspor, Haziran ayında Sergen’i Beşiktaş’tan transfer ederek Türkiye’yi ayağa kaldırmıştı.\n" +
                "Beşiktaş’a 800 milyar, Sergen’e ise 3 yıl için 500 milyar lira ödeyen Cem Uzan, şampiyonluğa oynayacak bir takım yarattı. Sergen’i satan Beşiktaş ise Letchkov ve Tayfur gibi iki as transfer etmesine karşın 1997’yi İstanbulspor’la aynı puanda ve dördüncü olarak kapadı.\n" +
                "Ocak 1998 – Yeni Yüzyıl Gazetesi Arşivi\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "REFİK KORALTAN VEFATI";
            label3.Text = "" +
                "Türkiye Büyük Millet Meclisi’nin eski başkanlarından Refik Koraltan dün saat 11.20’de tedavi edildiği Amiral Bristol Hastanesinde vefat etmiştir.\n\n\n" +
                "Uzun süreden beri muzdarip olduğu gut hastalığı sebebiyle 3 Haziran günü Etiler’deki evinden hastaneye kaldırılan Refik Koraltan’ın rahatsızlığı böbrek yetmezliği ve üremiye dönmüş, Refik Koraltan 85 yaşında hayata gözlerini yummuştur.\n" +
                "Tedavi altına alındığı günden beri Koraltan’ı yalnız bırakmayan eşi ve kızı ölüm haberi üzerine fenalık geçirmişlerdir. koraltan’ın cenazesi vasiyeti üzerine Ankara’ya götürülecektir.\n" +
                "Celal Bayar Konuştu\n\n\n" +
                "Öte yandan, DP kurucularından Refik Koraltan’ın ölümünü duyan Celal Bayar, çok üzüldüğünü belirtmiş “Rahmetli memleketine bağlı bir insandı” demiştir.\n" +
                "Haziran 1974 / Tercüman Gazetesi Arşivi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.IndianRed;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "YAŞAM DERGİSİ";
            label3.Text = "" +
                "D Vitamini Eksikliğini Gösteren 10 Belirti\n" +
                "1. Duygu Durumu Değişimi\n" +
                "Depresyon diyerek çok genellemek istemedik, bu yüzden ani duygu durumu değişiklikleri demek daha açıklayıcı olacaktır. D vitamini eksikliğinin en yaygın belirtisi bir anda değişen duygular. Eğer çok mutluyken bir anda ruh haliniz değişiyor ve mutsuz hissediyorsanız muhtemelen D vitamini eksikliğiniz var ya da manik depresif de olabilirsiniz, bizce bir doktora görünmekte fayda var.\n" +
                "2. Baş ve Boyunda Terleme\n" +
                "Garip gelebilir fakat D vitamini eksikliğini gösteren 10 belirti arasında terlemek de var. Eğer baş ve boyun terlemeniz her zamankinden daha fazla olmaya başlamışsa ve sizi rahatsız edecek duruma gelmişse, bir doktora görünmenizde fayda var.\n" +
                "3. Azalmayan Yorgunluk\n" +
                "Kendinizde işlerinizi halledecek gücü bulamıyor ve sürekli dinlenmek istiyorsanız muhtemelen D vitamini eksikliği yaşıyorsunuz. Çünkü D vitamini eksikliği kaslarda ve vücut iskeletinde zayıflık yaratıyor. Üşengeçlik de yapıyor olabilirsiniz, burası ayrı bir konu tabi…\n" +
                "4. Kramplarda Artış\n" +
                "Günlük hayatta oturma, kalkma, yürüme gibi sıradan aktiviteleri yaparken kramplar yaşıyorsanız D vitamini eksikliğiniz olabilir. Biraz önce bahsettiğimiz gibi zayıflayan vücut iskeleti, sık sık kramp yaşamanıza neden olabiliyor.\n" +
                "5. Sık Sık İshal Olmak\n" +
                "Eğer ayda birden fazla kez ishal olma durumu yaşıyorsanız D vitamini eksikliğini yaşamanız olası. D vitamini eksikliğinin en erken belirtisi ishaldir. Çünkü vücuttaki sindirim sistemini destekleyen en önemli vitamin, D vitaminidir.\n" +
                "6. Geçmeyen Nezle ve Grip\n" +
                "Bağışık sisteminizin güçlü olmasını sağlayan en önemli vitamin olan D vitamini, eksikliği durumunda sık sık ve uzun süreli hastalıklar yaşamanıza sebep oluyor. Özellikle kış aylarında, güneşin yokluğu ile daha da artan bu durumun önüne geçmek için D vitamini takviyesi şart.\n" +
                "7. Tansiyonun Bir Anda Yükselmesi\n" +
                "Eğer tansiyonunuz, hiç olmadık anlarda birden yükseliyorsa D vitamini eksikliği yaşıyor olabilirsiniz. Çünkü D vitamini, tansiyonun düzenli bir şekilde seyretmesi için büyük bir öneme sahip. Kısaca tansiyonunuzun bir anda yükselmesi, D vitamini eksikliğini gösteren 10 belirti arasında.\n" +
                "8. Vücut Yaralanmalarının Geç İyileşmesi\n" +
                "Hücrelerin yenilenmesine ve kanın daha çabuk pıhtılaşmasına yardımcı olan D vitamini, eksikliğinde; vücut yaralanmalarının geç iyileşmesine neden olabiliyor.\n" +
                "9. Saç Dökülmelerinin Artması\n" +
                "Günde 150 tele kadar dökülme normal olarak kabul edilebiliyor. Elbette saç dökülmesinin birçok ayrı nedeni söz konusu fakat saç dökülmelerinin nedenlerinden biri de D vitamini eksikliği. Saç köklerini besleyen D vitamini, saçların daha kalın ve sağlam bir yapıda olmasını sağlıyor.\n" +
                "10. Unutkanlığın Artış Göstermesi\n" +
                "D vitamini eksikliğini gösteren 10 belirti arasında unutkanlık faktörü de yer alıyor. Tabii sadece D vitamini değil birçok vitaminin eksikliği, hastalığın en büyük habercisi durumunda. Eğer vücut, yeteri düzeyde D vitamini depolayamazsa, ilerleyen günlerde unutkanlık ve dikkat eksikliğini ortaya çıkarabiliyor.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.IndianRed;
            button9.BackColor = Color.LightBlue;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "MÜZİKLİ HAYAT DERGİSİ";
            label3.Text = "" +
                "Müzik Dünyasının Gizemli Kadını Sia Hakkında Bilinmeyenler\n\n" +
                "1. Gerçek İsmi\n" +
                "Dünyanın geri kalanı onu sahne adı olan Sia ile tanıyor olabilirler. Bu isim hem akılda kalıcı hem de çok kolay söyleniyor. Fakat şarkıcının ismi aslında düşündüğünüzden çok daha uzun. Sia, sahnede daha etkileyici ve kısa bir isim olduğu için üç harflik bir isim kullanıyor olsa da Sia’nın tam adı aslında Sia Kate Isobelle Furler’dır. Sia aynı zamanda Avusturalyalıdır. Adalaide’de büyümüş olan Sia, hayatının sonraki döneminde Londra’ya taşınıp uzun yıllarını orada geçirmiştir. Otuz yaşındayken ise New York’a taşınmıştır. Bu kadar yer değiştirip farklı bölgelerde zaman geçirmiş olması da Sia’nın tatlı aksanını açıklıyor.\n" +
                "2. Sadece Şarkıcı Değil\n" +
                "Onu sadece şarkıcı olarak tanıyor olabilirsiniz. Fakat Sia bundan çok daha fazlası. Sia aynı zamanda çok yetenekli bir beste yazarı ve müzik videosu yönetmenidir. Şarkı yazarlığının en büyük tutkularından biri olduğunu söylüyor. Bu, yaptığı işin en güzel ve en sevdiği parçasıymış. Sia kendi şarkıları dışında birçok ünlü isme şarkı yazdı. Beyonce’nin Pretty Hurts şarkısı, Britney Spears’ın Perfume şarkısı, Kylie Minogue’nın Sexercise şarkısı, Neyo’nun Let Me Love You şarkısı, Lea Michele’nin Cannonball şarksı, Rita Ora’nın Radioactive şarkısı, Rihanna’nın Diamonds şarkısı ve daha birçok şarkıyı kendisi yazmıştır.\n" +
                "3. ‘Chandelier’ Öncesi\n" +
                "Birçoğumuz Sia’yı ünlü şarkısı Chandelier sayesinde tanıdık. Fakat Sia bundan çok öncesinde de müzik yapıyordu. 1990’ların ortasında doğru Sia, Adelaide’de bir jazz kulübünde kariyerine şarkıcı olarak başladı. Crisp isimli bir jazz gurubunun üyesiydi. Fakat grupları 1997 yılında ayrıldı ve Sia tam da bu zaman ilk stüdyo albümü olan OnlySee albümünü yayınladı. Flavoured Recods adında bir yayıncının aracı olduğu bu albüm Avusturalya’da yayınlandı ve sadece 1200 tane satabildi. Fakat bu numaralar, Sia’nın ileride atacağı adımları engellemedi. Daha sonrasında Londra’ya taşınan Sia, Zero 7 ile şarkıcılık kariyerine devam etti.\n" +
                "4. Madde Kullanımını Aşması Gerekti\n" +
                "Sia’nın 1997’de o zamanki erkek arkadaşı Dan, bir araba kazası sonunda hayatını kaybetti. Sia’nın bu ölümle tamamen yüzleşmesi ve iyileşebilmesi altı yılını aldı. Bu yıllar boyunca hayatının tepe taklak olduğunu söyleyen Sia, kendi kendini mahvetmeye aynı zamanlarda başladığını söylüyor. Madde bağımlılığının altı yıl boyunca kurbanı olduktan sonra kendini bu boşluktan çıkartabilmiş. Daha sonra ise hayatının bu kısmını ve yüzleşmek zorunda olduğu gerçekleri şarkılarına yansıtmış. Kötü ve üzücü tecrübeler biriktirmiş olsa da zamanla bunları aşabilmeyi ve tekrar doğru yolda yürümeyi başarabilmiş.\n" +
                "5. Mental Hastalıklarla Yüzleşmesi\n" +
                "Sia, konu mental hastalıklar olunca birçok ünlüden çok daha şeffaf davranmayı başarıyor. Verdiği röportajlarda daha önce depresyon ile mücadele ettiğini anlatan Sia, hayatının zorlu anlarını hayranlarıyla paylaştı. Karanlık bir dönemden geçerken neredeyse intiharın eşiğine kadar geldiğini ve bunun adına ucuz bir otel kiraladığını anlattı. Otel menajerine ve köpek gezdiricisine “Kendimi öldürdüm ve görmenizi istemiyorum” şeklinde bir not yazarak hayatını sona erdirecekti. Fakat Sia otelde olduğu sırada bir arkadaşı onu arayarak fikrini değiştirmeyi başardı. Sia bu sayede 12 aşamalı bir terapi programına yazıldı.\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.IndianRed;

            label3.BackColor = Color.White;
            label5.ForeColor = Color.DarkRed;
            label5.Text = "EĞİT DERGİ";
            label3.Text = "Üniversite Okuma Oranının En Yüksek Olduğu Ülkeler\n\n\n" +
                "10. Avustralya\n" +
                "Üniversite okuma oranının en yüksek olduğu ülkeler arasında en düşük oranın sahibi Avustralya. Ucuz bir ülke olmasından dolayı öğrenciler arasında popüler olan ülkeler arasında olan Avustralya okuma oranının en yüksek olduğu ülkelerden biri. Üniversite ya da yüksek lisans mezunlarının oranı %38.3. Bununla bağlantılı olan İşsizlik oranı da 2019 yılı itibariyle %5 sularında.\n" +
                "9. Finlandiya\n" +
                "Eğitim sistemiyle ve reformlarıyla dünyaya örnek olan Finlandiya, bu sayede dünyanın en gelişmiş ülkelerinden biri. Yükseköğretim harcamalarına bütçesinden büyük bir pay ayırıyor ve orta öğretime de yatırım yapıyor. Öğretmene, öğrenciye, okullara verdiği büyük önem sayesinde eğitim alanında yapılan uluslar arası araştırmalarda her yıl ilk sırayı koruyor.\n" +
                "8. Yeni Zelanda\n" +
                "Öğrencilerin gelişimini ve deneyimlerini ön plana çıkaran ve bu sayede okuryazarlık ve okuma oranını yüksek tutan ülkelerden birisi Yeni Zelanda. Lisans ya da yüksek lisans mezunlarının oranı %39.4. 2006 yılında yapılan araştırmaya göre yaşları 25 ila 64 arasında değişen Yeni Zelandalıların %77’si orta ve yüksek eğitim yeterliliği almıştır. PISA sınavlarında OECD ülkelerinin ilerisinde sonuçlar almaktadır ve eğitime ayırdıkları bütçe zamanla artmaktadır.\n" +
                "7. İngiltere\n" +
                "ABD’den sonra öğrencilerin eğitim almak için göç ettiği yer İngiltere. Dünyanın en kaliteli okullarına ev sahipliği yapan ülkede lisans ya da yüksek lisans mezunlarının oranı %39.4. Bütçeden eğitime ayrılan oran %6.5.\n" +
                "6. Güney Kore\n" +
                "Okuma oranının yüksek olduğu ve eğitim sisteminin kalitesiyle öne çıkan bir diğer ülke Güney Kore. Ülkede neredeyse okuma yazma bilmeyen yok. Üniversite veya yüksek lisans mezunlarının oranı %40.4. Üniversiteden mezun olanların iş bulma konusunda sıkıntı çekmediği söyleniyor. Öğretmenlik de saygı gören ve maaşı iyi bir meslek. Hal böyle olunca ülkenin nüfusu dünyanın en eğitimlilerinden.\n" +
                "5. ABD\n" +
                "Dünyanın en büyük ekonomilerinden birine sahip olan ABD, eğitim ve okuryazarlık bakımından da ileri seviyede. Lisans ya da yüksek lisans mezunlarının oranı %42.5. Milyonlarca başarılı yabancı öğrenciyi kendisine çeken ülke Harvard, Yale, Stanford gibi üniversitelere ev sahipliği yapıyor.\n" +
                "4. İsrail\n" +
                "İsrail okuma oranının en yüksek olduğu ülkelerin başında geliyor. Lisans veya yüksek lisans mezunlarının oranı tam %46.4. Ülkede yükseköğretim kurumlarından mezun olanların sayısı OECD raporlarının üzerinde.\n" +
                "3. Japonya\n" +
                "Okuma oranının en yüksek olduğu ülkelerden birisi de Japonya. Lisans ya da yüksek lisans mezunlarının oranı %46.4. Japonya dünyanın en eğitimli nüfusuna sahip. Öğrencilerin derslere devam oranı %99.9 olarak belirlenmiş. Bütçelerinin büyük bir kısmını da eğitime harcayan Japonlar, bireyin ahlakını geliştirmek ve sorumluluk bilincini yükseltmek için de çabalıyor.\n" +
                "2. Kanada\n" +
                "Eğitime verdiği önemle öne çıkan Kanada, sosyo-ekonomik ve toplumsal refah düzeyinin yüksek olması nedeniyle dünyanın en gelişmiş ülkeleri arasında. Okulların kalitesi, ülke gelirinden eğitime ayrılan oran, insanların kitaplara ve akademik çalışmalara erişimi kolay olması sebebiyle okuma oranı da bir hayli yüksek. Lisans ve yüksek lisans mezunlarının oranı %51.3. Öğrenci başına binlerce dolar harcayan Kanda, en yaşanılabilir ülkeler sıralamasında da zirvede.\n" +
                "1. Rusya\n" +
                "Üniversite okuma oranının en yüksek olduğu ülkeler listemizde en çok oranı sahip ülke Rusya. Okuryazarlık oranının en yüksek olduğu ülkelerden birisi. Ülkede lisans ya da yüksek lisans mezunlarının oranı %53.5 olarak belirlenmiş. Gayrisafi yurtiçi hasıladan eğitime ayrılan bütçe ise %4.9. 25-64 yaş arasındaki insanların yarısından fazlasının yükseköğretim yapabildiği belirtiliyor.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
