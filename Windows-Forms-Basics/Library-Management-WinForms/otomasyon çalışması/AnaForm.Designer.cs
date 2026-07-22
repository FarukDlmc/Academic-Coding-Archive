namespace otomasyon_çalışması
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Btn_yazar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(Btn_yazar);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 553);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü";
            // 
            // Btn_yazar
            // 
            Btn_yazar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_yazar.Location = new Point(6, 29);
            Btn_yazar.Name = "Btn_yazar";
            Btn_yazar.Size = new Size(181, 78);
            Btn_yazar.TabIndex = 1;
            Btn_yazar.Text = "Yazar";
            Btn_yazar.UseVisualStyleBackColor = true;
            Btn_yazar.Click += Btn_yazar_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(groupBox1);
            IsMdiContainer = true;
            MaximumSize = new Size(1200, 600);
            MinimumSize = new Size(1200, 600);
            Name = "AnaForm";
            Text = "AnaForm";
            Load += AnaForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Btn_yazar;
    }
}