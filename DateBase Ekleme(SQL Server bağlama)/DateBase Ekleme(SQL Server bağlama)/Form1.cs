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

namespace DateBase_Ekleme_SQL_Server_bağlama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("");

        private void verigöster()
        {
            baglan.Open();
            //SQL serverin tablosunu çağırmak için 
            SqlCommand komut = new SqlCommand("Select * from Bilgiler",baglan );
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read() )
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems .Add ( oku["Soyad"].ToString());
                ekle.SubItems.Add (oku["İl"].ToString());
                ekle.SubItems.Add ( oku["Bölüm"].ToString());
                ekle.SubItems.Add (oku["Klüp"].ToString());

                listView1.Items.Add(ekle);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigöster();

        }
    }
}
