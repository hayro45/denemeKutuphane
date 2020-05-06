using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace denemeKutuphane
{
    public partial class kitapVer : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");
      
        DataTable tablo = new DataTable();
        public kitapVer()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM ogrenciler WHERE tcno LIKE '" + txtTC.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                txtAd.Text = okuyucu["adi"].ToString();
                txtSoyad.Text = okuyucu["soyadi"].ToString();
                txtTel.Text = okuyucu["telefon"].ToString();
                rchAdres.Text = okuyucu["adres"].ToString();
            }
            baglanti.Close();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM kitaplar WHERE barkodNo LIKE '" + txtBarkod.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                txtKitapAdi.Text = okuyucu["kitapAdi"].ToString();
                txtYazar.Text = okuyucu["yazar"].ToString();
                txtSayfa.Text = okuyucu["sayfaSayisi"].ToString();
                txtRafNo.Text = okuyucu["rafNo"].ToString();

            }
            baglanti.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kitapVer (tcno, adi, soyadi, telefon, adres, barkodNo, kitapAdi, yazar, sayfaSayisi, rafNo, verilisTarihi, teslimTarihi) values ('"+ txtTC.Text +"', '"+ txtAd.Text +"', '"+ txtSoyad.Text +"', '"+ txtTel.Text +"', '" + rchAdres.Text +"', '" + txtBarkod.Text +"', '" + txtKitapAdi.Text +"', '" + txtYazar.Text +"', '" + txtSayfa.Text +"', '" + txtRafNo.Text +"', '" + dateTimePicker1.Text +"', '" + dateTimePicker2.Text +"')", baglanti);
            komut.ExecuteNonQuery();

            tablo.Clear();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("select * from kitapVer", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            MessageBox.Show("Başarıyla kaydedildi!");
            baglanti.Close();
            
        }

        private void KitapVer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            tablo.Clear();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("select * from kitapVer", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
