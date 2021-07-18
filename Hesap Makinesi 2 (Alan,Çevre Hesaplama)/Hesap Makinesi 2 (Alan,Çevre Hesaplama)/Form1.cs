using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_2__Alan_Çevre_Hesaplama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label1.Text = "Bir Kenar";
            label4.Text = "Kare"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label2.Visible = true ;
            textBox2.Visible = true ;
            label3.Visible = false;
            textBox3.Visible = false;
            label1.Text = "Kısa Kenar";
            label4.Text = "Dikdörtgen";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true  ;
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false ;
            textBox2.Visible = false ;
            label3.Visible = true ;
            textBox3.Visible = true ;
            label4.Text = "Daire";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int alan, cevre;
            int  a;

            a = Convert.ToInt32(textBox1.Text );
      
            alan = a * a;
            cevre = a * 4;

            label7.Text = alan.ToString();
            label9.Text = cevre.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int alan, cevre;
            int a,b;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            alan = a * b;
            cevre = (a * 2)+(b*2);

            label7.Text = alan.ToString();
            label9.Text = cevre.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int alan, cevre;
            int r;

            r = Convert.ToInt32(textBox3.Text);
         

            alan = r * r*3;
            cevre = (r * 2)* 3;

            label7.Text = alan.ToString();
            label9.Text = cevre.ToString();
        }
    }
}
