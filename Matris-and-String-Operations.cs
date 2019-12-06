using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            islemler(); //Program basliyor

        }

        public static void islemler()
        {
            Console.WriteLine("..::İSLEMLER::..");
            Console.WriteLine("1-Matris İslemleri");
            Console.WriteLine("2-String İslemleri");
            Console.WriteLine("3-Cikis");
            Console.Write("Seciminiz: ");

            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Matris();
                    break;

                case 2:
                    Console.Clear();
                    String();

                    break;

                case 3:
                    Cikis();
                    break;

                default:
                    Console.WriteLine("Hatali Secim");
                    islemler();
                    break;
            }
            Console.ReadLine();
        }

        public static void Matris()
        {
            Console.WriteLine("..::Matris Islemleri::..");
            Console.Write("Matrisin satir sayisini giriniz(1-10 arasinda): ");
            int matrissatir = int.Parse(Console.ReadLine());

            if (matrissatir < 10) //Deger kontrolu
            {
                int[,] Matris = new int[matrissatir, matrissatir];

                for (int i = 0; i < matrissatir; i++) //Girilen degere göre matrisimizin satiri sekilleniyor 
                {
                    for (int j = 0; j < matrissatir; j++) ////Girilen degere göre matrisimizin sutunu sekilleniyor
                    {
                        Console.Write("[{0},{1}] = ", i + 1, j + 1);
                        Matris[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                for (int k = 0; k < matrissatir; k++)
                {
                    for (int n = 0; n < matrissatir; n++)
                    {
                        Console.Write(Matris[k, n] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("1-Satir En Buyuk");
                Console.WriteLine("2-Satir Toplam");
                Console.Write("Seciminiz: ");
                
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        int enBuyuk =0;
                        for (int i=0; i<Matris.Length/2; i++)
                        {

                             for(int j=0; j<Matris.Length/2;j++)
                            {
                                try
                                {

                                if(enBuyuk<Matris[i,j])
                                {
                                    enBuyuk = Matris[i, j];
                                }
                                }
                                catch (Exception)
                                {                                 
                                }
                            }
                            Console.WriteLine(i+1 +".satir En büyük="+enBuyuk);
                          
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        
                        for (int i = 0; i < Matris.Length / 2; i++)
                        {
                            int toplam = 0;
                            for (int j = 0; j < Matris.Length / 2; j++)
                            {
                                try
                                {
                                    toplam += Matris[i, j];
                                }
                                catch (Exception)
                                {
                                }
                            }
                            Console.WriteLine(i+1 + ".Satirin Toplami=" + toplam);

                        }
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Hatali Secim");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lutfen 1-10 arasinda bir rakam giriniz");
                Matris();
            }


        }
        
        
        
        public static void String()
        {
            Console.Write("Islem yapilacak stringi giriniz..: ");
            string kelime = Console.ReadLine();
            Console.Write("Istenen harf..: ");
            char harf = Convert.ToChar(Console.ReadLine());
            int adet = 0;
            foreach (char item in kelime)
            {
                if(item == harf)
                {
                    adet++;
                }
            }
            if (adet < 2)
            { 
                Console.WriteLine("Cümle içerisinde aranan harf bulunamamıştır");
            }
            else
            {
                Console.WriteLine(adet+" adet bulundu");
            }
            Console.WriteLine("1-Ara Metni Tersten Yaz");
            Console.WriteLine("2-Ara Metni Tekrarlı Yaz");
            Console.Write("Seciminiz: ");

            int secim = int.Parse(Console.ReadLine());

            char[] temp = kelime.ToArray();

            for (int i = 0; i < temp.Length; i++)
            {
                if (harf == temp[i])
                {
                    temp[i] = ' ';
                }
            }
            switch (secim)
            {
                case 1:
                    for (int i = temp.Length-1; i >= 0; i--)
                    {
                        if (temp[i] != ' ')   
                            Console.Write(temp[i]);                        
                    }
                    break;

                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        for (int k = 0; k < temp.Length; k++)
                        {
                            if (temp[k] != ' ')
                                Console.Write(temp[k]);
                        }
                        Console.WriteLine("");
                    }

                    break;
            }
            }
        public static void Cikis()
        {
            Environment.Exit(0);
        }
    }
}
