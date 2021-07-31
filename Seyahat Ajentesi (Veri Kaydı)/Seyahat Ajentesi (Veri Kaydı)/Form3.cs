using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seyahat_Ajentesi__Veri_Kaydı_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox1.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Add(radioButton1.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Add(radioButton2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }
    }
}
