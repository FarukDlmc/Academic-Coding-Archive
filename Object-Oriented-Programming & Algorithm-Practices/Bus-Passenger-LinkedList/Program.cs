using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_3_Belediye_Otobüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("38 AB 077 Halk Otobüsü\n");

            Console.WriteLine("ÖN KAPI\n"); //Ön kapı yolcuları. Hepsi bilet basmış.

            Bus Ali = new Bus {ad = "Ali", soyad="Yılmaz", yas=25, cinsiyet="Erkek", kapi ="Ön", koltuk="1-Ö", bilet="+Bilet bastı"}; //yanında kapı var.
            Console.WriteLine("YOLCU: " + Ali.ad + " " + Ali.soyad + " | " + Ali.cinsiyet + " | " + "yaş=" + Ali.yas + " | " + "kapi=" + Ali.kapi + " | " + "koltuk=" + Ali.koltuk + " | " + Ali.bilet);

            Bus Cafer = new Bus { ad = "Cafer", soyad = "Akyol", yas = 16, cinsiyet = "Erkek", kapi = "Ön", koltuk = "2-Ö", bilet = "+Bilet bastı" };
            Ali.sonraki = Cafer; //bağlantılı listede sonraki kişi.
            Console.WriteLine("YOLCU: " + Cafer.ad + " " + Cafer.soyad + " | " + Cafer.cinsiyet + " | " + "yaş=" + Cafer.yas + " | " + "kapi=" + Cafer.kapi + " | " + "koltuk=" + Cafer.koltuk + " | " + Cafer.bilet);

            Bus Mehmet = new Bus { ad = "Mehmet", soyad = "Erdoğan", yas = 30, cinsiyet = "Erkek", kapi = "Ön", koltuk = "3-Ö", bilet = "+Bilet bastı" };
            Ali.sonraki = Mehmet; //bağlantılı listede sonraki kişi.
            Console.WriteLine("YOLCU: " + Mehmet.ad + " " + Mehmet.soyad + " | " + Mehmet.cinsiyet + " | " + "yaş=" + Mehmet.yas + " | " + "kapi=" + Mehmet.kapi + " | " + "koltuk=" + Mehmet.koltuk + " | " + Mehmet.bilet);

            Bus Ayse = new Bus { ad = "Ayşe", soyad = "Aydoğan", yas = 20, cinsiyet = "Kadın", kapi = "Ön", koltuk = "4-Ö", bilet = "+Bilet bastı" };
            Mehmet.sonraki = Ayse;
            Console.WriteLine("YOLCU: " + Ayse.ad + " " + Ayse.soyad + " | " + Ayse.cinsiyet + " | " + "yaş=" + Ayse.yas + " | " + "kapi=" + Ayse.kapi + " | " + "koltuk=" + Ayse.koltuk + " | " + Ayse.bilet);

            Bus Fatma = new Bus { ad = "Fatma", soyad = "Kılıç", yas = 27, cinsiyet = "Kadın", kapi = "Ön", koltuk = "5-Ö", bilet = "+Bilet bastı" };
            Ayse.sonraki = Fatma;
            Console.WriteLine("YOLCU: " + Fatma.ad + " " + Fatma.soyad + " | " + Fatma.cinsiyet + " | " + "yaş=" + Fatma.yas + " | " + "kapi=" + Fatma.kapi + " | " + "koltuk=" + Fatma.koltuk + " | " + Fatma.bilet);

            Bus Zeynep = new Bus { ad = "Zeynep", soyad = "Kaya", yas = 22, cinsiyet = "Kadın", kapi = "Ön", koltuk = "6-Ö", bilet = "+Bilet bastı" };
            Fatma.sonraki = Zeynep;
            Console.WriteLine("YOLCU: " + Zeynep.ad + " " + Zeynep.soyad + " | " + Zeynep.cinsiyet + " | " + "yaş=" + Zeynep.yas + " | " + "kapi=" + Zeynep.kapi + " | " + "koltuk=" + Zeynep.koltuk + " | " + Zeynep.bilet);

            Bus Emine = new Bus { ad = "Emine", soyad = "Gül", yas = 29, cinsiyet = "Kadın", kapi = "Ön", koltuk = "7-Ö", bilet = "+Bilet bastı" };
            Zeynep.sonraki = Emine;
            Console.WriteLine("YOLCU: " + Emine.ad + " " + Emine.soyad + " | " + Emine.cinsiyet + " | " + "yaş=" + Emine.yas + " | " + "kapi=" + Emine.kapi + " | " + "koltuk=" + Emine.koltuk + " | " + Emine.bilet);

            Bus Ahmet = new Bus { ad = "Ahmet", soyad = "Öztürk", yas = 35, cinsiyet = "Erkek", kapi = "Ön", koltuk = "8-Ö", bilet = "+Bilet bastı" };
            Emine.sonraki = Ahmet;
            Console.WriteLine("YOLCU: " + Ahmet.ad + " " + Ahmet.soyad + " | " + Ahmet.cinsiyet + " | " + "yaş=" + Ahmet.yas + " | " + "kapi=" + Ahmet.kapi + " | " + "koltuk=" + Ahmet.koltuk + " | " + Ahmet.bilet);

            Bus Mustafa = new Bus { ad = "Mustafa", soyad = "Demir", yas = 32, cinsiyet = "Erkek", kapi = "Ön", koltuk = "9-Ö", bilet = "+Bilet bastı" };
            Ahmet.sonraki = Mustafa;
            Console.WriteLine("YOLCU: " + Mustafa.ad + " " + Mustafa.soyad + " | " + Mustafa.cinsiyet + " | " + "yaş=" + Mustafa.yas + " | " + "kapi=" + Mustafa.kapi + " | " + "koltuk=" + Mustafa.koltuk + " | " + Mustafa.bilet);

            Bus Burcu = new Bus { ad = "Burcu", soyad = "Kaya", yas = 30, cinsiyet = "Kadın", kapi = "Ön", koltuk = "10-Ö", bilet = "+Bilet bastı" }; //yan koltuğu boş.
            Mustafa.sonraki = Burcu;
            Console.WriteLine("YOLCU: " + Burcu.ad + " " + Burcu.soyad + " | " + Burcu.cinsiyet + " | " + "yaş=" + Burcu.yas + " | " + "kapi=" + Burcu.kapi + " | " + "koltuk=" + Burcu.koltuk + " | " + Burcu.bilet);

            Bus Bos = new Bus();
            Burcu.sonraki = Bos;
            Bos.BosKoltuk();

            Bus İbrahim = new Bus { ad = "İbrahim", soyad = "Yılmaz", yas = 25, cinsiyet = "Erkek", kapi = "Ön", koltuk = "12-Ö", bilet = "+Bilet bastı" };
            Bos.sonraki = İbrahim;
            Console.WriteLine("YOLCU: " + İbrahim.ad + " " + İbrahim.soyad + " | " + İbrahim.cinsiyet + " | " + "yaş=" + İbrahim.yas + " | " + "kapi=" + İbrahim.kapi + " | " + "koltuk=" + İbrahim.koltuk + " | " + İbrahim.bilet);

            Bus Yusuf = new Bus { ad = "Yusuf", soyad = "Yeşil", yas = 45, cinsiyet = "Erkek", kapi = "Ön", koltuk = "13-Ö", bilet = "+Bilet bastı" };
            İbrahim.sonraki = Yusuf;
            Console.WriteLine("YOLCU: " + Yusuf.ad + " " + Yusuf.soyad + " | " + Yusuf.cinsiyet + " | " + "yaş=" + Yusuf.yas + " | " + "kapi=" + Yusuf.kapi + " | " + "koltuk=" + Yusuf.koltuk + " | " + Yusuf.bilet);

            Bus Hatice = new Bus { ad = "Hatice", soyad = "Demir", yas = 35, cinsiyet = "Kadın", kapi = "Ön", koltuk = "14-Ö", bilet = "+Bilet bastı" };
            Yusuf.sonraki = Hatice;
            Console.WriteLine("YOLCU: " + Hatice.ad + " " + Hatice.soyad + " | " + Hatice.cinsiyet + " | " + "yaş=" + Hatice.yas + " | " + "kapi=" + Hatice.kapi + " | " + "koltuk=" + Hatice.koltuk + " | " + Hatice.bilet);

            Bus Leyla = new Bus { ad = "Leyla", soyad = "Demir", yas = 30, cinsiyet = "Kadın", kapi = "Ön", koltuk = "15-Ö", bilet = "+Bilet bastı" };
            Hatice.sonraki = Leyla;
            Console.WriteLine("YOLCU: " + Leyla.ad + " " + Leyla.soyad + " | " + Leyla.cinsiyet + " | " + "yaş=" + Leyla.yas + " | " + "kapi=" + Leyla.kapi + " | " + "koltuk=" + Leyla.koltuk + " | " + Leyla.bilet);

            Bus Atakan = new Bus { ad = "Atakan", soyad = "Özkul", yas = 20, cinsiyet = "Erkek", kapi = "Ön", koltuk = "16-Ö", bilet = "+Bilet bastı" }; //yanında kapı var.
            Leyla.sonraki = Atakan;
            Console.WriteLine("YOLCU: " + Atakan.ad + " " + Atakan.soyad + " | " + Atakan.cinsiyet + " | " + "yaş=" + Atakan.yas + " | " + "kapi=" + Atakan.kapi + " | " + "koltuk=" + Atakan.koltuk + " | " + Atakan.bilet);

            Console.WriteLine("\nORTA KAPI\n"); //Orta kapı yolcuları. Yarısı bilet basmış. 

            Bus Oguz = new Bus { ad = "Oğuz", soyad = "Can", yas = 20, cinsiyet = "Erkek", kapi = "Orta", koltuk="17-O", bilet = "-Bilet basmadı" }; //yanında kapı var.
            Atakan.sonraki = Oguz;
            Console.WriteLine("YOLCU: " + Oguz.ad + " " + Oguz.soyad + " | " + Oguz.cinsiyet + " | " + "yaş=" + Oguz.yas + " | " + "kapi=" + Oguz.kapi + " | " + "koltuk=" + Oguz.koltuk + " | " + Oguz.bilet);

            Bus Kerem = new Bus { ad = "Kerem", soyad = "Aksoy", yas = 22, cinsiyet = "Erkek", kapi = "Orta", koltuk = "18-O", bilet = "-Bilet basmadı" };
            Oguz.sonraki = Kerem;
            Console.WriteLine("YOLCU: " + Kerem.ad + " " + Kerem.soyad + " | " + Kerem.cinsiyet + " | " + "yaş=" + Kerem.yas + " | " + "kapi=" + Kerem.kapi + " | " + "koltuk=" + Kerem.koltuk + " | " + Kerem.bilet);

            Bus Enes = new Bus { ad = "Enes", soyad = "Yılmaz", yas = 24, cinsiyet = "Erkek", kapi = "Orta", koltuk = "19-O", bilet = "+Bilet bastı" };
            Kerem.sonraki = Enes;
            Console.WriteLine("YOLCU: " + Enes.ad + " " + Enes.soyad + " | " + Enes.cinsiyet + " | " + "yaş=" + Enes.yas + " | " + "kapi=" + Enes.kapi + " | " + "koltuk=" + Enes.koltuk + " | " + Enes.bilet);

            Bus Arda = new Bus { ad = "Arda", soyad = "Gül", yas = 26, cinsiyet = "Erkek", kapi = "Orta", koltuk = "20-O", bilet = "+Bilet bastı" };
            Enes.sonraki = Arda;
            Console.WriteLine("YOLCU: " + Arda.ad + " " + Arda.soyad + " | " + Arda.cinsiyet + " | " + "yaş=" + Arda.yas + " | " + "kapi=" + Arda.kapi + " | " + "koltuk=" + Arda.koltuk + " | " + Arda.bilet);

            Bus Berk = new Bus { ad = "Berk", soyad = "Kara", yas = 29, cinsiyet = "Erkek", kapi = "Orta", koltuk = "21-O", bilet = "-Bilet basmadı" };
            Arda.sonraki = Berk;
            Console.WriteLine("YOLCU: " + Berk.ad + " " + Berk.soyad + " | " + Berk.cinsiyet + " | " + "yaş=" + Berk.yas + " | " + "kapi=" + Berk.kapi + " | " + "koltuk=" + Berk.koltuk + " | " + Berk.bilet);

            Bus Elif = new Bus { ad = "Elif", soyad = "Demir", yas = 23, cinsiyet = "Kadın", kapi = "Orta", koltuk = "22-O", bilet = "+Bilet bastı" };
            Berk.sonraki = Elif;
            Console.WriteLine("YOLCU: " + Elif.ad + " " + Elif.soyad + " | " + Elif.cinsiyet + " | " + "yaş=" + Elif.yas + " | " + "kapi=" + Elif.kapi + " | " + "koltuk=" + Elif.koltuk + " | " + Elif.bilet);

            Bus Berfin = new Bus { ad = "Berfin", soyad = "Aksoy", yas = 18, cinsiyet = "Kadın", kapi = "Orta", koltuk = "23-O", bilet = "+Bilet bastı" };
            Elif.sonraki = Berfin;
            Console.WriteLine("YOLCU: " + Berfin.ad + " " + Berfin.soyad + " | " + Berfin.cinsiyet + " | " + "yaş=" + Berfin.yas + " | " + "kapi=" + Berfin.kapi + " | " + "koltuk=" + Berfin.koltuk + " | " + Berfin.bilet);

            Bus Melisa = new Bus { ad = "Melisa", soyad = "Yılmaz", yas = 25, cinsiyet = "Kadın", kapi = "Orta", koltuk = "24-O", bilet = "-Bilet basmadı" };
            Berfin.sonraki = Melisa;
            Console.WriteLine("YOLCU: " + Melisa.ad + " " + Melisa.soyad + " | " + Melisa.cinsiyet + " | " + "yaş=" + Melisa.yas + " | " + "kapi=" + Melisa.kapi + " | " + "koltuk=" + Melisa.koltuk + " | " + Melisa.bilet);

            Bus Deniz = new Bus { ad = "Deniz", soyad = "Gül", yas = 20, cinsiyet = "Kadın", kapi = "Orta", koltuk = "25-O", bilet = "-Bilet basmadı" };
            Melisa.sonraki = Deniz;
            Console.WriteLine("YOLCU: " + Deniz.ad + " " + Deniz.soyad + " | " + Deniz.cinsiyet + " | " + "yaş=" + Deniz.yas + " | " + "kapi=" + Deniz.kapi + " | " + "koltuk=" + Deniz.koltuk + " | " + Deniz.bilet);

            Bus Ceren = new Bus { ad = "Ceren", soyad = "Yıldız", yas = 21, cinsiyet = "Kadın", kapi = "Orta", koltuk = "26-O", bilet = "+Bilet bastı" }; //yan koltuğu boş.
            Deniz.sonraki = Ceren;
            Console.WriteLine("YOLCU: " + Ceren.ad + " " + Ceren.soyad + " | " + Ceren.cinsiyet + " | " + "yaş=" + Ceren.yas + " | " + "kapi=" + Ceren.kapi + " | " + "koltuk=" + Ceren.koltuk + " | " + Ceren.bilet);

            Bus Bos2 = new Bus();
            Ceren.sonraki = Bos2;
            Bos2.BosKoltuk();

            Console.WriteLine("\nARKA KAPI\n"); //arka kapı yolcuları. 9 kişi bilet basmamış.

            Bus Fatih = new Bus { ad = "Fatih", soyad = "Altın", yas = 26, cinsiyet = "Erkek", kapi = "Arka", koltuk = "28-A", bilet = "+Bilet bastı" };
            Ceren.sonraki = Fatih;
            Console.WriteLine("YOLCU: " + Fatih.ad + " " + Fatih.soyad + " | " + Fatih.cinsiyet + " | " + "yaş=" + Fatih.yas + " | " + "kapi=" + Fatih.kapi + " | " + "koltuk=" + Fatih.koltuk + " | " + Fatih.bilet);

            Bus Tarık = new Bus { ad = "Tarık", soyad = "Atar", yas = 20, cinsiyet = "Erkek", kapi = "Arka", koltuk = "29-A", bilet = "+Bilet bastı" };
            Fatih.sonraki = Tarık;
            Console.WriteLine("YOLCU: " + Tarık.ad + " " + Tarık.soyad + " | " + Tarık.cinsiyet + " | " + "yaş=" + Tarık.yas + " | " + "kapi=" + Tarık.kapi + " | " + "koltuk=" + Tarık.koltuk + " | " + Tarık.bilet);

            Bus İrem = new Bus { ad = "İrem", soyad = "Dağarslan", yas = 45, cinsiyet = "Kadın", kapi = "Arka", koltuk = "30-A", bilet = "+Bilet bastı" };
            Tarık.sonraki = İrem;
            Console.WriteLine("YOLCU: " + İrem.ad + " " + İrem.soyad + " | " + İrem.cinsiyet + " | " + "yaş=" + İrem.yas + " | " + "kapi=" + İrem.kapi + " | " + "koltuk=" + İrem.koltuk + " | " + İrem.bilet);

            Bus Songul = new Bus { ad = "Songül", soyad = "Yerli", yas = 50, cinsiyet = "Kadın", kapi = "Arka", koltuk = "31-A", bilet = "+Bilet bastı" };
            İrem.sonraki = Songul;
            Console.WriteLine("YOLCU: " + Songul.ad + " " + Songul.soyad + " | " + Songul.cinsiyet + " | " + "yaş=" + Songul.yas + " | " + "kapi=" + Songul.kapi + " | " + "koltuk=" + Songul.koltuk + " | " + Songul.bilet);

            Bus Munevver = new Bus { ad = "Münevver", soyad = "Nur", yas = 20, cinsiyet = "Kadın", kapi = "Arka", koltuk = "32-A", bilet = "-Bilet basmadı" };
            Songul.sonraki = Munevver;
            Console.WriteLine("YOLCU: " + Munevver.ad + " " + Munevver.soyad + " | " + Munevver.cinsiyet + " | " + "yaş=" + Munevver.yas + " | " + "kapi=" + Munevver.kapi + " | " + "koltuk=" + Munevver.koltuk + " | " + Munevver.bilet);

            Bus Merve = new Bus { ad = "Merve", soyad = "Hasdemir", yas = 20, cinsiyet = "Kadın", kapi = "Arka", koltuk = "33-A", bilet = "-Bilet basmadı" };
            Munevver.sonraki = Merve;
            Console.WriteLine("YOLCU: " + Merve.ad + " " + Merve.soyad + " | " + Merve.cinsiyet + " | " + "yaş=" + Merve.yas + " | " + "kapi=" + Merve.kapi + " | " + "koltuk=" + Merve.koltuk + " | " + Merve.bilet);

            Bus Ceylin = new Bus { ad = "Ceylin", soyad = "Güz", yas = 23, cinsiyet = "Kadın", kapi = "Arka", koltuk = "34-A", bilet = "-Bilet basmadı" };
            Merve.sonraki = Ceylin;
            Console.WriteLine("YOLCU: " + Ceylin.ad + " " + Ceylin.soyad + " | " + Ceylin.cinsiyet + " | " + "yaş=" + Ceylin.yas + " | " + "kapi=" + Ceylin.kapi + " | " + "koltuk=" + Ceylin.koltuk + " | " + Ceylin.bilet);

            Bus Sumeyye = new Bus { ad = "Sümeyye", soyad = "Anigi", yas = 22, cinsiyet = "Kadın", kapi = "Arka", koltuk = "35-A", bilet = "-Bilet basmadı" };
            Ceylin.sonraki = Sumeyye;
            Console.WriteLine("YOLCU: " + Sumeyye.ad + " " + Sumeyye.soyad + " | " + Sumeyye.cinsiyet + " | " + "yaş=" + Sumeyye.yas + " | " + "kapi=" + Sumeyye.kapi + " | " + "koltuk=" + Sumeyye.koltuk + " | " + Sumeyye.bilet);

            Bus Salih = new Bus { ad = "Salih", soyad = "Yıldız", yas = 19, cinsiyet = "Erkek", kapi = "Arka", koltuk = "36-A", bilet = "-Bilet basmadı" }; //yanında kapı var.
            Sumeyye.sonraki = Salih;
            Console.WriteLine("YOLCU: " + Salih.ad + " " + Salih.soyad + " | " + Salih.cinsiyet + " | " + "yaş=" + Salih.yas + " | " + "kapi=" + Salih.kapi + " | " + "koltuk=" + Salih.koltuk + " | " + Salih.bilet);

            Bus Emre = new Bus { ad = "Emre", soyad = "Önal", yas = 27, cinsiyet = "Erkek", kapi = "Arka", koltuk = "37-A", bilet = "-Bilet basmadı" }; //arka dörtlü
            Salih.sonraki = Emre;
            Console.WriteLine("YOLCU: " + Emre.ad + " " + Emre.soyad + " | " + Emre.cinsiyet + " | " + "yaş=" + Emre.yas + " | " + "kapi=" + Emre.kapi + " | " + "koltuk=" + Emre.koltuk + " | " + Emre.bilet);

            Bus Adem = new Bus { ad = "Adem", soyad = "Budak", yas = 36, cinsiyet = "Erkek", kapi = "Arka", koltuk = "38-A", bilet = "-Bilet basmadı" }; //arka dörtlü
            Emre.sonraki = Adem;
            Console.WriteLine("YOLCU: " + Adem.ad + " " + Adem.soyad + " | " + Adem.cinsiyet + " | " + "yaş=" + Adem.yas + " | " + "kapi=" + Adem.kapi + " | " + "koltuk=" + Adem.koltuk + " | " + Adem.bilet);

            Bus Bülent = new Bus { ad = "Bülent", soyad = "Ağıl", yas = 20, cinsiyet = "Erkek", kapi = "Arka", koltuk = "39-A", bilet = "-Bilet basmadı" }; //arka dörtlü
            Adem.sonraki = Bülent;
            Console.WriteLine("YOLCU: " + Bülent.ad + " " + Bülent.soyad + " | " + Bülent.cinsiyet + " | " + "yaş=" + Bülent.yas + " | " + "kapi=" + Bülent.kapi + " | " + "koltuk=" + Bülent.koltuk + " | " + Bülent.bilet);

            Bus İrfan = new Bus { ad = "İrfan", soyad = "Çiçek", yas = 30, cinsiyet = "Erkek", kapi = "Arka", koltuk = "40-A", bilet = "-Bilet basmadı" }; //arka dörtlü
            Bülent.sonraki = İrfan;
            Console.WriteLine("YOLCU: " + İrfan.ad + " " + İrfan.soyad + " | " + İrfan.cinsiyet + " | " + "yaş=" + İrfan.yas + " | " + "kapi=" + İrfan.kapi + " | " + "koltuk=" + İrfan.koltuk + " | " + İrfan.bilet);

            Console.WriteLine("\n**OTOBÜS OTURMA PLANI**");
            Console.WriteLine("  ________________________________");
            Console.WriteLine(@"/                                \");
            Console.WriteLine("| ŞOFÖR                      KAPI -");
            Console.WriteLine("| (1-Ö)        |  |          KAPI _");
            Console.WriteLine("| (2-Ö)        |  |         (3-Ö) |");
            Console.WriteLine("| (4-Ö)        |  |         (5-Ö) |");
            Console.WriteLine("| (6-Ö)        |  |         (7-Ö) |");
            Console.WriteLine("| (8-Ö)        |  |         (9-Ö) |");
            Console.WriteLine("| (10-Ö)       |  |        (11-Ö) |");
            Console.WriteLine("| (12-Ö)       |  |        (13-Ö) |");
            Console.WriteLine("| (14-Ö)       |  |        (15-Ö) |");
            Console.WriteLine("| (16-Ö)       |  |          KAPI -");
            Console.WriteLine("| (17-O)       |  |          KAPI _");
            Console.WriteLine("| (18-O)       |  |        (19-O) |");
            Console.WriteLine("| (20-O)       |  |        (21-O) |");
            Console.WriteLine("| (22-O)       |  |        (23-O) |");
            Console.WriteLine("| (24-O)       |  |        (25-O) |");
            Console.WriteLine("| (26-O)       |  |        (27-O) |");
            Console.WriteLine("| (28-A)       |  |        (29-A) |");
            Console.WriteLine("| (30-A)       |  |        (31-A) |");
            Console.WriteLine("| (32-A)       |  |        (33-A) |");
            Console.WriteLine("| (34-A)       |  |        (35-A) |");
            Console.WriteLine("| (36-A)       |  |          KAPI -");
            Console.WriteLine("= PENCERE      |  |          KAPI _");
            Console.WriteLine("| (37-A) (38-A)|  | (39-A) (40-A) |");
            Console.WriteLine("___________________________________");

            Console.ReadLine();
        }
        public class Bus
        {
            public string ad, soyad, cinsiyet,bilet,kapi,koltuk;
            public int yas;
            public Bus sonraki; //bağlantılı listede sonraki eleman için.
            public void BosKoltuk() //boş koltuk bilgisi.
            {
                Console.WriteLine("YOLCU: -Boş Koltuk-");
            }
        }
    }
}
