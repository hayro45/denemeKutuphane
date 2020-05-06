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
    public partial class kitapListele : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");
        DataTable tablo = new DataTable();
        public kitapListele()
        {
            InitializeComponent();
        }

        private void KitapListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("SELECT * FROM kitaplar INNER JOIN raflar ON kitaplar.rafNo=raflar.rafNo", baglanti);
            tablo.Clear();
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
            baglanti.Close();
        }

        private void butunKitaplar(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("SELECT * FROM kitaplar INNER JOIN raflar ON kitaplar.rafNo=raflar.rafNo", baglanti);

            tablo.Clear();
            txtKitapAdı.Clear();
            txtKitapYazar.Clear();
            txtKitapTuru.Clear();
            adaptr.Fill(tablo);
            
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnKitapAdıAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("SELECT * FROM kitaplar INNER JOIN raflar ON kitaplar.rafNo=raflar.rafNo WHERE kitapAdi LIKE '" + txtKitapAdı.Text.ToString() + "%'", baglanti);
            tablo.Clear();
            //adaptr.SelectCommand.Parameters.Add("kitapAdi", OleDbType.VarChar, 50).Value = txtKitapAdı.Text;
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }

        private void btnKitapYazarı_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("SELECT * FROM kitaplar INNER JOIN raflar ON kitaplar.rafNo=raflar.rafNo WHERE yazar LIKE '" + txtKitapYazar.Text.ToString() + "%'", baglanti);
            tablo.Clear();
            //adaptr.SelectCommand.Parameters.Add("kitapAdi", OleDbType.VarChar, 50).Value = txtKitapAdı.Text;
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }

        private void btnKitapTuru_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("SELECT * FROM kitaplar INNER JOIN raflar ON kitaplar.rafNo=raflar.rafNo WHERE rafIsmi LIKE '" + txtKitapTuru.Text.ToString() + "%'", baglanti);
            tablo.Clear();
            //adaptr.SelectCommand.Parameters.Add("kitapAdi", OleDbType.VarChar, 50).Value = txtKitapAdı.Text;
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }

        
    }
}
