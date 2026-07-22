using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOOK_SYSTEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"                                                                  *-=BİLGİSAYAR TOPLA=-*");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("^^MARKALAR^^");
            Console.WriteLine("1-LENOVO\n2-SONY\n3-DELL\n4-ASUS");
            yanlisTuslama:
            Console.Write("Bir marka seçiniz (Örn. lenovo için 1, sony için 2):");           
            int deger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%");

            if (deger == 1)
            {
                LENOVO lenovo = new LENOVO();
                lenovo.DonanimSec();
            }
            else if (deger == 2)
            {
                SONY sony = new SONY();
                sony.DonanimSec();
            }
            else if (deger == 3)
            {
                DELL dell = new DELL();
                dell.DonanimSec();
            }
            else if (deger == 4)
            {
                ASUS asus = new ASUS();
                asus.DonanimSec();
            }
            else
            {
                Console.WriteLine("Yanlış tuşlama yaptınız.");
                goto yanlisTuslama;
            }
            Console.ReadLine();
        }
    }
    public class Donanim
    {
        public int _ram, _ekranBoyutu;
        public string _islemci, _anakart, _disk;
        public int islemcifiyat, ramfiyat, ekranfiyat, anakartfiyat, diskfiyat;
        public double toplamfiyat = 0;
        public double dolarkuru = 30; //güncel fiyatlar için kuru değiştirmek yeterli.
        public void GenelOzellikler(string marka,string islemci, int ram, float ekran, string anakart, string disk)
        {
            Console.WriteLine("\nGENEL ÖZELLİKLER");
            Console.WriteLine("Cihaz Adı    " + marka + "\nİşlemci      " + "i" + islemci + "-12700H 2.30 GHz" + "\nTakılı RAM   " + ram + " GB" + "\nEkran Boyutu " + ekran + ".3 inç" + "\nAnakart      " + "ASUS PRIME H610M-K DDR5 " + anakart + "MHz" + "\nDisk         " + "ASUS ROG STRIX Arion S500 1TB SSD (" + disk + "MB OKUMA)");
        }
    }
    public class LENOVO : Donanim //ekran 17.3 inç olacak
    {
        public void DonanimSec()
        {
            string markasi = "DESKTOP-LENOVO";
            Console.WriteLine("    ^^İŞLEMCİ^^");
            Console.WriteLine("1-i3-12700H 2.30 GHz\n2-i5-12700H 2.30 GHz\n3-i7-12700H 2.30 GHz");
            secim1:
            Console.Write("Bir İŞLEMCİ seçiniz (Örn. 3,5..):");
            string secilenislemci = Console.ReadLine();
            if (secilenislemci == "3" || secilenislemci == "5" || secilenislemci == "7")
            {
                Console.WriteLine(" --->Seçilen işlemci:" + "12th Gen Intel(R) Core(TM) " + "i" + secilenislemci + "-12700H 2.30 GHz");
                if (secilenislemci == "3")
                {
                    islemcifiyat += 50;
                    Console.WriteLine("Fiyatı: "+ islemcifiyat + " $");
                }
                else if(secilenislemci == "5")
                {
                    islemcifiyat += 120;
                    Console.WriteLine("Fiyatı: "+ islemcifiyat + " $");
                }
                else
                {
                    islemcifiyat += 200;
                    Console.WriteLine("Fiyatı: "+ islemcifiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim1;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^RAM^^");
            Console.WriteLine("1-8 GB\n2-16 GB\n3-32 GB");
            secim2:
            Console.Write("Bir RAM seçiniz (Örn. 8,16..):");
            int secilenram = Convert.ToInt16(Console.ReadLine());
            if (secilenram == 8 || secilenram == 16 || secilenram == 32)
            {
                Console.WriteLine(" --->Seçilen ram:" + secilenram + "GB");
                if (secilenram == 8)
                {
                    ramfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else if (secilenram == 16)
                {
                    ramfiyat += 110;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else
                {
                    ramfiyat += 160;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim2;
            }           
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^EKRAN^^");
            Console.WriteLine("1-17.3");
            secim3:
            Console.Write("Bir EKRAN seçiniz (Örn. 17):");
            float secilenekran = Convert.ToInt16(Console.ReadLine());
            if (secilenekran == 17)
            {
                Console.WriteLine(" --->Seçilen ekran:" + secilenekran + ".3 inç");
                ekranfiyat += 60;
                Console.WriteLine("Fiyatı: "+ekranfiyat+" $");
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim3;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^ANAKART^^");
            Console.WriteLine("1-GIGABYTE B760 DS3H DDR4 5333MHz\n2-GIGABYTE B760 DS3H DDR4 6400MHz\n3-GIGABYTE B760 DS3H DDR4 7600MHz");
            secim4:
            Console.Write("Bir ANAKART seçiniz (Örn. 5333):");
            string secilenanakart= Console.ReadLine();
            if (secilenanakart == "5333" || secilenanakart == "6400" || secilenanakart == "7600") 
            {
                Console.WriteLine(" --->Seçilen anakart:" + "GIGABYTE B760 DS3H DDR4 " + secilenanakart + "MHz");
                if(secilenanakart == "5333")
                {
                    anakartfiyat += 60;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else if (secilenanakart == "6400")
                {
                    anakartfiyat += 70;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else
                {
                    anakartfiyat += 80;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim4;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^DİSK^^");
            Console.WriteLine("1-GIGABYTE 1TB SSD (2300MB OKUMA)\n2-GIGABYTE 1TB SSD (5000MB OKUMA)\n3-GIGABYTE 1TB SSD (7300MB OKUMA)");
            secim5:
            Console.Write("Bir DİSK seçiniz (Örn. 2300):");
            string secilendisk = Console.ReadLine();
            if (secilendisk == "2300" || secilendisk == "5000" || secilendisk == "7300") 
            {
                Console.WriteLine(" --->Seçilen disk:" + "GIGABYTE 1TB SSD (" + secilendisk + "MB OKUMA)");
                if(secilendisk == "2300")
                {
                    diskfiyat += 40;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else if (secilendisk == "5000")
                {
                    diskfiyat += 45;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else
                {
                    diskfiyat += 50;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim5;
            }
            GenelOzellikler(markasi,secilenislemci, secilenram, secilenekran, secilenanakart, secilendisk);
            toplamfiyat = (islemcifiyat+ramfiyat+ekranfiyat+anakartfiyat+diskfiyat)*dolarkuru;
            Console.WriteLine("Sistem Fiyatı: "+toplamfiyat+" TL");
        }
    }
    public class SONY : Donanim //işlemci en az i5.
    {
        public void DonanimSec()
        {
            string markasi = "DESKTOP-SONY";
            Console.WriteLine("    ^^İŞLEMCİ^^");
            Console.WriteLine("1-i5-11700H 2.0 GHz\n2-i7-11700H 2.0 GHz");
        secim1:
            Console.Write("Bir İŞLEMCİ seçiniz (Örn. 5,7..):");
            string secilenislemci = Console.ReadLine();
            if (secilenislemci == "5" || secilenislemci == "7")
            {
                Console.WriteLine(" --->Seçilen işlemci:" + "11th Gen Intel(R) Core(TM) " + "i" + secilenislemci + "-11700H 2.0 GHz");
                if (secilenislemci == "5")
                {
                    islemcifiyat += 100;
                    Console.WriteLine("Fiyatı: "+islemcifiyat+" $");
                }
                else
                {
                    islemcifiyat += 140;
                    Console.WriteLine("Fiyatı: " + islemcifiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim1;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^RAM^^");
            Console.WriteLine("1-8 GB\n2-16 GB\n3-32 GB");
        secim2:
            Console.Write("Bir RAM seçiniz (Örn. 8,16..):");
            int secilenram = Convert.ToInt16(Console.ReadLine());
            if (secilenram == 8 || secilenram == 16 || secilenram == 32)
            {
                Console.WriteLine(" --->Seçilen ram:" + secilenram + "GB");
                if (secilenram == 8)
                {
                    ramfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else if (secilenram == 16)
                {
                    ramfiyat += 110;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else
                {
                    ramfiyat += 160;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim2;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^EKRAN^^");
            Console.WriteLine("1-15.3\n2-16.3\n3-17.3");
        secim3:
            Console.Write("Bir EKRAN seçiniz (Örn. 15,16..):");
            float secilenekran = Convert.ToInt16(Console.ReadLine());
            if (secilenekran == 15 || secilenekran == 16 || secilenekran == 17)
            {
                Console.WriteLine(" --->Seçilen ekran:" + secilenekran + ".3 inç");
                if(secilenekran == 15)
                {
                    ekranfiyat += 50;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
                else if (secilenekran == 16)
                {
                    ekranfiyat += 55;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
                else
                {
                    ekranfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim3;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^ANAKART^^");
            Console.WriteLine("1-MSI PRO Z790-A WIFI DDR5 5600MHz\n2-MSI PRO Z790-A WIFI DDR5 6600MHz\n3-MSI PRO Z790-A WIFI DDR4 7200MHz");
        secim4:
            Console.Write("Bir ANAKART seçiniz (Örn. 5600):");
            string secilenanakart = Console.ReadLine();
            if (secilenanakart == "5600" || secilenanakart == "6600" || secilenanakart == "7200")
            {
                Console.WriteLine(" --->Seçilen anakart:" + "MSI PRO Z790-A WIFI DDR5 " + secilenanakart + "MHz");
                if (secilenanakart == "5600")
                {
                    anakartfiyat += 65;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else if (secilenanakart == "6600")
                {
                    anakartfiyat += 75;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else
                {
                    anakartfiyat += 85;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim4;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^DİSK^^");
            Console.WriteLine("1-MSI 1TB SSD (3600MB OKUMA)\n2-MSI 1TB SSD (7000MB OKUMA)\n3-MSI 1TB SSD (10000MB OKUMA)");
        secim5:
            Console.Write("Bir DİSK seçiniz (Örn. 3600):");
            string secilendisk = Console.ReadLine();
            if (secilendisk == "3600" || secilendisk == "7000" || secilendisk == "10000")
            {
                Console.WriteLine(" --->Seçilen disk:" + "MSI 1TB SSD (" + secilendisk + "MB OKUMA)");
                if (secilendisk == "3600")
                {
                    diskfiyat += 40;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else if ( secilendisk == "7000")
                {
                    diskfiyat += 55;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else
                {
                    diskfiyat += 70;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim5;
            }
            GenelOzellikler(markasi, secilenislemci, secilenram, secilenekran, secilenanakart, secilendisk);
            toplamfiyat = (islemcifiyat + ramfiyat + ekranfiyat + anakartfiyat + diskfiyat) * dolarkuru;
            Console.WriteLine("Sistem Fiyatı: " + toplamfiyat + " TL");
        }
    }
    public class DELL : Donanim //disk SSD olacak
    {
        public void DonanimSec()
        {
            string markasi = "DESKTOP-DELL";
            Console.WriteLine("    ^^İŞLEMCİ^^");
            Console.WriteLine("1-i3-10700H 2.50 GHz\n2-i5-10700H 2.50 GHz\n3-i7-10700H 2.50 GHz");
        secim1:
            Console.Write("Bir İŞLEMCİ seçiniz (Örn. 3,5..):");
            string secilenislemci = Console.ReadLine();
            if (secilenislemci == "3" || secilenislemci == "5" || secilenislemci == "7")
            {
                Console.WriteLine(" --->Seçilen işlemci:" + "10th Gen Intel(R) Core(TM) " + "i" + secilenislemci + "-10700H 2.50 GHz");
                if (secilenislemci == "3")
                {
                    islemcifiyat += 40;
                    Console.WriteLine("Fiyatı: " + islemcifiyat + " $");
                }
                else if (secilenislemci == "5")
                {
                    islemcifiyat += 100;
                    Console.WriteLine("Fiyatı: " + islemcifiyat + " $");
                }
                else
                {
                    islemcifiyat += 160;
                    Console.WriteLine("Fiyatı: " + islemcifiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim1;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^RAM^^");
            Console.WriteLine("1-8 GB\n2-16 GB\n3-32 GB");
        secim2:
            Console.Write("Bir RAM seçiniz (Örn. 8,16..):");
            int secilenram = Convert.ToInt16(Console.ReadLine());
            if (secilenram == 8 || secilenram == 16 || secilenram == 32)
            {
                Console.WriteLine(" --->Seçilen ram:" + secilenram + "GB");
                if (secilenram == 8)
                {
                    ramfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else if (secilenram == 16)
                {
                    ramfiyat += 110;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else
                {
                    ramfiyat += 160;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim2;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^EKRAN^^");
            Console.WriteLine("1-15.3\n2-16.3\n3-17.3");
        secim3:
            Console.Write("Bir EKRAN seçiniz (Örn. 15,16..):");
            float secilenekran = Convert.ToInt16(Console.ReadLine());
            if (secilenekran == 15 || secilenekran == 16 || secilenekran == 17) 
            {
                Console.WriteLine(" --->Seçilen ekran:" + secilenekran + ".3 inç");
                if (secilenekran == 15)
                {
                    ekranfiyat += 50;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
                else if (secilenekran == 16)
                {
                    ekranfiyat += 55;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
                else
                {
                    ekranfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim3;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^ANAKART^^");
            Console.WriteLine("1-GIGABYTE A620M DDR4 6400MHz\n2-GIGABYTE A620M DDR4 6600MHz\n3-GIGABYTE A620M DDR4 7200MHz");
        secim4:
            Console.Write("Bir ANAKART seçiniz (Örn. 6400):");
            string secilenanakart = Console.ReadLine();
            if (secilenanakart == "6400" || secilenanakart == "6600" || secilenanakart == "7200")
            {
                Console.WriteLine(" --->Seçilen anakart:" + "GIGABYTE A620M DDR4 " + secilenanakart + " MHz");
                if (secilenanakart == "6400")
                {
                    anakartfiyat += 70;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else if (secilenanakart == "6200")
                {
                    anakartfiyat += 80;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else
                {
                    anakartfiyat += 90;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim4;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^DİSK^^");
            Console.WriteLine("1-GIGABYTE 1TB SSD (3500MB OKUMA)\n2-GIGABYTE 1TB SSD (5000MB OKUMA)\n3-GIGABYTE 1TB SSD (7300MB OKUMA)");
        secim5:
            Console.Write("Bir DİSK seçiniz (Örn. 3500):");
            string secilendisk = Console.ReadLine();
            if (secilendisk == "3500" || secilendisk == "5000" || secilendisk == "7300")
            {
                Console.WriteLine(" --->Seçilen disk:" + "GIGABYTE 1TB SSD (" + secilendisk + "MB OKUMA)");
                if (secilendisk == "3500")
                {
                    diskfiyat += 40;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else if (secilendisk == "5000")
                {
                    diskfiyat += 50;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else
                {
                    diskfiyat += 60;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim5;
            }
            GenelOzellikler(markasi, secilenislemci, secilenram, secilenekran, secilenanakart, secilendisk);
            toplamfiyat = (islemcifiyat + ramfiyat + ekranfiyat + anakartfiyat + diskfiyat) * dolarkuru;
            Console.WriteLine("Sistem Fiyatı: " + toplamfiyat + " TL");
        }
    }
    public class ASUS : Donanim //sadece i7 olacak.
    {
        public void DonanimSec()
        {
            string markasi = "DESKTOP-ASUS";
            Console.WriteLine("    ^^İŞLEMCİ^^");
            Console.WriteLine("1-i7-12700H 2.30 GHz");
        secim1:
            Console.Write("Bir İŞLEMCİ seçiniz (Örn. 7)");
            string secilenislemci = Console.ReadLine();
            if (secilenislemci == "7")
            {
                Console.WriteLine(" --->Seçilen işlemci:" + "12th Gen Intel(R) Core(TM) " + "i" + secilenislemci + "-12700H 2.30 GHz");
                if (secilenislemci == "7")
                {
                    islemcifiyat += 200;
                    Console.WriteLine("Fiyatı: " + islemcifiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim1;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^RAM^^");
            Console.WriteLine("1-8 GB\n2-16 GB\n3-32 GB");
        secim2:
            Console.Write("Bir RAM seçiniz (Örn. 8,16..):");
            int secilenram = Convert.ToInt16(Console.ReadLine());
            if (secilenram == 8 || secilenram == 16 || secilenram == 32)
            {
                Console.WriteLine(" --->Seçilen ram:" + secilenram + "GB");
                if (secilenram == 8)
                {
                    ramfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else if (secilenram == 16)
                {
                    ramfiyat += 110;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
                else
                {
                    ramfiyat += 160;
                    Console.WriteLine("Fiyatı: " + ramfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim2;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^EKRAN^^");
            Console.WriteLine("1-15.3\n2-16.3\n3-17.3");
        secim3:
            Console.Write("Bir EKRAN seçiniz (Örn. 15,16..):");
            float secilenekran = Convert.ToInt16(Console.ReadLine());
            if (secilenekran == 15 || secilenekran == 16 || secilenekran == 17)
            {
                Console.WriteLine(" --->Seçilen ekran:" + secilenekran + ".3 inç");
                if (secilenekran == 15)
                {
                    ekranfiyat += 50;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
                else if (secilenekran == 16)
                {
                    ekranfiyat += 55;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
                else
                {
                    ekranfiyat += 60;
                    Console.WriteLine("Fiyatı: " + ekranfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim3;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^ANAKART^^");
            Console.WriteLine("1-ASUS PRIME H610M-K DDR5 5600MHz\n2-ASUS PRIME H610M-K DDR5 6400MHz\n3-ASUS PRIME H610M-K DDR5 7600MHz");
        secim4:
            Console.Write("Bir ANAKART seçiniz (Örn. 5600):");
            string secilenanakart = Console.ReadLine();
            if (secilenanakart == "5600" || secilenanakart == "6400" || secilenanakart == "7600")
            {
                Console.WriteLine(" --->Seçilen anakart:" + "ASUS PRIME H610M-K DDR5 " + secilenanakart + " MHz");
                if (secilenanakart == "5600")
                {
                    anakartfiyat += 60;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else if (secilenanakart == "6400")
                {
                    anakartfiyat += 70;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
                else
                {
                    anakartfiyat += 80;
                    Console.WriteLine("Fiyatı: " + anakartfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim4;
            }
            Console.WriteLine("=====================");

            Console.WriteLine("    ^^DİSK^^");
            Console.WriteLine("1-ASUS ROG STRIX Arion S500 1TB SSD (2300MB OKUMA)\n2-ASUS ROG STRIX Arion S500 1TB SSD (5000MB OKUMA)\n3-ASUS ROG STRIX Arion S500 1TB SSD (7300MB OKUMA)");
        secim5:
            Console.Write("Bir DİSK seçiniz (Örn. 2300):");
            string secilendisk = Console.ReadLine();
            if (secilendisk == "2300" || secilendisk == "5000" || secilendisk == "7300")
            {
                Console.WriteLine(" --->Seçilen disk:" + "ASUS ROG STRIX Arion S500 1TB SSD (" + secilendisk + "MB OKUMA)");
                if (secilendisk == "2300")
                {
                    diskfiyat += 35;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else if (secilendisk == "5000")
                {
                    diskfiyat += 50;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
                else
                {
                    diskfiyat += 60;
                    Console.WriteLine("Fiyatı: " + diskfiyat + " $");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                goto secim5;
            }
            GenelOzellikler(markasi, secilenislemci, secilenram, secilenekran, secilenanakart, secilendisk);
            toplamfiyat = (islemcifiyat + ramfiyat + ekranfiyat + anakartfiyat + diskfiyat) * dolarkuru;
            Console.WriteLine("Sistem Fiyatı: " + toplamfiyat + " TL");
        }
    }
}
