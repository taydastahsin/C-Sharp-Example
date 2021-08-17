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

namespace Kütüphane_KayıtANDSilme_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Kütüphane;Integrated Security=True");
      private void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Kitaplar ",baglan );
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Kitap"].ToString());
                ekle.SubItems.Add(oku["Yazar"].ToString());
                ekle.SubItems.Add(oku["Sayfa"].ToString());

                listView1.Items.Add(ekle);

            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Kitaplar (id,AdSoyad,Kitap,Yazar,Sayfa) values ('"+textBox1 .Text.ToString ()+"','"+textBox2 .Text.ToString () +"','"+textBox3 .Text.ToString () +"','"+textBox4 .Text.ToString () +"','"+textBox5 .Text.ToString () +"')",baglan );
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();

        }
        int id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from Kitaplar Where id =(" + id + ")",baglan );
            komut.ExecuteNonQuery();
            
            baglan.Close();
            verilerigöster();
        }
    }
}
