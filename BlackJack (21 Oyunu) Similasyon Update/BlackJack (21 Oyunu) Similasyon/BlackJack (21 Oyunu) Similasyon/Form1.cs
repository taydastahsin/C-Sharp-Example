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

            if (label1.Text == "1")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label1.Text == "3")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label1.Text == "9")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }
            ///////////////////////////////////////////////////////
             if (label2 .Text == "1")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label2.Text == "2")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label2.Text == "3")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label2.Text == "4")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label2.Text == "5")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label2.Text == "6")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label2.Text == "7")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label2.Text == "8")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label2.Text == "9")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label2.Text == "10")
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }
            /////////////////////////////////////////
            if (label3.Text == "1")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label3.Text == "2")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label3.Text == "3")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label3.Text == "4")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label3.Text == "5")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label3.Text == "6")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label3.Text == "7")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label3.Text == "8")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label3.Text == "9")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label3.Text == "10")
            {
                pictureBox3.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }
            //////////////////////////////
             if (label4 .Text == "1")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label4.Text == "2")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label4.Text == "3")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label4.Text == "4")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label4.Text == "5")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label4.Text == "6")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label4.Text == "7")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label4.Text == "8")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label4.Text == "9")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label4.Text == "10")
            {
                pictureBox4.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
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

        private void Form1_Load(object sender, EventArgs e)
        {
           
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


            if (label5.Text == "1")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label5.Text == "2")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label5.Text == "3")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label5.Text == "4")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label5.Text == "5")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label5.Text == "6")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label5.Text == "7")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label5.Text == "8")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label5.Text == "9")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label5.Text == "10")
            {
                pictureBox5.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }
            ///////////////////////////////////////////////////////
            if (label6 .Text == "1")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label6.Text == "2")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label6.Text == "3")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label6.Text == "4")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label6.Text == "5")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label6.Text == "6")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label6.Text == "7")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label6.Text == "8")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label6.Text == "9")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label6.Text == "10")
            {
                pictureBox6.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }
            /////////////////////////////////////////
            if (label7.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label7.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label7.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label7.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label7.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label7.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label7.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label7.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label7.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label7.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }
            //////////////////////////////
            if (label8 .Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\1.png";
            }
            if (label8.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\2.png";
            }
            if (label8.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\3.png";
            }
            if (label8.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\4.png";
            }
            if (label8.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\5.png";
            }
            if (label8.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\6.png";
            }
            if (label8.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\7.png";
            }
            if (label8.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\8.png";
            }
            if (label8.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\9.png";
            }
            if (label8.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\Kart Resimleri\\10.png";
            }

        }
    }
}
