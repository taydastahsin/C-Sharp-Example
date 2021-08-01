using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Do_While_Döngüsü_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // İlk olarak döngünün dışında başlangıç terimini belirliyoruz.
            int i = 0;
            // Döngünün aralığını parantezin içine yazıyoruz.
            while (i<10)
            {
                //Döngünün sonucunu yazdırmak için listbox a ekliyoruz.
                listBox1.Items.Add(i);
                //Döngünün artış miktarını belirler.
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // İlk olarak döngünün dışında başlangıç terimini belirliyoruz.
            int j = 0;
            //Döngünün koşul kısmını içerir.
            do
            {
                //Döngünün sonucunu yazdırmak için listbox a ekliyoruz.
                listBox2.Items.Add(j);
                //Döngünün artış miktarını belirler.
                j = j+2;
            }
            // Döngünün aralığını parantezin içine yazıyoruz.
            //Dikkat etmenizi isterim burda döngüyü bitirmek için ";" kullandık.
            while (j < 15);
        }
    }
}
