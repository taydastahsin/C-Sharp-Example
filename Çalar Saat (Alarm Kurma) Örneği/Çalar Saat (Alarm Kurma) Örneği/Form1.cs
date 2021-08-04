using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalar_Saat__Alarm_Kurma__Örneği
{
    public partial class Form1 : Form
    {
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
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute  .ToString();

            if (comboBox1 .Text == label1 .Text && comboBox2 .Text == label2.Text)
            {
                timer1.Enabled = false ;

                MessageBox.Show("Uyanma Vakti Geldi!!!!!!!!!!!!!");
                // İstediğiniz müziği yolunu ekeleyerek çaldırabilirsiniz.
               // axWindowsMediaPlayer1.URL = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int j = 0;j< 60; j++)
            
            {
               comboBox2.Items.Add(j); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm Kuruldu.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
            MessageBox.Show("Alarm Durduruldu!!!!!");
            timer1.Enabled = true;
        }
    }
}
