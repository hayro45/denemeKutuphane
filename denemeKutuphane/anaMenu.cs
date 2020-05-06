using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeKutuphane
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrenciekle = new ogrenciEkle();
            ogrenciekle.Show();
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencisil = new ogrenciSil();
            ogrencisil.Show();
        }

        private void DüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrenciduzenle = new ogrenciDuzenle();
            ogrenciduzenle.Show();
        }

        private void ListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencilistele = new ogrenciListele();
            ogrencilistele.Show();
        }

        private void EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapekle = new kitapEkle();
            kitapekle.Show();
        }

        private void SilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitapesil = new kitapSil();
            kitapesil.Show();
        }

        private void DüzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitapduzenle = new kitapDuzenle();
            kitapduzenle.Show();
        }

        private void ListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitaplistele = new kitapListele();
            kitaplistele.Show();
        }

        private void KitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapver = new kitapVer();
            kitapver.Show();

        }

        private void GeçKalanKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form geckalankitaplar = new gecKalanKitaplar();
            geckalankitaplar.Show();
        }
    }
}
