using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Kullanım_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double  a;
            double  b;
            double  toplam;

            a = Convert.ToDouble(textBox1 .Text);
            b = Convert.ToDouble(textBox2.Text);

            toplam = a + b;
            label4.Text = toplam.ToString();


        }
    }
}
