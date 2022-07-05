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
    public partial class FELSEFE : Form
    {
        public FELSEFE()
        {
            InitializeComponent();
            label6.Text = "Felsefe Nedir?";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kanasayfa fr = new Kanasayfa();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.IndianRed;
            label6.Text = "Felsefe Nedir?";
            label5.ForeColor = Color.DarkRed;
            label5.Text = "FELSEFE NEDİR?";
            label3.BackColor = Color.White;
            label3.Text = "" +
                "Felsefe (Yunanca: φιλοσοφία, philosophia, 'bilgelik sevgisi' veya 'hikmet arayışı'); varlık, bilgi, gerçek, adalet, güzellik, doğruluk, akıl ve dil gibi konularla ilgili özsel sorunlara ilişkin yapılan çalışmalardır.[4][5] Felsefe düşünce sanatı olarak da bilinir. Buna göre, felsefe Yunanlar için, 'bilgelik sevgisi' ya da 'hikmet arayışı' anlamına gelmiştir. Başlangıçtaki bu özgün anlama göre, her türden bilimsel araştırmacıya 'filozof' adı verilmiştir. Filozof, yeni (farklı) sonuçlara varan ve bu sonuçları ifade etmek için yeni tanımlar üreten kişidir. Filozoflar hayata yeni sözler, cümleler ve bilgiler koyarak insan yaşamında önemli bir yer edinmişlerdir. Öğüt verici bilgileri ile insanların hayatlarında daha kolay bir yaşam için uğraş vermişlerdir.";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
