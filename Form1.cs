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
    
    public partial class Form1 : Form
    {
        
        
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=" + Application.StartupPath+"\\denemeDb.accdb");
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
        public Form1()
        {
            InitializeComponent();
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private void kapat(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girisYap(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            if (kullaniciAdi == "" && sifre == "")
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi doldurun");
            }
            else if (kullaniciAdi == "")
            {
                MessageBox.Show("Lütfen kullanıcı adını boş bırakmayın!");
            }
            else if (sifre == "")
            {
                MessageBox.Show("Lütfen şifreyi boş bırakmayın!");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM kullanicilar WHERE kullaniciadi='" + kullaniciAdi.ToString() + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (kullaniciAdi.ToString() == okuyucu["kullaniciadi"].ToString() && sifre.ToString() == okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldin sayin " + okuyucu["adi"].ToString() + " " + okuyucu["soyadi"].ToString());
                        Form anamenu = new anaMenu();
                        anamenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifreniz yanlış! Lütfen tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreniz yanlış! Lütfen tekrar deneyiniz.");
                }
                baglanti.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        
    }
}
