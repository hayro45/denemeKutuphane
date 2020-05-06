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
    public partial class ogrenciDuzenle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");

        public ogrenciDuzenle()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE ogrenciler SET tcno='" + textBox1.Text + "', adi='" + textBox2.Text + "', soyadi='" + textBox3.Text + "', telefon='" + textBox4.Text + "', adres='" + richTextBox1.Text + "' WHERE tcno='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("öğrenci bilgileri başarıyla düzenlendi");
            baglanti.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM ogrenciler WHERE tcno LIKE '" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["adi"].ToString() ;
                textBox3.Text = okuyucu["soyadi"].ToString();
                textBox4.Text = okuyucu["telefon"].ToString();
                richTextBox1.Text = okuyucu["adres"].ToString();
            }
            baglanti.Close();
        }

        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
