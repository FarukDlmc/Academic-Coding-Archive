using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ödev__2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger;
            Person1 prsn1 = new Person1();
            Person2 prsn2 = new Person2();
            Person3 prsn3 = new Person3();
            Person4 prsn4 = new Person4();
            Person5 prsn5 = new Person5();
            Person6 prsn6 = new Person6();
            Console.WriteLine("***KİŞİLER***");
            Console.WriteLine("1-AHMED DİLMAÇ\n2-MURAT TAŞYÜREK\n3-ALİ KILIÇ\n4-AYŞE YILMAZ\n5-MEHMET ÖZDEMİR\n6-FATMA ŞAHİN");
            Console.Write("Araç Bilgilerini Görmek İstediğiniz Kişiyi Seçiniz:");
            deger = Convert.ToInt32(Console.ReadLine());
            if (deger == 1) //Kişi seçimi.
            {
                prsn1.ShowInfo1();
            }
            else if (deger == 2)
            {
                prsn2.ShowInfo2();
            }
            else if (deger == 3)
            {
                prsn3.ShowInfo3();
            }
            else if (deger == 4)
            {
                prsn4.ShowInfo4();
            }
            else if (deger == 5)
            {
                prsn5.ShowInfo5();
            }
            else if (deger == 6)
            {
                prsn6.ShowInfo6();
            }
            else
            {
                Console.WriteLine("Yanlış tuşlama yaptınız. Lütfen sisteme tekrar giriş yapınız!");
            }
        }
    }
    public class Person1
    {
        public Arac1 arac1 = new Arac1();
        string adi = "Ahmed", soyadi = "Dilmaç"; //private veriler.
        int dogumyili = 2003;
        long tcNO = 12571010524;
        long araciedinmefiyati=1220000;
        int edinmeyili=2023;
        public void SetPersonalInfo1(string adi, string soyadi, int dogumyili, long tcNO, long araciedinmefiyati, int edinmeyili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.tcNO = tcNO;
            this.dogumyili = dogumyili;
            this.araciedinmefiyati = araciedinmefiyati;
            this.edinmeyili = edinmeyili;
        }

        public void ShowInfo1()
        {
            arac1.AracInfo1();
            Console.WriteLine("Şuanki sahibi:{0} {1}", adi, soyadi);
            Console.WriteLine("Edinme Tarihi:{0}-Model Yılı:{1}" , edinmeyili, arac1.uretimyili + " Bir önceki sahibinin adı:Fatma Şahin");
        }
    }
    public class Person2
    {
        public Arac2 arac2 = new Arac2();
        string adi = "Murat", soyadi = "Taşyürek"; //private veriler.
        int dogumyili = 1980;
        long tcNO = 312345678901;
        long araciedinmefiyati = 1000000;
        int edinmeyili = 2022;
        private void SetPersonalInfo2(string adi, string soyadi, int dogumyili, long tcNO, long araciedinmefiyati, int edinmeyili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.tcNO = tcNO;
            this.dogumyili = dogumyili;
            this.araciedinmefiyati = araciedinmefiyati;
            this.edinmeyili = edinmeyili;
        }
        public void ShowInfo2()
        {
            arac2.AracInfo2();
            Console.WriteLine("Şuanki sahibi:{0} {1}", adi, soyadi);
            Console.WriteLine("Edinme Tarihi:{0}-Model Yılı:{1}", edinmeyili, arac2.uretimyili + " Bir önceki sahibinin adı:Ali Kılıç");
        }
    }
    public class Person3
    {
        public Arac3 arac3 = new Arac3();
        string adi = "Ali", soyadi = "Kılıç"; //private veriler.
        int dogumyili = 1975;
        long tcNO = 323456789012;
        long araciedinmefiyati = 1420000;
        int edinmeyili = 2021;
        private void SetPersonalInfo3(string adi, string soyadi, int dogumyili, long tcNO, long araciedinmefiyati, int edinmeyili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.tcNO = tcNO;
            this.dogumyili = dogumyili;
            this.araciedinmefiyati = araciedinmefiyati;
            this.edinmeyili = edinmeyili;
        }
        public void ShowInfo3()
        {
            arac3.AracInfo3();
            Console.WriteLine("Şuanki sahibi:{0} {1}", adi, soyadi);
            Console.WriteLine("Edinme Tarihi:{0}-Model Yılı:{1}", edinmeyili, arac3.uretimyili + " Bir önceki sahibinin adı:Mehmet Özdemir");
        }
    }
    public class Person4
    {
        public Arac4 arac4 = new Arac4();
        string adi = "Ayşe", soyadi = "Yılmaz"; //private veriler.
        int dogumyili = 1970;
        long tcNO = 334567890135;
        long araciedinmefiyati = 720000;
        int edinmeyili = 2020;
        private void SetPersonalInfo4(string adi, string soyadi, int dogumyili, long tcNO, long araciedinmefiyati, int edinmeyili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.tcNO = tcNO;
            this.dogumyili = dogumyili;
            this.araciedinmefiyati = araciedinmefiyati;
            this.edinmeyili = edinmeyili;
        }
        public void ShowInfo4()
        {
            arac4.AracInfo4();
            Console.WriteLine("Şuanki sahibi:{0} {1}", adi, soyadi);
            Console.WriteLine("Edinme Tarihi:{0}-Model Yılı:{1}", edinmeyili, arac4.uretimyili + " Bir önceki sahibinin adı:Ahmed Dilmaç");
        }
    }
    public class Person5
    {
        public Arac5 arac5 = new Arac5();
        string adi = "Mehmet", soyadi = "Özdemir"; //private veriler.
        int dogumyili = 2000;
        long tcNO = 363456789016;
        long araciedinmefiyati = 2220000;
        int edinmeyili = 2019;
        private void SetPersonalInfo5(string adi, string soyadi, int dogumyili, long tcNO, long araciedinmefiyati, int edinmeyili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.tcNO = tcNO;
            this.dogumyili = dogumyili;
            this.araciedinmefiyati = araciedinmefiyati;
            this.edinmeyili = edinmeyili;
        }
        public void ShowInfo5()
        {
            arac5.AracInfo5();
            Console.WriteLine("Şuanki sahibi:{0} {1}", adi, soyadi);
            Console.WriteLine("Edinme Tarihi:{0}-Model Yılı:{1}", edinmeyili, arac5.uretimyili + " Bir önceki sahibinin adı:Murat Taşyürek");
        }
    }
    public class Person6
    {
        public Arac6 arac6 = new Arac6();
        string adi = "Fatma", soyadi = "Şahin"; //private veriler.
        int dogumyili = 1990;
        long tcNO = 383456789018;
        long araciedinmefiyati = 950000;
        int edinmeyili = 2023;
        private void SetPersonalInfo6(string adi, string soyadi, int dogumyili, long tcNO, long araciedinmefiyati, int edinmeyili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.tcNO = tcNO;
            this.dogumyili = dogumyili;
            this.araciedinmefiyati = araciedinmefiyati;
            this.edinmeyili = edinmeyili;
        }
        public void ShowInfo6()
        {
            arac6.AracInfo6();
            Console.WriteLine("Şuanki sahibi:{0} {1}", adi, soyadi);
            Console.WriteLine("Edinme Tarihi:{0}-Model Yılı:{1}", edinmeyili, arac6.uretimyili + " Bir önceki sahibinin adı:Ayşe Yılmaz");
        }
    }
    public class Arac1
    {
        string markasi = "T0GG", modeli = "T10X"; //private veriler.
        public int uretimyili = 2021;
        string sasiNO = "***G***1";
        public void SetPersonalInfo1(string markasi, string modeli, int uretimyili, string sasiNO)
        {
            this.markasi = markasi;
            this.modeli = modeli;
            this.uretimyili = uretimyili;
            this.sasiNO = sasiNO;
        }
        public void AracInfo1()
        {
            Console.WriteLine("_/ Araç Bilgileri /_");
            Console.WriteLine("Şasi Numarası:" + sasiNO);

        }
    }
    public class Arac2
    {
        string markasi = "Mercedes", modeli = "C180"; //private veriler.
        public int uretimyili = 2014;
        string sasiNO = "***C***0";
        public void SetPersonalInfo2(string markasi, string modeli, int uretimyili, string sasiNO)
        {
            this.markasi = markasi;
            this.modeli = modeli;
            this.uretimyili = uretimyili;
            this.sasiNO = sasiNO;
        }
        public void AracInfo2()
        {
            Console.WriteLine("_/ Araç Bilgileri /_");
            Console.WriteLine("Şasi Numarası:" + sasiNO);

        }
    }
    public class Arac3
    {
        string markasi = "Volkswagen", modeli = "Passat"; //private veriler.
        public int uretimyili = 2018;
        string sasiNO = "***P***8";
        public void SetPersonalInfo3(string markasi, string modeli, int uretimyili, string sasiNO)
        {
            this.markasi = markasi;
            this.modeli = modeli;
            this.uretimyili = uretimyili;
            this.sasiNO = sasiNO;
        }
        public void AracInfo3()
        {
            Console.WriteLine("_/ Araç Bilgileri /_");
            Console.WriteLine("Şasi Numarası:" + sasiNO);

        }
    }
    public class Arac4
    {
        string markasi = "Renault", modeli = "Megane"; //private veriler.
        public int uretimyili = 2020;
        string sasiNO = "***M***2";
        public void SetPersonalInfo4(string markasi, string modeli, int uretimyili, string sasiNO)
        {
            this.markasi = markasi;
            this.modeli = modeli;
            this.uretimyili = uretimyili;
            this.sasiNO = sasiNO;
        }
        public void AracInfo4()
        {
            Console.WriteLine("_/ Araç Bilgileri /_");
            Console.WriteLine("Şasi Numarası:" + sasiNO);

        }
    }
    public class Arac5
    {
        string markasi = "BMW", modeli = "520i M Sport"; //private veriler.
        public int uretimyili = 2018;
        string sasiNO = "***B***5";
        public void SetPersonalInfo5(string markasi, string modeli, int uretimyili, string sasiNO)
        {
            this.markasi = markasi;
            this.modeli = modeli;
            this.uretimyili = uretimyili;
            this.sasiNO = sasiNO;
        }
        public void AracInfo5()
        {
            Console.WriteLine("_/ Araç Bilgileri /_");
            Console.WriteLine("Şasi Numarası:" + sasiNO);

        }
    }
    public class Arac6
    {
        string markasi = "Volkswagen", modeli = "Caravelle"; //private veriler.
        public int uretimyili = 2015;
        string sasiNO = "***C***6";
        public void SetPersonalInfo6(string markasi, string modeli, int uretimyili, string sasiNO)
        {
            this.markasi = markasi;
            this.modeli = modeli;
            this.uretimyili = uretimyili;
            this.sasiNO = sasiNO;
        }
        public void AracInfo6()
        {
            Console.WriteLine("_/ Araç Bilgileri /_");
            Console.WriteLine("Şasi Numarası:" + sasiNO);

        }
    }
}
