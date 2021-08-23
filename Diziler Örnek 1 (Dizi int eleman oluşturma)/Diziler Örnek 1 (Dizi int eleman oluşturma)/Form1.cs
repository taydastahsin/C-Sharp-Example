using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek_1__Dizi_int_eleman_oluşturma_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sayı = Convert.ToInt32(textBox1.Text);

            label1.Text = sayılar[sayı].ToString();
            

        }
    }
}
