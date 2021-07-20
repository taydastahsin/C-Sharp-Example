using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Sayı_Üretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Random sayı = new Random();   şeklinde yaparak her yerde kullanabiliriz.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random sayı = new Random();

            int a = sayı.Next(0,51);

            int b = sayı.Next(50,101);

            label1.Text = a.ToString();

            label2.Text = b.ToString();

        }
    }
}
