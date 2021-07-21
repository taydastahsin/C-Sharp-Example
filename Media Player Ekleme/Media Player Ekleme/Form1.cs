using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // İstediğimiz müziğin lokasyonunu aldıktan sonra çift tırnak arasına (sondaki kısma) yazın.
            axWindowsMediaPlayer1.URL = "C:\\Users\\TAHSİN\\Desktop\\";
            // İstediğiniz resmin lokasyonunu aldıktan sonra çift tırnak arasına yazın.
            pictureBox1.ImageLocation = "C:\\Users\\TAHSİN\\Desktop\\2.jpg";
 


        }
    }
}
