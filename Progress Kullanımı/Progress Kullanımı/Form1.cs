using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (a == 90)
            {
                button5.Enabled = false;
            }
            a += 10;
            progressBar1.Value = a ;

            button6.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 25;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 10)
            {
                button6.Enabled = false;
            }
            a -= 10;
            progressBar1.Value = a;

            button5.Enabled = true;
        }
    }
}
