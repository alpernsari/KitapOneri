using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


    }
}
