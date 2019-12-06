using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
namespace Odev1
{
    public partial class Form2 : Form
    {
        Image<Bgr, byte> imgInput;
        public Form2()
        {
            InitializeComponent();
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                pictureBox1.Image = imgInput.Bitmap;
                if (imgInput == null)
                {
                    MessageBox.Show("Please select an image");
                    return;
                }

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgOutput = imgInput.Convert<Gray, byte>();
            pictureBox2.Image = imgOutput.Bitmap;
        }

       
    }
}
