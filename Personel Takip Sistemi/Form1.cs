using System.Data.OleDb;

namespace Personel_Takip_Sistemi
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\\Users\\Hp\\Documents\\takipsistemi.accdb");
        static int hak = 3;
        public string devir_ad;
        public string devir_soyad;
        public string devir_foto = @"C:\Personel Takip Sistemi\Kullanýcý Resimleri\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            giris_hakki.Text = hak.ToString();
            sifre.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kullanici_ad.Text.Trim() == "" || sifre.Text.Trim() == "")
                {
                    MessageBox.Show("Bütün bilgilerin eksiksiz þekilde doldurulduðundan emin olunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int sayac = 0;
                    baglanti.Open();
                    OleDbCommand arama = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
                    OleDbDataReader okuma = arama.ExecuteReader();
                    while (okuma.Read())
                    {
                        if (kullanici_ad.Text == (string)okuma["kullaniciad"] && sifre.Text == (string)okuma["parola"])
                        {
                            sayac++;
                        }
                    }
                    baglanti.Close();

                    if (sayac == 0)
                    {
                        hak--;
                        if (hak == 0)
                        {
                            MessageBox.Show("Giriþ hakký dolmuþtur.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Hatalý deneme. Lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            giris_hakki.Text = hak.ToString();
                        }
                    }
                    else
                    {
                        baglanti.Open();
                        OleDbCommand arama_2 = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
                        OleDbDataReader okuma_2 = arama_2.ExecuteReader();
                        while (okuma_2.Read())
                        {
                            if (kullanici_ad.Text == (string)okuma_2["kullaniciad"])
                            {
                                devir_ad = (string)okuma_2["ad"];
                                devir_soyad = (string)okuma_2["soyad"];
                                devir_foto += (string)okuma_2["kullaniciad"] + ".jpg";
                            } 
                        }
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.kullanan_ad = devir_ad;
                        f2.kullanan_soyad = devir_soyad;
                        f2.kullanan_resim = devir_foto;
                        f2.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu." + "\n" + ex.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}