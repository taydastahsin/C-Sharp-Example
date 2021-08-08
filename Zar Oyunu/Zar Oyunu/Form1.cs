using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamben;
        int toplampc;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(1,7);
            int b = rastgele.Next(1, 7);
            int toplam;

            label2.Text = a.ToString();
            label3.Text = b.ToString();
            toplam = a + b;
            toplamben = toplamben + a + b;
            label17.Text = toplamben.ToString();
            label5.Text = toplam.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\6.jpg";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\6.jpg";
            }

            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            int toplam;

            label11.Text = c.ToString();
            label9.Text = d.ToString();
            toplam = c + d;
            toplampc = toplampc + c + d;
            label13.Text = toplampc.ToString();
            label7.Text = toplam.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\6.jpg";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\TAHSİN\\Source\\Repos\\Zar Oyunu\\Zar Oyunu\\Zar Resimleri\\6.jpg";
            }

            button1.Enabled = true ;
            button2.Enabled = false ;

            if (toplamben >= 100 && toplamben > toplampc)
            {
                MessageBox.Show("Siz Kazandınız. Tebrikler!!!!!!!!!!!!!");
                toplamben = 0;
                toplampc = 0;

            }

            if (toplampc >= 100 && toplampc > toplamben)
            {
                MessageBox.Show("Bilgisayar Kazandı. Tebrikler!!!!!!!!!!!!!");
                toplamben = 0;
                toplampc = 0;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
