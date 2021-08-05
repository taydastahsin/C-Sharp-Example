using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambası_Similasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(label1.Text);
            sayı++;

            label1.Text = sayı.ToString();

            if (sayı == 1)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;

            }

            if (sayı == 30)
            {
                button1.BackColor = Color.White ;
                button2.BackColor = Color.Yellow ;
                button3.BackColor = Color.White;
            }
            
            if (sayı == 35)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.Red;
            }

            if (sayı == 50)
            {
                sayı = 0;
                label1.Text = sayı.ToString();
            }
        }
    }
}
