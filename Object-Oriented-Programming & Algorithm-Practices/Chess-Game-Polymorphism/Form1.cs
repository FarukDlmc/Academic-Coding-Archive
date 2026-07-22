using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_SATRANÇ
{
    public partial class Form1 : Form
    {
        private ITaşlar taslarBeyazKale,taslarBeyazAt,taslarBeyazFil,taslarBeyazKral,taslarBeyazVezir,taslarBeyazPiyon;
        private ITaşlar taslarSiyahKale, taslarSiyahAt, taslarSiyahFil, taslarSiyahKral, taslarSiyahVezir, taslarSiyahPiyon;
        public Form1()
        {
            InitializeComponent();
            
            taslarBeyazKale = new BeyazKale(); 
            taslarBeyazAt = new BeyazAt();
            taslarBeyazFil = new BeyazFil();
            taslarBeyazKral = new BeyazKral();
            taslarBeyazVezir = new BeyazVezir();
            taslarBeyazPiyon = new BeyazPiyon();

            taslarSiyahKale = new SiyahKale();
            taslarSiyahAt = new SiyahAt();
            taslarSiyahFil = new SiyahFil();
            taslarSiyahKral = new SiyahKral();
            taslarSiyahVezir = new SiyahVezir();
            taslarSiyahPiyon = new SiyahPiyon();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textboxbilgi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Taşa tıklandığında hareket edebileceği yerler MAVİ, hareket edemeyeceği yerler KIRMIZI yanmaktadır.";
            textBox1.Text = "KURALLAR";
            textBox1.Text = "-Rok:\r\nŞah ve bir kaleden yapılan özel bir hamledir.\r\nŞah iki kare sağa veya sola, kule ise şahın yanına geçer.\r\n\n-Şah Mat ve Beraberlik:\r\n-Şah Mat: Bir oyuncunun şahı tehdit altındaysa ve kaçacak bir karesi yoksa, bu durumda \"şah mat\" olmuştur ve oyun sona erer.\r\n-Beraberlik:\r\nOyun belirli durumlarda berabere bitebilir, örneğin \"beraberlik teklifi\" ile, üç kez aynı hamlenin tekrarı ile veya hamle sınırlarının aşılmasıyla.\r\n\n-En passant (Yanından Alma):\r\nPiyon iki kare ileri hareket ettiğinde ve yanındaki düşman piyonun hemen yanına gelirse, düşman piyon bu geçişi hemen alabilir.\r\n\n-Piyonların İlerlemesi:\r\nPiyonlar ilk hamlelerinde iki kare ileri gidebilirler.\n\r\n-Promosyon:\r\nBir piyon, tahtanın diğer tarafına geçtiğinde, oyuncu bu piyonu başka bir taşa dönüştürebilir (genellikle vezire).";
            Controls.Add(textBox1);
        }
        private void A8_Click(object sender, EventArgs e) //Sol Beyaz Kale
        {
            if(A8.BackColor == Color.White)
            {
                A8.BackColor = Color.LawnGreen;
                A7.BackColor = Color.Red;
                A6.BackColor = Color.Red;
                A5.BackColor = Color.Red;
                A4.BackColor = Color.Red;
                A3.BackColor = Color.Red;
                A2.BackColor = Color.Red;
                A1.BackColor = Color.Red;

                B8.BackColor = Color.Red;
                C8.BackColor = Color.Red;
                D8.BackColor = Color.Red;
                E8.BackColor = Color.Red;
                F8.BackColor = Color.Red;
                G8.BackColor = Color.Red;
                H8.BackColor = Color.Red;

                taslarBeyazKale.Move(); //Her taş aynı metodla çağırılıyor ancak hareketleri farklı(Polimorfizm).
            }
            else
            {
                A7.BackColor = Color.Brown;
                A6.BackColor = Color.White;
                A5.BackColor = Color.Brown;
                A4.BackColor = Color.White;
                A3.BackColor = Color.Brown;
                A2.BackColor = Color.White;
                A1.BackColor = Color.Brown;

                A8.BackColor = Color.White;
                B8.BackColor = Color.Brown;
                C8.BackColor = Color.White;
                D8.BackColor = Color.Brown;
                E8.BackColor = Color.White;
                F8.BackColor = Color.Brown;
                G8.BackColor = Color.White;
                H8.BackColor = Color.Brown;
            }
        }
        private void B8_Click(object sender, EventArgs e) //Sol Beyaz At
        {
            if(B8.BackColor == Color.Brown)
            {
                B8.BackColor = Color.LawnGreen;
                A6.BackColor = Color.LightBlue;
                C6.BackColor = Color.LightBlue;

                taslarBeyazAt.Move();
            }
            else
            {
                B8.BackColor = Color.Brown;
                A6.BackColor = Color.White;
                C6.BackColor = Color.White;
            }
        }
        private void C8_Click(object sender, EventArgs e) //Sol Beyaz Fil
        {
            if(C8.BackColor == Color.White)
            {
                C8.BackColor = Color.LawnGreen;
                A6.BackColor = Color.Red;
                B7.BackColor = Color.Red;

                D7.BackColor = Color.Red;
                E6.BackColor = Color.Red;
                F5.BackColor = Color.Red;
                G4.BackColor = Color.Red;
                H3.BackColor = Color.Red;
                taslarBeyazFil.Move();
            }
            else
            {
                C8.BackColor = Color.White;
                A6.BackColor = Color.White;
                B7.BackColor = Color.White;

                D7.BackColor = Color.White;
                E6.BackColor = Color.White;
                F5.BackColor = Color.White;
                G4.BackColor = Color.White;
                H3.BackColor = Color.White;
            }
        }
        private void D8_Click(object sender, EventArgs e) //Beyaz Kral
        {
            if(D8.BackColor == Color.Brown)
            {
                D8.BackColor = Color.LawnGreen;
                C7.BackColor = Color.Red;
                C8.BackColor = Color.Red;
                D7.BackColor = Color.Red;
                E7.BackColor = Color.Red;
                E8.BackColor = Color.Red;

                taslarBeyazKral.Move();
            }
            else
            {
                D8.BackColor = Color.Brown;
                B8.BackColor = Color.Brown;
                C7.BackColor = Color.Brown;
                C8.BackColor = Color.White;
                D7.BackColor = Color.White;
                E7.BackColor = Color.Brown;
                E8.BackColor = Color.White;
            }
        }
        private void E8_Click(object sender, EventArgs e) //Beyaz Vezir
        {
            if(E8.BackColor == Color.White)
            {
                E8.BackColor = Color.LawnGreen;
                E1.BackColor = Color.Red;
                E2.BackColor = Color.Red;
                E3.BackColor = Color.Red;
                E4.BackColor = Color.Red;
                E5.BackColor = Color.Red;
                E6.BackColor = Color.Red;
                E7.BackColor = Color.Red;

                F8.BackColor = Color.Red;
                G8.BackColor = Color.Red;
                H8.BackColor = Color.Red;
                D8.BackColor = Color.Red;
                C8.BackColor = Color.Red;
                B8.BackColor = Color.Red;
                A8.BackColor = Color.Red;

                F7.BackColor = Color.Red;
                G6.BackColor = Color.Red;
                H5.BackColor = Color.Red;

                D7.BackColor = Color.Red;
                C6.BackColor = Color.Red;
                B5.BackColor = Color.Red;
                A4.BackColor = Color.Red;

                taslarBeyazVezir.Move();
            }
            else
            {
                E8.BackColor = Color.White;
                E1.BackColor = Color.Brown;
                E2.BackColor = Color.White;
                E3.BackColor = Color.Brown;
                E4.BackColor = Color.White;
                E5.BackColor = Color.Brown;
                E6.BackColor = Color.White;
                E7.BackColor = Color.Brown;

                F8.BackColor = Color.Brown;
                G8.BackColor = Color.White;
                H8.BackColor = Color.Brown;
                D8.BackColor = Color.Brown;
                C8.BackColor = Color.White;
                B8.BackColor = Color.Brown;
                A8.BackColor = Color.White;

                F7.BackColor = Color.White;
                G6.BackColor = Color.White;
                H5.BackColor = Color.White;

                D7.BackColor = Color.White;
                C6.BackColor = Color.White;
                B5.BackColor = Color.White;
                A4.BackColor = Color.White;
            }
        }
        private void F8_Click(object sender, EventArgs e) //Sağ Beyaz Fil
        {
            if(F8.BackColor == Color.Brown)
            {
                F8.BackColor = Color.LawnGreen;
                G7.BackColor = Color.Red;
                H6.BackColor = Color.Red;

                E7.BackColor = Color.Red;
                D6.BackColor = Color.Red;
                C5.BackColor = Color.Red;
                B4.BackColor = Color.Red;
                A3.BackColor = Color.Red;

                taslarBeyazFil.Move();
            }
            else
            {
                F8.BackColor = Color.Brown;
                G7.BackColor = Color.Brown;
                H6.BackColor = Color.Brown;

                E7.BackColor = Color.Brown;
                D6.BackColor = Color.Brown;
                C5.BackColor = Color.Brown;
                B4.BackColor = Color.Brown;
                A3.BackColor = Color.Brown;
            }
        }
        private void G8_Click(object sender, EventArgs e) //Sağ Beyaz At
        {
            if(G8.BackColor == Color.White)
            {
                G8.BackColor = Color.LawnGreen;
                F6.BackColor = Color.LightBlue;
                H6.BackColor = Color.LightBlue;

                taslarBeyazAt.Move();
            }
            else
            {
                G8.BackColor = Color.White;
                F6.BackColor = Color.Brown;
                H6.BackColor = Color.Brown;
            }
        }
        private void H8_Click(object sender, EventArgs e) //Sağ Beyaz Kale
        {
            if(H8.BackColor == Color.Brown)
            {
                H8.BackColor = Color.LawnGreen;
                H1.BackColor = Color.Red;
                H2.BackColor = Color.Red;
                H3.BackColor = Color.Red;
                H4.BackColor = Color.Red;
                H5.BackColor = Color.Red;
                H6.BackColor = Color.Red;
                H7.BackColor = Color.Red;

                A8.BackColor = Color.Red;
                B8.BackColor = Color.Red;
                C8.BackColor = Color.Red;
                D8.BackColor = Color.Red;
                E8.BackColor = Color.Red;
                F8.BackColor = Color.Red;
                G8.BackColor = Color.Red;

                taslarBeyazKale.Move();
            }
            else
            {
                H8.BackColor = Color.Brown;
                H1.BackColor = Color.White;
                H2.BackColor = Color.Brown;
                H3.BackColor = Color.White;
                H4.BackColor = Color.Brown;
                H5.BackColor = Color.White;
                H6.BackColor = Color.Brown;
                H7.BackColor = Color.White;

                A8.BackColor = Color.White;
                B8.BackColor = Color.Brown;
                C8.BackColor = Color.White;
                D8.BackColor = Color.Brown;
                E8.BackColor = Color.White;
                F8.BackColor = Color.Brown;
                G8.BackColor = Color.White;
            }
        }
        private void A7_Click(object sender, EventArgs e) //Beyaz Piyon 1
        {
            if(A7.BackColor == Color.Brown)
            {
                A7.BackColor = Color.LawnGreen;
                A5.BackColor = Color.LightBlue;
                A6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                A7.BackColor = Color.Brown;
                A5.BackColor = Color.Brown;
                A6.BackColor = Color.White;
            }
        }
        private void B7_Click(object sender, EventArgs e) //Beyaz Piyon 2
        {
            if(B7.BackColor == Color.White)
            {
                B7.BackColor = Color.LawnGreen;
                B5.BackColor = Color.LightBlue;
                B6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                B7.BackColor = Color.White;
                B5.BackColor = Color.White;
                B6.BackColor = Color.Brown;
            }
        }
        private void C7_Click(object sender, EventArgs e) //Beyaz Piyon 3
        {
            if(C7.BackColor == Color.Brown)
            {
                C7.BackColor = Color.LawnGreen;
                C5.BackColor = Color.LightBlue;
                C6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                C7.BackColor = Color.Brown;
                C5.BackColor = Color.Brown;
                C6.BackColor = Color.White;
            }
        }
        private void D7_Click(object sender, EventArgs e) //Beyaz Piyon 4
        {
            if(D7.BackColor == Color.White)
            {
                D7.BackColor = Color.LawnGreen;
                D5.BackColor = Color.LightBlue;
                D6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                D7.BackColor = Color.White;
                D5.BackColor = Color.White;
                D6.BackColor = Color.Brown;
            }
        }
        private void E7_Click(object sender, EventArgs e) //Beyaz Piyon 5
        {
            if(E7.BackColor == Color.Brown)
            {
                E7.BackColor = Color.LawnGreen;
                E5.BackColor = Color.LightBlue;
                E6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                E7.BackColor = Color.Brown;
                E5.BackColor = Color.Brown;
                E6.BackColor = Color.White;
            }
        }
        private void F7_Click(object sender, EventArgs e) //Beyaz Piyon 6
        {
            if(F7.BackColor == Color.White)
            {
                F7.BackColor = Color.LawnGreen;
                F5.BackColor = Color.LightBlue;
                F6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                F7.BackColor = Color.White;
                F5.BackColor = Color.White;
                F6.BackColor = Color.Brown;
            }
        }
        private void G7_Click(object sender, EventArgs e) //Beyaz Piyon 7
        {
            if(G7.BackColor == Color.Brown)
            {
                G7.BackColor = Color.LawnGreen;
                G5.BackColor = Color.LightBlue;
                G6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                G7.BackColor = Color.Brown;
                G5.BackColor = Color.Brown;
                G6.BackColor = Color.White;
            }
        }
        private void H7_Click(object sender, EventArgs e) //Beyaz Piyon 8
        {
            if(H7.BackColor == Color.White)
            {
                H7.BackColor = Color.LawnGreen;
                H5.BackColor = Color.LightBlue;
                H6.BackColor = Color.LightBlue;

                taslarBeyazPiyon.Move();
            }
            else
            {
                H7.BackColor = Color.White;
                H5.BackColor = Color.White;
                H6.BackColor = Color.Brown;
            }
        }

        //SİYAH TAŞLAR

        private void A1_Click(object sender, EventArgs e) //Sol Siyah Kale
        {
            if(A1.BackColor == Color.Brown)
            {
                A1.BackColor = Color.LawnGreen;
                A2.BackColor = Color.Red;
                A3.BackColor = Color.Red;
                A4.BackColor = Color.Red;
                A5.BackColor = Color.Red;
                A6.BackColor = Color.Red;
                A7.BackColor = Color.Red;
                A8.BackColor = Color.Red;

                B1.BackColor = Color.Red;
                C1.BackColor = Color.Red;
                D1.BackColor = Color.Red;
                E1.BackColor = Color.Red;
                F1.BackColor = Color.Red;
                G1.BackColor = Color.Red;
                H1.BackColor = Color.Red;

                taslarSiyahKale.Move();
            }
            else
            {
                A1.BackColor = Color.Brown;
                A2.BackColor = Color.White;
                A3.BackColor = Color.Brown;
                A4.BackColor = Color.White;
                A5.BackColor = Color.Brown;
                A6.BackColor = Color.White;
                A7.BackColor = Color.Brown;
                A8.BackColor = Color.White;

                B1.BackColor = Color.White;
                C1.BackColor = Color.Brown;
                D1.BackColor = Color.White;
                E1.BackColor = Color.Brown;
                F1.BackColor = Color.White;
                G1.BackColor = Color.Brown;
                H1.BackColor = Color.White;
            }
        }
        private void B1_Click(object sender, EventArgs e) //Sol Siyah At
        {
            if(B1.BackColor == Color.White)
            {
                B1.BackColor = Color.LawnGreen;
                A3.BackColor = Color.LightBlue;
                C3.BackColor = Color.LightBlue;

                taslarSiyahAt.Move();
            }
            else
            {
                B1.BackColor = Color.White;
                A3.BackColor = Color.Brown;
                C3.BackColor = Color.Brown;
            }
        }
        private void C1_Click(object sender, EventArgs e) //Sol Siyah Fil
        {
            if(C1.BackColor == Color.Brown)
            {
                C1.BackColor = Color.LawnGreen;
                B2.BackColor = Color.Red;
                A3.BackColor = Color.Red;

                D2.BackColor = Color.Red;
                E3.BackColor = Color.Red;
                F4.BackColor = Color.Red;
                G5.BackColor = Color.Red;
                H6.BackColor = Color.Red;

                taslarSiyahFil.Move();
            }
            else
            {
                C1.BackColor = Color.Brown;
                B2.BackColor = Color.Brown;
                A3.BackColor = Color.Brown;

                D2.BackColor = Color.Brown;
                E3.BackColor = Color.Brown;
                F4.BackColor = Color.Brown;
                G5.BackColor = Color.Brown;
                H6.BackColor = Color.Brown;
            }
        }
        private void D1_Click(object sender, EventArgs e) //Siyah Kral
        {
            if(D1.BackColor == Color.White)
            {
                D1.BackColor = Color.LawnGreen;
                C1.BackColor = Color.Red;
                C2.BackColor = Color.Red;
                D2.BackColor = Color.Red;
                E1.BackColor = Color.Red;
                E2.BackColor = Color.Red;

                taslarSiyahKral.Move();
            }
            else
            {
                D1.BackColor = Color.White;
                C1.BackColor = Color.Brown;
                C2.BackColor = Color.White;
                D2.BackColor = Color.Brown;
                E1.BackColor = Color.Brown;
                E2.BackColor = Color.White;
            }
        }
        private void E1_Click(object sender, EventArgs e) //Siyah Vezir
        {
            if(E1.BackColor == Color.Brown)
            {
                E1.BackColor = Color.LawnGreen;
                E2.BackColor = Color.Red;
                E3.BackColor = Color.Red;
                E4.BackColor = Color.Red;
                E5.BackColor = Color.Red;
                E6.BackColor = Color.Red;
                E7.BackColor = Color.Red;
                E8.BackColor = Color.Red;

                A1.BackColor = Color.Red;
                B1.BackColor = Color.Red;
                C1.BackColor = Color.Red;
                D1.BackColor = Color.Red;
                F1.BackColor = Color.Red;
                G1.BackColor = Color.Red;
                H1.BackColor = Color.Red;

                D2.BackColor = Color.Red;
                C3.BackColor = Color.Red;
                B4.BackColor = Color.Red;
                A5.BackColor = Color.Red;

                F2.BackColor = Color.Red;
                G3.BackColor = Color.Red;
                H4.BackColor = Color.Red;

                taslarSiyahVezir.Move();
            }
            else
            {
                E1.BackColor = Color.Brown;
                E2.BackColor = Color.White;
                E3.BackColor = Color.Brown;
                E4.BackColor = Color.White;
                E5.BackColor = Color.Brown;
                E6.BackColor = Color.White;
                E7.BackColor = Color.Brown;
                E8.BackColor = Color.White;

                A1.BackColor = Color.Brown;
                B1.BackColor = Color.White;
                C1.BackColor = Color.Brown;
                D1.BackColor = Color.White;
                F1.BackColor = Color.White;
                G1.BackColor = Color.Brown;
                H1.BackColor = Color.White;

                D2.BackColor = Color.Brown;
                C3.BackColor = Color.Brown;
                B4.BackColor = Color.Brown;
                A5.BackColor = Color.Brown;

                F2.BackColor = Color.Brown;
                G3.BackColor = Color.Brown;
                H4.BackColor = Color.Brown;
            }
        }
        private void F1_Click(object sender, EventArgs e) //Sağ Siyah Fil
        {
            if(F1.BackColor == Color.White)
            {
                F1.BackColor = Color.LawnGreen;
                E2.BackColor = Color.Red;
                D3.BackColor = Color.Red;
                C4.BackColor = Color.Red;
                B5.BackColor = Color.Red;
                A6.BackColor = Color.Red;

                G2.BackColor = Color.Red;
                H3.BackColor = Color.Red;

                taslarSiyahFil.Move();
            }
            else
            {
                F1.BackColor = Color.White;
                E2.BackColor = Color.White;
                D3.BackColor = Color.White;
                C4.BackColor = Color.White;
                B5.BackColor = Color.White;
                A6.BackColor = Color.White;

                G2.BackColor = Color.White;
                H3.BackColor = Color.White;
            }
        }
        private void G1_Click(object sender, EventArgs e) //Sağ Siyah At
        {
            if(G1.BackColor == Color.Brown)
            {
                G1.BackColor = Color.LawnGreen;
                F3.BackColor = Color.LightBlue;
                H3.BackColor = Color.LightBlue;

                taslarSiyahAt.Move();
            }
            else
            {
                G1.BackColor = Color.Brown;
                F3.BackColor = Color.White;
                H3.BackColor = Color.White;
            }
        }
        private void H1_Click(object sender, EventArgs e) //Sağ Siyah Kale
        {
            if(H1.BackColor == Color.White)
            {
                H1.BackColor = Color.LawnGreen;
                A1.BackColor = Color.Red;
                B1.BackColor = Color.Red;
                C1.BackColor = Color.Red;
                D1.BackColor = Color.Red;
                E1.BackColor = Color.Red;
                F1.BackColor = Color.Red;
                G1.BackColor = Color.Red;

                H2.BackColor = Color.Red;
                H3.BackColor = Color.Red;
                H4.BackColor = Color.Red;
                H5.BackColor = Color.Red;
                H6.BackColor = Color.Red;
                H7.BackColor = Color.Red;
                H8.BackColor = Color.Red;

                taslarSiyahKale.Move();
            }
            else
            {
                H1.BackColor = Color.White;
                A1.BackColor = Color.Brown;
                B1.BackColor = Color.White;
                C1.BackColor = Color.Brown;
                D1.BackColor = Color.White;
                E1.BackColor = Color.Brown;
                F1.BackColor = Color.White;
                G1.BackColor = Color.Brown;

                H2.BackColor = Color.Brown;
                H3.BackColor = Color.White;
                H4.BackColor = Color.Brown;
                H5.BackColor = Color.White;
                H6.BackColor = Color.Brown;
                H7.BackColor = Color.White;
                H8.BackColor = Color.Brown;
            }
        }
        private void A2_Click(object sender, EventArgs e) //Siyah Piyon 1
        {
            if(A2.BackColor == Color.White)
            {
                A2.BackColor = Color.LawnGreen;
                A3.BackColor = Color.LightBlue;
                A4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                A2.BackColor = Color.White;
                A3.BackColor = Color.Brown;
                A4.BackColor = Color.White;
            }
        }
        private void B2_Click(object sender, EventArgs e) //Siyah Piyon 2
        {
            if(B2.BackColor == Color.Brown)
            {
                B2.BackColor = Color.LawnGreen;
                B3.BackColor = Color.LightBlue;
                B4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                B2.BackColor = Color.Brown;
                B3.BackColor = Color.White;
                B4.BackColor = Color.Brown;
            }
        }
        private void C2_Click(object sender, EventArgs e) //Siyah Piyon 3
        {
            if(C2.BackColor == Color.White)
            {
                C2.BackColor = Color.LawnGreen;
                C3.BackColor = Color.LightBlue;
                C4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                C2.BackColor = Color.White;
                C3.BackColor = Color.Brown;
                C4.BackColor = Color.White;
            }
        }
        private void D2_Click(object sender, EventArgs e) //Siyah Piyon 4
        {
            if(D2.BackColor == Color.Brown)
            {
                D2.BackColor = Color.LawnGreen;
                D3.BackColor = Color.LightBlue;
                D4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                D2.BackColor = Color.Brown;
                D3.BackColor = Color.White;
                D4.BackColor = Color.Brown;
            }
        }
        private void E2_Click(object sender, EventArgs e) //Siyah Piyon 5
        {
            if(E2.BackColor == Color.White)
            {
                E2.BackColor = Color.LawnGreen;
                E3.BackColor = Color.LightBlue;
                E4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                E2.BackColor = Color.White;
                E3.BackColor = Color.Brown;
                E4.BackColor = Color.White;
            }
        }
        private void F2_Click(object sender, EventArgs e) //Siyah Piyon 6
        {
            if(F2.BackColor == Color.Brown)
            {
                F2.BackColor = Color.LawnGreen;
                F3.BackColor = Color.LightBlue;
                F4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                F2.BackColor = Color.Brown;
                F3.BackColor = Color.White;
                F4.BackColor = Color.Brown;
            }
        }
        private void G2_Click(object sender, EventArgs e) //Siyah Piyon 7
        {
            if(G2.BackColor == Color.White)
            {
                G2.BackColor = Color.LawnGreen;
                G3.BackColor = Color.LightBlue;
                G4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                G2.BackColor = Color.White;
                G3.BackColor = Color.Brown;
                G4.BackColor = Color.White;
            }
        }
        private void H2_Click(object sender, EventArgs e) //Siyah Piyon 8
        {
            if(H2.BackColor == Color.Brown)
            {
                H2.BackColor = Color.LawnGreen;
                H3.BackColor = Color.LightBlue;
                H4.BackColor = Color.LightBlue;

                taslarSiyahPiyon.Move();
            }
            else
            {
                H2.BackColor = Color.Brown;
                H3.BackColor = Color.White;
                H4.BackColor = Color.Brown;
            }
        }
        
    }
    interface ITaşlar //Polimorfizm'i Move metodunda kullandım. Birden çok hareket türünü tek bir değişkende birleştirdim.
    {
        void Move(); //Move metodu tüm taşların ortak özelliğidir. Tüm taşlar için hareket eylemi bulunmasına rağmen bir vezirle bir piyon hareketi farklıdır(İs A ilişkisi).
    }
    class BeyazKale : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Beyaz Kale\nHAREKET YETENEĞİ: Dikey veya yatay olarak sınırsız hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");
        }
    }
    class BeyazAt : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Beyaz At\nHAREKET YETENEĞİ: \"L\" şeklinde hareket eder.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");
        }
    }
    class BeyazFil : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Beyaz Fil\nHAREKET YETENEĞİ: Çapraz olarak sınırsız hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
    class BeyazKral : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Beyaz Kral\nHAREKET YETENEĞİ: Bir kare her yönde hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
    class BeyazVezir : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Beyaz Vezir\nHAREKET YETENEĞİ: Her yönde sınırsız hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
    class BeyazPiyon : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Beyaz Piyon\nHAREKET YETENEĞİ: Başlangıç durumunda öne doğru 2 kare, sonraki durumlarda öne doğru 1 kare hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }

    class SiyahKale : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Siyah Kale\nHAREKET YETENEĞİ: Dikey veya yatay olarak sınırsız hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");
        }
    }
    class SiyahAt : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Siyah At\nHAREKET YETENEĞİ: \"L\" şeklinde hareket eder.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");
        }
    }
    class SiyahFil : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Siyah Fil\nHAREKET YETENEĞİ: Çapraz olarak sınırsız hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
    class SiyahKral : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Siyah Kral\nHAREKET YETENEĞİ: Bir kare her yönde hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
    class SiyahVezir : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Siyah Vezir\nHAREKET YETENEĞİ: Her yönde sınırsız hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
    class SiyahPiyon : ITaşlar
    {
        public void Move()
        {
            MessageBox.Show("SEÇİLEN TAŞ: Siyah Piyon\nHAREKET YETENEĞİ: Başlangıç durumunda öne doğru 2 kare, sonraki durumlarda öne doğru 1 kare hareket edebilir.\n\n(Taş'ların eski haline dönmesi için aynı taşa tekrar tıklayınız.)");

        }
    }
}
