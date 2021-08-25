using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek__Dizi_Double_değişkeni_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sayılar = { 1.5, 2.3, 3.8, 4.5, 5.1, 6.9 };
            int eleman = sayılar.Length;
            label5.Text = eleman.ToString();

            int sayı;
            sayı = Convert.ToInt32(textBox1.Text);

            label1.Text = sayılar[sayı].ToString();


        }
    }
}
