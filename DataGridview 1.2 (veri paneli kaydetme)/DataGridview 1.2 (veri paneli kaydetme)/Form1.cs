using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridview_1._2__veri_paneli_kaydetme_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "SıraNo:";
            dataGridView1.Columns[1].Name = "İsim";
            dataGridView1.Columns[2].Name = "Soyad";
            dataGridView1.Columns[3].Name = "Meslek";
            dataGridView1.Columns[4].Name = "İl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                int i = dataGridView1.Rows.Add();

                i = 0;

                dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
                dataGridView1.Rows[i].Cells[4].Value = textBox5.Text;



            }  
        }
    }
}
