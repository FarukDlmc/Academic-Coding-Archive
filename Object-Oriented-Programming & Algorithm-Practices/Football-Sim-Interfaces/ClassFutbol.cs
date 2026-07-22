using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbaal
{
    interface IYetenekler
    {
        void Pas();
        void Sut();
        void TopTutma();
        void FreeKick();
        void BirincilAyak();
    }
    enum Ayak
    {
        Sağ,
        Sol
    }
    abstract class Oyuncu
    {
        public int age { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public Ayak _ayak;
        private int _FormaNo;
        public int getFormaNo
        {
            get { return _FormaNo; }
        }
    }
    class Kaleci : Oyuncu , IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 7");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 4");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 9");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 2");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class Defans1 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class Defans2 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class Defans3 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class Defans4 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class OrtaSaha1 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 10");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 7");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 5");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class OrtaSaha2 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 10");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 7");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 5");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class SağBek : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 7");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 8");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 6");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 9");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class SolBek : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 7");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 8");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 6");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 9");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sol");
        }
    }
    class Forvet1 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 5");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 9");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 9");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 8");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sol");
        }
    }
    class Forvet2 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 5");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 9");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 9");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 8");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }

    //RAKİP TAKIM 

    class RKaleci : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 7");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 4");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 9");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 2");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RDefans1 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RDefans2 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RDefans3 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RDefans4 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 9");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 8");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 3");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class ROrtaSaha1 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 10");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 7");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 5");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class ROrtaSaha2 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 10");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 6");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 7");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 5");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RSağBek : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 7");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 8");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 6");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 9");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RSolBek : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 7");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 8");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 6");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 9");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sol");
        }
    }
    class RForvet1 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 5");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 9");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 9");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 8");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sağ");
        }
    }
    class RForvet2 : Oyuncu, IYetenekler
    {
        public void Pas()
        {
            Console.WriteLine("Pas Yeteneği: 5");
        }
        public void Sut()
        {
            Console.WriteLine("Şut Yeteneği: 9");
        }
        public void TopTutma()
        {
            Console.WriteLine("Top tutma Yeteneği: 9");
        }
        public void FreeKick()
        {
            Console.WriteLine("FreeKick kullanma yeteneği: 8");
        }
        public void BirincilAyak()
        {
            Console.WriteLine("Birincil Ayak: Sol");
        }
    }
    
}
