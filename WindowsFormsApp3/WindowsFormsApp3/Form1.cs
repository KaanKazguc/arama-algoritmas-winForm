using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil201210601031Odev1
{
    
    public partial class Form1 : Form
    {
        int CalistirmaSayisi=0;

        public bool kontrol()
        {
            bool sayiVarMi=false, HarfVarMi = false, karakterVarMi = false, donrurulecekDeger= true;
            string kontrolEdilecek = ArananGirdisi.Text.ToLower() ;

            for (int i = 0; i < kontrolEdilecek.Length; i++)
            {
                if (kontrolEdilecek[i] >= 'a' & kontrolEdilecek[i] <= 'z')
                {
                    HarfVarMi = true;
                }

                else if (kontrolEdilecek[i]>= '0' & kontrolEdilecek[i] <= '9')
                {
                    sayiVarMi = true;
                }

                else
                {
                    karakterVarMi = true;
                }              
            }

            if (BisMetin.Checked != HarfVarMi)
            {
                donrurulecekDeger = false;
                MessageBox.Show("Metin check boxunu lutfen duzeltin");
            }
            if (BisSayi.Checked != sayiVarMi)
            {
                donrurulecekDeger = false;
                MessageBox.Show("Sayi check boxunu lutfen duzeltin");
            }
            if(BisKarekter.Checked != karakterVarMi)
            {
                donrurulecekDeger = false;
                MessageBox.Show("Karekter check boxunu lutfen duzeltin");
            }
            return donrurulecekDeger;
        }

        public void bulunamama(ListViewItem logSonuc)
        {
            SonucGoster.Text += "girilen metinde bulunmamaktadir.\r\n" ;
            logSonuc.Text += ("ve bulunmadigi tespit edilmistir.");
        }

        public void bulunduIndexleriBulveSay(string paragraf, string aranan, int konum,ListViewItem logSonuc)
        {

            int gecmeSayisi = 0;
            while (konum != -1)
            {
                gecmeSayisi++;
                SonucGoster.Text += (" " + konum + " ");
                konum = paragraf.IndexOf(aranan, konum + 1);
            }
            SonucGoster.Text += "indexlerinde bulunmuştur." + " Toplamda " +gecmeSayisi+" defa geçmektedir\r\n";
            logSonuc.Text += ("ve "+gecmeSayisi + " defa bulunmustur.");
        }

        public void arama(string paragraf , string aranan)
        {
            CalistirmaSayisi++;

            SonucGoster.Text += "Aranan '" + aranan + "' ifadesi ";

            ListViewItem logSonuc = new ListViewItem();
            logSonuc.Text += CalistirmaSayisi.ToString() ;
            logSonuc.Text += ")  Metinde '" + aranan + "' ifadesi aranmis ";

            int konum = paragraf.IndexOf(aranan);

            if (konum == -1) bulunamama(logSonuc);
            else bulunduIndexleriBulveSay(paragraf, aranan, konum, logSonuc);

            SonucGoster.Text += "Metin uzunlugu: "+paragraf.Length+"\tAranan ifade uzunlugu: "+ aranan.Length+ "\r\n";
            SonucGoster.Text += "Girilen metin: " + paragraf.Replace(aranan, aranan.ToUpper())+ "\r\n\r\n";
            logSonuc.Text += "   Metin uzunlugu ="+paragraf.Length+"\r\n";
            tabControl1.SelectedIndex = 1;
            logEkrani.Items.Add(logSonuc);
        }

        public Form1()
        {
            InitializeComponent();
            BasladiBildirimi.Icon = SystemIcons.Information;
            BasladiBildirimi.ShowBalloonTip(500);
        }


        private void Calistir_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(MetinGirdisi.Text)) & !(string.IsNullOrWhiteSpace(ArananGirdisi.Text)))
            {
                if (kontrol())
                    arama(MetinGirdisi.Text.ToLower(), ArananGirdisi.Text.ToLower());
            }
            else
                MessageBox.Show("Lutfen metin ve aranacak ifade bolgelerini doldurunuz");
        }

        private void Tab0ileri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void Tab1geri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Tab1clr_Click(object sender, EventArgs e)
        {
            SonucGoster.Text = "";
        }

        private void Tab1ileri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void toAnaEkran_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Tab2geri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void Tab2clr_Click(object sender, EventArgs e)
        {
            logEkrani.Items.Clear();
            CalistirmaSayisi = 0;
        }
    }
}
