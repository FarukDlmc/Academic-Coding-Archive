using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BİLGİLER");
            Console.WriteLine("* --> Kök elemanı temsil eder.");
            Console.WriteLine("+ --> Elemanın sağındaki elemanı temsil eder.");
            Console.WriteLine("- --> Elemanın solundaki elemanı temsil eder.");
            Console.WriteLine("Elemanların konumu köke göre belirlenmiştir. Örneğin DENİZ DEMİR elemanı kökün sol elemanı, " +
                "BURAK BİLGİN elemanı kökün solunun sol elemanıdır.\n");
            Console.WriteLine("(NOT: Ağacı sıralarken 23 tane elemanın ortanca elemanını kök yaptım. " +
                "Alfabeye göre kökten önce gelen elemanalar solda, " +"kökten sonra gelen elemanlar ise sağda yer alıyor.)\n");

            CompositeElement root = new CompositeElement("İSMAİL İNAN",12345678901);//kök

            root.Add(new SolEleman("DENİZ DEMİR",12571010524)); //kökün sol alt ağacı

            SolSolEleman solSolEleman = new SolSolEleman("BURAK BİLGİN", 23456789012);
            SolSolSolEleman solsolsolEleman = new SolSolSolEleman("AHMET AKSOY", 34567890123);
            //AYŞE ARSLAN elemanını, AHMET AKSOY elemanına .Add komutuyla eklememin sebebi onun çocuğu konumunda olması (ağaç yapısındaki çocuk kavramı).
            solsolsolEleman.Add(new SolSolSolSolEleman("AYŞE ARSLAN", 56789012345)); 
            SolSolSağEleman solsolsağEleman = new SolSolSağEleman("CEREN CENGİZ", 45678901234);
            solsolsağEleman.Add(new SolSolSağSağEleman("CAN CİHAN", 67890123456));

            SolSağEleman solSağEleman = new SolSağEleman("ESRA ERDOĞAN", 78901234567);
            SolSağSolEleman solsağsolEleman = new SolSağSolEleman("ELİF EKİNCİ", 89012345678);
            solsağsolEleman.Add(new SolSağSolSolEleman("EMRE ERCAN", 90123456789));
            SolSağSağEleman solsağsağEleman = new SolSağSağEleman("GÖKHAN GENÇ",12345678902);
            solsağsağEleman.Add(new SolSağSağSağEleman("GAMZE GÜNDÜZ", 23456789013));

            root.Add(solSolEleman); //elemanları ağaca ekleyen kod.
            root.Add(solsolsolEleman);
            root.Add(solsolsağEleman);

            root.Add(solSağEleman);
            root.Add(solsağsolEleman);
            root.Add(solsağsağEleman);

            root.Add(new SağEleman("ÖZGE ÖZTÜRK", 34567890124)); //kökün sağ alt ağacı

            SağSolEleman sağsolEleman = new SağSolEleman("ÖZLEM ÖRCAN", 45678901235);
            SağSolSolEleman sağsolsolEleman = new SağSolSolEleman("KAAN KAYA",56789012346);
            sağsolsolEleman.Add(new SağSolSolSolEleman("KÜBRA KARAHAN",67890123457));
            sağsolsolEleman.Add(new SağSolSolSağEleman("KEREM KOÇ", 78901234568));
            SağSolSağEleman sağsolsağEleman = new SağSolSağEleman("ONUR ÖZDEMİR", 89012345679);
            sağsolsağEleman.Add(new SağSolSağSağEleman("OZAN ÖZKAN",90123456780));

            SağSağEleman sağsağEleman = new SağSağEleman("TAYLAN TUNCER",95175385246);
            SağSağSolEleman sağsağsolEleman = new SağSağSolEleman("TUBA TAŞKIN", 16479238456);
            sağsağsolEleman.Add(new SağSağSolSağEleman("TUĞBA TEKİN", 56983241725));
            SağSağSağEleman sağsağsağEleman = new SağSağSağEleman("YASİN YILMAZ",75365489215);

            root.Add(sağsolEleman);
            root.Add(sağsolsolEleman);
            root.Add(sağsolsağEleman);

            root.Add(sağsağEleman);
            root.Add(sağsağsolEleman);
            root.Add(sağsağsağEleman);

            root.Display(1);
            Console.ReadKey();
        }
    }
    public abstract class DrawingElement
    {
        public string name;
        public long TC;
        public DrawingElement(string name,long tc)
        {
            this.name = name;
            this.TC = tc;
        }
        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }

    public class CompositeElement : DrawingElement //kök eleman sınıfı
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public CompositeElement(string name, long tc) : base(name,tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("* " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolEleman : DrawingElement //diğer elemanların sınıfı
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("\n-   " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    
    public class SolSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("--   " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("-+   " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSağSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSağSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("-+-  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSağSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSağSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("-++  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSağSolSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSağSolSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("-+-- | |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSağSağSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSağSağSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("-+++   |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSolSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSolSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("---  |  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSolSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSolSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("--+  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSolSolSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSolSolSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("---- |    |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SolSolSağSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SolSolSağSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("--++   |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }

    public class SağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("\n+   " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+-   " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSolSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSolSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+--  |  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSolSolSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSolSolSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+--- |    |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSolSolSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSolSolSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+--+ |    |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSolSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSolSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+-+  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSolSağSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSolSağSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+-++    |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("++   " + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSağSolEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSağSolEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("++-  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSağSolSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSağSolSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("++-+ | |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
    public class SağSağSağEleman : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public SağSağSağEleman(string name, long tc) : base(name, tc)
        {
        }
        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }
        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
        public override void Display(int indent)
        {
            Console.WriteLine("+++  |_" + name + " " + TC);
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}
