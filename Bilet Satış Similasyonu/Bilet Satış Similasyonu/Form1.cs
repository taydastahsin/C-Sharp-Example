using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_Satış_Similasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int people = 0;
        int bprice =0;
        int acola = 0;
        int asu = 0;
        int amısır = 0;
        int asoda = 0;
        int pcola = 0;
        int psu = 0;
        int pmısır = 0;
        int psoda = 0;
        int tprice = 0;
        int tadet = 0;



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            people++;
            bprice  = bprice  +10 ;

            textBox1.Text = people.ToString();
            textBox2.Text = bprice.ToString();

            if (people == 15)
            {
                button1.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            people--;
            bprice = bprice - 10;

            textBox1.Text = people.ToString();
            textBox2.Text = bprice.ToString();

            if (people < 15)
            {
                button1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            acola++;
            pcola = pcola + 4;
            textBox6.Text = acola.ToString();
            textBox5.Text = pcola.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            acola--;
            pcola = pcola - 4;
            textBox6.Text = acola.ToString();
            textBox5.Text = pcola.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            asu++;
            psu = psu + 1;
            textBox8.Text = asu .ToString();
            textBox7.Text = psu .ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asu--;
            psu = psu - 1;
            textBox8.Text = asu.ToString();
            textBox7.Text = psu.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            amısır++;
            pmısır  = pmısır + 2;
            textBox10.Text = amısır.ToString();
            textBox9.Text = pmısır.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            amısır--;
            pmısır = pmısır - 2;
            textBox10.Text = amısır.ToString();
            textBox9.Text = pmısır.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            asoda ++;
            psoda = psoda + 3;
            textBox12.Text = asoda .ToString();
            textBox11.Text = psoda.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            asoda--;
            psoda = psoda - 3;
            textBox12.Text = asoda.ToString();
            textBox11.Text = psoda.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text.ToString();
            textBox3.Text = textBox2.Text.ToString();
            tprice = pcola + psu + psoda + pmısır;
            tadet = acola + amısır + asu + asoda;
            textBox14.Text = tadet.ToString();
            textBox13.Text = tprice.ToString();

        }
    }
}
