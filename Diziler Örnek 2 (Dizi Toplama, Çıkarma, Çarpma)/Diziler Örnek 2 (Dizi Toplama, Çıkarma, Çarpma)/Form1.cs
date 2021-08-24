using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek_2__Dizi_Toplama__Çıkarma__Çarpma_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 3, 4, 5 };

            int toplam = 0;
            int çıkarma = 0;
            int çarpma = 1;

            for(int i=0;i < sayılar .Length;i++ )
            {
                toplam = toplam + sayılar[i];
                label4.Text = toplam.ToString();

                çıkarma  = çıkarma  - sayılar[i];
                label5.Text = çıkarma .ToString();

                çarpma  = çarpma  * sayılar[i];
                label6.Text = çarpma .ToString();

            }
        }
    }
}
