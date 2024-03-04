
namespace Bil201210601031Odev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MetinGirdisi = new System.Windows.Forms.TextBox();
            this.ArananGirdisi = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AnaEkran = new System.Windows.Forms.TabPage();
            this.BisKarekter = new System.Windows.Forms.CheckBox();
            this.BisSayi = new System.Windows.Forms.CheckBox();
            this.BisMetin = new System.Windows.Forms.CheckBox();
            this.Aranacak = new System.Windows.Forms.Label();
            this.Metin = new System.Windows.Forms.Label();
            this.Tab0ileri = new System.Windows.Forms.Button();
            this.Calistir = new System.Windows.Forms.Button();
            this.Sonuclar = new System.Windows.Forms.TabPage();
            this.Tab1geri = new System.Windows.Forms.Button();
            this.Tab1ileri = new System.Windows.Forms.Button();
            this.Tab1clr = new System.Windows.Forms.Button();
            this.SonucGoster = new System.Windows.Forms.TextBox();
            this.Loglama = new System.Windows.Forms.TabPage();
            this.logEkrani = new System.Windows.Forms.ListView();
            this.toAnaEkran = new System.Windows.Forms.Button();
            this.Tab2clr = new System.Windows.Forms.Button();
            this.Tab2geri = new System.Windows.Forms.Button();
            this.BasladiBildirimi = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.AnaEkran.SuspendLayout();
            this.Sonuclar.SuspendLayout();
            this.Loglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetinGirdisi
            // 
            this.MetinGirdisi.Location = new System.Drawing.Point(121, 28);
            this.MetinGirdisi.Multiline = true;
            this.MetinGirdisi.Name = "MetinGirdisi";
            this.MetinGirdisi.Size = new System.Drawing.Size(428, 135);
            this.MetinGirdisi.TabIndex = 0;
            // 
            // ArananGirdisi
            // 
            this.ArananGirdisi.Location = new System.Drawing.Point(121, 197);
            this.ArananGirdisi.Name = "ArananGirdisi";
            this.ArananGirdisi.Size = new System.Drawing.Size(428, 22);
            this.ArananGirdisi.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AnaEkran);
            this.tabControl1.Controls.Add(this.Sonuclar);
            this.tabControl1.Controls.Add(this.Loglama);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // AnaEkran
            // 
            this.AnaEkran.Controls.Add(this.BisKarekter);
            this.AnaEkran.Controls.Add(this.BisSayi);
            this.AnaEkran.Controls.Add(this.BisMetin);
            this.AnaEkran.Controls.Add(this.Aranacak);
            this.AnaEkran.Controls.Add(this.Metin);
            this.AnaEkran.Controls.Add(this.Tab0ileri);
            this.AnaEkran.Controls.Add(this.Calistir);
            this.AnaEkran.Controls.Add(this.MetinGirdisi);
            this.AnaEkran.Controls.Add(this.ArananGirdisi);
            this.AnaEkran.Location = new System.Drawing.Point(4, 25);
            this.AnaEkran.Name = "AnaEkran";
            this.AnaEkran.Padding = new System.Windows.Forms.Padding(3);
            this.AnaEkran.Size = new System.Drawing.Size(611, 397);
            this.AnaEkran.TabIndex = 0;
            this.AnaEkran.Text = "AnaEkran";
            this.AnaEkran.UseVisualStyleBackColor = true;
            // 
            // BisKarekter
            // 
            this.BisKarekter.AutoSize = true;
            this.BisKarekter.Location = new System.Drawing.Point(414, 251);
            this.BisKarekter.Name = "BisKarekter";
            this.BisKarekter.Size = new System.Drawing.Size(84, 21);
            this.BisKarekter.TabIndex = 9;
            this.BisKarekter.Text = "Karekter";
            this.BisKarekter.UseVisualStyleBackColor = true;
            // 
            // BisSayi
            // 
            this.BisSayi.AutoSize = true;
            this.BisSayi.Location = new System.Drawing.Point(295, 251);
            this.BisSayi.Name = "BisSayi";
            this.BisSayi.Size = new System.Drawing.Size(57, 21);
            this.BisSayi.TabIndex = 8;
            this.BisSayi.Text = "Sayi";
            this.BisSayi.UseVisualStyleBackColor = true;
            // 
            // BisMetin
            // 
            this.BisMetin.AutoSize = true;
            this.BisMetin.Location = new System.Drawing.Point(159, 251);
            this.BisMetin.Name = "BisMetin";
            this.BisMetin.Size = new System.Drawing.Size(64, 21);
            this.BisMetin.TabIndex = 7;
            this.BisMetin.Text = "Metin";
            this.BisMetin.UseVisualStyleBackColor = true;
            // 
            // Aranacak
            // 
            this.Aranacak.AutoSize = true;
            this.Aranacak.Location = new System.Drawing.Point(8, 200);
            this.Aranacak.Name = "Aranacak";
            this.Aranacak.Size = new System.Drawing.Size(107, 17);
            this.Aranacak.TabIndex = 6;
            this.Aranacak.Text = "Aranacak ifade:";
            // 
            // Metin
            // 
            this.Metin.AutoSize = true;
            this.Metin.Location = new System.Drawing.Point(6, 31);
            this.Metin.Name = "Metin";
            this.Metin.Size = new System.Drawing.Size(90, 17);
            this.Metin.TabIndex = 5;
            this.Metin.Text = "Metin Giriniz:";
            // 
            // Tab0ileri
            // 
            this.Tab0ileri.Location = new System.Drawing.Point(352, 301);
            this.Tab0ileri.Name = "Tab0ileri";
            this.Tab0ileri.Size = new System.Drawing.Size(110, 28);
            this.Tab0ileri.TabIndex = 4;
            this.Tab0ileri.Text = "İleri >>";
            this.Tab0ileri.UseVisualStyleBackColor = true;
            this.Tab0ileri.Click += new System.EventHandler(this.Tab0ileri_Click);
            // 
            // Calistir
            // 
            this.Calistir.Location = new System.Drawing.Point(193, 301);
            this.Calistir.Name = "Calistir";
            this.Calistir.Size = new System.Drawing.Size(110, 28);
            this.Calistir.TabIndex = 3;
            this.Calistir.Text = "Calistir";
            this.Calistir.UseVisualStyleBackColor = true;
            this.Calistir.Click += new System.EventHandler(this.Calistir_Click);
            // 
            // Sonuclar
            // 
            this.Sonuclar.Controls.Add(this.Tab1geri);
            this.Sonuclar.Controls.Add(this.Tab1ileri);
            this.Sonuclar.Controls.Add(this.Tab1clr);
            this.Sonuclar.Controls.Add(this.SonucGoster);
            this.Sonuclar.Location = new System.Drawing.Point(4, 25);
            this.Sonuclar.Name = "Sonuclar";
            this.Sonuclar.Padding = new System.Windows.Forms.Padding(3);
            this.Sonuclar.Size = new System.Drawing.Size(611, 397);
            this.Sonuclar.TabIndex = 1;
            this.Sonuclar.Text = "Analiz Sonuçları";
            this.Sonuclar.UseVisualStyleBackColor = true;
            // 
            // Tab1geri
            // 
            this.Tab1geri.Location = new System.Drawing.Point(76, 316);
            this.Tab1geri.Name = "Tab1geri";
            this.Tab1geri.Size = new System.Drawing.Size(110, 28);
            this.Tab1geri.TabIndex = 6;
            this.Tab1geri.Text = "<< Geri";
            this.Tab1geri.UseVisualStyleBackColor = true;
            this.Tab1geri.Click += new System.EventHandler(this.Tab1geri_Click);
            // 
            // Tab1ileri
            // 
            this.Tab1ileri.Location = new System.Drawing.Point(421, 316);
            this.Tab1ileri.Name = "Tab1ileri";
            this.Tab1ileri.Size = new System.Drawing.Size(110, 28);
            this.Tab1ileri.TabIndex = 5;
            this.Tab1ileri.Text = "İleri >>";
            this.Tab1ileri.UseVisualStyleBackColor = true;
            this.Tab1ileri.Click += new System.EventHandler(this.Tab1ileri_Click);
            // 
            // Tab1clr
            // 
            this.Tab1clr.Location = new System.Drawing.Point(253, 316);
            this.Tab1clr.Name = "Tab1clr";
            this.Tab1clr.Size = new System.Drawing.Size(110, 28);
            this.Tab1clr.TabIndex = 4;
            this.Tab1clr.Text = "Temizle";
            this.Tab1clr.UseVisualStyleBackColor = true;
            this.Tab1clr.Click += new System.EventHandler(this.Tab1clr_Click);
            // 
            // SonucGoster
            // 
            this.SonucGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucGoster.Location = new System.Drawing.Point(29, 23);
            this.SonucGoster.Multiline = true;
            this.SonucGoster.Name = "SonucGoster";
            this.SonucGoster.ReadOnly = true;
            this.SonucGoster.Size = new System.Drawing.Size(544, 246);
            this.SonucGoster.TabIndex = 0;
            // 
            // Loglama
            // 
            this.Loglama.Controls.Add(this.logEkrani);
            this.Loglama.Controls.Add(this.toAnaEkran);
            this.Loglama.Controls.Add(this.Tab2clr);
            this.Loglama.Controls.Add(this.Tab2geri);
            this.Loglama.Location = new System.Drawing.Point(4, 25);
            this.Loglama.Name = "Loglama";
            this.Loglama.Size = new System.Drawing.Size(611, 397);
            this.Loglama.TabIndex = 2;
            this.Loglama.Text = "Loglama";
            this.Loglama.UseVisualStyleBackColor = true;
            // 
            // logEkrani
            // 
            this.logEkrani.HideSelection = false;
            this.logEkrani.Location = new System.Drawing.Point(22, 12);
            this.logEkrani.Name = "logEkrani";
            this.logEkrani.Size = new System.Drawing.Size(567, 301);
            this.logEkrani.TabIndex = 12;
            this.logEkrani.UseCompatibleStateImageBehavior = false;
            this.logEkrani.View = System.Windows.Forms.View.List;
            // 
            // toAnaEkran
            // 
            this.toAnaEkran.Location = new System.Drawing.Point(80, 331);
            this.toAnaEkran.Name = "toAnaEkran";
            this.toAnaEkran.Size = new System.Drawing.Size(110, 28);
            this.toAnaEkran.TabIndex = 10;
            this.toAnaEkran.Text = "Ana Ekran";
            this.toAnaEkran.UseVisualStyleBackColor = true;
            this.toAnaEkran.Click += new System.EventHandler(this.toAnaEkran_Click);
            // 
            // Tab2clr
            // 
            this.Tab2clr.Location = new System.Drawing.Point(425, 331);
            this.Tab2clr.Name = "Tab2clr";
            this.Tab2clr.Size = new System.Drawing.Size(110, 28);
            this.Tab2clr.TabIndex = 9;
            this.Tab2clr.Text = "Temizle";
            this.Tab2clr.UseVisualStyleBackColor = true;
            this.Tab2clr.Click += new System.EventHandler(this.Tab2clr_Click);
            // 
            // Tab2geri
            // 
            this.Tab2geri.Location = new System.Drawing.Point(257, 331);
            this.Tab2geri.Name = "Tab2geri";
            this.Tab2geri.Size = new System.Drawing.Size(110, 28);
            this.Tab2geri.TabIndex = 8;
            this.Tab2geri.Text = "<< Geri";
            this.Tab2geri.UseVisualStyleBackColor = true;
            this.Tab2geri.Click += new System.EventHandler(this.Tab2geri_Click);
            // 
            // BasladiBildirimi
            // 
            this.BasladiBildirimi.BalloonTipText = "Uygulama Calisiyor";
            this.BasladiBildirimi.BalloonTipTitle = "Bilgilendirme";
            this.BasladiBildirimi.Text = "A";
            this.BasladiBildirimi.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Ödev-1";
            this.tabControl1.ResumeLayout(false);
            this.AnaEkran.ResumeLayout(false);
            this.AnaEkran.PerformLayout();
            this.Sonuclar.ResumeLayout(false);
            this.Sonuclar.PerformLayout();
            this.Loglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MetinGirdisi;
        private System.Windows.Forms.TextBox ArananGirdisi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AnaEkran;
        private System.Windows.Forms.Button Tab0ileri;
        private System.Windows.Forms.Button Calistir;
        private System.Windows.Forms.TabPage Sonuclar;
        private System.Windows.Forms.CheckBox BisKarekter;
        private System.Windows.Forms.CheckBox BisSayi;
        private System.Windows.Forms.CheckBox BisMetin;
        private System.Windows.Forms.Label Aranacak;
        private System.Windows.Forms.Label Metin;
        private System.Windows.Forms.Button Tab1geri;
        private System.Windows.Forms.Button Tab1ileri;
        private System.Windows.Forms.Button Tab1clr;
        private System.Windows.Forms.TextBox SonucGoster;
        private System.Windows.Forms.TabPage Loglama;
        private System.Windows.Forms.Button toAnaEkran;
        private System.Windows.Forms.Button Tab2clr;
        private System.Windows.Forms.Button Tab2geri;
        public System.Windows.Forms.NotifyIcon BasladiBildirimi;
        private System.Windows.Forms.ListView logEkrani;
    }
}

