using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika =0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        // timer 'ın özelliklerinden interval "1000" yapılarak saniye cinsinden artış sağlanır.
        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye = Convert.ToInt32(label2.Text);
            saniye++;

            label2.Text = saniye.ToString();

            if(saniye == 60)
            {
                saniye = 0;
                label2.Text = saniye.ToString();
                dakika++;
                label1.Text = dakika.ToString();
                saniye = 0;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "0";
            label2.Text = "0";
        }
    }
}
