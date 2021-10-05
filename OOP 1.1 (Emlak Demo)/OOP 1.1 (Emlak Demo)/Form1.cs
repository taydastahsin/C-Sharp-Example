using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1._1__Emlak_Demo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ev birinciev = new Ev();

            birinciev.turu = "Daire";
            birinciev.renk = "Mavi";
            birinciev.kat = 3;
            birinciev.oda = 3;

            label5.Text = birinciev.turu.ToString();
            label6.Text = birinciev.renk.ToString();
            label7.Text = birinciev.kat.ToString();
            label8.Text = birinciev.oda.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ev ikinciev = new Ev();

            ikinciev.turu = "Daire";
            ikinciev.renk = "Kırmızı";
            ikinciev.kat = 2;
            ikinciev.oda = 4;

            label5.Text = ikinciev.turu.ToString();
            label6.Text = ikinciev.renk.ToString();
            label7.Text = ikinciev.kat.ToString();
            label8.Text = ikinciev.oda.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Ev ucuncuev = new Ev();

            ucuncuev.turu = "Apartman";
            ucuncuev.renk = "Beyaz";
            ucuncuev.kat = 7;
            ucuncuev.oda = 3;

            label5.Text = ucuncuev.turu.ToString();
            label6.Text = ucuncuev.renk.ToString();
            label7.Text = ucuncuev.kat.ToString();
            label8.Text = ucuncuev.oda.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ev dorduncuev = new Ev();

            dorduncuev.turu = "Apartman";
            dorduncuev.renk = "Yeşil";
            dorduncuev.kat = 12;
            dorduncuev.oda = 5;

            label5.Text = dorduncuev.turu.ToString();
            label6.Text = dorduncuev.renk.ToString();
            label7.Text = dorduncuev.kat.ToString();
            label8.Text = dorduncuev.oda.ToString();
        }
    }
}
