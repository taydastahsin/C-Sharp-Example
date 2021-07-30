using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.amazon.com.tr");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.facebook.com.tr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.twiter.com.tr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.instagram.com.tr");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.hepsiburada.com.tr");
        }
    }
}
