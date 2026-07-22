using System;
using System.Collections.Generic;
using System.Linq;

namespace hafta4_ÖDEV
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string ad, soyad,kart;
             List<string> destedeKalanKartlar = new List<string>(); //desteyi arraylist olarak atadım.
            destedeKalanKartlar.Add("sinek as");
            destedeKalanKartlar.Add("sinek 2");
            destedeKalanKartlar.Add("sinek 3");
            destedeKalanKartlar.Add("sinek 4");
            destedeKalanKartlar.Add("sinek 5");
            destedeKalanKartlar.Add("sinek 6");
            destedeKalanKartlar.Add("sinek 7");
            destedeKalanKartlar.Add("sinek 8");
            destedeKalanKartlar.Add("sinek 9");
            destedeKalanKartlar.Add("sinek 10");
            destedeKalanKartlar.Add("sinek Joker");
            destedeKalanKartlar.Add("sinek Kız");
            destedeKalanKartlar.Add("sinek Kral");

            destedeKalanKartlar.Add("karo as");
            destedeKalanKartlar.Add("karo 2");
            destedeKalanKartlar.Add("karo 3");
            destedeKalanKartlar.Add("karo 4");
            destedeKalanKartlar.Add("karo 5");
            destedeKalanKartlar.Add("karo 6");
            destedeKalanKartlar.Add("karo 7");
            destedeKalanKartlar.Add("karo 8");
            destedeKalanKartlar.Add("karo 9");
            destedeKalanKartlar.Add("karo 10");
            destedeKalanKartlar.Add("karo Joker");
            destedeKalanKartlar.Add("karo Kız");
            destedeKalanKartlar.Add("karo Kral");

            destedeKalanKartlar.Add("kupa as");
            destedeKalanKartlar.Add("kupa 2");
            destedeKalanKartlar.Add("kupa 3");
            destedeKalanKartlar.Add("kupa 4");
            destedeKalanKartlar.Add("kupa 5");
            destedeKalanKartlar.Add("kupa 6");
            destedeKalanKartlar.Add("kupa 7");
            destedeKalanKartlar.Add("kupa 8");
            destedeKalanKartlar.Add("kupa 9");
            destedeKalanKartlar.Add("kupa 10");
            destedeKalanKartlar.Add("kupa Joker");
            destedeKalanKartlar.Add("kupa Kız");
            destedeKalanKartlar.Add("kupa Kral");

            destedeKalanKartlar.Add("maça as");
            destedeKalanKartlar.Add("maça 2");
            destedeKalanKartlar.Add("maça 3");
            destedeKalanKartlar.Add("maça 4");
            destedeKalanKartlar.Add("maça 5");
            destedeKalanKartlar.Add("maça 6");
            destedeKalanKartlar.Add("maça 7");
            destedeKalanKartlar.Add("maça 8");
            destedeKalanKartlar.Add("maça 9");
            destedeKalanKartlar.Add("maça 10");
            destedeKalanKartlar.Add("maça Joker");
            destedeKalanKartlar.Add("maça Kız");
            destedeKalanKartlar.Add("maça Kral");

             List<string> el1 = new List<string>(); //oyuncuların elini de arraylist yaptım.
             List<string> el2 = new List<string>();
             bool pişti = false;
             int DogumGunu;
             Console.Write("Adınız:");
             ad = Console.ReadLine();
             Console.Write("Soyadınız:");
             soyad = Console.ReadLine();
             Console.WriteLine("1.oyuncu={0},2.oyuncu={1}",ad,soyad);
             Console.Write("Oyuncunun doğum gününü giriniz:");
             DogumGunu=Convert.ToInt32(Console.ReadLine());
             while (destedeKalanKartlar.Count > 0)
             {
                 kart = destedeKalanKartlar[new Random().Next(0, DogumGunu)]; //doğumgününe göre karma işlemi.
                 Console.WriteLine("Çekilen kart: " + kart); //çekilen kartlar.
                 destedeKalanKartlar.Remove(kart);

                 if (el1.Contains(kart) || el2.Contains(kart))
                 {
                     pişti = true;
                     if (el1.Contains(kart))
                     {
                         Console.WriteLine(ad + " Pişti!");
                     }
                     else
                     {
                         Console.WriteLine(soyad + " Pişti!");
                     }
                 }
                 else
                 {
                     if (el1.Count == el2.Count)
                     {
                         el1.Add(kart);
                     }
                     else
                     {
                         el2.Add(kart);
                     }
                 }
             }

         
        }
    }
}
