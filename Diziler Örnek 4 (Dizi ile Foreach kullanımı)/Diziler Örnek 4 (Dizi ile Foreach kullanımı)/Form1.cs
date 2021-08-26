using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek_4__Dizi_ile_Foreach_kullanımı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            int toplam = 0;

            int[] sayılar = { sayı1, sayı2 };

            foreach (int sayı in sayılar)
            {
                toplam = toplam + sayı;
                label4.Text = toplam.ToString();

            }

            
        }
    }
}
