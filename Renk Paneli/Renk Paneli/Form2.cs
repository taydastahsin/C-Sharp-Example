using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renk_Paneli
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1 .Text =="Mavi") {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " renk : "+ "güvenirliği, sadakati, sakinliği, uyumu, huzuru, sevgiyi ve zekayı temsil eder.";

                button2.BackColor = Color.Blue;
                
            }

            if (comboBox1.Text == "Sarı")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " renk : " + " sıcaklığı, pozitifliği, neşeyi, enerjiyi ve mutluluğu temsil eder.";

                button2.BackColor = Color.Yellow;
            }

            if (comboBox1.Text == "Kırmızı")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " renk : " + "dikkat çekici ,iştah açıcı bir renk ,güçlü ve enerjik ,sevginin, hatta aşkın, tutkunun temsilcisidir.";

                button2.BackColor = Color.Red;
            }

            if (comboBox1.Text == "Yeşil")
            {
                label3.Text = textBox1.Text + " " + comboBox1.Text + " renk : " + "tazeliği, dengeyi, pozitifliği, zenginliği, sakinliği, doğallığı ve üretkenliği temsil eder.";

                button2.BackColor = Color.Green;
            }

          
            label3.ForeColor = Color.DarkBlue;
        }
    }
}
