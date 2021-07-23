using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lig_Similasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //if (textBox1 .Text == "oyuncu" && textBox2 .Text == "12345") {

            Form2 oyun = new Form2();

            oyun.Show();
            this.Hide();

           //  }
        }
    }
}
