using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string girisYapanKullanici;
        private int progressValue;
        private List<string> tempOneriler;

        public Form1(string kullaniciAdi)
        {
            InitializeComponent();
            girisYapanKullanici = kullaniciAdi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("oneriler.txt");

            foreach (string satir in satirlar)
            {
                // Satırı virgüllerden ayır
                string[] parcalar = satir.Split(',');

                if (parcalar.Length > 0)
                {
                    string name = parcalar[0] + "-" + parcalar[1] + "-" + parcalar[2];
                    lbKitapList.Items.Add(name);
                }
            }

            // ProgressBar ayarları
            pbKitapOner.Minimum = 0;
            pbKitapOner.Maximum = 100;
            pbKitapOner.Value = 0;

            // Timer ayarları
            
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;

            KullaniciBazliOner();
            gbKullanici.Text = girisYapanKullanici;
        }

        private void btnSwitchRight_Click(object sender, EventArgs e)
        {
            if (lbKitapList.SelectedItem != null)
            {
                lbSecilenKitaplar.Items.Add(lbKitapList.SelectedItem.ToString());
                lbKitapList.Items.RemoveAt(lbKitapList.SelectedIndex);
            }
        }

        private void btnSwitchLeft_Click(object sender, EventArgs e)
        {
            if (lbSecilenKitaplar.SelectedItem != null)
            {
                lbKitapList.Items.Add(lbSecilenKitaplar.SelectedItem.ToString());
                lbSecilenKitaplar.Items.Remove(lbSecilenKitaplar.SelectedItem);
            }
        }

        private void btnRastgeleOner_Click(object sender, EventArgs e)
        {
            lbOneriKitaplar.Items.Clear();

            // Kategorilerin frekanslarını belirle
            Dictionary<string, int> kategoriFrekans = new Dictionary<string, int>();

            foreach (var item in lbSecilenKitaplar.Items)
            {
                string kitapBilgisi = item.ToString();
                string kategori = kitapBilgisi.Split('-')[0].Trim();

                if (kategoriFrekans.ContainsKey(kategori))
                {
                    kategoriFrekans[kategori]++;
                }
                else
                {
                    kategoriFrekans[kategori] = 1;
                }
            }

            // Tüm kitapları kitaplar.txt'den oku ve kategorilere göre grupla
            Dictionary<string, List<string>> kategoriBazliKitaplar = new Dictionary<string, List<string>>();
            string[] satirlar = File.ReadAllLines("kitaplar.txt");

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');

                if (parcalar.Length > 0)
                {
                    string kategori = parcalar[0].Trim();

                    if (!kategoriBazliKitaplar.ContainsKey(kategori))
                    {
                        kategoriBazliKitaplar[kategori] = new List<string>();
                    }

                    kategoriBazliKitaplar[kategori].Add(satir);
                }
            }

            // Rastgele kitapları ağırlıklı olarak seç
            Random rastgele = new Random();
            List<string> rastgeleSecilenKitaplar = new List<string>();

            int toplamFrekans = kategoriFrekans.Values.Sum();
            foreach (var kategori in kategoriFrekans)
            {
                if (kategoriBazliKitaplar.ContainsKey(kategori.Key))
                {
                    int kategoriyeAitKitapSayisi = (kategori.Value * 40) / toplamFrekans; // Ağırlıklı kitap sayısı
                    List<string> mevcutKategoriKitaplar = kategoriBazliKitaplar[kategori.Key]
                        .OrderBy(x => rastgele.Next())
                        .Take(kategoriyeAitKitapSayisi)
                        .ToList();

                    rastgeleSecilenKitaplar.AddRange(mevcutKategoriKitaplar);
                }
            }

            // Geriye kalan kitapları tamamla (Eğer 20'den az kaldıysa)
            int eksikSayisi = 40 - rastgeleSecilenKitaplar.Count;
            if (eksikSayisi > 0)
            {
                List<string> tumUygunKitaplar = kategoriBazliKitaplar
                    .SelectMany(x => x.Value)
                    .Where(x => !rastgeleSecilenKitaplar.Contains(x))
                    .OrderBy(x => rastgele.Next())
                    .Take(eksikSayisi)
                    .ToList();

                rastgeleSecilenKitaplar.AddRange(tumUygunKitaplar);
            }

            // Önerilen kitapları ListBox'a ekle
            foreach (var item in rastgeleSecilenKitaplar)
            {
                lbOneriKitaplar.Items.Add(item);
            }
        }

        private void btnKullaniciOner_Click(object sender, EventArgs e)
        {
            KullaniciBazliOner();
        }

        private void KullaniciBazliOner()
        {
            lbKullaniciOneriler.Items.Clear();
            tempOneriler = new List<string>(); // Geçici listeyi sıfırla

            // Kullanıcıya ait kategorileri kullanicikitaplar.txt'den oku
            HashSet<string> kategoriler = new HashSet<string>();
            string[] satirlar = File.ReadAllLines("kullanicikitaplar.txt");

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');

                if (parcalar.Length > 1)
                {
                    string kullaniciAdi = parcalar[0].Trim();
                    string kategori = parcalar[1].Trim();

                    if (kullaniciAdi == girisYapanKullanici)
                    {
                        kategoriler.Add(kategori);
                    }
                }
            }

            // Tüm kitapları kitaplar.txt'den oku
            List<string> uygunKitaplar = new List<string>();
            string[] kitaplar = File.ReadAllLines("kitaplar.txt");

            foreach (string kitap in kitaplar)
            {
                string[] parcalar = kitap.Split(',');

                if (parcalar.Length > 0)
                {
                    string kategori = parcalar[0].Trim();
                    if (kategoriler.Contains(kategori))
                    {
                        uygunKitaplar.Add(kitap);
                    }
                }
            }

            // Kategori yoğunluğunu belirle
            Dictionary<string, int> kategoriSayisi = kategoriler
                .GroupBy(k => k)
                .ToDictionary(g => g.Key, g => g.Count());

            // Rastgele 20 kitap seç, kategori yoğunluğunu göz önünde bulundur
            Random rastgele = new Random();
            List<string> rastgeleSecilenKitaplar = uygunKitaplar
                .OrderByDescending(k => kategoriSayisi.ContainsKey(k.Split(',')[0]) ? kategoriSayisi[k.Split(',')[0]] : 0)
                .ThenBy(x => rastgele.Next())
                .Take(20)
                .ToList();

            tempOneriler = rastgeleSecilenKitaplar; // Önerileri geçici listeye ekle
            progressValue = 0;
            pbKitapOner.Value = 0;
            timer1.Start(); // ProgressBar'ı başlat
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue++;
                pbKitapOner.Value = progressValue;
            }
            else
            {
                timer1.Stop(); // İşlem tamamlandığında timer durdurulur

                // ProgressBar tamamlandıktan sonra ListBox'ı doldur
                foreach (var kitap in tempOneriler)
                {
                    lbKullaniciOneriler.Items.Add(kitap);
                }

                MessageBox.Show("Öneriler başarıyla yüklendi!");
            }
        }
    }
}
