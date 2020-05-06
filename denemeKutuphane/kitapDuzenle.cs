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
    
    public partial class kitapDuzenle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");

        public kitapDuzenle()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE kitaplar SET barkodno='" + textBox1.Text + "', adi='" + textBox2.Text + "', yazar='" + textBox3.Text + "', sayfaSayisi='" + textBox4.Text + "', rafNo='" + textBox5.Text +"' where barkodNo='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap başarıyla güncellendi.");
            baglanti.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM kitaplar WHERE barkodNo LIKE '" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["kitapAdi"].ToString();
                textBox3.Text = okuyucu["yazar"].ToString();
                textBox4.Text = okuyucu["sayfaSayisi"].ToString();
                textBox5.Text = okuyucu["rafNo"].ToString();
                
            }
            baglanti.Close();
        }
    }
}
