using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_For_Döngüsü_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // for döngüsü ilk kısma başlangıç değeri ikinciye aralık üçüncüsü artış miktarı
            int i;
            for (i=0 ; i>10 ; i++)
            {
                listBox1.Items.Add(i); 
            }
        }
    }
}
