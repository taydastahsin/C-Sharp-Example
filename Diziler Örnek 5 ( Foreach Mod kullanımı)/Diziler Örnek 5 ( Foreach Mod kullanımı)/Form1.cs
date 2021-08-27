using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Örnek_5___Foreach_Mod_kullanımı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 5, 12, 26, 85, 165, 520,-25,-36,-158 };
            foreach (int sayı in sayılar)
            {
                if (sayı %2==0)
                {
                    listBox1.Items.Add(sayı);
                }
            }
        }
    }
}
