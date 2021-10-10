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

namespace DataGridview_2__Ekleme_Silme__Kütüphane___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Kütüphane;Integrated Security=True");
      
        private void verilerigöster(string veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri,baglan );

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster("Select * From Kitaplar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Kitaplar (id,Kitap,Yazar,Yayınevi,Sayfa) values (@idi,@kitapi,@yazari,@yayınyeri,@sayfası)",baglan );

            komut.Parameters.AddWithValue("@idi", textBox1.Text);
            komut.Parameters.AddWithValue("@kitapi", textBox2.Text);
            komut.Parameters.AddWithValue("@yazari", textBox3.Text);
            komut.Parameters.AddWithValue("@yayınyeri", textBox4.Text);
            komut.Parameters.AddWithValue("@sayfası", textBox5.Text);

            komut.ExecuteNonQuery();
            verilerigöster("Select * from Kitaplar");

            baglan.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("delete from Kitaplar where id =@idi",baglan );
            komut.Parameters.AddWithValue("@idi", textBox6.Text);
            komut.ExecuteNonQuery();
            verilerigöster("Select * from Kitaplar");

            baglan.Close();
            textBox6.Clear();

        }
    }
}
