using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bölünen_Sayı_ile_Toplamları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int tambölünen = 0;
            for (int i=1;i<=100;i++)
            {
                if(i % 7==0)
                {
                    tambölünen++;
                    label3.Text = tambölünen.ToString();

                    toplam = toplam + i;
                    label4.Text = toplam.ToString();


                }
            }

        }
    }
}
