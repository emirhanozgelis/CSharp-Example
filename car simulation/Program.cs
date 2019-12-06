using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabaSimulasyonu
{

    class Program
    {


        static void Main(string[] args)
        {
            int hiz = 0;
            int secim = 0;
            string secim2 = null;
            bool calistir;

            kontak anahtar = new kontak();
           

            Console.WriteLine("Lutfen aracın motor tipini seciniz: ");
            Console.WriteLine("1-)Dizel ");
            Console.WriteLine("2-)Benzinli ");
            secim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aracı çalıştırmak ister misiniz?(e/h)");


            secim2 = Console.ReadLine();


            if (secim2 == "e" || secim == 1)
            {
                anahtar.kontakKontrol(true);
                dizelMotor motor = new dizelMotor();
                gazPedali gaz = new gazPedali(true);
                frenPedali fren = new frenPedali(false);
                direksiyon yon = new direksiyon();
                tekerlekler tekerlekYon = new tekerlekler();
                hizGöstergesi aracHiz = new hizGöstergesi();
                farlar far = new farlar();
                sinyalLambalari sinyal = new sinyalLambalari();

                far.farKolu();
                


            }
            else if (secim2 == "e" || secim == 2)
            {
                anahtar.kontakKontrol(true);
                benzinliMotor motor = new benzinliMotor();
                gazPedali gaz = new gazPedali(true);
                frenPedali fren = new frenPedali(true);
                direksiyon yon = new direksiyon();
                tekerlekler tekerlekYon = new tekerlekler();
                hizGöstergesi aracHiz = new hizGöstergesi();
                farlar far = new farlar();
                sinyalLambalari sinyal = new sinyalLambalari();
               
            }
            else
            {
                farlar far = new farlar();
                sinyalLambalari sinyal = new sinyalLambalari();
                anahtar.kontakKontrol(false);

            }

           

            Console.ReadLine();
          
        }
    }

    public class elektronikBeyin
    {
        private  elektronikBeyin(bool kontakDurum,IMotor motor)
        {
            int hiz = 0;
            kontak anahtar = new kontak();
            anahtar.kontakKontrol(kontakDurum);
            motor.motorHizi(hiz);
        }

        

    }
    interface IMotor
    {
        int motorHizi(int hiz);

    }
    class benzinliMotor : IMotor
    {
        public int motorHizi(int hiz)
        {
            if (hiz == 220)
            {
                return hiz;
            }
            else
            {
                hiz = hiz + 10;
                return hiz;
            }
        }
    }
    class dizelMotor : IMotor
    {
        public int motorHizi(int hiz)
        {
            if (hiz == 220)
            {
                return hiz;
            }
            else
            {
                hiz = hiz + 8;
                return hiz;
            }
        }
    }
    public class kontak
    {
        public bool kontakKontrol(bool çalıştır)
        {
            if (çalıştır == true)
            {

                return true;
            }
            else
                return false;
        }

    }

    class gazPedali
    {
        public bool gazPedaliDurumu { get; set; }
        public gazPedali(bool gazPedaliDurumu)
        {
            if (gazPedaliDurumu == true)
                return;
            if (gazPedaliDurumu == false)
                return;
        }
       
    }
    class frenPedali
    {
        public bool frenPedaliDurumu { get; set; }
        public frenPedali(bool frenPedaliDurumu)
        {
            if (frenPedaliDurumu == true)
                return;
            if (frenPedaliDurumu == false)
                return;
        }
    }
    class direksiyon
    {

    }
    class tekerlekler
    {

    }
    class hizGöstergesi
    {

    }
    public class farlar
    {

        bool kisaFarlar;
        bool uzunFarlar;
        string secim;
        public bool farKolu()
        {
            Console.WriteLine("Kisa farları yakmak icin ak,kapatmak için kk. Uzun farlari yakmak için au, kapatmak için ku yaziniz.");
            secim=Console.ReadLine();

            if (secim == "ak")
            {
                kisaFarlar = true;
                return kisaFarlar;
            }
            else if(secim=="kk")
            {
                kisaFarlar = false;
                return kisaFarlar;
            }
            else if(secim=="au")
            {
                uzunFarlar = true;
                return uzunFarlar;
            }
            else
            {
                uzunFarlar = false;
                return uzunFarlar;
            }

        }
    }
    class sinyalLambalari
    {

    }
}
