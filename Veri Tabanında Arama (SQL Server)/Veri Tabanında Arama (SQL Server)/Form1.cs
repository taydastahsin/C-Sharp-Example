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

namespace Veri_Tabanında_Arama__SQL_Server_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Bilgiler;Integrated Security=True");
        
        private void verilerigöster()
        {
            baglan.Open();
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("Select * from Kişiler",baglan );

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());

                listView1.Items.Add(ekle );

                
            }
            baglan.Close();

        }

        private void bul()
        {
            baglan.Open();


            SqlCommand komut = new SqlCommand("Select * from Kişiler where Ad like '% " + textBox1.Text + "% ' ", baglan);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());

                listView1.Items.Add(ekle);


            }
            baglan.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bul();
            listView1.Items.Clear();
        }

    }
}
