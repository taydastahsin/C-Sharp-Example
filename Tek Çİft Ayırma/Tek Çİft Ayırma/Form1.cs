using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_Çİft_Ayırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int teksayı = 0;
        int çiftsayı = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;

            sayı = Convert.ToInt32(textBox1.Text);

            if (sayı %2 == 0)
            {
                çiftsayı =  sayı + çiftsayı;
                listBox2.Items.Add(çiftsayı);

            }
            if (sayı % 2 == 1)
            {
                teksayı  = sayı + teksayı  ;
                listBox1.Items.Add(teksayı );

            }

        }
    }
}
