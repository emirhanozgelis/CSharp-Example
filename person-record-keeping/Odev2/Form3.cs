using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Odev2
{
    public partial class rchListele : Form
    {
        public rchListele()
        {
            InitializeComponent();
            Yazdir(Oku());
        }
        private List<kisiler> Oku()//veriler.txt yi okuyup generic list'e atan metot
        {

            List<kisiler> okunanKisi = new List<kisiler>();
            
            StreamReader dosyaOku = new StreamReader(@"veriler.txt");
            string line;
            while ((line = dosyaOku.ReadLine()) != null)//Satır satır okuma yapıyoruz .Burada using bloğu da kullanılabilir kişi ekleyle aynı olsun diyorsan using koyup f.le.Close() kaldırabilirsin
            {

                string[] okunan = line.Split(' ');
                 okunanKisi.Add(new kisiler { Renk = okunan[0], Ad = okunan[1], SoyAd = okunan[2], Numara = okunan[3] });//Okuduğumuz verileri yeni bir kişi nesnesi içinde listeye atıyoruz
                
                

            }


            dosyaOku.Close();

            return okunanKisi;

        }
        private void Yazdir(List<kisiler> okunanListe)//Alınan kişi listesini richtextboxa yazan fonksiyon
        {

            for (int i = 0; i < okunanListe.Count; i++)
            {
                if (i % 2 == 0)//okunan değer eğer tekli satırlar ise fontu bold olsun
                {
                    rchListele2.SelectionFont = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold);
                }
                else//değilse regular olsun
                {
                    rchListele2.SelectionFont = new Font(FontFamily.GenericSerif, 12, FontStyle.Regular);
                }
                Color yaziRenk = new Color();//gelen verilerin renkleri tutacak değişken
                char[] renkler = okunanListe[i].Renk.ToCharArray();//veriler.txt de tutulan renkleri char diziye atadık teker teker kontrolü için
                for (int j = 0; j < renkler.Length; j++)
                {

                    if (renkler[j] == 'k')//renklerin kontrolünü yapıyoruz
                    {
                        yaziRenk = Color.Red;
                    }
                    else if (renkler[j] == 'm')
                    {
                        yaziRenk = Color.Blue;
                    }
                    else if (renkler[j] == 'y')
                    {
                        yaziRenk = Color.Green;
                    }
                    rchListele2.SelectionColor = yaziRenk;//rich textboxun rengini atadık
                    if (j == 0)
                    {
                        rchListele2.AppendText(okunanListe[i].Ad + " ");//AppendText() metodu richtextbox a teker teker atama yapmamıza yarıyor
                    }
                    else if (j == 1)
                    {
                        rchListele2.AppendText(okunanListe[i].SoyAd + " ");
                    }
                    else
                    {
                        rchListele2.AppendText(okunanListe[i].Numara + "\r\n");
                    }
                }



            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
