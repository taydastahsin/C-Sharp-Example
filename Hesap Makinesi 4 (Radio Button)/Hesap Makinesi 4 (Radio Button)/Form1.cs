using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_4__Radio_Button_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int çıkarma;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            çıkarma = sayı1 - sayı2;

            button2.Text = çıkarma.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int toplam;

            sayı1 = Convert.ToInt32(textBox1 .Text );
            sayı2 = Convert.ToInt32(textBox2.Text);

            toplam = sayı1 + sayı2;

            button2.Text = toplam.ToString();
           
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int çarpma;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            çarpma = sayı1 * sayı2;

            button2.Text = çarpma.ToString();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int bölme;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            bölme = sayı1 / sayı2;

            button2.Text = bölme.ToString();

        }
    }
}
