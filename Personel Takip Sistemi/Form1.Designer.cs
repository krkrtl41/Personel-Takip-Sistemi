namespace Personel_Takip_Sistemi
{
    partial class Form1
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
            label4 = new Label();
            giris_hakki = new Label();
            giris = new Button();
            kullanici_ad = new TextBox();
            sifre = new TextBox();
            cikis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 65);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 112);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Parola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 309);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 0;
            label4.Text = "Giriş Hakkı";
            // 
            // giris_hakki
            // 
            giris_hakki.AutoSize = true;
            giris_hakki.BackColor = SystemColors.Control;
            giris_hakki.ForeColor = Color.Red;
            giris_hakki.Location = new Point(246, 309);
            giris_hakki.Name = "giris_hakki";
            giris_hakki.Size = new Size(17, 20);
            giris_hakki.TabIndex = 0;
            giris_hakki.Text = "a";
            // 
            // giris
            // 
            giris.Location = new Point(246, 221);
            giris.Name = "giris";
            giris.Size = new Size(94, 37);
            giris.TabIndex = 1;
            giris.Text = "Giriş";
            giris.UseVisualStyleBackColor = true;
            giris.Click += button1_Click;
            // 
            // kullanici_ad
            // 
            kullanici_ad.Location = new Point(246, 58);
            kullanici_ad.Name = "kullanici_ad";
            kullanici_ad.Size = new Size(225, 27);
            kullanici_ad.TabIndex = 3;
            // 
            // sifre
            // 
            sifre.Location = new Point(246, 111);
            sifre.Name = "sifre";
            sifre.Size = new Size(225, 27);
            sifre.TabIndex = 4;
            // 
            // cikis
            // 
            cikis.Location = new Point(377, 221);
            cikis.Name = "cikis";
            cikis.Size = new Size(94, 37);
            cikis.TabIndex = 1;
            cikis.Text = "Çıkış";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 377);
            Controls.Add(sifre);
            Controls.Add(kullanici_ad);
            Controls.Add(cikis);
            Controls.Add(giris);
            Controls.Add(giris_hakki);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Giriş Ekranı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label giris_hakki;
        private Button giris;
        private TextBox kullanici_ad;
        private TextBox sifre;
        private Button cikis;
    }
}