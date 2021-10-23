using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör_Similasyonu__Point_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point aralık = new Point();
            aralık.X = 40;
            aralık.Y = 292;
            pictureBox1.Location = aralık;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point aralık = new Point();
            aralık.X = 40;
            aralık.Y = 228;
            pictureBox1.Location = aralık;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point aralık = new Point();
            aralık.X = 40;
            aralık.Y = 164;
            pictureBox1.Location = aralık;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point aralık = new Point();
            aralık.X = 40;
            aralık.Y = 100;
            pictureBox1.Location = aralık;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Point aralık = new Point();
            aralık.X = 40;
            aralık.Y = 36;
            pictureBox1.Location = aralık;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point aralık = new Point();
            aralık.X = 40;
            aralık.Y = 356;
            pictureBox1.Location = aralık;

        }
    }
}
