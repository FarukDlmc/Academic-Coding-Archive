using System;

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cinsiyet,is_gunu, DogumGun, DogumAy, DogumYil, BuGun, BuAy, BuYil; //cinsiyeti de integer tipinde aldım daha sonrasında if ile daha rahat kontrol edebilmek için.
            UInt64 numara;
            string ad,soyad;
            Console.Write("Dogum Tarihinizi Gun-Ay-Yil seklinde giriniz:");
            DogumGun = Convert.ToInt16(Console.ReadLine()); DogumAy = Convert.ToInt16(Console.ReadLine()); DogumYil = Convert.ToInt16(Console.ReadLine());
            Console.Write("Bugunun Tarihini Gun-Ay-Yil seklinde giriniz:");
            BuGun = Convert.ToInt16(Console.ReadLine()); BuAy = Convert.ToInt16(Console.ReadLine()); BuYil = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Dogum Tarihi:{0}/{1}/{2}\n Bugunun Tarihi:{3}/{4}/{5}", DogumGun, DogumAy, DogumYil,BuGun,BuAy,BuYil);
            Console.Write("Adiniz:");
            ad = Console.ReadLine();
            Console.Write("Soyadiniz:");
            soyad = Console.ReadLine();
            Console.Write("Cinsiyetiniz(Erkek ise '1' Kadin ise '0' yaziniz):");
            cinsiyet = Convert.ToInt16(Console.ReadLine());
            Console.Write("Numaraniz(5xxxxxxxxx):");
            numara = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Kac gun sonra isiniz var:");
            is_gunu = Convert.ToInt32(Console.ReadLine());
            if (cinsiyet == 1) //CİNSİYETİN ERKEK OLDUĞU DURUM.
            {
                int i, k;i = 0;k = 0;
                if(BuYil-DogumYil ==20) //21 yaşından gün alanlar.
                {
                    if (is_gunu > 40) //21 yaşından gün alan erkekler için bir ay 40 gün.Ve iş gününün 40'tan fazla girildiği durum.
                    {
                        i = (is_gunu / 40) + 1; //Kaçıncı ay sorusunun cevabı.
                        k = is_gunu % 40; //Kaçıncı gün sorusunun cevabı.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} bey {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, i, k);
                    }
                    else //İş gününün 40'tan az girildiği durum.
                    {
                        i = 1; //40'tan az girildiği durumlarda her türlü 1. ayda olacaktır o yüzden i değişkenine 1 atadım.
                        k = is_gunu; //Kaçıncı gün olacağı ise direkt olarak iş günü değeridir.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} bey {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, i, k);
                    }  
                }
            
            else //21 yaşından gün almayanlar.
            {
                int x, y;
                if(is_gunu >48) //21 yaşından gün almayan erkekler için bir ay 48 gün.Ve iş gününün 48'den fazla girildiği durum.
                {
                        x = (is_gunu / 48) + 1; //Kaçıncı ay sorusunun cevabı.
                        y = is_gunu % 48; //Kaçıncı gün sorusunun cevabı.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} bey {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, x, y);
                }
                    else //İş gününü 48'den az girildiği durum.
                    {
                        x = 1; //48'den az girildiği durumlarda her türlü 1. ayda olacaktır o yüzden x değişkenine 1 atadım.
                        y = is_gunu; //Kaçıncı gün olacağı ise direkt olarak iş günü değeridir.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} bey {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, x, y);
                    }
            }


            }
            else //CİNSİYETİN KADIN OLDUĞU DURUM.
            {
                if(BuYil-DogumYil == 20) //21 yaşından gün alanlar.
                {
                    int a, b; a = 0; b = 0; 
                    if (is_gunu > 30) //21 yaşından gün alan kadınlar için bir ay 30 gün. Ve iş gününün 30'dan fazla girildiği durum.
                    {
                        a = (is_gunu / 30) + 1; //Kaçıncı ay sorusunun cevabı.
                        b = is_gunu % 30; //Kaçıncı gün sorusunun cevabı.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} hanım {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, a, b);
                    }
                    else //İş gününün 30'dan az girildiği durum.
                    {
                        a = 1; //30'dan az girildiği durumlarda her türlü 1. ayda olacaktır o yüzden a değişkenine 1 atadım.
                        b = is_gunu; //Kaçıncı gün olacağı ise direkt olarak iş günü değeridir.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} hanım {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, a, b);
                    }
                }
                else //21 yaşından gün almayanlar.
                {
                    int c, d; c = 0; d = 0;
                    if (is_gunu > 36)  //21 yaşından gün almayan kadınlar için bir ay 36 gün. Ve iş gününün 36'dan fazla girildiği durum.
                    {
                        c = (is_gunu / 36) + 1; //Kaçıncı ay sorusunun cevabı.
                        d = is_gunu % 36; //Kaçıncı gün sorusunun cevabı.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} hanım {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, c, d);
                    }
                    else //İş gününün 36'dan az girildiği durum. 
                    {
                        c = 1; //36'dan az girildiği durumlarda her türlü 1. ayda olacaktır o yüzden c değişkenine 1 atadım.
                        d = is_gunu; //Kaçıncı gün olacağı ise direkt olarak iş günü değeridir.
                        Console.WriteLine("Sayin {0} isimli {1} soyisimli {0} hanım {3} yasindasiniz {4}.ayin {5}.gununde isiniz bulunmaktadir.", ad, soyad, ad, BuYil - DogumYil, c, d);
                    }

                }
            }
        }
    }
}
