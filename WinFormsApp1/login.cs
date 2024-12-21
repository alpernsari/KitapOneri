using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            // Kullanıcılar.txt dosyasını oku
            string[] satirlar = File.ReadAllLines("kullanicilar.txt");

            bool girisBasarili = false;

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');

                if (parcalar.Length == 2)
                {
                    string dosyaKullaniciAdi = parcalar[0].Trim();
                    string dosyaSifre = parcalar[1].Trim();

                    if (dosyaKullaniciAdi == kullaniciAdi && dosyaSifre == sifre)
                    {
                        girisBasarili = true;
                        break;
                    }
                }
            }

            if (girisBasarili)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Form1'i kullanıcı adı ile aç
                Form1 form1 = new Form1(kullaniciAdi);
                form1.Show();

                // Login formunu kapat
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
