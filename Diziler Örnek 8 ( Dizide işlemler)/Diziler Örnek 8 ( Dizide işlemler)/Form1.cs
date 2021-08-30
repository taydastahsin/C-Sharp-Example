using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek_8___Dizide_işlemler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32 .Parse(listBox1.Items[i].ToString());
            }
            textBox1.Clear();

            Array.Sort(sayılar);
            label2.Text = sayılar[sayılar.Length-1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            textBox1.Clear();

            Array.Sort(sayılar);
            label3.Text = sayılar[0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            textBox1.Clear();
            foreach (int i in sayılar)
            {
                if (i % 2 == 1)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            textBox1.Clear();
            foreach (int i in sayılar)
            {
                if (i % 2 == 0)
                {
                    listBox3.Items.Add(i);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            textBox1.Clear();

            int toplam = 0;

            foreach (int i in sayılar)
            {
                toplam = toplam + i;
            }
            label7.Text = toplam.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] sayılar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayılar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            textBox1.Clear();

            int toplam = 0;

            foreach (int i in sayılar)
            {
                toplam = toplam + i;
            }

            label5.Text = (toplam / sayılar.Length).ToString();

        }
    }
}
