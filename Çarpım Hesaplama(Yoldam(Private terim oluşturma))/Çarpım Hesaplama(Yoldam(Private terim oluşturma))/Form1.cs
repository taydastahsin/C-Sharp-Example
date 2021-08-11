using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çarpım_Hesaplama_Yoldam_Private_terim_oluşturma__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void  temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
      


        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sonuc;
            sonuc = a * b;
            textBox3.Enabled = true;
            textBox3.Text = sonuc.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
            textBox3.Enabled = false;
        }
    }
}
