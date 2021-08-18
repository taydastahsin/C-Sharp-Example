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

namespace Gayrimenkul_Kayıt_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0QQE4BG;Initial Catalog=Gayrimenkul KayıtDefteri;Integrated Security=True");

        private void verilerigöster()
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("Select *from Kayıt", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Site"].ToString());
                ekle.SubItems.Add(oku["SatKira"].ToString());
                ekle.SubItems.Add(oku["OdaSayısı"].ToString());
                ekle.SubItems.Add(oku["Metrekare"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["Blok"].ToString());
                ekle.SubItems.Add(oku["No"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Notlar"].ToString());

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
            SqlCommand komut = new SqlCommand("insert into Kayıt(id,Site,SatKira,OdaSayısı,Metrekare,Fiyat,Blok,No,AdSoyad,Telefon,Notlar) values ('" + textBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3 .Text.ToString() + "','"
                + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox9.Text.ToString() + "','"
                + textBox8.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
           
        }

        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            // listview olaylar kısmından double click seçilmeli unutulmamalı!!!!!!!
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from Kayıt where id =("+ id +")",baglan  );
            komut.ExecuteNonQuery();
            baglan.Close();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox2 .Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3 .Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox1 .Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox10.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update Kayıt set id='"+textBox1 .Text .ToString ()+ "',Site='" + comboBox1 .Text.ToString() + "'," +
                "SatKira='" + comboBox3 .Text.ToString() + "',OdaSayısı='" + textBox4.Text.ToString() + "',Metrekare='" + textBox5.Text.ToString() + "'," +
                "Fiyat='" + textBox6.Text.ToString() + "',Blok='" + comboBox1 .Text.ToString() + "',No='" + textBox7.Text.ToString() + "'," +
                "AdSoyad='" + textBox10.Text.ToString() + "',Telefon='" + textBox9.Text.ToString() + "',Notlar='" + textBox8.Text.ToString() + "' where id="+ id +"",baglan );

            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (comboBox2.Text == "Zambak")
            {
                button8.BackColor = Color.Silver ;
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;

                button5.ForeColor = Color.White;
            }
            if (comboBox2.Text == "Papatya")
            {
                button8.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Blue;
                button7.BackColor = Color.Silver;

                button6.ForeColor = Color.White;

            }
            if (comboBox2.Text == "Gül")
            {
                button8.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                button7.BackColor = Color.Blue;

                button7.ForeColor = Color.White;

            }
            if (comboBox2.Text == "Menekşe")
            {
                button8.BackColor = Color.Blue;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
                button7.BackColor = Color.Silver;

                button8.ForeColor = Color.White;

            }
        }
    }
}
