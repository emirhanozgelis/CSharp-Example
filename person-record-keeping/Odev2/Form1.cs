using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        Form2 kayitEkle = new Form2();
        rchListele kayitListele = new rchListele();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayitEkleme_Click(object sender, EventArgs e)
        {
            kayitEkle.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            kayitListele.Show();
            this.Hide();
        }
    }
}
