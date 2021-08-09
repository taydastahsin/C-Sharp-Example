using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması_Similasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru =0;
        int dogru = 0;
        int yanlıs = 0;
        int süre = 20;

        private void button5_Click(object sender, EventArgs e)
        {
            soru++;
            label2.Text = soru.ToString();

            timer1.Enabled = true;

            button5.Enabled = false;

            

            if (soru == 1)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürkün doğduğu yıl ?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";

               


            }


            if (soru == 2)
            {
                richTextBox1.Text = "Türkiye kaç coğrafi bölgeye ayrılır?";
                button1.Text = "5";
                button2.Text = "6";
                button3.Text = "7";
                button4.Text = "14";

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

                süre = 20;
                label8.Text = süre.ToString();
            }

            if (soru == 3)
            {
                richTextBox1.Text = "Türkiye'nin en yüksek dağı nedir?";
                button1.Text = "Ağrı Dağı";
                button2.Text = "Nemrut Dağı";
                button3.Text = "Yedi Tepe";
                button4.Text = "Balkanlar";

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (soru == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }

            if (soru == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
            if (soru == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Doğru Cevap verdiniz !!!!!!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (soru == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                dogru++;
                label3.Text = dogru.ToString();

                button5.Text = "İleri";

                MessageBox.Show("Doğru Cevap verdiniz !!!!!!");


            }
            if (soru == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
            if (soru == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (soru == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                dogru++;
                label5.Text = dogru.ToString();

                button5.Text = "İleri";

                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");


            }
            if (soru == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
            if (soru == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (soru == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";

                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");


            }
            if (soru == 2)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
            if (soru == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                yanlıs++;
                label5.Text = yanlıs.ToString();

                button5.Text = "İleri";


                MessageBox.Show("Yanlış Cevap verdiniz !!!!!!");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            süre = süre - 1;
            label8.Text = süre.ToString();

            if (süre <= 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

                timer1.Enabled = false;

                MessageBox.Show("Süreniz Bitmiştir");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
