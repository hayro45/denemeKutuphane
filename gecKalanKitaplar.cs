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
        public gecKalanKitaplar()
        {
            InitializeComponent();
        }

        private void GecKalanKitaplar_Load(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToShortDateString();
            
            baglanti.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM kitapVer WHERE teslimTarihi<?", baglanti);
            komut.SelectCommand.Parameters.Add("@teslimTarihi",OleDbType.Date).Value=tarih;
            komut.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
