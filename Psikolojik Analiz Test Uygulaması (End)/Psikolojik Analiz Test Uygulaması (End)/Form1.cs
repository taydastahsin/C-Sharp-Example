using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psikolojik_Analiz_Test_Uygulaması__End_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru = 0;
        int toplam = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            soru++;
            button1.Enabled = true ;
            button2.Enabled = true ;
            button3.Enabled = true ;
            button4.Enabled = true ;
            button5.Enabled = false;
            if (soru == 1)
            {
                textBox1.Text = "1.Kızınca bir şeyler fırlatırım.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";

            }
            if (soru == 2)
            {
                textBox1.Text = "2.Benimle candan ilgili pek çok kişi olduğuna inanıyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 3)
            {
                textBox1.Text = "3.Düşüncesizce hareket etmeye eğilimli olduğumu sanıyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 4)
            {
                textBox1.Text = "4.Başkalarına anlatılmayacak kadar kötü şeyler düşünüyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 5)
            {
                textBox1.Text = "5.Çok fazla sorumluluğumun olduğunu düşünüyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 6)
            {
                textBox1.Text = "6.Yapabileceğim faydalı pek çok şey olduğuna inanıyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 7)
            {
                textBox1.Text = "7.Başkalarını cezalandırmak için intiharı düşünüyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 8)
            {
                textBox1.Text = "8.Başkalarına karşı düşmanca duygular duyuyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 9)
            {
                textBox1.Text = "9.Kendimi insanlardan soyutlanmış hissediyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
            }
            if (soru == 10)
            {
                textBox1.Text = "10.İnsanların bana olduğum gibi değer verdiklerini hissediyorum.";
                button1.Text = "Hiçbir zaman veya nadiren";
                button2.Text = "Bazen";
                button3.Text = "Sık sık";
                button4.Text = "Çoğu zaman veya her zaman";

                button5.Text = "Sonraki";
                button6.Enabled = true;




            }
            if (soru == 11)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                

            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = toplam + 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam = toplam + 2;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam = toplam + 3;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam = toplam + 4;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = toplam.ToString();
            if (toplam < 15)
            {
                textBox1.Text = "Birşeyiniz yok devam ke";
               
            }
            if (toplam > 15 && toplam < 20)
            {
                textBox1.Text = "Hayattan bıkmış ve intihar nasıl edebilceğinizi düşünmüşlerdensiniz";
               
            }
            if (toplam > 20 && toplam < 30)
            {
                textBox1.Text = "Kafanızda intihar etme planları kuruyorsunuz";
            }
            if (toplam > 30)
            {
                textBox1.Text = "İntihar etmeye meyillisiniz";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;

        }
    }
}
