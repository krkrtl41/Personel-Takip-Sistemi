namespace Personel_Takip_Sistemi
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            k_ara = new Button();
            sifre_gucu = new Label();
            k_parolatekrar_goster = new Button();
            k_parola_goster = new Button();
            parola_durum = new Label();
            label1 = new Label();
            label9 = new Label();
            k_ilerlemecubugu = new ProgressBar();
            kullanici_vt = new DataGridView();
            k_parolatekrar = new TextBox();
            k_parola = new TextBox();
            k_kullaniciad = new TextBox();
            panel1 = new Panel();
            k_kadin = new RadioButton();
            k_erkek = new RadioButton();
            k_soyad = new TextBox();
            k_ad = new TextBox();
            k_kimlik = new TextBox();
            k_sil = new Button();
            k_guncelle = new Button();
            k_kaydet = new Button();
            k_parolatekrar_label = new Label();
            k_parola_label = new Label();
            k_kullaniciad_label = new Label();
            k_cinsiyet_label = new Label();
            k_soyad_label = new Label();
            k_ad_label = new Label();
            k_kimlik_label = new Label();
            tabPage2 = new TabPage();
            p_ara = new Button();
            p_gorevyeri = new ComboBox();
            p_gorev = new ComboBox();
            p_maasi = new TextBox();
            p_dogumtarihi = new DateTimePicker();
            panel2 = new Panel();
            p_kadin = new RadioButton();
            p_erkek = new RadioButton();
            p_mezuniyet = new ComboBox();
            p_soyad = new TextBox();
            p_ad = new TextBox();
            p_kimlik = new TextBox();
            personel_vt = new DataGridView();
            p_kaydet = new Button();
            p_sil = new Button();
            p_guncelle = new Button();
            p_mezuniyet_label = new Label();
            p_maas_label = new Label();
            p_cinsiyet_label = new Label();
            p_soyad_label = new Label();
            p_gorevyeri_label = new Label();
            p_gorev_label = new Label();
            p_ad_label = new Label();
            p_dogumtarihi_label = new Label();
            p_kimlik_label = new Label();
            gozat = new Button();
            p_resimkutusu = new PictureBox();
            k_resimkutusu = new PictureBox();
            label8 = new Label();
            k_kimlikkontrol = new ErrorProvider(components);
            aktif_kullanici = new Label();
            resim_bakici = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kullanici_vt).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personel_vt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_resimkutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)k_resimkutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)k_kimlikkontrol).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(30, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1157, 877);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(k_ara);
            tabPage1.Controls.Add(sifre_gucu);
            tabPage1.Controls.Add(k_parolatekrar_goster);
            tabPage1.Controls.Add(k_parola_goster);
            tabPage1.Controls.Add(parola_durum);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(k_ilerlemecubugu);
            tabPage1.Controls.Add(kullanici_vt);
            tabPage1.Controls.Add(k_parolatekrar);
            tabPage1.Controls.Add(k_parola);
            tabPage1.Controls.Add(k_kullaniciad);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(k_soyad);
            tabPage1.Controls.Add(k_ad);
            tabPage1.Controls.Add(k_kimlik);
            tabPage1.Controls.Add(k_sil);
            tabPage1.Controls.Add(k_guncelle);
            tabPage1.Controls.Add(k_kaydet);
            tabPage1.Controls.Add(k_parolatekrar_label);
            tabPage1.Controls.Add(k_parola_label);
            tabPage1.Controls.Add(k_kullaniciad_label);
            tabPage1.Controls.Add(k_cinsiyet_label);
            tabPage1.Controls.Add(k_soyad_label);
            tabPage1.Controls.Add(k_ad_label);
            tabPage1.Controls.Add(k_kimlik_label);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1149, 844);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanıcı İşlemleri";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // k_ara
            // 
            k_ara.Location = new Point(418, 48);
            k_ara.Name = "k_ara";
            k_ara.Size = new Size(94, 29);
            k_ara.TabIndex = 19;
            k_ara.Text = "Ara";
            k_ara.UseVisualStyleBackColor = true;
            k_ara.Click += k_ara_Click;
            // 
            // sifre_gucu
            // 
            sifre_gucu.AutoSize = true;
            sifre_gucu.Location = new Point(1030, 284);
            sifre_gucu.Name = "sifre_gucu";
            sifre_gucu.Size = new Size(18, 20);
            sifre_gucu.TabIndex = 18;
            sifre_gucu.Text = "...";
            // 
            // k_parolatekrar_goster
            // 
            k_parolatekrar_goster.Location = new Point(399, 283);
            k_parolatekrar_goster.Name = "k_parolatekrar_goster";
            k_parolatekrar_goster.Size = new Size(61, 29);
            k_parolatekrar_goster.TabIndex = 17;
            k_parolatekrar_goster.Text = "Göster";
            k_parolatekrar_goster.UseVisualStyleBackColor = true;
            k_parolatekrar_goster.Click += k_parolatekrar_goster_Click;
            // 
            // k_parola_goster
            // 
            k_parola_goster.Location = new Point(399, 248);
            k_parola_goster.Name = "k_parola_goster";
            k_parola_goster.Size = new Size(61, 29);
            k_parola_goster.TabIndex = 17;
            k_parola_goster.Text = "Göster";
            k_parola_goster.UseVisualStyleBackColor = true;
            k_parola_goster.Click += k_parola_goster_Click;
            // 
            // parola_durum
            // 
            parola_durum.AutoSize = true;
            parola_durum.Location = new Point(1047, 288);
            parola_durum.Name = "parola_durum";
            parola_durum.Size = new Size(0, 20);
            parola_durum.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(628, 245);
            label1.Name = "label1";
            label1.Size = new Size(375, 20);
            label1.TabIndex = 14;
            label1.Text = "Parola minimum 6, maksimum 10 karakterden oluşabilir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(628, 212);
            label9.Name = "label9";
            label9.Size = new Size(395, 20);
            label9.TabIndex = 14;
            label9.Text = "Büyük harf, küçük harf ve rakam bulunmasına dikkat ediniz.";
            // 
            // k_ilerlemecubugu
            // 
            k_ilerlemecubugu.Location = new Point(628, 283);
            k_ilerlemecubugu.Name = "k_ilerlemecubugu";
            k_ilerlemecubugu.Size = new Size(375, 29);
            k_ilerlemecubugu.TabIndex = 13;
            // 
            // kullanici_vt
            // 
            kullanici_vt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kullanici_vt.Location = new Point(132, 399);
            kullanici_vt.Name = "kullanici_vt";
            kullanici_vt.RowHeadersWidth = 51;
            kullanici_vt.RowTemplate.Height = 29;
            kullanici_vt.Size = new Size(792, 337);
            kullanici_vt.TabIndex = 12;
            // 
            // k_parolatekrar
            // 
            k_parolatekrar.Location = new Point(143, 288);
            k_parolatekrar.Name = "k_parolatekrar";
            k_parolatekrar.Size = new Size(250, 27);
            k_parolatekrar.TabIndex = 11;
            // 
            // k_parola
            // 
            k_parola.Location = new Point(143, 248);
            k_parola.Name = "k_parola";
            k_parola.Size = new Size(250, 27);
            k_parola.TabIndex = 11;
            k_parola.TextChanged += k_parola_TextChanged;
            // 
            // k_kullaniciad
            // 
            k_kullaniciad.Location = new Point(143, 208);
            k_kullaniciad.Name = "k_kullaniciad";
            k_kullaniciad.Size = new Size(250, 27);
            k_kullaniciad.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(k_kadin);
            panel1.Controls.Add(k_erkek);
            panel1.Location = new Point(143, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 27);
            panel1.TabIndex = 10;
            // 
            // k_kadin
            // 
            k_kadin.AutoSize = true;
            k_kadin.Location = new Point(146, 3);
            k_kadin.Name = "k_kadin";
            k_kadin.Size = new Size(68, 24);
            k_kadin.TabIndex = 0;
            k_kadin.TabStop = true;
            k_kadin.Text = "Kadın";
            k_kadin.UseVisualStyleBackColor = true;
            // 
            // k_erkek
            // 
            k_erkek.AutoSize = true;
            k_erkek.Location = new Point(3, 3);
            k_erkek.Name = "k_erkek";
            k_erkek.Size = new Size(65, 24);
            k_erkek.TabIndex = 0;
            k_erkek.TabStop = true;
            k_erkek.Text = "Erkek";
            k_erkek.UseVisualStyleBackColor = true;
            // 
            // k_soyad
            // 
            k_soyad.Location = new Point(143, 128);
            k_soyad.Name = "k_soyad";
            k_soyad.Size = new Size(250, 27);
            k_soyad.TabIndex = 9;
            k_soyad.KeyPress += k_ad_KeyPress;
            // 
            // k_ad
            // 
            k_ad.Location = new Point(143, 88);
            k_ad.Name = "k_ad";
            k_ad.Size = new Size(250, 27);
            k_ad.TabIndex = 9;
            k_ad.KeyPress += k_ad_KeyPress;
            // 
            // k_kimlik
            // 
            k_kimlik.Location = new Point(143, 48);
            k_kimlik.Name = "k_kimlik";
            k_kimlik.Size = new Size(250, 27);
            k_kimlik.TabIndex = 9;
            k_kimlik.TextChanged += k_kimlik_TextChanged;
            k_kimlik.KeyPress += k_kimlik_KeyPress;
            k_kimlik.Leave += k_kimlik_Leave;
            // 
            // k_sil
            // 
            k_sil.Location = new Point(765, 348);
            k_sil.Name = "k_sil";
            k_sil.Size = new Size(209, 36);
            k_sil.TabIndex = 7;
            k_sil.Text = "SİL";
            k_sil.UseVisualStyleBackColor = true;
            k_sil.Click += k_sil_Click;
            // 
            // k_guncelle
            // 
            k_guncelle.Location = new Point(435, 348);
            k_guncelle.Name = "k_guncelle";
            k_guncelle.Size = new Size(209, 36);
            k_guncelle.TabIndex = 7;
            k_guncelle.Text = "GÜNCELLE";
            k_guncelle.UseVisualStyleBackColor = true;
            k_guncelle.Click += k_guncelle_Click;
            // 
            // k_kaydet
            // 
            k_kaydet.Location = new Point(105, 348);
            k_kaydet.Name = "k_kaydet";
            k_kaydet.Size = new Size(209, 36);
            k_kaydet.TabIndex = 7;
            k_kaydet.Text = "KAYDET";
            k_kaydet.UseVisualStyleBackColor = true;
            k_kaydet.Click += k_kaydet_Click;
            // 
            // k_parolatekrar_label
            // 
            k_parolatekrar_label.AutoSize = true;
            k_parolatekrar_label.Location = new Point(28, 295);
            k_parolatekrar_label.Name = "k_parolatekrar_label";
            k_parolatekrar_label.Size = new Size(94, 20);
            k_parolatekrar_label.TabIndex = 6;
            k_parolatekrar_label.Text = "Parola Tekrar";
            // 
            // k_parola_label
            // 
            k_parola_label.AutoSize = true;
            k_parola_label.Location = new Point(28, 255);
            k_parola_label.Name = "k_parola_label";
            k_parola_label.Size = new Size(50, 20);
            k_parola_label.TabIndex = 5;
            k_parola_label.Text = "Parola";
            // 
            // k_kullaniciad_label
            // 
            k_kullaniciad_label.AutoSize = true;
            k_kullaniciad_label.Location = new Point(28, 215);
            k_kullaniciad_label.Name = "k_kullaniciad_label";
            k_kullaniciad_label.Size = new Size(92, 20);
            k_kullaniciad_label.TabIndex = 4;
            k_kullaniciad_label.Text = "Kullanıcı Adı";
            // 
            // k_cinsiyet_label
            // 
            k_cinsiyet_label.AutoSize = true;
            k_cinsiyet_label.Location = new Point(28, 175);
            k_cinsiyet_label.Name = "k_cinsiyet_label";
            k_cinsiyet_label.Size = new Size(60, 20);
            k_cinsiyet_label.TabIndex = 3;
            k_cinsiyet_label.Text = "Cinsiyet";
            // 
            // k_soyad_label
            // 
            k_soyad_label.AutoSize = true;
            k_soyad_label.Location = new Point(28, 135);
            k_soyad_label.Name = "k_soyad_label";
            k_soyad_label.Size = new Size(50, 20);
            k_soyad_label.TabIndex = 2;
            k_soyad_label.Text = "Soyad";
            // 
            // k_ad_label
            // 
            k_ad_label.AutoSize = true;
            k_ad_label.Location = new Point(28, 95);
            k_ad_label.Name = "k_ad_label";
            k_ad_label.Size = new Size(28, 20);
            k_ad_label.TabIndex = 1;
            k_ad_label.Text = "Ad";
            // 
            // k_kimlik_label
            // 
            k_kimlik_label.AutoSize = true;
            k_kimlik_label.Location = new Point(28, 55);
            k_kimlik_label.Name = "k_kimlik_label";
            k_kimlik_label.Size = new Size(94, 20);
            k_kimlik_label.TabIndex = 0;
            k_kimlik_label.Text = "TC Kimlik No";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(p_ara);
            tabPage2.Controls.Add(p_gorevyeri);
            tabPage2.Controls.Add(p_gorev);
            tabPage2.Controls.Add(p_maasi);
            tabPage2.Controls.Add(p_dogumtarihi);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(p_mezuniyet);
            tabPage2.Controls.Add(p_soyad);
            tabPage2.Controls.Add(p_ad);
            tabPage2.Controls.Add(p_kimlik);
            tabPage2.Controls.Add(personel_vt);
            tabPage2.Controls.Add(p_kaydet);
            tabPage2.Controls.Add(p_sil);
            tabPage2.Controls.Add(p_guncelle);
            tabPage2.Controls.Add(p_mezuniyet_label);
            tabPage2.Controls.Add(p_maas_label);
            tabPage2.Controls.Add(p_cinsiyet_label);
            tabPage2.Controls.Add(p_soyad_label);
            tabPage2.Controls.Add(p_gorevyeri_label);
            tabPage2.Controls.Add(p_gorev_label);
            tabPage2.Controls.Add(p_ad_label);
            tabPage2.Controls.Add(p_dogumtarihi_label);
            tabPage2.Controls.Add(p_kimlik_label);
            tabPage2.Controls.Add(gozat);
            tabPage2.Controls.Add(p_resimkutusu);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1149, 844);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Personel İşlemleri";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // p_ara
            // 
            p_ara.Location = new Point(394, 210);
            p_ara.Name = "p_ara";
            p_ara.Size = new Size(94, 29);
            p_ara.TabIndex = 11;
            p_ara.Text = "Ara";
            p_ara.UseVisualStyleBackColor = true;
            p_ara.Click += p_ara_Click;
            // 
            // p_gorevyeri
            // 
            p_gorevyeri.FormattingEnabled = true;
            p_gorevyeri.Location = new Point(813, 292);
            p_gorevyeri.Name = "p_gorevyeri";
            p_gorevyeri.Size = new Size(230, 28);
            p_gorevyeri.TabIndex = 10;
            // 
            // p_gorev
            // 
            p_gorev.FormattingEnabled = true;
            p_gorev.Location = new Point(813, 249);
            p_gorev.Name = "p_gorev";
            p_gorev.Size = new Size(230, 28);
            p_gorev.TabIndex = 10;
            // 
            // p_maasi
            // 
            p_maasi.Location = new Point(813, 336);
            p_maasi.Name = "p_maasi";
            p_maasi.Size = new Size(230, 27);
            p_maasi.TabIndex = 9;
            p_maasi.KeyPress += k_kimlik_KeyPress;
            // 
            // p_dogumtarihi
            // 
            p_dogumtarihi.Format = DateTimePickerFormat.Short;
            p_dogumtarihi.Location = new Point(813, 209);
            p_dogumtarihi.Name = "p_dogumtarihi";
            p_dogumtarihi.Size = new Size(230, 27);
            p_dogumtarihi.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(p_kadin);
            panel2.Controls.Add(p_erkek);
            panel2.Location = new Point(148, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 28);
            panel2.TabIndex = 7;
            // 
            // p_kadin
            // 
            p_kadin.AutoSize = true;
            p_kadin.Location = new Point(123, 3);
            p_kadin.Name = "p_kadin";
            p_kadin.Size = new Size(68, 24);
            p_kadin.TabIndex = 0;
            p_kadin.TabStop = true;
            p_kadin.Text = "Kadın";
            p_kadin.UseVisualStyleBackColor = true;
            // 
            // p_erkek
            // 
            p_erkek.AutoSize = true;
            p_erkek.Location = new Point(3, 3);
            p_erkek.Name = "p_erkek";
            p_erkek.Size = new Size(65, 24);
            p_erkek.TabIndex = 0;
            p_erkek.TabStop = true;
            p_erkek.Text = "Erkek";
            p_erkek.UseVisualStyleBackColor = true;
            // 
            // p_mezuniyet
            // 
            p_mezuniyet.FormattingEnabled = true;
            p_mezuniyet.Location = new Point(148, 380);
            p_mezuniyet.Name = "p_mezuniyet";
            p_mezuniyet.Size = new Size(230, 28);
            p_mezuniyet.TabIndex = 6;
            // 
            // p_soyad
            // 
            p_soyad.Location = new Point(148, 293);
            p_soyad.Name = "p_soyad";
            p_soyad.Size = new Size(230, 27);
            p_soyad.TabIndex = 5;
            p_soyad.KeyPress += k_ad_KeyPress;
            // 
            // p_ad
            // 
            p_ad.Location = new Point(148, 248);
            p_ad.Name = "p_ad";
            p_ad.Size = new Size(230, 27);
            p_ad.TabIndex = 5;
            p_ad.KeyPress += k_ad_KeyPress;
            // 
            // p_kimlik
            // 
            p_kimlik.Location = new Point(148, 209);
            p_kimlik.Name = "p_kimlik";
            p_kimlik.Size = new Size(230, 27);
            p_kimlik.TabIndex = 5;
            p_kimlik.KeyPress += k_kimlik_KeyPress;
            p_kimlik.Leave += p_kimlik_Leave;
            // 
            // personel_vt
            // 
            personel_vt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personel_vt.Location = new Point(18, 491);
            personel_vt.Name = "personel_vt";
            personel_vt.RowHeadersWidth = 51;
            personel_vt.RowTemplate.Height = 29;
            personel_vt.Size = new Size(1125, 297);
            personel_vt.TabIndex = 4;
            // 
            // p_kaydet
            // 
            p_kaydet.Location = new Point(95, 427);
            p_kaydet.Name = "p_kaydet";
            p_kaydet.Size = new Size(209, 36);
            p_kaydet.TabIndex = 3;
            p_kaydet.Text = "KAYDET";
            p_kaydet.UseVisualStyleBackColor = true;
            p_kaydet.Click += p_kaydet_Click;
            // 
            // p_sil
            // 
            p_sil.Location = new Point(825, 427);
            p_sil.Name = "p_sil";
            p_sil.Size = new Size(209, 36);
            p_sil.TabIndex = 3;
            p_sil.Text = "SİL";
            p_sil.UseVisualStyleBackColor = true;
            p_sil.Click += p_sil_Click;
            // 
            // p_guncelle
            // 
            p_guncelle.Location = new Point(460, 427);
            p_guncelle.Name = "p_guncelle";
            p_guncelle.Size = new Size(209, 36);
            p_guncelle.TabIndex = 3;
            p_guncelle.Text = "GÜNCELLE";
            p_guncelle.UseVisualStyleBackColor = true;
            p_guncelle.Click += p_guncelle_Click;
            // 
            // p_mezuniyet_label
            // 
            p_mezuniyet_label.AutoSize = true;
            p_mezuniyet_label.Location = new Point(26, 388);
            p_mezuniyet_label.Name = "p_mezuniyet_label";
            p_mezuniyet_label.Size = new Size(81, 20);
            p_mezuniyet_label.TabIndex = 2;
            p_mezuniyet_label.Text = "Mezuniyeti";
            // 
            // p_maas_label
            // 
            p_maas_label.AutoSize = true;
            p_maas_label.Location = new Point(672, 343);
            p_maas_label.Name = "p_maas_label";
            p_maas_label.Size = new Size(48, 20);
            p_maas_label.TabIndex = 2;
            p_maas_label.Text = "Maaşı";
            // 
            // p_cinsiyet_label
            // 
            p_cinsiyet_label.AutoSize = true;
            p_cinsiyet_label.Location = new Point(26, 345);
            p_cinsiyet_label.Name = "p_cinsiyet_label";
            p_cinsiyet_label.Size = new Size(60, 20);
            p_cinsiyet_label.TabIndex = 2;
            p_cinsiyet_label.Text = "Cinsiyet";
            // 
            // p_soyad_label
            // 
            p_soyad_label.AutoSize = true;
            p_soyad_label.Location = new Point(26, 302);
            p_soyad_label.Name = "p_soyad_label";
            p_soyad_label.Size = new Size(50, 20);
            p_soyad_label.TabIndex = 2;
            p_soyad_label.Text = "Soyad";
            // 
            // p_gorevyeri_label
            // 
            p_gorevyeri_label.AutoSize = true;
            p_gorevyeri_label.Location = new Point(672, 300);
            p_gorevyeri_label.Name = "p_gorevyeri_label";
            p_gorevyeri_label.Size = new Size(76, 20);
            p_gorevyeri_label.TabIndex = 2;
            p_gorevyeri_label.Text = "Görev Yeri";
            // 
            // p_gorev_label
            // 
            p_gorev_label.AutoSize = true;
            p_gorev_label.Location = new Point(672, 257);
            p_gorev_label.Name = "p_gorev_label";
            p_gorev_label.Size = new Size(52, 20);
            p_gorev_label.TabIndex = 2;
            p_gorev_label.Text = "Görevi";
            // 
            // p_ad_label
            // 
            p_ad_label.AutoSize = true;
            p_ad_label.Location = new Point(26, 259);
            p_ad_label.Name = "p_ad_label";
            p_ad_label.Size = new Size(28, 20);
            p_ad_label.TabIndex = 2;
            p_ad_label.Text = "Ad";
            // 
            // p_dogumtarihi_label
            // 
            p_dogumtarihi_label.AutoSize = true;
            p_dogumtarihi_label.Location = new Point(672, 214);
            p_dogumtarihi_label.Name = "p_dogumtarihi_label";
            p_dogumtarihi_label.Size = new Size(98, 20);
            p_dogumtarihi_label.TabIndex = 2;
            p_dogumtarihi_label.Text = "Doğum Tarihi";
            // 
            // p_kimlik_label
            // 
            p_kimlik_label.AutoSize = true;
            p_kimlik_label.Location = new Point(26, 216);
            p_kimlik_label.Name = "p_kimlik_label";
            p_kimlik_label.Size = new Size(94, 20);
            p_kimlik_label.TabIndex = 2;
            p_kimlik_label.Text = "TC Kimlik No";
            // 
            // gozat
            // 
            gozat.Location = new Point(232, 3);
            gozat.Name = "gozat";
            gozat.Size = new Size(94, 29);
            gozat.TabIndex = 1;
            gozat.Text = "Gözat";
            gozat.UseVisualStyleBackColor = true;
            gozat.Click += gozat_Click;
            // 
            // p_resimkutusu
            // 
            p_resimkutusu.BorderStyle = BorderStyle.Fixed3D;
            p_resimkutusu.Location = new Point(18, 6);
            p_resimkutusu.Name = "p_resimkutusu";
            p_resimkutusu.Size = new Size(198, 182);
            p_resimkutusu.TabIndex = 0;
            p_resimkutusu.TabStop = false;
            // 
            // k_resimkutusu
            // 
            k_resimkutusu.BorderStyle = BorderStyle.Fixed3D;
            k_resimkutusu.Location = new Point(1247, 54);
            k_resimkutusu.Name = "k_resimkutusu";
            k_resimkutusu.Size = new Size(188, 181);
            k_resimkutusu.TabIndex = 1;
            k_resimkutusu.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1247, 262);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 2;
            label8.Text = "Aktif Kullanıcı";
            // 
            // k_kimlikkontrol
            // 
            k_kimlikkontrol.ContainerControl = this;
            // 
            // aktif_kullanici
            // 
            aktif_kullanici.AutoSize = true;
            aktif_kullanici.ForeColor = Color.Red;
            aktif_kullanici.Location = new Point(1353, 262);
            aktif_kullanici.Name = "aktif_kullanici";
            aktif_kullanici.Size = new Size(12, 20);
            aktif_kullanici.TabIndex = 3;
            aktif_kullanici.Text = ".";
            // 
            // resim_bakici
            // 
            resim_bakici.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 828);
            Controls.Add(aktif_kullanici);
            Controls.Add(label8);
            Controls.Add(k_resimkutusu);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Yönetici İşlemleri";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kullanici_vt).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personel_vt).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_resimkutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)k_resimkutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)k_kimlikkontrol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox k_resimkutusu;
        private DataGridView kullanici_vt;
        private TextBox k_parolatekrar;
        private TextBox k_parola;
        private TextBox k_kullaniciad;
        private Panel panel1;
        private TextBox k_soyad;
        private TextBox k_ad;
        private TextBox k_kimlik;
        private Button k_sil;
        private Button k_guncelle;
        private Button k_kaydet;
        private Label k_parolatekrar_label;
        private Label k_parola_label;
        private Label k_kullaniciad_label;
        private Label k_cinsiyet_label;
        private Label k_soyad_label;
        private Label k_ad_label;
        private Label k_kimlik_label;
        private Label label8;
        private RadioButton k_kadin;
        private RadioButton k_erkek;
        private Label label9;
        private ProgressBar k_ilerlemecubugu;
        private Label p_maas_label;
        private Label p_cinsiyet_label;
        private Label p_soyad_label;
        private Label p_ad_label;
        private Label p_kimlik_label;
        private Button gozat;
        private PictureBox p_resimkutusu;
        private ErrorProvider k_kimlikkontrol;
        private DataGridView personel_vt;
        private Button p_kaydet;
        private Button p_sil;
        private Button p_guncelle;
        private Label p_mezuniyet_label;
        private Label p_gorevyeri_label;
        private Label p_gorev_label;
        private Label p_dogumtarihi_label;
        private Panel panel2;
        private RadioButton p_kadin;
        private RadioButton p_erkek;
        private ComboBox p_mezuniyet;
        private TextBox p_soyad;
        private TextBox p_ad;
        private TextBox p_kimlik;
        private TextBox p_maasi;
        private DateTimePicker p_dogumtarihi;
        private Label aktif_kullanici;
        private Label parola_durum;
        private Button k_parolatekrar_goster;
        private Button k_parola_goster;
        private Label label1;
        private Label sifre_gucu;
        private OpenFileDialog resim_bakici;
        private Button k_ara;
        private ComboBox p_gorevyeri;
        private ComboBox p_gorev;
        private Button p_ara;
    }
}