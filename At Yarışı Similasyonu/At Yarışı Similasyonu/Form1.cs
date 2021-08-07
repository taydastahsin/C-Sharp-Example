using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı_Similasyonu
{
    public partial class Form1 : Form
    {

        Random rastgele = new Random();

        int birinciatsoluzak ;
        int ikinciatsoluzak ;
        int ucuncuatsoluzak ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            int birinciatgenislikuzak = pictureBox1.Width ;
            int ikinciatgenislikuzak = pictureBox2.Width ;
            int ucuncuatgenislikuzak = pictureBox3.Width ;

            pictureBox1.Left = pictureBox1 .Left + rastgele.Next(5,16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);

            int bitis = label5.Left;
            
            if (birinciatgenislikuzak + pictureBox1 .Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Birinci at yarışı kazandı!!!!!!!!!!!!");

            }
            if (ikinciatgenislikuzak + pictureBox2 .Left  >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("İkinci at yarışı kazandı!!!!!!!!!!!!");

            }

            if (ucuncuatgenislikuzak +pictureBox3 .Left  >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Üçüncü at yarışı kazandı!!!!!!!!!!!!");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
             birinciatsoluzak = pictureBox1.Left;
             ikinciatsoluzak = pictureBox2.Left;
             ucuncuatsoluzak = pictureBox3.Left;
        }
    }
}
