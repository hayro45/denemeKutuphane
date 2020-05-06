using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace denemeKutuphane
{
    public partial class ogrenciProfil : Form
    {
        public string tcno;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath + "\\denemeDb.accdb");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ogrenciProfil()
        {
            InitializeComponent();
            tcno = Form1.nesne;
            baglanti.Open();
            OleDbCommand kullanici = new OleDbCommand("SELECT * FROM ogrenciler WHERE tcno='" + tcno.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = kullanici.ExecuteReader();
            while (okuyucu.Read())
            {
                txtTcNo.Text = okuyucu["tcno"].ToString() ;
                txtAd.Text = okuyucu["adi"].ToString();
                txtSoyad.Text = okuyucu["soyadi"].ToString();
                txtTel.Text = okuyucu["telefon"].ToString();
                richAdres.Text = okuyucu["adres"].ToString();
                txtEposta.Text = okuyucu["eposta"].ToString();
            }
            baglanti.Close();
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form kitaplistele = new kitapListele();
            kitaplistele.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE ogrenciler SET tcno='" + txtTcNo.Text + "', adi='" + txtAd.Text + "', soyadi='" + txtSoyad.Text + "', telefon='" + txtTel.Text + "', eposta='"+ txtEposta.Text+"', adres='" + richAdres.Text + "' WHERE tcno='" + txtTcNo.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz başarıyla düzenlendi", "İşlemler");
            baglanti.Close();
        }
    }
}
