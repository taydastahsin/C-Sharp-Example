using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_3__Double_ve_if_komutu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, toplam, çarpma, bölme, çıkarma;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox3.Text);

            toplam  = a + b;
            çıkarma = a - b;
            çarpma  = a * b;
            bölme   = a / b;

          if (textBox2  .Text == "+")
            {
                label5.Text = toplam.ToString();
            }

            if (textBox2.Text == "-")
            {
                label5.Text = çıkarma .ToString();
            }

            if (textBox2.Text == "*")
            {
                label5.Text = çarpma .ToString();
            }

            if (textBox2.Text == "/")
            {
                label5.Text = bölme .ToString();
            }

        }
    }
}
