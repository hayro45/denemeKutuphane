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
    public partial class ogrenciListele : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source="+Application.StartupPath+"\\denemeDb.accdb");
        DataTable tablo = new DataTable();
        public ogrenciListele()
        {
            InitializeComponent();
        }

        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("SELECT * FROM ogrenciler ", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
