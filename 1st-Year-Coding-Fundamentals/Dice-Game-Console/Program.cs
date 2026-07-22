using System;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogumayi;
            string adiniz, soyadiniz;
            Console.Write("Adınız:");
            adiniz =Console.ReadLine();
            Console.Write("Soyadiniz:");
            soyadiniz = Console.ReadLine();
            Console.Write("Hangi ayda doğdunuz?:");
            dogumayi = Convert.ToInt32(Console.ReadLine());
            OyunProgrami oyuncu = new OyunProgrami(adiniz,soyadiniz,dogumayi);
            oyuncu.YasaGörePuan();
            oyuncu.AdSoyadaGörePuan();
            oyuncu.ZarAtımı();
            oyuncu.PuanDurumu();
        }
        public class OyunProgrami
        {
            public string ad;
            public string soyad;
            public int yas;
            public int puan;
            public OyunProgrami(string ad, string soyad, int yas)
            {
                this.ad = ad;
                this.soyad = soyad;
                this.yas = yas;
                this.puan = 0; 
            }
            public void YasaGörePuan() //Doğduğu aya göre kazanacağı puan.
            {
                if ((this.yas + 5) < 12)
                {
                    Console.WriteLine("İlk 6 ayda doğanlar 30 puan kazanır.");
                    this.puan += 30;
                }
                else if ((this.yas + 5) >= 12)
                {
                    Console.WriteLine("Son 6 ayda doğanlar 20 puan kaybeder.");
                    this.puan -= 20;
                }
            }
            public void AdSoyadaGörePuan() //Ad Soyad uzunluğuna göre kazanacağı puan.
            {
                if (this.ad.Length > this.soyad.Length)
                {
                    Console.WriteLine("Adı soyadından daha uzun olanlar 50 puan kazanır.");
                    this.puan += 50;
                }
                else if (this.ad.Length == this.soyad.Length)
                {
                    Console.WriteLine("Adı soyadı aynı uzunlukta olanlar 25 puan kazanır.");
                    this.puan += 25;
                }
                else
                {
                    Console.WriteLine("Adı soyadından daha kısa olanlar 10 puan kaybeder.");
                    this.puan -= 10;
                }
            }
            public void ZarAtımı()
            {
                Random rnd = new Random();
                for (int i = 1; i <= 10; i++) // 10 kez zar atılır
                {
                    Console.WriteLine($"Atış {i}:"); // Hangi atışın yapıldığı ekrana yazdırılır
                    int zar = rnd.Next(1, 7);

                    if (zar == 6)
                    {
                        Console.WriteLine("6 geldi! 100 puan kazandın.");
                        this.puan += 100;
                    }
                    else if (zar == 1)
                    {
                        Console.WriteLine("1 geldi! 75 puan kaybettin.");
                        this.puan -= 75;
                    }
                    else
                    {
                        Console.WriteLine($"{zar} geldi. Tekrar zar atılacak.");
                        i--; // Tekrar zar atılacağı için atış sayısı artırılmaz.
                    }
                }
            }
            public void PuanDurumu()
            {
                if (this.puan >= 500)
                {
                    Console.WriteLine("Tebrikler, kazandınız! Toplam puanınız: " + this.puan);
                }
                else
                {
                    Console.WriteLine("Maalesef kaybettiniz. Toplam puanınız: " + this.puan);
                }
            }
            
        }
    }
}
