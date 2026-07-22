using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NotePad_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void islem_ac(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
            }
        }
        private void islem_yeni(object sender, EventArgs e)
        {
            this.Text = "Yazı Dosyası-> Kayıtsız";
            richTextBox1.Text = "";
        }
        private void islem_farklıKaydet(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
            }
        }
        private void islem_Kaydet(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                richTextBox1.SaveFile(openFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
            }
            else
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            islem_farklıKaydet(sender, e);
        }
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_farklıKaydet(sender, e);
        }
        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_farklıKaydet(sender, e);
        }
        private void FarklıKayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_farklıKaydet(sender, e);
        }
        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            islem_farklıKaydet(sender, e);
            this.Close();
        }
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            islem_ac(sender, e);
        }
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_ac(sender, e);
        }
        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            islem_ac(sender, e);
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            islem_yeni(sender, e);
        }
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem_yeni(sender,e);
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Form2 yardımformu = new Form2();
            yardımformu.Show();
        }

        private void yardımKonularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 yardımformu = new Form2();
            yardımformu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void durumÇubuğuToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tarih: " + Convert.ToString(DateTime.Now).Substring(0, 10);
            toolStripStatusLabel2.Text = "Saat: " + Convert.ToString(DateTime.Now).Substring(9, 8);
        }
        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
