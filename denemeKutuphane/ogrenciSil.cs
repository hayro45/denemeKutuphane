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
    public partial class ogrenciSil : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");

        public ogrenciSil()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("DELETE FROM ogrenciler WHERE tcno='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci başarıyla silindi..");
            baglanti.Close();
        }
    }
}
