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
            label1 = new Label();
            label3 = new Label();
            lbSecilenKitaplar = new ListBox();
            lbKitapList = new ListBox();
            btnSwitchRight = new Button();
            btnSwitchLeft = new Button();
            btnRastgeleOner = new Button();
            lbOneriKitaplar = new ListBox();
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
            lbOneriKitaplar.Location = new Point(12, 430);
            lbOneriKitaplar.Name = "lbOneriKitaplar";
            lbOneriKitaplar.Size = new Size(865, 409);
            lbOneriKitaplar.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 851);
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
    }
}
