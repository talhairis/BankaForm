namespace BankaForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxMusteriKredibilite = new System.Windows.Forms.ComboBox();
            this.buttonKayitSure = new System.Windows.Forms.Button();
            this.buttonSehreGoreListele = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.textAdresSehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAdresPostaKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMusteriTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAdresNo = new System.Windows.Forms.TextBox();
            this.textMusteriEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMusteriId = new System.Windows.Forms.TextBox();
            this.textMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textKisiId = new System.Windows.Forms.TextBox();
            this.textMusteriAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonBakiyeDegisiklik = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBakiyeGuncelle = new System.Windows.Forms.Button();
            this.buttonBakiyeToplam = new System.Windows.Forms.Button();
            this.buttonHesapListele = new System.Windows.Forms.Button();
            this.textMaxBakiye = new System.Windows.Forms.TextBox();
            this.textMinBakiye = new System.Windows.Forms.TextBox();
            this.textHesapBilgisiBakiye = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textHesapBilgisiId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 545);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxMusteriKredibilite);
            this.tabPage1.Controls.Add(this.buttonKayitSure);
            this.tabPage1.Controls.Add(this.buttonSehreGoreListele);
            this.tabPage1.Controls.Add(this.buttonAra);
            this.tabPage1.Controls.Add(this.buttonSil);
            this.tabPage1.Controls.Add(this.buttonGuncelle);
            this.tabPage1.Controls.Add(this.buttonEkle);
            this.tabPage1.Controls.Add(this.buttonListele);
            this.tabPage1.Controls.Add(this.textAdresSehir);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textAdresPostaKodu);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textMusteriTelefon);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textAdresNo);
            this.tabPage1.Controls.Add(this.textMusteriEmail);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textMusteriId);
            this.tabPage1.Controls.Add(this.textMusteriSoyad);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textKisiId);
            this.tabPage1.Controls.Add(this.textMusteriAd);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1271, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Musteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxMusteriKredibilite
            // 
            this.comboBoxMusteriKredibilite.FormattingEnabled = true;
            this.comboBoxMusteriKredibilite.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxMusteriKredibilite.Location = new System.Drawing.Point(1087, 233);
            this.comboBoxMusteriKredibilite.Name = "comboBoxMusteriKredibilite";
            this.comboBoxMusteriKredibilite.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMusteriKredibilite.TabIndex = 24;
            // 
            // buttonKayitSure
            // 
            this.buttonKayitSure.Location = new System.Drawing.Point(1087, 365);
            this.buttonKayitSure.Name = "buttonKayitSure";
            this.buttonKayitSure.Size = new System.Drawing.Size(161, 29);
            this.buttonKayitSure.TabIndex = 23;
            this.buttonKayitSure.Text = "Kayit Sureleriyle Listele";
            this.buttonKayitSure.UseVisualStyleBackColor = true;
            this.buttonKayitSure.Click += new System.EventHandler(this.buttonKayitSure_Click);
            // 
            // buttonSehreGoreListele
            // 
            this.buttonSehreGoreListele.Location = new System.Drawing.Point(1087, 330);
            this.buttonSehreGoreListele.Name = "buttonSehreGoreListele";
            this.buttonSehreGoreListele.Size = new System.Drawing.Size(161, 29);
            this.buttonSehreGoreListele.TabIndex = 23;
            this.buttonSehreGoreListele.Text = "Sehre Gore Listele";
            this.buttonSehreGoreListele.UseVisualStyleBackColor = true;
            this.buttonSehreGoreListele.Click += new System.EventHandler(this.buttonSehreGoreListele_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(959, 365);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(83, 29);
            this.buttonAra.TabIndex = 23;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(959, 435);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(83, 29);
            this.buttonSil.TabIndex = 22;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(959, 470);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(83, 29);
            this.buttonGuncelle.TabIndex = 21;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(959, 400);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(83, 29);
            this.buttonEkle.TabIndex = 20;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(959, 330);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(83, 29);
            this.buttonListele.TabIndex = 19;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // textAdresSehir
            // 
            this.textAdresSehir.Location = new System.Drawing.Point(1087, 289);
            this.textAdresSehir.Name = "textAdresSehir";
            this.textAdresSehir.Size = new System.Drawing.Size(121, 22);
            this.textAdresSehir.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(956, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres Sehir:";
            // 
            // textAdresPostaKodu
            // 
            this.textAdresPostaKodu.Location = new System.Drawing.Point(1087, 261);
            this.textAdresPostaKodu.Name = "textAdresPostaKodu";
            this.textAdresPostaKodu.Size = new System.Drawing.Size(121, 22);
            this.textAdresPostaKodu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(956, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres Posta Kodu:";
            // 
            // textMusteriTelefon
            // 
            this.textMusteriTelefon.Location = new System.Drawing.Point(1087, 205);
            this.textMusteriTelefon.Name = "textMusteriTelefon";
            this.textMusteriTelefon.Size = new System.Drawing.Size(121, 22);
            this.textMusteriTelefon.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(956, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Musteri Kredibilite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kisi Telefon:";
            // 
            // textAdresNo
            // 
            this.textAdresNo.Location = new System.Drawing.Point(1087, 77);
            this.textAdresNo.Name = "textAdresNo";
            this.textAdresNo.Size = new System.Drawing.Size(121, 22);
            this.textAdresNo.TabIndex = 15;
            // 
            // textMusteriEmail
            // 
            this.textMusteriEmail.Location = new System.Drawing.Point(1087, 177);
            this.textMusteriEmail.Name = "textMusteriEmail";
            this.textMusteriEmail.Size = new System.Drawing.Size(121, 22);
            this.textMusteriEmail.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(956, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Adres No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kisi Email:";
            // 
            // textMusteriId
            // 
            this.textMusteriId.Location = new System.Drawing.Point(1087, 49);
            this.textMusteriId.Name = "textMusteriId";
            this.textMusteriId.Size = new System.Drawing.Size(121, 22);
            this.textMusteriId.TabIndex = 16;
            // 
            // textMusteriSoyad
            // 
            this.textMusteriSoyad.Location = new System.Drawing.Point(1087, 149);
            this.textMusteriSoyad.Name = "textMusteriSoyad";
            this.textMusteriSoyad.Size = new System.Drawing.Size(121, 22);
            this.textMusteriSoyad.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(956, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Musteri Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(956, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kisi Soyad:";
            // 
            // textKisiId
            // 
            this.textKisiId.Location = new System.Drawing.Point(1087, 21);
            this.textKisiId.Name = "textKisiId";
            this.textKisiId.Size = new System.Drawing.Size(121, 22);
            this.textKisiId.TabIndex = 17;
            // 
            // textMusteriAd
            // 
            this.textMusteriAd.Location = new System.Drawing.Point(1087, 121);
            this.textMusteriAd.Name = "textMusteriAd";
            this.textMusteriAd.Size = new System.Drawing.Size(121, 22);
            this.textMusteriAd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(956, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kisi Id:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1056, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Silme";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1008, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ekleme ve Güncelleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(956, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kisi Adi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 504);
            this.dataGridView1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.buttonBakiyeDegisiklik);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.buttonBakiyeGuncelle);
            this.tabPage2.Controls.Add(this.buttonBakiyeToplam);
            this.tabPage2.Controls.Add(this.buttonHesapListele);
            this.tabPage2.Controls.Add(this.textMaxBakiye);
            this.tabPage2.Controls.Add(this.textMinBakiye);
            this.tabPage2.Controls.Add(this.textHesapBilgisiBakiye);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textHesapBilgisiId);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hesap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(944, 504);
            this.dataGridView2.TabIndex = 44;
            // 
            // buttonBakiyeDegisiklik
            // 
            this.buttonBakiyeDegisiklik.Location = new System.Drawing.Point(1007, 301);
            this.buttonBakiyeDegisiklik.Name = "buttonBakiyeDegisiklik";
            this.buttonBakiyeDegisiklik.Size = new System.Drawing.Size(218, 29);
            this.buttonBakiyeDegisiklik.TabIndex = 43;
            this.buttonBakiyeDegisiklik.Text = "Bakiye Degisikliklerini Listele";
            this.buttonBakiyeDegisiklik.UseVisualStyleBackColor = true;
            this.buttonBakiyeDegisiklik.Click += new System.EventHandler(this.buttonBakiyeDegisiklik_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1007, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 29);
            this.button2.TabIndex = 42;
            this.button2.Text = "Bakiye Araligindaki Musterileri Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBakiyeGuncelle
            // 
            this.buttonBakiyeGuncelle.Location = new System.Drawing.Point(1029, 148);
            this.buttonBakiyeGuncelle.Name = "buttonBakiyeGuncelle";
            this.buttonBakiyeGuncelle.Size = new System.Drawing.Size(170, 29);
            this.buttonBakiyeGuncelle.TabIndex = 41;
            this.buttonBakiyeGuncelle.Text = "Bakiye Guncelle";
            this.buttonBakiyeGuncelle.UseVisualStyleBackColor = true;
            this.buttonBakiyeGuncelle.Click += new System.EventHandler(this.buttonBakiyeGuncelle_Click);
            // 
            // buttonBakiyeToplam
            // 
            this.buttonBakiyeToplam.Location = new System.Drawing.Point(1029, 266);
            this.buttonBakiyeToplam.Name = "buttonBakiyeToplam";
            this.buttonBakiyeToplam.Size = new System.Drawing.Size(170, 29);
            this.buttonBakiyeToplam.TabIndex = 40;
            this.buttonBakiyeToplam.Text = "Musteriler Bakiye Toplam";
            this.buttonBakiyeToplam.UseVisualStyleBackColor = true;
            this.buttonBakiyeToplam.Click += new System.EventHandler(this.buttonBakiyeToplam_Click);
            // 
            // buttonHesapListele
            // 
            this.buttonHesapListele.Location = new System.Drawing.Point(1029, 231);
            this.buttonHesapListele.Name = "buttonHesapListele";
            this.buttonHesapListele.Size = new System.Drawing.Size(170, 29);
            this.buttonHesapListele.TabIndex = 39;
            this.buttonHesapListele.Text = "Hesap Bilgilerini Listele";
            this.buttonHesapListele.UseVisualStyleBackColor = true;
            this.buttonHesapListele.Click += new System.EventHandler(this.buttonHesapListele_Click);
            // 
            // textMaxBakiye
            // 
            this.textMaxBakiye.Location = new System.Drawing.Point(1121, 368);
            this.textMaxBakiye.Name = "textMaxBakiye";
            this.textMaxBakiye.Size = new System.Drawing.Size(121, 22);
            this.textMaxBakiye.TabIndex = 33;
            // 
            // textMinBakiye
            // 
            this.textMinBakiye.Location = new System.Drawing.Point(994, 368);
            this.textMinBakiye.Name = "textMinBakiye";
            this.textMinBakiye.Size = new System.Drawing.Size(121, 22);
            this.textMinBakiye.TabIndex = 33;
            // 
            // textHesapBilgisiBakiye
            // 
            this.textHesapBilgisiBakiye.Location = new System.Drawing.Point(1117, 120);
            this.textHesapBilgisiBakiye.Name = "textHesapBilgisiBakiye";
            this.textHesapBilgisiBakiye.Size = new System.Drawing.Size(121, 22);
            this.textHesapBilgisiBakiye.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(970, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "HesapBilgisi Bakiye:";
            // 
            // textHesapBilgisiId
            // 
            this.textHesapBilgisiId.Location = new System.Drawing.Point(1117, 92);
            this.textHesapBilgisiId.Name = "textHesapBilgisiId";
            this.textHesapBilgisiId.Size = new System.Drawing.Size(121, 22);
            this.textHesapBilgisiId.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1118, 349);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 16);
            this.label18.TabIndex = 30;
            this.label18.Text = "Maksimum Bakiye:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(991, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Minimum Bakiye:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(970, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "HesapBilgisi Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1303, 569);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxMusteriKredibilite;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.TextBox textAdresSehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAdresPostaKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMusteriTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMusteriEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMusteriSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMusteriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBakiyeDegisiklik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBakiyeGuncelle;
        private System.Windows.Forms.Button buttonBakiyeToplam;
        private System.Windows.Forms.Button buttonHesapListele;
        private System.Windows.Forms.TextBox textHesapBilgisiBakiye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textHesapBilgisiId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textAdresNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textMusteriId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textKisiId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSehreGoreListele;
        private System.Windows.Forms.TextBox textMaxBakiye;
        private System.Windows.Forms.TextBox textMinBakiye;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonKayitSure;
    }
}

