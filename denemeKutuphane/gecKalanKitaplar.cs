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
    public partial class gecKalanKitaplar : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");
        DataTable tablo = new DataTable();
        string tarih = DateTime.Now.ToShortDateString();
        public gecKalanKitaplar()
        {
            InitializeComponent();
        }

        private void GecKalanKitaplar_Load(object sender, EventArgs e)
        {
            
            
            baglanti.Open();
            
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM kitapVer WHERE teslimTarihi<?", baglanti);
            komut.SelectCommand.Parameters.Add("@teslimTarihi",OleDbType.Date).Value=tarih;
            komut.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("DELETE FROM kitapver WHERE barkodNo='" + label1.Text + "'", baglanti);
            komut.ExecuteNonQuery();

            tablo.Clear();
            
            OleDbDataAdapter a = new OleDbDataAdapter("SELECT * FROM kitapVer WHERE teslimTarihi<?", baglanti);
            a.SelectCommand.Parameters.Add("@teslimTarihi", OleDbType.Date).Value = tarih;
            a.Fill(tablo);
            dataGridView1.DataSource = tablo;

            MessageBox.Show("Kitap başarıyla teslim edildi..","İşlemler");
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            baglanti.Close();
        }

    }
}
