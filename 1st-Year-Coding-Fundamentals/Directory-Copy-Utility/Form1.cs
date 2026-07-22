using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DizinKopyalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())//dizin(klasör) seçme işlemini buradan yaptık 
            {
                dialog.SelectedPath = @"C:\";

                DialogResult dg = dialog.ShowDialog();                // kullanıcının bir dizin seçmesini sağlıyoruz


                if (dg == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    txtKaynakKlasor.Text = dialog.SelectedPath;                    // seçilen dizinin yolunu yazdırıyoruz
                    MessageBox.Show("Kopyalanacak klasör :" + txtKaynakKlasor.Text);

                }
                else
                {
                    MessageBox.Show("Klasör seçmediniz.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog()) // bir kaydetme iletişim kutusu oluşturduk

            {
                dialog.InitialDirectory = @"C:\";

                DialogResult result = dialog.ShowDialog();                // kullanıcıya kaydedilecek konumu seçiyoruz


                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    txtHedefKlasor.Text = Path.GetDirectoryName(dialog.FileName);//Kopyalanacak klasörü nereye yerleştireceksek onun yolunu alıyoruz.
                    string kaynakKlasor = txtKaynakKlasor.Text.ToString();
                    string hedefKlasor = txtHedefKlasor.Text.ToString();




                    // kaynak klasörün içindeki belirli bir klasörü hedef klasöre kopyalar
                    string kaynakKlasorYolu = Path.Combine(kaynakKlasor);
                    string hedefKlasorYolu = Path.Combine(hedefKlasor,dialog.FileName);// hedef dizinindeki ana klasörü oluşturur
                    kopyala(kaynakKlasorYolu, hedefKlasorYolu);

                    txtHedefKlasor.Text = hedefKlasorYolu;
                    MessageBox.Show("Kopyalandığı klasör :" + txtHedefKlasor.Text);


                }

            }

        }
        private void kopyala(string kaynakdosya, string hedefdosya)
        {
            // kaynak klasördeki tüm dosyaları ve klasörleri kopyalar
            if (!Directory.Exists(hedefdosya))
            {
                Directory.CreateDirectory(hedefdosya);
            }

            string[] dosyalar = Directory.GetFiles(kaynakdosya);
            foreach (string dosya in dosyalar)
            {
                string ad = Path.GetFileName(dosya);
                string hedef = Path.Combine(hedefdosya, ad);
                File.Copy(dosya, hedef);//Dosyayı kopyalar
            }

            string[] klasörler = Directory.GetDirectories(kaynakdosya);
            foreach (string klasör in klasörler)
            {
                string ad = Path.GetFileName(klasör);
                string hedef = Path.Combine(hedefdosya, ad);
                kopyala(klasör, hedef);//Klasörü kopyalar
            }

        }
    }
}

