using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_For_Döngüsü_Örneği_2__Faktoriyel_Hesaplama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 1;
        int faktoriyel = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            for (i=1;i<=7;i++)
            {
                faktoriyel = faktoriyel * i;

                label1.Text = faktoriyel.ToString();
                listBox1.Items.Add(i);
                listBox2.Items.Add(faktoriyel);
            }
        }
    }
}
