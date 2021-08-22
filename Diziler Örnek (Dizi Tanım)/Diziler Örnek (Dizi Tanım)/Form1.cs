using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek__Dizi_Tanım_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Haftanın günlerini sıraladık
            int sayı;
            //Diziyi oluşturup kaç eleman olcağını yazdık
            string[] day = new string[7];
            //Dizinin elemanlarını oluşturduk
            day[0] = "Pazartesi";
            day[1] = "Salı";
            day[2] = "Çarşamba";
            day[3] = "Perşembe";
            day[4] = "Cuma";
            day[5] = "Cumartesi";
            day[6] = "Pazar";

         sayı = Convert.ToInt32(textBox1.Text);
            //Texbox dan gelen sayı ile diziyi eşleştirdik
            label1.Text = day[sayı];

        }
    }
}
