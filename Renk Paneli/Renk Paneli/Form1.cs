using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renk_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                Form2 yeni = new Form2();

                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lütfen istenilen şeyleri giriniz!!!");
            }
        }
    }
}
