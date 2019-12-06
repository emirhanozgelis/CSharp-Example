using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                anamenu();
            }       
        }
        public static void anamenu() //Üst menü kısmı
        {
            Console.WriteLine("1-Malzeme Hesabı");
            Console.WriteLine("2-Menu girisi");
            Console.WriteLine("3-Cikis");
            Console.Write("Seciminiz .. : ");
            int secim = Convert.ToInt16(Console.ReadLine());

            switch (secim)  //Menu secenekleri
            {
                case 1:
                    Console.Clear();
                    malzemeHesapla();
                    
                    break;

                case 2:
                    Console.Clear();
                    menuGiris();
                    break;

                case 3:
                    cikis();
                    break;
                default:
                    Console.WriteLine("Hatali menu secimi");
                    Console.Clear();
                    anamenu();

                    break;
                    
            }
        
        }
        public static void malzemeHesapla()
        {
            Console.WriteLine("1-Taze Fasulye");
            Console.WriteLine("2-Karnı Yarık");
            Console.WriteLine("3-Ust Menu");
            Console.Write("Alt menu seciminiz ..: ");
            int altMenuSecim = Convert.ToInt16(Console.ReadLine());
            switch (altMenuSecim)
            {
                case 1:
                    Console.Write("Kisi sayisi..: ");
                    int kisiSayisi = Convert.ToInt16(Console.ReadLine());
                    int tazeFasulye = 250;
                    int kusbasi = 100;
                    int domatesSogan = 1;

                    int sonucFasulye = kisiSayisi * tazeFasulye;
                    int sonucKusbasi = kisiSayisi * kusbasi;
                    int sonucDomatesSogan = kisiSayisi * domatesSogan;

                    Console.WriteLine("{0} gram taze fasulye, {1} gram kusbasi , {2} adet domates sogan .",sonucFasulye,sonucKusbasi,sonucDomatesSogan);

                    break;

                case 2:
                    Console.Write("Kisi sayisi..: ");
                    int kisiSayisi2 = Convert.ToInt16(Console.ReadLine());
                    int patlican = 200;
                    int kiyma = 75;
                    int domatesSogan2 = 2;

                    int sonucPatlican = kisiSayisi2 * patlican;
                    int sonucKiyma = kisiSayisi2 * kiyma;
                    int sonucDomatesSogan2 = kisiSayisi2 * domatesSogan2;

                    Console.WriteLine("{0} gram patlican, {1} gram kiyma , {2} adet domates sogan .", sonucPatlican, sonucKiyma, sonucDomatesSogan2);



                    break;

                case 3:
                    Console.Clear();
                    anamenu();
                    break;
                default:
                    Console.WriteLine("Hatali alt menu secimi");
                    Console.Clear();
                    anamenu();

                    break;

            }

        }
        public static void menuGiris()
        {
            Console.Write("Yeni Menu : ");
            string yeniMenu = Console.ReadLine();
            Console.WriteLine("1-Yemek Listesi");
            Console.WriteLine("2-Yemek Sayisi");
            Console.WriteLine("3-Ust menu");
            Console.WriteLine("Alt menu seciminiz ..: ");
            string[] sonucDizi = yeniMenu.Split(',');

            int secim2 = Convert.ToInt16(Console.ReadLine());
            switch (secim2)
            {
                case 1:
                    foreach (string menu in sonucDizi)
                    {
                        Console.WriteLine(menu);
                    }
                    Console.ReadLine();
                    break;
                case 2:

                    Console.WriteLine("Yemek menüsü sayisi..: " + sonucDizi.Count());

                    break;
                        
                default:
                    Console.WriteLine("Hatali menu secimi");
                    Console.Clear();
                    menuGiris();
                    
                    break;
            }


        }
        public static void cikis()
        {
            Console.WriteLine("Cikis yaptiniz .");
            Environment.Exit(0);
        }
    }
   
}
