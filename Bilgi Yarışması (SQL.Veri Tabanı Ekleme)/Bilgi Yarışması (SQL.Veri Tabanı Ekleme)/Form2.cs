using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilgi_Yarışması__SQL.Veri_Tabanı_Ekleme_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayaç = 0;
        int puan  = 0;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Bilgi Yarışması;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Soru1 ",baglan );
            SqlDataReader oku = komut.ExecuteReader();

            while (oku .Read ())
            {
                textBox1.Text = (oku["soru"].ToString());
                button1 .Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                label5 .Text = (oku["dogru"].ToString());

            }
            baglan.Close();
            sayaç++;
            label3.Text = sayaç.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true ;

            if (button1 .Text ==label5 .Text )
            {
                button1.BackColor = Color.Green;

                puan = puan + 10;
                label4.Text = puan.ToString();
                
            }
            else
            {
                button1.BackColor = Color.Red ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            if (button2.Text == label5.Text)
            {
                button2.BackColor = Color.Green;

                puan = puan + 10;
                label4.Text = puan.ToString();

            }
            else
            {
                button2.BackColor = Color.Red;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            if (button3.Text == label5.Text)
            {
                button3.BackColor = Color.Green;

                puan = puan + 10;
                label4.Text = puan.ToString();

            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            if (button4.Text == label5.Text)
            {
                button4.BackColor = Color.Green;

                puan = puan + 10;
                label4.Text = puan.ToString();

            }
            else
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayaç++;
            label3.Text = sayaç.ToString();

            button1.Enabled = true ;
            button2.Enabled = true ;
            button3.Enabled = true ;
            button4.Enabled = true ;
            button5.Enabled = false ;

            button1.BackColor  = Color .Silver;
            button2.BackColor = Color.Silver;
            button3.BackColor = Color.Silver;
            button4.BackColor = Color.Silver;




            if (sayaç == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Soru2 ", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    label5.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
                


            }
            if (sayaç == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Soru3 ", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    label5.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
                


            }
            if (sayaç == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Soru4 ", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    label5.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
                



            }
            if (sayaç == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from Soru5 ", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = (oku["soru"].ToString());
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    label5.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
                


            }
            if (sayaç == 6)
            {
                button5.Text = "Oyun Bitmiştir.";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }
    }
}
