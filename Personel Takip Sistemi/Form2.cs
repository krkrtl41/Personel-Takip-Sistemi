using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Sistemi
{
    public partial class Form2 : Form
    {
        private int sifre_oluru;
        public string kullanan_ad;
        public string kullanan_soyad;
        public string kullanan_resim;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Hp\\Documents\\takipsistemi.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            k_resimkutusu.Load(kullanan_resim);
            this.CenterToScreen();
            this.BackColor = Color.DarkGray;

            KullaniciListele();
            PersonelListele();

            k_parola.UseSystemPasswordChar = true;
            k_parolatekrar.UseSystemPasswordChar = true;

            k_parola.MaxLength = 10;
            k_parolatekrar.MaxLength = 10;

            k_kimlik.MaxLength = 11;
            aktif_kullanici.Text = kullanan_ad + " " + kullanan_soyad;

            k_ilerlemecubugu.Minimum = 0;
            k_ilerlemecubugu.Maximum = 10;
            k_ilerlemecubugu.Step = 1;
            k_ilerlemecubugu.Style = ProgressBarStyle.Blocks;
            k_ilerlemecubugu.Dock = DockStyle.None;

            k_kimlikkontrol.BlinkRate = 200;
            k_kimlikkontrol.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            k_kimlikkontrol.RightToLeft = false;

            p_kimlik.MaxLength = 11;
            string[] mezuniyetler = { "İlkokul", "Ortaokul", "Lise", "Üniversite" };
            p_mezuniyet.Items.AddRange(mezuniyetler);
            p_mezuniyet.DropDownStyle = ComboBoxStyle.DropDownList;

            resim_bakici.Title = "Resim seçiniz";
            resim_bakici.FileName = "Resim seç";
            resim_bakici.Filter = "jpeg Dosyaları|*.jpeg";
            resim_bakici.InitialDirectory = @"C:\Users\Hp\Pictures";

            string[] gorevler = { "Satış Elemanı", "Şoför", "Beden İşçisi", "Muhasabeci", "Şef", "Depo Sorumlusu" };
            p_gorev.Items.AddRange(gorevler);
            p_gorev.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] gorevyerleri = { "Nakliye", "Ofis", "Muhasabe", "Depo", "Üretim" };
            p_gorevyeri.Items.AddRange(gorevyerleri);
            p_gorevyeri.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void k_kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void k_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
        private void k_kimlik_Leave(object sender, EventArgs e)
        {
            if (k_kimlik.Text.Length != 11)
            {
                MessageBox.Show("Kimlik No bölümü 11 haneli olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                k_kimlik.Clear();
            }
        }
        private void p_kimlik_Leave(object sender, EventArgs e)
        {
            if (p_kimlik.Text.Length != 11)
            {
                MessageBox.Show("Kimlik No bölümü 11 haneli olmalıdır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                p_kimlik.Clear();
            }
        }
        private void k_kimlik_TextChanged(object sender, EventArgs e)
        {
            if (k_kimlik.TextLength != 11)
            {
                k_kimlikkontrol.SetError(k_kimlik, "TC Kimlik No 11 Haneli olmalıdır.");
            }
            else
            {
                k_kimlikkontrol.Clear();
            }
        }
        private void k_parola_goster_Click(object sender, EventArgs e)
        {
            if (k_parola.UseSystemPasswordChar == true)
            {
                k_parola.UseSystemPasswordChar = false;
            }
            else
            {
                k_parola.UseSystemPasswordChar = true;
            }
        }
        private void k_parolatekrar_goster_Click(object sender, EventArgs e)
        {
            if (k_parolatekrar.UseSystemPasswordChar == true)
            {
                k_parolatekrar.UseSystemPasswordChar = false;
            }
            else
            {
                k_parolatekrar.UseSystemPasswordChar = true;
            }
        }
        private void k_parola_TextChanged(object sender, EventArgs e)
        {
            SifreOlunabilirligi();
            if (sifre_oluru == 0)
            {
                label9.Text = "Büyük harf, küçük harf ve rakam bulunmasına dikkat ediniz";
            }
            else
            {
                label9.Text = "";
            }

            if (k_parola.TextLength == k_parola.MaxLength && sifre_oluru == 1)
            {
                k_ilerlemecubugu.Value = k_ilerlemecubugu.Maximum;
                sifre_gucu.Text = "Güçlü";
            }
            else if (k_parola.TextLength == 0)
            {
                k_ilerlemecubugu.Value = k_ilerlemecubugu.Minimum;
                sifre_gucu.Text = "...";
            }
            else
            {
                if (k_parola.Text.Length >= 6 && sifre_oluru == 1)
                {
                    sifre_gucu.Text = "Güçlü";
                }
                else
                {
                    sifre_gucu.Text = "Zayıf";
                }
                k_ilerlemecubugu.Value = k_parola.Text.Length;
            }
        }
        private void k_kaydet_Click(object sender, EventArgs e)
        {
            if (k_kimlik.Text == "" || k_ad.Text == "" || k_soyad.Text == "" || (k_erkek.Checked == false && k_kadin.Checked == false) || k_kullaniciad.Text == "" || k_parola.Text == "" || k_parolatekrar.Text == "")
            {
                Sorgula();
                if (k_parola.Text != k_parolatekrar.Text || k_parola.TextLength < 6 || sifre_oluru == 0)
                {
                    k_parola_label.ForeColor = Color.Red;
                    k_parolatekrar_label.ForeColor = Color.Red;
                }
                MessageBox.Show("Bütün bölümlerin dolu olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (k_parola.Text != k_parolatekrar.Text || k_parola.TextLength < 6 || sifre_oluru == 0)
            {
                Sorgula();
                k_parola_label.ForeColor = Color.Red;
                k_parolatekrar_label.ForeColor = Color.Red;
                MessageBox.Show("Parolaların aynı olmasına, parolanın minimum 6 maksimum 10 karakter içermesine ve büyük harf-küçük harf-rakam kriterlerini sağladığına emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cinsiyet;
                if (k_erkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }
                int sayac = 0;
                baglanti.Open();
                OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar ", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {
                    if (k_kimlik.Text == (string)okuma["tcno"] || k_kullaniciad.Text == (string)okuma["kullaniciad"])
                    {
                        sayac++;
                    }
                }
                baglanti.Close();
                if (sayac != 0)
                {
                    Sorgula();
                    MessageBox.Show("Bu TCNO veya Kullanıcı Ad ile kayıtlı bir 'kullanıcı' bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int sayac_2 = 0;
                    baglanti.Open();
                    OleDbCommand arama_2 = new OleDbCommand("SELECT * FROM personeller", baglanti);
                    OleDbDataReader okuma_2 = arama_2.ExecuteReader();
                    while (okuma_2.Read())
                    {
                        if (k_kimlik.Text == (string)okuma_2["tcno"])
                        {
                            sayac_2++;
                        }
                    }
                    baglanti.Close();
                    if (sayac_2 != 0)
                    {
                        Sorgula();
                        MessageBox.Show("Bu TCNO veya Kullanıcı Ad ile kayıtlı bir 'personel' bulunmaktadır. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        baglanti.Open();
                        OleDbDataAdapter ekle = new OleDbDataAdapter("INSERT INTO kullanicilar VALUES ('" + k_kimlik.Text + "', '" + k_ad.Text + "', '" + k_soyad.Text + "', '" + cinsiyet + "', '" + k_kullaniciad.Text + "', '" + k_parola.Text + "')", baglanti);
                        DataSet ds = new();
                        ekle.Fill(ds);
                        baglanti.Close();
                        MessageBox.Show("Bilgiler veri tabanına kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KullaniciListele();
                    }
                }
            }
        }
        private void KullaniciListele()
        {
            baglanti.Open();
            OleDbDataAdapter listele = new OleDbDataAdapter("SELECT * FROM kullanicilar ORDER BY tcno ASC", baglanti);
            DataSet ds = new();
            listele.Fill(ds);
            kullanici_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void PersonelListele()
        {
            baglanti.Open();
            OleDbDataAdapter lisetele = new OleDbDataAdapter("SELECT * FROM personeller ORDER BY tcno ASC", baglanti);
            DataSet ds = new();
            lisetele.Fill(ds);
            personel_vt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void SifreOlunabilirligi()
        {
            string model = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$";
            if (!Regex.IsMatch(k_parola.Text, model))
            {
                sifre_oluru = 0;//olmaz
            }
            else
            {
                sifre_oluru = 1;//olur
            }
        }
        private void Sorgula()
        {
            if (k_kimlik.Text == "")
            {
                k_kimlik_label.ForeColor = Color.Red;
            }
            else
            {
                k_kimlik_label.ForeColor = Color.Black;
            }

            if (k_ad.Text == "")
            {
                k_ad_label.ForeColor = Color.Red;
            }
            else
            {
                k_ad_label.ForeColor = Color.Black;
            }

            if (k_soyad.Text == "")
            {
                k_soyad_label.ForeColor = Color.Red;
            }
            else
            {
                k_soyad_label.ForeColor = Color.Black;
            }

            if (k_erkek.Checked == false && k_kadin.Checked == false)
            {
                k_cinsiyet_label.ForeColor = Color.Red;
            }
            else
            {
                k_cinsiyet_label.ForeColor = Color.Black;
            }

            if (k_kullaniciad.Text == "")
            {
                k_kullaniciad_label.ForeColor = Color.Red;
            }
            else
            {
                k_kullaniciad_label.ForeColor = Color.Black;
            }

            if (k_parola.Text == "")
            {
                k_parola_label.ForeColor = Color.Red;
            }
            else
            {
                k_parola_label.ForeColor = Color.Black;
            }

            if (k_parolatekrar.Text == "")
            {
                k_parolatekrar_label.ForeColor = Color.Red;
            }
            else
            {
                k_parolatekrar_label.ForeColor = Color.Black;
            }
        }
        private void gozat_Click(object sender, EventArgs e)
        {
            if (resim_bakici.ShowDialog() == DialogResult.OK)
            {
                p_resimkutusu.Load(resim_bakici.FileName);
            }

        }
        private void k_sil_Click(object sender, EventArgs e)
        {
            if (kullanici_vt.SelectedRows.Count != 1 || kullanici_vt.Rows.Count == 1)
            {
                MessageBox.Show("Veri tabanında veri bulunmasına ve silinecek yalnız bir verinin seçilmesine dikkat ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Seçili veri silinsin mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    baglanti.Open();
                    string kimlik = (string)kullanici_vt.SelectedRows[0].Cells[0].Value;
                    OleDbDataAdapter silme = new("DELETE * FROM kullanicilar WHERE tcno = '" + kimlik + "'", baglanti);
                    DataSet ds = new DataSet();
                    silme.Fill(ds);
                    baglanti.Close();
                    KullaniciListele();
                    MessageBox.Show("Seçili veri silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void k_ara_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            baglanti.Open();
            OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
            OleDbDataReader okuma = arama.ExecuteReader();
            while (okuma.Read())
            {
                if (k_kimlik.Text == (string)okuma["tcno"])
                {
                    sayac++;
                    k_kimlik.Text = (string)okuma["tcno"];
                    k_ad.Text = (string)okuma["ad"];
                    k_soyad.Text = (string)okuma["soyad"];
                    if ((string)okuma["cinsiyet"] == "Erkek")
                    {
                        k_erkek.Checked = true;
                    }
                    else
                        k_kadin.Checked = false;
                    k_kullaniciad.Text = (string)okuma["kullaniciad"];
                    k_parola.Text = (string)okuma["parola"];
                    k_parolatekrar.Text = k_parola.Text;
                }
            }
            baglanti.Close();
            if (sayac == 0)
            {
                k_ad.Clear();
                k_soyad.Clear();
                if (k_erkek.Checked)
                    k_erkek.Checked = false;
                else
                    k_kadin.Checked = false;
                k_kullaniciad.Clear();
                k_parola.Clear();
                k_parolatekrar.Clear();
                baglanti.Close();
                MessageBox.Show(k_kimlik.Text + " kimlik numaralı bir kullanıcı bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void k_guncelle_Click(object sender, EventArgs e)
        {
            if (k_kimlik.Text == "" || k_ad.Text == "" || k_soyad.Text == "" || (k_erkek.Checked == false && k_kadin.Checked == false) || k_kullaniciad.Text == "" || k_parola.Text == "" || k_parolatekrar.Text == "")
            {
                Sorgula();
                MessageBox.Show("Bilgilerin güncellenmesi için bütün bilgilerin girildiğinden emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (k_parola.Text != k_parolatekrar.Text || k_parola.TextLength < 6 || sifre_oluru == 0)
                {
                    k_parola_label.ForeColor = Color.Red;
                    k_parolatekrar_label.ForeColor = Color.Red;
                }
            }
            else if (k_parola.Text != k_parolatekrar.Text || k_parola.Text.Length < 6 || sifre_oluru == 0)
            {
                Sorgula();
                k_parola_label.ForeColor = Color.Red;
                k_parolatekrar_label.ForeColor = Color.Red;
                MessageBox.Show("Parolaların aynı olmasına, parolanın minimum 6 maksimum 10 karakter içermesine ve büyük harf-küçük harf-rakam kriterlerini sağladığına emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Sorgula();
                int sayac_1 = 0;
                string cinsiyet = "";
                string ifade = "";
                int sayac_2 = 0;

                baglanti.Open();
                OleDbCommand arama = new("SELECT * FROM kullanicilar", baglanti);
                OleDbDataReader okuma = arama.ExecuteReader();
                while (okuma.Read())
                {

                    if (k_kimlik.Text == (string)okuma["tcno"] && k_kullaniciad.Text == (string)okuma["kullaniciad"])
                        sayac_1++;

                    else if (k_kimlik.Text == (string)okuma["tcno"] && k_kullaniciad.Text != (string)okuma["kullaniciad"])
                        sayac_1 += 2;
                }
                baglanti.Close();

                if (sayac_1 == 0)
                {
                    MessageBox.Show(k_kimlik.Text + " kimlik numaralı biri bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }

                else if (sayac_1 == 1)
                {
                    baglanti.Open();
                    if (k_erkek.Checked)
                        cinsiyet = "Erkek";
                    else
                        cinsiyet = "Kadın";
                    OleDbDataAdapter guncelle = new("UPDATE kullanicilar SET tcno = '" + k_kimlik.Text + "', ad = '" + k_ad.Text + "', soyad = '" + k_soyad.Text + "', cinsiyet = '" + cinsiyet + "', kullaniciad = '" + k_kullaniciad.Text + "', parola = '" + k_parola.Text + "' WHERE tcno = '" + k_kimlik.Text + "'", baglanti);
                    DataSet ds = new();
                    guncelle.Fill(ds);
                    baglanti.Close();
                    KullaniciListele();
                    MessageBox.Show(k_kimlik.Text + " kimlik numaralı kişinin bilgileri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (sayac_1 == 2)
                {
                    for (int a = 0; a < kullanici_vt.Rows.Count; a++)
                    {
                        if (k_kullaniciad.Text == (string)kullanici_vt.Rows[a].Cells[4].Value)
                        {
                            sayac_2++;
                            break;
                        }
                    }
                    if (sayac_2 == 0)
                    {
                        if (k_erkek.Checked)
                            cinsiyet = "Erkek";
                        else
                            cinsiyet = "Kadın";
                        baglanti.Open();
                        OleDbDataAdapter guncelle = new("UPDATE kullanicilar SET tcno = '" + k_kimlik.Text + "', ad = '" + k_ad.Text + "', soyad = '" + k_soyad.Text + "', cinsiyet = '" + cinsiyet + "', kullaniciad = '" + k_kullaniciad.Text + "', parola = '" + k_parola.Text + "' WHERE tcno = '" + k_kimlik.Text + "'", baglanti);
                        DataSet ds = new();
                        guncelle.Fill(ds);
                        baglanti.Close();
                        KullaniciListele();
                        MessageBox.Show(k_kimlik.Text + " kimlik numaralı kişinin bilgileri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı başka bir kullanıcıya aittir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void p_kaydet_Click(object sender, EventArgs e)
        {
            if (p_kimlik.Text == "" || p_ad.Text == "" || p_soyad.Text == "" || (p_erkek.Checked == false && p_kadin.Checked == false) || p_mezuniyet.SelectedItem == null || p_dogumtarihi.Value == DateTime.Today || p_gorev.SelectedItem == null || p_gorevyeri.SelectedItem == null || p_maasi.Text == "" || p_resimkutusu.Image == null)
            {
                Sorgula_2();
                MessageBox.Show("Lütfen bütün bölümlerin dolu olduğundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime su_an = DateTime.Today;
                DateTime yas = p_dogumtarihi.Value.AddYears(18);
                if (yas > su_an)
                {
                    Sorgula_2();
                    p_dogumtarihi_label.ForeColor = Color.Red;
                    MessageBox.Show("18 yaşından küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int sayac = 0;
                    baglanti.Open();
                    OleDbCommand personel_arama = new OleDbCommand("SELECT * FROM personeller", baglanti);
                    OleDbDataReader personel_okuma = personel_arama.ExecuteReader();
                    while (personel_okuma.Read())
                    {
                        if (p_kimlik.Text == (string)personel_okuma["tcno"])
                        {
                            sayac++;
                        }
                    }
                    baglanti.Close();
                    if (sayac != 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarasına ait başka bir personel bulunmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Sorgula_2();
                    }
                    else
                    {
                        baglanti.Open();
                        OleDbCommand kullanici_arama = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
                        OleDbDataReader kullanici_okuma = kullanici_arama.ExecuteReader();
                        while (kullanici_okuma.Read())
                        {
                            if (p_kimlik.Text == (string)kullanici_okuma["tcno"])
                            {
                                sayac++;
                            }
                        }
                        baglanti.Close();
                        if (sayac != 0)
                        {
                            MessageBox.Show("Bu TC kimlik numarasına ait bir kullanıcı bulunmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Sorgula_2();
                        }
                        else
                        {
                            string cinsiyet;
                            if (p_erkek.Checked)
                                cinsiyet = p_erkek.Text;
                            else
                                cinsiyet = p_kadin.Text;
                            baglanti.Open();
                            OleDbDataAdapter ekleme = new OleDbDataAdapter("INSERT INTO personeller VALUES ('" + p_kimlik.Text + "', '" + p_ad.Text + "', '" + p_soyad.Text + "', '" + cinsiyet + "', '" + p_mezuniyet.SelectedItem.ToString() + "', '" + p_dogumtarihi.Value.ToShortDateString() + "', '" + p_gorev.SelectedItem.ToString() + "', '" + p_gorevyeri.SelectedItem.ToString() + "', " + p_maasi.Text + ")", baglanti);
                            DataSet ds = new();
                            ekleme.Fill(ds);
                            baglanti.Close();
                            PersonelListele();

                            string dosya = @"C:\Personel Takip Sistemi\Personel Resimleri\" + p_kimlik.Text + ".jpg";
                            p_resimkutusu.Image.Save(dosya);

                            p_resimkutusu.Image = null;
                            p_kimlik.Text = "";
                            p_ad.Text = "";
                            p_soyad.Text = "";
                            p_erkek.Checked = false;
                            p_kadin.Checked = false;
                            p_mezuniyet.SelectedItem = null;
                            p_dogumtarihi.Value = DateTime.Today;
                            p_gorev.SelectedItem = null;
                            p_gorevyeri.SelectedItem = null;
                            p_maasi.Text = "";


                            MessageBox.Show("Personel veri tabanına eklendi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void Sorgula_2()
        {
            if (p_kimlik.Text == "")
                p_kimlik_label.ForeColor = Color.Red;
            else
                p_kimlik_label.ForeColor = Color.Black;

            if (p_ad.Text == "")
                p_ad_label.ForeColor = Color.Red;
            else
                p_ad_label.ForeColor = Color.Black;

            if (p_soyad.Text == "")
                p_soyad_label.ForeColor = Color.Red;
            else
                p_soyad_label.ForeColor = Color.Black;

            if (p_erkek.Checked == false && p_kadin.Checked == false)
                p_cinsiyet_label.ForeColor = Color.Red;
            else
                p_cinsiyet_label.ForeColor = Color.Black;

            if (p_mezuniyet.SelectedItem == null)
                p_mezuniyet_label.ForeColor = Color.Red;
            else
                p_mezuniyet_label.ForeColor = Color.Black;

            if (p_dogumtarihi.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
                p_dogumtarihi_label.ForeColor = Color.Red;
            else
                p_dogumtarihi_label.ForeColor = Color.Black;

            if (p_gorev.SelectedItem == null)
                p_gorev_label.ForeColor = Color.Red;
            else
                p_gorev_label.ForeColor = Color.Black;

            if (p_gorevyeri.SelectedItem == null)
                p_gorevyeri_label.ForeColor = Color.Red;
            else
                p_gorevyeri_label.ForeColor = Color.Black;

            if (p_maasi.Text == "")
                p_maas_label.ForeColor = Color.Red;
            else
                p_maas_label.ForeColor = Color.Black;

            if (p_resimkutusu.Image == null)
                gozat.ForeColor = Color.Red;
            else
                gozat.ForeColor = Color.Black;
        }

        private void p_sil_Click(object sender, EventArgs e)
        {
            if (personel_vt.Rows.Count == 1 || personel_vt.SelectedRows.Count != 1)
            {
                MessageBox.Show("Silme işlemi için lütfen veri tabanından bir kayıt seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string tcno = (string)personel_vt.SelectedRows[0].Cells[0].Value;
                baglanti.Open();
                OleDbDataAdapter silme = new("DELETE FROM personeller WHERE tcno = '" + p_kimlik.Text + "'", baglanti);
                DataSet ds = new();
                silme.Fill(ds);
                baglanti.Close();
                PersonelListele();
                MessageBox.Show("Seçili kayıt silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void p_guncelle_Click(object sender, EventArgs e)
        {
            if (p_kimlik.Text == "" || p_ad.Text == "" || p_soyad.Text == "" || (p_erkek.Checked == false && p_kadin.Checked == false) || p_mezuniyet.SelectedItem == null || p_dogumtarihi.Value.ToShortDateString() == DateTime.Today.ToShortDateString() || p_gorev.SelectedItem == null || p_gorevyeri.SelectedItem == null || p_maasi.Text == "" || p_resimkutusu.Image == null)
            {
                Sorgula_2();
                MessageBox.Show("Güncelleme işlemi için bütün bilgilerin girildiğinden emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime suan = DateTime.Today;
                DateTime yas = p_dogumtarihi.Value.AddYears(18);
                if (yas > suan)
                {
                    Sorgula_2();
                    MessageBox.Show("Güncelleme için 18 yaşından küçük olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int sayac = 0;
                    for (int a = 0; a < personel_vt.Rows.Count; a++)
                    {
                        if (p_kimlik.Text == (string)personel_vt.Rows[a].Cells[0].Value)
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        Sorgula_2();
                        MessageBox.Show("Bu TC kimlik numarasına ait bir personel bulunmamaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string cinsiyet;
                        if (p_erkek.Checked)
                            cinsiyet = "Erkek";
                        else
                            cinsiyet = "Kadın";
                        baglanti.Open();
                        OleDbDataAdapter guncelleme = new("UPDATE personeller SET ad = '" + p_ad.Text + "', soyad = '" + p_soyad.Text + "', cinsiyet = '" + cinsiyet + "', mezuniyet = '" + p_mezuniyet.SelectedItem.ToString() + "', dogum_tarihi = '" + p_dogumtarihi.Value.ToShortDateString() + "', gorevi = '" + p_gorev.SelectedItem.ToString() + "', gorev_yeri = '" + p_gorevyeri.SelectedItem.ToString() + "', maas = " + p_maasi.Text + " WHERE tcno = '" + p_kimlik.Text + "'", baglanti);
                        DataSet ds = new();
                        guncelleme.Fill(ds);
                        baglanti.Close();
                        PersonelListele();

                        string resim = @"C:\Personel Takip Sistemi\Personel Resimleri\" + p_kimlik.Text + ".jpg";
                        p_resimkutusu.Image.Save(resim);

                        PersonelTemizle();
                        MessageBox.Show(p_kimlik.Text + " TC kimlik numaralı kişinin bilgileri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void p_ara_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            baglanti.Open();
            OleDbCommand ara = new("SELECT * FROM personeller", baglanti);
            OleDbDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                if (p_kimlik.Text == (string)oku["tcno"])
                {
                    sayac++;
                    p_ad.Text = (string)oku["ad"];
                    p_soyad.Text = (string)oku["soyad"];
                    if ((string)oku["cinsiyet"] == "Erkek")
                        p_erkek.Checked = true;
                    else
                        p_kadin.Checked = true;
                    p_mezuniyet.SelectedItem = (string)oku["mezuniyet"];
                    p_dogumtarihi.Value = (DateTime)oku["dogum_tarihi"];
                    p_gorev.SelectedItem = (string)oku["gorevi"];
                    p_gorevyeri.SelectedItem = (string)oku["gorev_yeri"];
                    decimal deger = (decimal)oku["maas"];
                    p_maasi.Text = deger.ToString();
                    string dosya = @"C:\Personel Takip Sistemi\Personel Resimleri\" + p_kimlik.Text + ".jpg";
                    p_resimkutusu.Load(dosya);
                    break;
                }
            }
            baglanti.Close();
            if (sayac == 0)
            {
                PersonelTemizle();
                MessageBox.Show(p_kimlik.Text + " TC kimlik numaralı personel bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void PersonelTemizle()
        {
            p_kimlik.Clear();
            p_ad.Clear();
            p_soyad.Clear();
            p_erkek.Checked = false;
            p_kadin.Checked = false;
            p_mezuniyet.SelectedItem = null;
            p_dogumtarihi.Value = DateTime.Today;
            p_gorev.SelectedItem = null;
            p_gorevyeri.SelectedItem = null;
            p_maasi.Clear();
            p_resimkutusu.Image = null;
        }
    }
}
