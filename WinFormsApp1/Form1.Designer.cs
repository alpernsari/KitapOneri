namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label3 = new Label();
            lbSecilenKitaplar = new ListBox();
            lbKitapList = new ListBox();
            btnSwitchRight = new Button();
            btnSwitchLeft = new Button();
            btnRastgeleOner = new Button();
            lbOneriKitaplar = new ListBox();
            btnKullaniciOner = new Button();
            gbKullanici = new GroupBox();
            pbKitapOner = new ProgressBar();
            lbKullaniciOneriler = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            gbKullanici.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Kitap Öneri Listesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Seçilen Kitaplar";
            // 
            // lbSecilenKitaplar
            // 
            lbSecilenKitaplar.FormattingEnabled = true;
            lbSecilenKitaplar.ItemHeight = 15;
            lbSecilenKitaplar.Location = new Point(577, 31);
            lbSecilenKitaplar.Margin = new Padding(3, 2, 3, 2);
            lbSecilenKitaplar.Name = "lbSecilenKitaplar";
            lbSecilenKitaplar.Size = new Size(300, 394);
            lbSecilenKitaplar.TabIndex = 6;
            // 
            // lbKitapList
            // 
            lbKitapList.FormattingEnabled = true;
            lbKitapList.ItemHeight = 15;
            lbKitapList.Location = new Point(12, 31);
            lbKitapList.Margin = new Padding(3, 2, 3, 2);
            lbKitapList.Name = "lbKitapList";
            lbKitapList.Size = new Size(321, 394);
            lbKitapList.TabIndex = 7;
            // 
            // btnSwitchRight
            // 
            btnSwitchRight.Location = new Point(382, 31);
            btnSwitchRight.Name = "btnSwitchRight";
            btnSwitchRight.Size = new Size(135, 85);
            btnSwitchRight.TabIndex = 8;
            btnSwitchRight.Text = "->";
            btnSwitchRight.UseVisualStyleBackColor = true;
            btnSwitchRight.Click += btnSwitchRight_Click;
            // 
            // btnSwitchLeft
            // 
            btnSwitchLeft.Location = new Point(382, 134);
            btnSwitchLeft.Name = "btnSwitchLeft";
            btnSwitchLeft.Size = new Size(135, 78);
            btnSwitchLeft.TabIndex = 9;
            btnSwitchLeft.Text = "<-";
            btnSwitchLeft.UseVisualStyleBackColor = true;
            btnSwitchLeft.Click += btnSwitchLeft_Click;
            // 
            // btnRastgeleOner
            // 
            btnRastgeleOner.Location = new Point(382, 291);
            btnRastgeleOner.Name = "btnRastgeleOner";
            btnRastgeleOner.Size = new Size(135, 90);
            btnRastgeleOner.TabIndex = 10;
            btnRastgeleOner.Text = "Kitap Öner";
            btnRastgeleOner.UseVisualStyleBackColor = true;
            btnRastgeleOner.Click += btnRastgeleOner_Click;
            // 
            // lbOneriKitaplar
            // 
            lbOneriKitaplar.FormattingEnabled = true;
            lbOneriKitaplar.ItemHeight = 15;
            lbOneriKitaplar.Location = new Point(12, 460);
            lbOneriKitaplar.Name = "lbOneriKitaplar";
            lbOneriKitaplar.Size = new Size(408, 379);
            lbOneriKitaplar.TabIndex = 11;
            // 
            // btnKullaniciOner
            // 
            btnKullaniciOner.Location = new Point(390, 10);
            btnKullaniciOner.Name = "btnKullaniciOner";
            btnKullaniciOner.Size = new Size(75, 23);
            btnKullaniciOner.TabIndex = 13;
            btnKullaniciOner.Text = "Yeni Öner";
            btnKullaniciOner.UseVisualStyleBackColor = true;
            btnKullaniciOner.Click += btnKullaniciOner_Click;
            // 
            // gbKullanici
            // 
            gbKullanici.Controls.Add(pbKitapOner);
            gbKullanici.Controls.Add(lbKullaniciOneriler);
            gbKullanici.Controls.Add(btnKullaniciOner);
            gbKullanici.Location = new Point(426, 430);
            gbKullanici.Name = "gbKullanici";
            gbKullanici.Size = new Size(471, 409);
            gbKullanici.TabIndex = 15;
            gbKullanici.TabStop = false;
            gbKullanici.Text = "Kullanıcı Adı";
            // 
            // pbKitapOner
            // 
            pbKitapOner.Location = new Point(82, 10);
            pbKitapOner.Name = "pbKitapOner";
            pbKitapOner.Size = new Size(302, 23);
            pbKitapOner.TabIndex = 14;
            // 
            // lbKullaniciOneriler
            // 
            lbKullaniciOneriler.FormattingEnabled = true;
            lbKullaniciOneriler.ItemHeight = 15;
            lbKullaniciOneriler.Location = new Point(6, 39);
            lbKullaniciOneriler.Name = "lbKullaniciOneriler";
            lbKullaniciOneriler.Size = new Size(459, 364);
            lbKullaniciOneriler.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 851);
            Controls.Add(gbKullanici);
            Controls.Add(lbOneriKitaplar);
            Controls.Add(btnRastgeleOner);
            Controls.Add(btnSwitchLeft);
            Controls.Add(btnSwitchRight);
            Controls.Add(lbKitapList);
            Controls.Add(lbSecilenKitaplar);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbKullanici.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private ListBox lbSecilenKitaplar;
        private ListBox lbKitapList;
        private Button btnSwitchRight;
        private Button btnSwitchLeft;
        private Button btnRastgeleOner;
        private ListBox lbOneriKitaplar;
        private Button btnKullaniciOner;
        private GroupBox gbKullanici;
        private ListBox lbKullaniciOneriler;
        private ProgressBar pbKitapOner;
        private System.Windows.Forms.Timer timer1;
    }
}
