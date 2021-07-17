using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = label1.Text ;
           label7.Text = textBox1.Text ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = label2.Text ;
            label9.Text = textBox2.Text ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label10.Text = label3.Text ;
            label11.Text = comboBox1.Text ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label12.Text = label4.Text ;
            label13.Text = comboBox2.Text ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label14.Text = label5.Text ;
            label15.Text = textBox5.Text ;
        }
    }
}
