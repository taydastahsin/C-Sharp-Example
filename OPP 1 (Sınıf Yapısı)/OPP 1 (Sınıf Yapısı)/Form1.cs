using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP_1__Sınıf_Yapısı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil() ;

            oto.marka = "Ford";
            oto.model = "Pikap";
            oto.modelyılı = 2010;
            oto.renk = "Mavi";
            oto.vitestipi = "Manuel";

            string marka = oto.markagetir();

            label6.Text = oto.marka.ToString();
            label7.Text = oto.model.ToString();
            label8.Text = oto.modelyılı.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();

        }
    }
}
