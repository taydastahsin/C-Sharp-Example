using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Menüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox1.Text);
            
            listBox4.Items.Add(textBox2.Text);

            listBox5.Items.Add(textBox3.Text);

            listBox6.Items.Add(comboBox1  .Text); 
            
            listBox7.Items.Add(comboBox2  .Text);

            listBox8.Items.Add(label13.Text +" "+label14 +" "+ label15.Text + " " + label16 +" "+ label17.Text + "" + label18 +" "+
                label19.Text + "" + label20 +" "+ label21.Text + "" + label22);

         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = checkBox6.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label19.Text = checkBox7.Text;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = checkBox8.Text;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label21.Text = checkBox9.Text;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = checkBox10.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text  = "";
            comboBox2.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = ""; 
            label14.Text = "";
            label15.Text = ""; 
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            

        }
    }
}
