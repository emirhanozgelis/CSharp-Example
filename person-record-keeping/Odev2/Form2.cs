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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kırmızı");
            comboBox1.Items.Add("Mavi");
            comboBox1.Items.Add("Yeşil");
            comboBox2.Items.Add("Kırmızı");
            comboBox2.Items.Add("Mavi");
            comboBox2.Items.Add("Yeşil");
            comboBox3.Items.Add("Kırmızı");
            comboBox3.Items.Add("Mavi");
            comboBox3.Items.Add("Yeşil");

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] renk = new string[3];

            if (comboBox1.Text == "Kırmızı")
            {
                renk[0] = "k";
            }
            else if (comboBox1.Text == "Mavi")
            {
                renk[0] = "m";
            }
            else if (comboBox1.Text == "Yeşil")
            {
                renk[0] = "y";
            }


            if (comboBox2.Text == "Kırmızı")
            {
                renk[1] = "k";
            }
            else if (comboBox2.Text == "Mavi")
            {
                renk[1] = "m";
            }
            else if (comboBox2.Text == "Yeşil")
            {
                renk[1] = "y";
            }

            if (comboBox3.Text == "Kırmızı")
            {
                renk[2] = "k";
            }
            else if (comboBox3.Text == "Mavi")
            {
                renk[2] = "m";
            }
            else if (comboBox3.Text == "Yeşil")
            {
                renk[2] = "y";
            }



            string ad = null;
            string soyad = null;
            int numara = 0;
            string dosyaYolu = @"veriler.txt";
            StreamWriter dosyaKayitEkle = File.AppendText(dosyaYolu);

            ad = txtAd.Text;
            soyad = txtSoyAd.Text;
            numara = Convert.ToInt32(txtNumara.Text);
          
            dosyaKayitEkle.WriteLine (renk[0]+ renk[2]+ renk[1]  +"  " + ad+ "  "+ soyad+ "  "+ numara );

            dosyaKayitEkle.Flush();
            dosyaKayitEkle.Close();
        }
    }
}
