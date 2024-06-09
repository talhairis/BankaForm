using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Banka; user ID=postgres; password=2300786");

        private void buttonListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT \"Kisi\".\"kisiId\", \"Musteri\".\"musteriId\", \"Adres\".\"adresNo\", \"Kisi\".\"ad\", \"Kisi\".\"soyad\", \"Musteri\".\"kredibilite\", \"Kisi\".\"email\", \"Kisi\".\"telefon\", \"Adres\".\"postaKodu\", \"Adres\".\"sehir\", \"Musteri\".\"kayitTarihi\", \"Musteri\".\"yeniMusteri\" FROM \"Musteri\" INNER JOIN \"Kisi\" ON \"Musteri\".\"musteriId\" = \"Kisi\".\"kisiId\" INNER JOIN \"Adres\" ON \"Kisi\".\"adresNo\" = \"Adres\".\"adresNo\";";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonHesapListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT hb.\"hesapBilgisiId\", k.ad, k.soyad, hb.vadeli, hb.vadesiz, hb.bakiye, m.kredibilite FROM public.\"Musteri\" AS m INNER JOIN public.\"Hesap\" AS h ON m.\"musteriId\" = h.\"musteriId\" INNER JOIN public.\"HesapBilgisi\" AS hb ON h.\"hesapBilgisiId\" = hb.\"hesapBilgisiId\" INNER JOIN public.\"Kisi\" AS k ON m.\"musteriId\" = k.\"kisiId\";";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO \"Adres\" (\"postaKodu\",\"sehir\") VALUES (@p1,@p2); INSERT INTO \"Kisi\" (\"ad\",\"soyad\",\"email\",\"telefon\",\"adresNo\") VALUES (@p3,@p4,@p5,@p6,currval('\"adres_adres_no_seq\"')); INSERT INTO \"Musteri\" (\"musteriId\",\"kayitTarihi\",\"kredibilite\") VALUES (currval('\"Kisi_kisiId_seq\"'), CURRENT_TIMESTAMP, @p7);", baglanti);
            komut1.Parameters.AddWithValue("@p1", textAdresPostaKodu.Text);
            komut1.Parameters.AddWithValue("@p2", textAdresSehir.Text);
            komut1.Parameters.AddWithValue("@p3", textMusteriAd.Text);
            komut1.Parameters.AddWithValue("@p4", textMusteriSoyad.Text);
            komut1.Parameters.AddWithValue("@p5", textMusteriEmail.Text);
            komut1.Parameters.AddWithValue("@p6", textMusteriTelefon.Text);
            komut1.Parameters.AddWithValue("@p7", Int16.Parse(comboBoxMusteriKredibilite.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri ekleme islemi basarili bir sekilde gerceklesti!");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("DELETE FROM \"Musteri\" WHERE \"musteriId\" = @p2; DELETE FROM \"Kisi\" WHERE \"kisiId\" = @p1; DELETE FROM \"Adres\" WHERE \"adresNo\" = @p3;", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textKisiId.Text));
            komut2.Parameters.AddWithValue("@p2", int.Parse(textMusteriId.Text));
            komut2.Parameters.AddWithValue("@p3", int.Parse(textAdresNo.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri silme islemi basarili bir sekilde gerceklesti!");
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("UPDATE \"Kisi\" SET \"email\" = @p1, \"telefon\" = @p2 WHERE \"kisiId\" = @p3; UPDATE \"Musteri\" SET \"kredibilite\" = @p4 WHERE \"musteriId\" = @p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", textMusteriEmail.Text);
            komut3.Parameters.AddWithValue("@p2", textMusteriTelefon.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(textKisiId.Text));
            komut3.Parameters.AddWithValue("@p4", Int16.Parse(comboBoxMusteriKredibilite.Text));
            komut3.Parameters.AddWithValue("@p5", int.Parse(textMusteriId.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri guncelleme islemi basarili bir sekilde gerceklesti!");
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("SELECT \"Kisi\".\"kisiId\", \"Musteri\".\"musteriId\", \"Adres\".\"adresNo\", \"Kisi\".\"ad\", \"Kisi\".\"soyad\", \"Musteri\".\"kredibilite\", \"Kisi\".\"email\", \"Kisi\".\"telefon\", \"Adres\".\"postaKodu\", \"Adres\".\"sehir\", \"Musteri\".\"kayitTarihi\" FROM \"Musteri\" INNER JOIN \"Kisi\" ON \"Musteri\".\"musteriId\" = \"Kisi\".\"kisiId\" INNER JOIN \"Adres\" ON \"Kisi\".\"adresNo\" = \"Adres\".\"adresNo\" WHERE \"Musteri\".\"musteriId\" = @p1;", baglanti);
            komut4.Parameters.AddWithValue("@p1", int.Parse(textMusteriId.Text));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void buttonBakiyeToplam_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT musteribakiyetopla();";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonSehreGoreListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("SELECT * FROM musteribilgileri(@p1);", baglanti);
            komut5.Parameters.AddWithValue("@p1", textAdresSehir.Text);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut6 = new NpgsqlCommand("SELECT * FROM musterihesapbilgileribakiyearaligi(@p1,@p2);", baglanti);
            komut6.Parameters.AddWithValue("@p1", Decimal.Parse(textMinBakiye.Text));
            komut6.Parameters.AddWithValue("@p2", Decimal.Parse(textMaxBakiye.Text));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut6);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            baglanti.Close();
        }

        private void buttonKayitSure_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT * FROM musterikayitsuresi();";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonBakiyeDegisiklik_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT \"kayitNo\", \"hesapBilgisiId\", \"eskiBakiye\", \"yeniBakiye\", \"degisiklikTarihi\" FROM \"BakiyeDegisikligiIzle\";";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void buttonBakiyeGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("UPDATE \"HesapBilgisi\" SET \"bakiye\" = @p1 WHERE \"hesapBilgisiId\" = @p2;", baglanti);
            komut3.Parameters.AddWithValue("@p1", Decimal.Parse(textHesapBilgisiBakiye.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(textHesapBilgisiId.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bakiye guncelleme islemi basarili bir sekilde gerceklesti!");
        }
    }
}
