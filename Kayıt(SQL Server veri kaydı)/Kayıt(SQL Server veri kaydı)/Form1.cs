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

namespace Kayıt_SQL_Server_veri_kaydı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Kayıt Etme(C# Veri Kaydı);Integrated Security=True");
       
        private void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Kayıt",baglan );
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString ());
                ekle.SubItems.Add(oku["Semt"].ToString ());

                listView1.Items.Add(ekle);
                
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kaydet = new SqlCommand(" Insert into Kayıt (AdSoyad,Firma,Semt) Values ('"+textBox1 .Text.ToString ()+"','"+ textBox2 .Text.ToString ()+ "','"+ comboBox1 .Text .ToString ()+"')",baglan );
            kaydet.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();

            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }
    }
}
