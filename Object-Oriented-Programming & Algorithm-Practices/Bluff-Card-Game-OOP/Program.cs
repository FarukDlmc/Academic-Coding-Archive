using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Ödev_4_BLÖF.Program;

namespace Ödev_4_BLÖF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Players ply = new Players();
            Console.WriteLine(@"                                                  *-=BLÖF OYUNU=-*");
            ply.Kurallar();
            ply.OyuncuTanımlaVeKartlarıDagıt();
            
            Console.ReadLine();
        }
        public class Players
        {
         public void OyuncuTanımlaVeKartlarıDagıt()
            {
                string oyuncu1, oyuncu2, oyuncu3;
                oyuncu3 = "BİLGİSAYAR";
                Console.Write("-Oyuncu 1'i Giriniz:");
                oyuncu1 = Console.ReadLine();
                Console.Write("-Oyuncu 2'yi Giriniz:");
                oyuncu2 = Console.ReadLine();
                Console.Write("-Oyuncu 3:{0}\n", oyuncu3);
                

                List<string> deste = new List<string>();
                deste.Add("sinek-as");
                for (int i = 2; i < 11; i++) //2'den 10'a kadar olan kartlar.
                    deste.Add("sinek-" + i);
                deste.Add("sinek-JOKER");
                deste.Add("sinek-QUEEN");
                deste.Add("sinek-KING");

                deste.Add("karo-as");
                for (int i = 2; i < 11; i++) //2'den 10'a kadar olan kartlar.
                    deste.Add("karo-" + i);
                deste.Add("karo-JOKER");
                deste.Add("karo-QUEEN");
                deste.Add("karo-KING");

                deste.Add("maça-as");
                for (int i = 2; i < 11; i++) //2'den 10'a kadar olan kartlar.
                    deste.Add("maça-" + i);
                deste.Add("maça-JOKER");
                deste.Add("maça-QUEEN");
                deste.Add("maça-KING");

                string[] oyuncular = { oyuncu1, oyuncu2, oyuncu3 };
                
                Random random = new Random();
                deste = deste.OrderBy(x => random.Next()).ToList();
                int oyuncuIndex = 0;
                int kartIndex = 0;

                List<string>[] oyuncuKartlari = new List<string>[oyuncular.Length];
                for (int i = 0; i < oyuncuKartlari.Length; i++)
                {
                    oyuncuKartlari[i] = new List<string>();
                }

                for (int i = 0; i < deste.Count; i++)
                {
                    oyuncuKartlari[kartIndex].Add(deste[i]);
                    kartIndex = (kartIndex + 1) % oyuncular.Length;
                }

                for (int i = 0; i <= 3; i++) //Oyundaki el sayısı.
                {
                    string atilankartlar;
                    // Oyuncu 1'in kartlarını yazdırma.              
                    Console.WriteLine((oyuncuIndex + 1) + ".Oyuncu = " + oyuncular[0] + " kartları:");
                    foreach (var kart in oyuncuKartlari[0])
                    {
                        Console.Write(kart + " ");
                    }
                    Console.Write("\nBir hamle yapınız:");
                    atilankartlar = Console.ReadLine();
                    if (atilankartlar.Length == 0)
                    {
                        Console.WriteLine("Yanlış hamle.Sıra diğer oyuncuda.");
                    }
                    else
                    {
                        int atilanKartIndex = oyuncuKartlari[oyuncuIndex].FindIndex(kart => kart == atilankartlar);
                        if (atilanKartIndex >= 0)
                        {
                            // Atılan kartı oyuncunun elinden kaldır.
                            oyuncuKartlari[oyuncuIndex].RemoveAt(atilanKartIndex);
                            Console.WriteLine("Kart başarıyla atıldı.");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir kart elinizde bulunmuyor.");
                        }
                        Dictionary<string, bool> playerBeliefs = new Dictionary<string, bool>();
                        Console.WriteLine("Diğer oyuncular hamleyi değerlendiriyor...");
                        foreach (var player in oyuncular) //rastgele şekilde blöf veya pas dedirten.
                        {
                            if (player != oyuncu1)
                            {
                                bool believe = random.Next(0, 1) == 1;
                                playerBeliefs[player] = believe;
                                Console.WriteLine($"{player} hamleye inanıyor mu? {(believe ? "Blöf" : "Pas")}");
                            }
                        }
                    }                                         
                    //oyuncu 2.
                    Console.WriteLine((oyuncuIndex + 2) + ".Oyuncu = " + oyuncular[1] + " kartları:");
                    foreach (var kart in oyuncuKartlari[1])
                    {
                        Console.Write(kart + " ");
                    }
                    Console.Write("\nBir hamle yapınız:");
                    atilankartlar = Console.ReadLine();
                    if (atilankartlar.Length == 0)
                    {
                        Console.WriteLine("Yanlış hamle.Sıra diğer oyuncuda.");
                    }
                    else
                    {
                        int atilanKartIndex = oyuncuKartlari[oyuncuIndex].FindIndex(kart => kart == atilankartlar);
                        if (atilanKartIndex >= 0)
                        {
                            // Atılan kartı oyuncunun elinden kaldır.
                            oyuncuKartlari[oyuncuIndex].RemoveAt(atilanKartIndex);
                            Console.WriteLine("Kart başarıyla atıldı.");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir kart elinizde bulunmuyor.");
                        }
                        Dictionary<string, bool> playerBeliefs = new Dictionary<string, bool>();
                        Console.WriteLine("Diğer oyuncular hamleyi değerlendiriyor...");
                        foreach (var player in oyuncular) //rastgele şekilde blöf veya pas dedirten.
                        {
                            if (player != oyuncu2)
                            {
                                bool believe = random.Next(0, 1) == 1;
                                playerBeliefs[player] = believe;
                                Console.WriteLine($"{player} hamleye inanıyor mu? {(believe ? "Blöf" : "Pas")}");
                            }
                        }
                    }
                    //bilgisayar.
                    Console.WriteLine((oyuncuIndex + 3) + ".Oyuncu = " + oyuncular[2] + " kartları:");
                    foreach (var kart in oyuncuKartlari[2])
                    {
                        Console.Write(kart + " ");
                    }
                    List<string> bilgisayarKartlari = oyuncuKartlari[oyuncuIndex];
                    bilgisayarKartlari = oyuncuKartlari[2].OrderBy(x => random.Next()).ToList();
                    int atilanKartSayisi = 2;

                    if (bilgisayarKartlari.Count < atilanKartSayisi)
                    {
                        Console.WriteLine("Bilgisayarın elinde yeterli kart yok.");
                    }
                    else
                    {                     
                        for (int j = 0; j < atilanKartSayisi; j++)
                        {
                            string atilanKart = bilgisayarKartlari[i];
                            Console.WriteLine($"\nBilgisayar, {atilanKart} kartını atıyor.");
                            bilgisayarKartlari.RemoveAt(i);
                        }
                        Dictionary<string, bool> playerBeliefs = new Dictionary<string, bool>();
                        Console.WriteLine("Diğer oyuncular hamleyi değerlendiriyor...");
                        foreach (var player in oyuncular) //rastgele şekilde blöf veya pas dedirten.
                        {
                            if (player != oyuncu3)
                            {
                                bool believe = random.Next(0, 1) == 1;
                                playerBeliefs[player] = believe;
                                Console.WriteLine($"{player} hamleye inanıyor mu? {(believe ? "Blöf" : "Pas")}");
                            }
                        }
                    }                   
                }
            }   
            public void Kurallar()
            {
                Console.WriteLine("+KURALLAR+");
                Console.WriteLine("1-En az 2 en fazla 3 kart atabilirsiniz.");
                Console.WriteLine("2-Hamle'nin blöf olduğu anlaşılırsa sıra diğer oyuncuya geçer.");
                Console.WriteLine("3-Elindeki kartları ilk bitiren kişi oyunu kazanır.");
                Console.WriteLine("(başlamak için 'Enter'a basınız.)\n");
                Console.ReadKey();
            }
        }
    }
}
