using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV__6__Kredi_Kartı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                                  *-ÖDEME MERKEZİ-*");
            Console.WriteLine("KATEGORİLER");
            Console.WriteLine("1-Ulaşım\n2-Eğlence\n3-Giyim\n4-Yemek\n5-Diğer");
            seçim:
            Console.Write("Alışverişin Türünü Seçiniz:");
            int alışveriş = Convert.ToInt16(Console.ReadLine());

            if (alışveriş == 1)
            {
                UlaşimSanalKart ulaşim = new UlaşimSanalKart();
                ulaşim.Harcama();
            }
            else if (alışveriş == 2)
            {
                EglenceSanalKart eglence = new EglenceSanalKart();
                eglence.Harcama();
            }
            else if (alışveriş == 3)
            {
                GiyimSanalKart giyim = new GiyimSanalKart();
                giyim.Harcama();
            }
            else if (alışveriş == 4)
            {
                YemekSanalKart yemek = new YemekSanalKart();
                yemek.Harcama();
            }
            else if (alışveriş == 5)
            {
                CreditCart kredikart = new CreditCart();
                kredikart.MainKart();
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Deneyiniz.");
                goto seçim;
            }
            Console.ReadLine();
        }
    }
    public class CreditCart
    {
        public int limit = 6000;
        public int ulaşimlimit = 3500;
        public int eglencelimit = 3500;
        public int giyimlimit = 3500;
        public int yemeklimit = 3500;
        public int asimlimiti = 800;
        public int ulaşimkalan, eglencekalan, giyimkalan, yemekkalan, anakalan,limitkalan;
        public virtual void Harcama()
        {
            Console.WriteLine("(Bu kart bir sanal karttır).");
        }
        List<string> CreditCartEkstresi = new List<string>();
        public void MainKart()
        {
            Console.WriteLine("\nKart Tipi:" + this.GetType().Name);
            Console.WriteLine("İŞLEMLER");
        seçim:
            Console.WriteLine("1-Faturalar\n2-Eğitim Masrafları\n---\n3-Ekstre Göster");
            Console.Write("Yapmak istediğiniz işlemi seçiniz:");
            int seçim = Convert.ToInt16(Console.ReadLine());
            if (seçim == 1)
            {
                Console.WriteLine("_FATURALAR_");
                Console.WriteLine("1-İnternet\n2-Su\n3-Elektrik\n4-Doğalgaz");
                seçimm:
                Console.Write("Hangi Faturayı ödemek istiyorsunuz:");
                int faturaseçim = Convert.ToInt16(Console.ReadLine());
                if (faturaseçim == 1)
                {
                    seçim1:
                    Console.Write("İnternet faturası tutarını giriniz:");
                    int tutar = Convert.ToInt16(Console.ReadLine());
                    if (tutar <= limit)
                    {
                        limitkalan = limit - tutar;
                        limit = limitkalan;
                        Console.WriteLine("Yeni bakiye: " + limitkalan + " TL");
                        string eleman = "Yapılan işlem 'İnternet Faturası' ödemesi.Harcanan tutar:" + tutar + " TL";
                        CreditCartEkstresi.Add(eleman);
                        goto seçim;
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                        goto seçim1;
                    }
                }
                else if (faturaseçim == 2)
                {
                seçim2:
                    Console.Write("Su faturası tutarını giriniz:");
                    int tutar = Convert.ToInt16(Console.ReadLine());
                    if (tutar <= limit)
                    {
                        limitkalan = limit - tutar;
                        limit = limitkalan;
                        Console.WriteLine("Yeni bakiye: " + limitkalan + " TL");
                        string eleman = "Yapılan işlem 'Su Faturası' ödemesi.Harcanan tutar:" + tutar + " TL";
                        CreditCartEkstresi.Add(eleman);
                        goto seçim;
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                        goto seçim2;
                    }
                }
                else if (faturaseçim == 3)
                {
                seçim3:
                    Console.Write("Elektrik faturası tutarını giriniz:");
                    int tutar = Convert.ToInt16(Console.ReadLine());
                    if (tutar <= limit)
                    {
                        limitkalan = limit - tutar;
                        limit = limitkalan;
                        Console.WriteLine("Yeni bakiye: " + limitkalan + " TL");
                        string eleman = "Yapılan işlem 'Elektrik Faturası' ödemesi.Harcanan tutar:" + tutar + " TL";
                        CreditCartEkstresi.Add(eleman);
                        goto seçim;
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                        goto seçim3;
                    }
                }
                else if (faturaseçim == 4)
                {
                seçim4:
                    Console.Write("Doğalgaz faturası tutarını giriniz:");
                    int tutar = Convert.ToInt16(Console.ReadLine());
                    if (tutar <= limit)
                    {
                        limitkalan = limit - tutar;
                        limit = limitkalan;
                        Console.WriteLine("Yeni bakiye: " + limitkalan + " TL");
                        string eleman = "Yapılan işlem 'Doğalgaz Faturası' ödemesi.Harcanan tutar:" + tutar + " TL";
                        CreditCartEkstresi.Add(eleman);
                        goto seçim;
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz bakiye.");
                        goto seçim4;
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Seçim Yapınız.");
                    goto seçimm;
                }
            }
            else if (seçim == 2)
            {
                seçim1:
                Console.Write("Eğitim masrafları tutarını giriniz:");
                int tutar = Convert.ToInt16(Console.ReadLine());
                if (tutar <= limit)
                {
                    limitkalan = limit - tutar;
                    limit = limitkalan;
                    Console.WriteLine("Yeni bakiye: " + limitkalan + " TL");
                    string eleman = "Yapılan işlem 'Eğitim Masrafları' ödemesi.Harcanan tutar:" + tutar + " TL";
                    CreditCartEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim1;
                }

            }
            else if (seçim == 3)
            {
                foreach (string ekstre in CreditCartEkstresi)
                {
                    Console.WriteLine(ekstre);
                }
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Seçim Yapınız.");
                goto seçim;
            }
        }
    }
    public class UlaşimSanalKart : CreditCart
    {
        List<string> UlasimEkstresi = new List<string>();
        public sealed override void Harcama()
        {
            base.Harcama();
            Console.WriteLine("\nKart Tipi:"+this.GetType().Name);
            Console.WriteLine("İŞLEMLER");
            seçim:
            Console.WriteLine("1-Araç Yakıtı\n2-Şehirlerarası Yolculuk\n3-ŞehirKart Yüklemesi\n4-Araç Muayene\n5-Araç Sigortası\n---\n6-Ekstre Göster\n");
            Console.Write("Yapmak istediğiniz işlemi seçiniz:");
            int seçim = Convert.ToInt16(Console.ReadLine());
            if (seçim == 1)
            {
                seçim1:
                Console.Write("Yakıt tutarını giriniz:");
                int tutar = Convert.ToInt16(Console.ReadLine());
                if(tutar <= (ulaşimlimit + asimlimiti))
                {
                    ulaşimkalan = ulaşimlimit - tutar;
                    ulaşimlimit = ulaşimkalan;
                    Console.WriteLine("Yeni bakiye: " + ulaşimkalan + " TL");
                    string eleman = "Yapılan işlem 'Araç Yakıtı' ödemesi.Harcanan tutar:" + tutar + " TL";
                    UlasimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim1;
                }
            }
            else if(seçim == 2)
            {
                
                seçim2:
                Console.Write("Bilet fiyatını giriniz:");
                int biletfiyat = Convert.ToInt16(Console.ReadLine());
                if(biletfiyat <= (ulaşimlimit + asimlimiti))
                {
                    ulaşimkalan = ulaşimlimit - biletfiyat;
                    ulaşimlimit = ulaşimkalan;
                    Console.WriteLine("Yeni bakiye: "+ ulaşimkalan + " TL");
                    string eleman = "Yapılan işlem 'Şehirlerarası Yolculuk' ödemesi.Harcanan tutar:" + biletfiyat + " TL";
                    UlasimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim2;
                }
            }
            else if(seçim == 3)
            {
                seçim3:
                Console.Write("Şehirkarta yüklemek istediğiniz tutarı giriniz:");
                int sehirkarttutar = Convert.ToInt16(Console.ReadLine());
                if (sehirkarttutar <= (ulaşimlimit + asimlimiti))
                {
                    ulaşimkalan = ulaşimlimit - sehirkarttutar;
                    ulaşimlimit = ulaşimkalan;
                    Console.WriteLine("Yeni bakiye: "+ ulaşimkalan + " TL");
                    string eleman = "Yapılan işlem 'Şehirkart Yüklemesi' ödemesi.Harcanan tutar:" + sehirkarttutar + " TL";
                    UlasimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim3;
                }
            }
            else if (seçim == 4)
            {
                seçim4:
                Console.Write("Araç Muayene ücretini giriniz:");
                int muayene = Convert.ToInt16(Console.ReadLine());
                if (muayene <= (ulaşimlimit + asimlimiti))
                {
                    ulaşimkalan = ulaşimlimit - muayene;
                    ulaşimlimit = ulaşimkalan;
                    Console.WriteLine("Yeni bakiye: "+ulaşimkalan + "TL");
                    string eleman = "Yapılan işlem 'Araç Muayene' ödemesi.Harcanan tutar:" + muayene + " TL";
                    UlasimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim4;
                }
            }
            else if (seçim == 5)
            {
            seçim5:
                Console.Write("Araç Sigorta ücretini giriniz:");
                int sigorta = Convert.ToInt16(Console.ReadLine());
                if (sigorta <= (ulaşimlimit + asimlimiti))
                {
                    ulaşimkalan = ulaşimlimit - sigorta;
                    ulaşimlimit = ulaşimkalan;
                    Console.WriteLine("Yeni bakiye: " + ulaşimkalan + "TL");
                    string eleman = "Yapılan işlem 'Araç Sigorta' ödemesi.Harcanan tutar:" + sigorta + " TL";
                    UlasimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim5;
                }
            }
            else if (seçim == 6)
            {
                foreach (string ekstre in UlasimEkstresi)
                {  
                    Console.WriteLine(ekstre);
                }
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Seçim Yapınız.");
                goto seçim;
            }
        } 
    }
    public class EglenceSanalKart : CreditCart
    {
        List<string> EglenceEkstresi = new List<string>();
        public sealed override void Harcama()
        {
            base.Harcama();
            Console.WriteLine("\nKart Tipi:" + this.GetType().Name);
            Console.WriteLine("İŞLEMLER");
            seçim:
            Console.WriteLine("1-Sinema\n2-Tiyatro\n3-Oyun CD'leri\n---\n4-Ekstre Göster\n");
            Console.Write("Yapmak istediğiniz işlemi seçiniz:");
            int seçim = Convert.ToInt16(Console.ReadLine());
            if (seçim == 1)
            {
            seçim1:
                Console.Write("Sinema bilet fiyatını giriniz:");
                int tutar = Convert.ToInt16(Console.ReadLine());
                if (tutar <= (eglencelimit + asimlimiti))
                {
                    eglencekalan = eglencelimit - tutar;
                    eglencelimit = eglencekalan;
                    Console.WriteLine("Yeni bakiye: " + eglencekalan + " TL");
                    string eleman = "Yapılan işlem 'Sinema' ödemesi.Harcanan tutar:" + tutar + " TL";
                    EglenceEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim1;
                }
            }
            else if (seçim == 2)
            {

            seçim2:
                Console.Write("Tiyatro bilet fiyatını giriniz:");
                int biletfiyat = Convert.ToInt16(Console.ReadLine());
                if (biletfiyat <= (eglencelimit + asimlimiti))
                {
                    eglencekalan = eglencelimit - biletfiyat;
                    eglencelimit = eglencekalan;
                    Console.WriteLine("Yeni bakiye: " + eglencekalan + " TL");
                    string eleman = "Yapılan işlem 'Tiyatro' ödemesi.Harcanan tutar:" + biletfiyat + " TL";
                    EglenceEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim2;
                }
            }
            else if (seçim == 3)
            {
            seçim3:
                Console.Write("Oyun CD'lerine ödenen tutarı giriniz:");
                int CDtutar = Convert.ToInt16(Console.ReadLine());
                if (CDtutar <= (eglencelimit + asimlimiti))
                {
                    eglencekalan = eglencelimit - CDtutar;
                    eglencelimit = eglencekalan;
                    Console.WriteLine("Yeni bakiye: " + ulaşimkalan + " TL");
                    string eleman = "Yapılan işlem 'Oyun CD'leri' ödemesi.Harcanan tutar:" + CDtutar + " TL";
                    EglenceEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim3;
                }
            }
            else if (seçim == 4)
            {
                foreach (string ekstre in EglenceEkstresi)
                {
                    Console.WriteLine(ekstre);
                }
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Seçim Yapınız.");
                goto seçim;
            }
        }
    }
    public class GiyimSanalKart : CreditCart
    {
        List<string> GiyimEkstresi = new List<string>();
        public sealed override void Harcama()
        {
            base.Harcama();
            Console.WriteLine("\nKart Tipi:" + this.GetType().Name);
            Console.WriteLine("İŞLEMLER");
            seçim:
            Console.WriteLine("1-Erkek Kıyafet\n2-Bayan Kıyafet\n3-Ayakkabı\n4-Aksesuar\n---\n5-Ekstre Göster\n");
            Console.Write("Yapmak istediğiniz işlemi seçiniz:");
            int seçim = Convert.ToInt16(Console.ReadLine());
            if (seçim == 1)
            {
            seçim1:
                Console.Write("Erkek kıyafete harcanan ücreti giriniz:");
                int tutar = Convert.ToInt16(Console.ReadLine());
                if (tutar <= (giyimlimit + asimlimiti))
                {
                    giyimkalan = giyimlimit - tutar;
                    giyimlimit = giyimkalan;
                    Console.WriteLine("Yeni bakiye: " + giyimkalan + " TL");
                    string eleman = "Yapılan işlem 'Erkek Kıyafet' ödemesi.Harcanan tutar:" + tutar + " TL";
                    GiyimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim1;
                }
            }
            else if (seçim == 2)
            {

            seçim2:
                Console.Write("Bayan kıyafete harcanan ücreti giriniz:");
                int tutar = Convert.ToInt16(Console.ReadLine());
                if (tutar <= (giyimlimit + asimlimiti))
                {
                    giyimkalan = giyimlimit - tutar;
                    giyimlimit = giyimkalan;
                    Console.WriteLine("Yeni bakiye: " + giyimkalan + " TL");
                    string eleman = "Yapılan işlem 'Bayan Kıyafet' ödemesi.Harcanan tutar:" + tutar + " TL";
                    GiyimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim2;
                }
            }
            else if (seçim == 3)
            {
            seçim3:
                Console.Write("Ayakkabıya ödenen tutarı giriniz:");
                int ayakkabıtutar = Convert.ToInt16(Console.ReadLine());
                if (ayakkabıtutar <= (giyimlimit + asimlimiti))
                {
                    giyimkalan = giyimlimit - ayakkabıtutar;
                    giyimlimit = giyimkalan;
                    Console.WriteLine("Yeni bakiye: " + giyimkalan + " TL");
                    string eleman = "Yapılan işlem 'Ayakkabı' ödemesi.Harcanan tutar:" + ayakkabıtutar + " TL";
                    GiyimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim3;
                }
            }
            else if (seçim == 4)
            {
            seçim3:
                Console.Write("Aksesuara ödenen tutarı giriniz:");
                int akstutar = Convert.ToInt16(Console.ReadLine());
                if (akstutar <= (giyimlimit + asimlimiti))
                {
                    giyimkalan = giyimlimit - akstutar;
                    giyimlimit = giyimkalan;
                    Console.WriteLine("Yeni bakiye: " + giyimkalan + " TL");
                    string eleman = "Yapılan işlem 'Aksesuar' ödemesi.Harcanan tutar:" + akstutar + " TL";
                    GiyimEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim3;
                }
            }
            else if (seçim == 5)
            {
                foreach (string ekstre in GiyimEkstresi)
                {
                    Console.WriteLine(ekstre);
                }
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Seçim Yapınız.");
                goto seçim;
            }
        }
    }
    public class YemekSanalKart : CreditCart
    {
        List<string> YemekEkstresi = new List<string>();
        public sealed override void Harcama()
        {
            base.Harcama();
            Console.WriteLine("\nKart Tipi:" + this.GetType().Name);
            Console.WriteLine("İŞLEMLER");
            seçim:
            Console.WriteLine("1-Mutfak Giderleri\n2-Resataurant Ödemeleri\n3-Abur-Cubur\n---\n4-Ekstre Göster\n");
            Console.Write("Yapmak istediğiniz işlemi seçiniz:");
            int seçim = Convert.ToInt16(Console.ReadLine());
            if (seçim == 1)
            {
            seçim1:
                Console.Write("Mutfak gideri tutarını giriniz:");
                int tutar = Convert.ToInt16(Console.ReadLine());
                if (tutar <= (yemeklimit + asimlimiti))
                {
                    yemekkalan = yemeklimit - tutar;
                    yemeklimit = yemekkalan;
                    Console.WriteLine("Yeni bakiye: " + yemekkalan + " TL");
                    string eleman = "Yapılan işlem 'Mutfak Giderleri' ödemesi.Harcanan tutar:" + tutar + " TL";
                    YemekEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim1;
                }
            }
            else if (seçim == 2)
            {

            seçim2:
                Console.Write("Resataurant'a harcanan ücreti giriniz:");
                int restutar = Convert.ToInt16(Console.ReadLine());
                if (restutar <= (yemeklimit + asimlimiti))
                {
                    yemekkalan = yemeklimit - restutar;
                    yemeklimit = yemekkalan;
                    Console.WriteLine("Yeni bakiye: " + yemekkalan + " TL");
                    string eleman = "Yapılan işlem 'Restaurant Ödemeleri' ödemesi.Harcanan tutar:" + restutar + " TL";
                    YemekEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim2;
                }
            }
            else if (seçim == 3)
            {
            seçim3:
                Console.Write("Abur-Cubur'a ödenen tutarı giriniz:");
                int actutar = Convert.ToInt16(Console.ReadLine());
                if (actutar <= (yemeklimit + asimlimiti))
                {
                    yemekkalan = yemeklimit - actutar;
                    yemeklimit = yemekkalan;
                    Console.WriteLine("Yeni bakiye: " + yemekkalan + " TL");
                    string eleman = "Yapılan işlem 'Abur-Cubur' ödemesi.Harcanan tutar:" + actutar + " TL";
                    YemekEkstresi.Add(eleman);
                    goto seçim;
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye.");
                    goto seçim3;
                }
            }
            else if (seçim == 4)
            {
                foreach (string ekstre in YemekEkstresi)
                {
                    Console.WriteLine(ekstre);
                }
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama. Lütfen Tekrar Seçim Yapınız.");
                goto seçim;
            }
        }
    }
}
