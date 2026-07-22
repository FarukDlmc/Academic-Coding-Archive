using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_çalışması
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            Login yeni = new Login();

            yeni.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        private void Btn_yazar_Click(object sender, EventArgs e)
        {
            FYazar yeni = new FYazar();
            yeni.MdiParent = this;
            yeni.Dock = DockStyle.Fill;
            yeni.Show();
        }
    }
}
