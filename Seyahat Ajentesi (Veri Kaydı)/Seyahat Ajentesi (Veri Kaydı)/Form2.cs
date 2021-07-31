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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.Red;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = Color.Red;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.ForeColor = Color.Red;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.ForeColor = Color.Red;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.ForeColor = Color.Red;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.ForeColor = Color.Red;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.ForeColor = Color.Red;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.ForeColor = Color.Red;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.ForeColor = Color.Red;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.ForeColor = Color.Red;
        }
    }
}
