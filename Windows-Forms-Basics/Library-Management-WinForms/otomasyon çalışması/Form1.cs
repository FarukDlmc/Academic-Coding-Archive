namespace otomasyon_çalışması
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ErrorProvider provider = new ErrorProvider();
        ErrorProvider provider2 = new ErrorProvider();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kullaniciadi.Text == "" || txt_sifre.Text == "")
            {
                provider.SetError(txt_kullaniciadi, "Bu alan boş geçilemez");
                provider.SetError(txt_sifre, "Bu alan boş geçilemez");
            }
            else
            {
                provider.Clear();
                provider2.Clear();

                if (txt_kullaniciadi.Text == "ahmed" && txt_sifre.Text == "12345")
                {
                    Login login = new Login();
                    login.Close();
                    AnaForm anaform = new AnaForm();
                    anaform.Show();
                    anaform.Enabled = true;
                    //((AnaForm)Application.OpenForms["AnaForm"]).Enabled = true;
                    //((AnaForm)Application.OpenForms["AnaForm"]).TopMost = true;
                }
                else if (txt_kullaniciadi.Text == "ahmed" && txt_sifre.Text != "12345")
                {
                    provider.SetError(txt_sifre, "Yanlis Şifre");
                    txt_kullaniciadi.Text = "";
                    txt_sifre.Text = "";
                }
                else if (txt_sifre.Text == "12345" && txt_kullaniciadi.Text != "ahmed")
                {
                    provider.SetError(txt_kullaniciadi, "Yanliş Kullanici adi");
                    txt_kullaniciadi.Text = "";
                    txt_sifre.Text = "";
                }
                else
                {
                    provider.SetError(txt_kullaniciadi, "Yanliş Kullanici adi");
                    provider.SetError(txt_sifre, "Yanlis Şifre");
                    txt_kullaniciadi.Text = "";
                    txt_sifre.Text = "";

                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}