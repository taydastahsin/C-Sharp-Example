using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek_7___Dizi_Veri_tabanı_tutms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = new string[10];
        string[] ilçe = new string[10];
        string[] tel = new string[10];
        int i;

        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isim[i] = textBox1.Text;
            ilçe[i] = textBox2.Text;
            tel[i] = textBox3.Text;
            i++;

            temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
          label7 .Text = isim[i];
          label9 .Text = ilçe[i];
          label8 .Text = tel[i];

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i--;
            label7.Text = isim[i];
            label9.Text = ilçe[i];
            label8.Text = tel[i];

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            label7.Text = isim[i];
            label9.Text = ilçe[i];
            label8.Text = tel[i];

         
        }
    }
}
