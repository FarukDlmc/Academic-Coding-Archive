using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Defteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adi_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyadi_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tarih_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void randevu_al_button1_Click(object sender, EventArgs e)
        {
            string fileName = "Randevular.txt";
            if (!File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName,FileMode.OpenOrCreate);
                using (StreamWriter sr = new StreamWriter(fs)) 
                {
                    sr.WriteLine(adi_textBox1.Text + " " + soyadi_textBox2.Text + " " + tarih_textBox3.Text);
                    sr.WriteLine("Sayın {0} bey {1} tarihine randevunuz alınmıştır.",adi_textBox1.Text,tarih_textBox3.Text);
                }
            }
            else
            {
                FileStream fs = new FileStream(fileName, FileMode.Append);
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.WriteLine(adi_textBox1.Text + " " + soyadi_textBox2.Text + " " + tarih_textBox3.Text);
                    sr.WriteLine("Sayın {0} bey {1} tarihine randevunuz alınmıştır.", adi_textBox1.Text, tarih_textBox3.Text);
                }
            }
            
            adi_textBox1.Text = string.Empty;
            soyadi_textBox2.Text = string.Empty;
            tarih_textBox3 .Text = string.Empty;
            label4.Text = "Randevunuz Alınmıştır.";

        }
    }
}
