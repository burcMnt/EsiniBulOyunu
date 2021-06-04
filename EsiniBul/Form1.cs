using EsiniBul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class Form1 : Form
    {
        int satirAdet = 4;
        int sutunAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int[] bayrakHavuzu;
        int[] bayraklar;

        public int KartAdet { get { return satirAdet * sutunAdet; } }
        // public int KartAdet=> satirAdet * sutunAdet; //Lambda gösterim
        public Form1()
        {
            InitializeComponent();
            BayrakHavuzunuDoldur();
            BayraklariDoldur();
            KartlariDiz();

        }

        private void BayraklariDoldur()
        {
            bayraklar = new int[KartAdet];
            Array.Copy(bayrakHavuzu, bayraklar, KartAdet / 2);
            Array.Copy(bayrakHavuzu, 0, bayraklar, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(bayraklar);
        }

        private void BayrakHavuzunuDoldur()
        {
            bayrakHavuzu = Enumerable.Range(1, 263).ToArray();
            Islemler.Karistir(bayrakHavuzu);
        }

        private void KartlariDiz()
        {
            BayraklariDoldur();

            //Random rnd = new Random();

            pnlKartlar.Width = sutunAdet * (kartBoyut + kartArasi) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartBoyut + kartArasi) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);
            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                //pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + rnd.Next(1, 264));  //rastgele bayrakları ekrana getirdik

                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + bayraklar[i]);
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.BackColor = Color.Pink;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }
    }
}
