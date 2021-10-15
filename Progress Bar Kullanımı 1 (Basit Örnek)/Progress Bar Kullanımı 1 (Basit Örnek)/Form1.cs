using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar_Kullanımı_1__Basit_Örnek_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // progres bar'ın max seviyesini belirler
            progressBar1.Maximum = 10001;

            int sayı;
            // sayı değişkeniyle barın artışını for döngüsüyle kontrol ediyoruz.
            for (sayı=0; sayı <= 10000; sayı ++)
            {
                progressBar1.Value = sayı;
                listBox1.Items.Add(sayı);

            }
        }
    }
}
