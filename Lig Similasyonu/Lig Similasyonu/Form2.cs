using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lig_Similasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        int fb = 0;
        int gs = 0;
        int bjk = 0;
        int ts = 0;

        int avfb = 0;
        int avgs = 0;
        int avbjk = 0;
        int avts = 0;

        private void button5_Click(object sender, EventArgs e)
        {

            // 0 ile 4 sayısı üretme kodu

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            // Skor yazma Kodu

            label17.Text = a.ToString();
            label18.Text = b.ToString();
            label19.Text = c.ToString();
            label20.Text = d.ToString();

            // skor tahmin edildikten sonra puanlama sistem kodu

            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label18.Text))
            {
                // fb kazanınca puan ekler

                fb = fb + 3;

                fbpuanlabel.Text = fb.ToString();

                // fb kazanınca avaraj ekler

                avfb = avfb + a;

                fbavlabel.Text = avfb.ToString();

                //gs kaybettiği için avaraj siler

                avgs = b - a;

                gsavlabel.Text = avgs.ToString();

            }

            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label17.Text))
            {
                // gs kazanınca puan ekler

                gs = gs + 3;

                gspuanlabel.Text = gs.ToString();

                // gs kazanınca avaraj ekler

                avgs = avgs + b;

                gsavlabel.Text = avgs.ToString();

                //fb kaybettiği için avaraj siler

                avfb = a - b;

                fbavlabel.Text = avfb.ToString();

            }

            if (Convert.ToInt32(label19.Text) > Convert.ToInt32(label20.Text))
            {
                //bjk kazanınca puan ekler

                bjk = bjk + 3;

                bjkpuanlabel.Text = bjk.ToString();

                // bjk kazanınca avaraj ekler

                avbjk = avbjk + c;

                bjkavlabel.Text = avbjk.ToString();

                //ts kaybettiği için avaraj siler

                avts = d - c;

                tsavlabel.Text = avts.ToString();

            }

            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label19.Text))
            {
                //ts kazanınca puan ekler

                ts = ts + 3;

                tspuanlabel.Text = ts.ToString();

                // ts kazanınca avaraj ekler

                avts = avts + d;

                tsavlabel.Text = avts.ToString();

                //bjk kaybettiği için avaraj siler

                avbjk = c - d;

                bjkavlabel.Text = avbjk.ToString();

            }

            if (Convert.ToInt32(label17.Text) == Convert.ToInt32(label18.Text))
            {
                // berabere kalınca her iki takımada 1'er puan ekleme

                fb = fb + 1;

                gs = gs + 1;

                fbpuanlabel.Text = fb.ToString();

                gspuanlabel.Text = gs.ToString();

            }

            if (Convert.ToInt32(label19.Text) == Convert.ToInt32(label20.Text))
            {
                // berabere kalınca her iki takımada 1'er puan ekleme

                ts = ts + 1;

                bjk = bjk + 1;

                tspuanlabel.Text = ts.ToString();

                bjkpuanlabel.Text = bjk.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 0 ile 4 sayısı üretme kodu

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            // Skor yazma Kodu

            label21.Text = a.ToString();
            label22.Text = b.ToString();
            label23.Text = c.ToString();
            label24.Text = d.ToString();

            // skor tahmin edildikten sonra puanlama sistem kodu

            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label22.Text))
            {
                // fb kazanınca puan ekler

                fb = fb + 3;

                fbpuanlabel.Text = fb.ToString();

                // fb kazanınca avaraj ekler

                avfb = avfb + a;

                fbavlabel.Text = avfb.ToString();

                //bjk kaybettiği için avaraj siler

                avbjk = b - a;

                bjkavlabel.Text = avbjk.ToString();

            }

            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label21.Text))
            {
                // bjk kazanınca puan ekler

                bjk = bjk + 3;

                bjkpuanlabel.Text = bjk.ToString();

                // bjk kazanınca avaraj ekler

                avbjk = avbjk + b;

                bjkavlabel.Text = avbjk.ToString();

                //fb kaybettiği için avaraj siler

                avfb = a - b;

                fbavlabel.Text = avfb.ToString();

            }

            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label24.Text))
            {
                // gs kazanınca puan ekler

                gs = gs + 3;

                gspuanlabel.Text = gs.ToString();

                // gs kazanınca avaraj ekler

                avgs = avgs + c;

                gsavlabel.Text = avgs.ToString();

                //ts kaybettiği için avaraj siler

                avts = d - c;

                tsavlabel.Text = avts.ToString();

            }

            if (Convert.ToInt32(label24.Text) > Convert.ToInt32(label23.Text))
            {
                //ts kazanınca puan ekler

                ts = ts + 3;

                tspuanlabel.Text = ts.ToString();

                // ts kazanınca avaraj ekler

                avts = avts + d;

                tsavlabel.Text = avts.ToString();

                //gs kaybettiği için avaraj siler

                avgs = c - d;

                gsavlabel.Text = avgs.ToString();

            }

            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label22.Text))
            {
                // berabere kalınca her iki takımada 1'er puan ekleme

                fb = fb + 1;

                bjk = bjk + 1;

                fbpuanlabel.Text = fb.ToString();

                bjkpuanlabel.Text = bjk.ToString();

            }

            if (Convert.ToInt32(label23.Text) == Convert.ToInt32(label24.Text))
            {
                // berabere kalınca her iki takımada 1'er puan ekleme

                ts = ts + 1;

                gs = gs + 1;

                tspuanlabel.Text = ts.ToString();

                gspuanlabel.Text = gs.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Sonuç'a tıkladığınızda Şampiyon belli olcaktır. ");

            // 0 ile 4 sayısı üretme kodu

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            // Skor yazma Kodu

            label25.Text = a.ToString();
            label26.Text = b.ToString();
            label27.Text = c.ToString();
            label28.Text = d.ToString();

            // skor tahmin edildikten sonra puanlama sistem kodu

            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                // fb kazanınca puan ekler

                fb = fb + 3;

                fbpuanlabel.Text = fb.ToString();

                // fb kazanınca avaraj ekler

                avfb = avfb + a;

                fbavlabel.Text = avfb.ToString();

                //ts kaybettiği için avaraj siler

                avts = b - a;

                tsavlabel.Text = avts.ToString();

            }

            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label25.Text))
            {
                // ts kazanınca puan ekler

                ts = ts + 3;

                tspuanlabel.Text = ts.ToString();

                // ts kazanınca avaraj ekler

                avts = avts + b;

                tsavlabel.Text = avts.ToString();

                //fb kaybettiği için avaraj siler

                avfb = a - b;

                fbavlabel.Text = avfb.ToString();

            }

            if (Convert.ToInt32(label27.Text) > Convert.ToInt32(label28.Text))
            {
                // gs kazanınca puan ekler

                gs = gs + 3;

                gspuanlabel.Text = gs.ToString();

                // gs kazanınca avaraj ekler

                avgs = avgs + c;

                gsavlabel.Text = avgs.ToString();

                //bjk kaybettiği için avaraj siler

                avbjk = d - c;

                bjkavlabel.Text = avbjk.ToString();

            }

            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label27.Text))
            {
                //bjk kazanınca puan ekler

                bjk = bjk + 3;

                bjkpuanlabel.Text = bjk.ToString();

                // bjk kazanınca avaraj ekler

                avbjk = avbjk + d;

                bjkavlabel.Text = avbjk.ToString();

                //gs kaybettiği için avaraj siler

                avgs = c - d;

                gsavlabel.Text = avgs.ToString();

            }

            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label26.Text))
            {
                // berabere kalınca her iki takımada 1'er puan ekleme

                fb = fb + 1;

                ts = ts + 1;

                fbpuanlabel.Text = fb.ToString();

                tspuanlabel.Text = ts.ToString();

            }

            if (Convert.ToInt32(label27.Text) == Convert.ToInt32(label28.Text))
            {
                // berabere kalınca her iki takımada 1'er puan ekleme

                bjk = bjk + 1;

                gs = gs + 1;

                bjkpuanlabel.Text = bjk.ToString();

                gspuanlabel.Text = gs.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int a1;
            int b1;
            int c1;
            int d1;

            a = Convert.ToInt32(fbpuanlabel.Text);

            b  = Convert.ToInt32(gspuanlabel.Text);

            c = Convert.ToInt32(bjkpuanlabel.Text);

            d  = Convert.ToInt32(tspuanlabel.Text); 

            a1  = Convert.ToInt32(fbavlabel.Text);

            b1  = Convert.ToInt32(gsavlabel.Text);

            c1  = Convert.ToInt32(bjkavlabel.Text);

            d1  = Convert.ToInt32(tsavlabel.Text);



            if ( (a > b && a1 >b1) && (a > c && a1 > c1) && (a > d && a1 > d1) )
            {
                label1 .Text = " FENERBAHÇE";
            }

            if ((b > a && b1 > a1) && (b > c && b1 > c1) && (b > d && b1 > d1))
            {
                label1 .Text = " GALATASARAY";
            }

            if ((c > b && c1 > b1) && (c > a && c1 > a1) && (c > d && c1 > d1))
            {
                label1 .Text = " BEŞİKTAŞ";
            }

            if ((d > a && d1 > a1) && (d > b && d1 > b1) && (d > c && d1 > c1))
            {
                label1 .Text = " TRABZONSPOR";
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }

