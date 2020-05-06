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
    public partial class ogrenciEkle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");
        public ogrenciEkle()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into ogrenciler (tcno, adi, soyadi, telefon, eposta, adres) values ('"+txtTc.Text+ "', '" + txtAd.Text + "', '" + txtSoyad.Text + "', '" + txtTel.Text + "', '"+ txtEposta.Text +"', '" + richAdres.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci başarıyla kaydedildi");
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTc.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
            richAdres.Clear();
        }
    }
}
