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

namespace DataGridview_3__Ekleme_Silme_Güncelleme_Arama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Kütüphane;Integrated Security=True");
        
        private void kitaplar(string veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri,baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kitaplar("Select * From Kitaplar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Kitaplar (id,Kitap,Yazar,Yayınevi,Sayfa) values (@idi,@kitapi,@yazari,@yayınyeri,@sayfası)",baglan );
            komut.Parameters.AddWithValue ("@idi", textBox1.Text);
            komut.Parameters.AddWithValue("@kitapi", textBox2.Text);
            komut.Parameters.AddWithValue("@yazari", textBox3.Text);
            komut.Parameters.AddWithValue("@yayınyeri", textBox4.Text);
            komut.Parameters.AddWithValue("@sayfası", textBox5.Text);

            komut.ExecuteNonQuery();
            kitaplar("Select * from Kitaplar");
            baglan.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
        }
        int a = 0;
        private void button3_Click(object sender, EventArgs e)
        {
          
            a++;
            if (a == 1)
            {
                MessageBox.Show("Lütfen silmek  istediğiniz kitabın sayısını giriniz!!");
            }
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from Kitaplar where id = @idi",baglan );
            komut.Parameters.AddWithValue("@idi", textBox1.Text);
            komut.ExecuteNonQuery();
            kitaplar("Select * from Kitaplar");
            baglan.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
        int b = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            b++;
            if (b == 1)
            {
                MessageBox.Show("Lütfen aramak  istediğiniz kitabın adını giriniz!!");
            }

            baglan.Open();

            SqlCommand komut = new SqlCommand("Select * from Kitaplar where Kitap like '%"+textBox2 .Text +"%'",baglan );
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
