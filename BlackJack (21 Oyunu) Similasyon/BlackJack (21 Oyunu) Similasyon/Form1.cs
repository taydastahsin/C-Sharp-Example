using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack__21_Oyunu__Similasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayaç = 0, toplam = 0;

        private void restart()
        {
            button1.Enabled = true;
            button2.Enabled = true;

            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
            label4.Text = "00";
            label5.Text = "00";
            label6.Text = "00";
            label7.Text = "00";
            label8.Text = "00";
            label11.Text = "00";
            label12.Text = "00";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a1, a2, a3, a4;
            
            sayaç++;

            if (sayaç == 1)
            {
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                toplam = a1 + a2;

                label11.Text = toplam.ToString();
            }

            if (sayaç == 2)
            {
                a3 = rastgele.Next(1, 11);

                label3.Text = a3.ToString();

                toplam = toplam + a3;
                label11.Text = toplam.ToString();
            }
            if (sayaç == 3)
            {
                a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = toplam + a4;
                label11.Text = toplam.ToString();
            }
            if (sayaç == 4)
            {
                MessageBox.Show("Lütfen PC şans veriniz !!!!!!");
                button1.Enabled = false ;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y;

            x = Convert.ToInt32(label11.Text);
            y = Convert.ToInt32(label12.Text);

            if (x > y)
            {
                MessageBox.Show("Tebrikler Siz Kazandınız!!!!!!!"); 
            }
            else
            {
                MessageBox.Show("Tebrikler PC Kazandı!!!!!!");
            }

            restart();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int b1, b2, b3, b4, toplam = 0;

            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);

            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            toplam = b1 + b2;
            label12.Text = toplam.ToString();

            if (toplam < 16)
            {
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();

                toplam = toplam + b3;
                label12.Text = toplam.ToString();
            }

            if (toplam < 16)
            {
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();

                toplam = toplam + b4;
                label12.Text = toplam.ToString();
            }
            button2.Enabled = false;

        }
    }
}
