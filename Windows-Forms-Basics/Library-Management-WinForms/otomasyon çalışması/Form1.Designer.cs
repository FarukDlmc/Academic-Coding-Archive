namespace otomasyon_çalışması
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_kullaniciadi = new TextBox();
            txt_sifre = new TextBox();
            btn_giris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 51);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 95);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txt_kullaniciadi
            // 
            txt_kullaniciadi.Location = new Point(190, 47);
            txt_kullaniciadi.Name = "txt_kullaniciadi";
            txt_kullaniciadi.Size = new Size(140, 27);
            txt_kullaniciadi.TabIndex = 1;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(190, 91);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(140, 27);
            txt_sifre.TabIndex = 2;
            // 
            // btn_giris
            // 
            btn_giris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_giris.Location = new Point(233, 141);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(97, 35);
            btn_giris.TabIndex = 3;
            btn_giris.Text = "Giriş";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 213);
            Controls.Add(btn_giris);
            Controls.Add(txt_sifre);
            Controls.Add(txt_kullaniciadi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_kullaniciadi;
        private TextBox txt_sifre;
        private Button btn_giris;
    }
}