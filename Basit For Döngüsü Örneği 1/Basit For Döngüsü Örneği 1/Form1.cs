using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_For_Döngüsü_Örneği_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // For döngüsü için i belirttik ve i yi 0 a eşitledik.
        // toplam değişkenini 0 a eşitleyerek for döngüsünden çıkan değeri ona kaydediceğiz.
        int i = 0;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // For döngüsü metod örneği
            for ( i=0 ; i < 6 ; i++)
            {
             // belirttiğimiz aralıktaki sayıları toplamak için kullandığımız yöntem
                toplam = toplam + i;
             // çıkan değerleri label ve listbox a yazdırma kodu
                label1.Text = toplam.ToString();
                listBox1.Items.Add(i);
                listBox2.Items.Add(toplam);
            }
        }
    }
}
