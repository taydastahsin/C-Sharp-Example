using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_İşlemler_Üssü_Karekök_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2;
            double üs;

            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            
            üs = Math.Pow(sayı1, sayı2);

            label5.Text = üs.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayı3;
            double karekök;

            sayı3 = Convert.ToDouble(textBox3.Text);

            karekök = Math.Sqrt(sayı3);

            label6.Text = karekök.ToString();
        }
    }
}
