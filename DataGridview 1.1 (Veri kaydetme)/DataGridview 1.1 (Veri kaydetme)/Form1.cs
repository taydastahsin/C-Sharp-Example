using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridview_1._1__Veri_kaydetme_
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

                dataGridView1.Rows[i].Cells[0].Value = 1;
                dataGridView1.Rows[i].Cells[1].Value = "Tahsin";
                dataGridView1.Rows[i].Cells[2].Value = "Taydaş";
                dataGridView1.Rows[i].Cells[3].Value = "Yazılıım";
                dataGridView1.Rows[i].Cells[4].Value = "İstanbul";
            }

            if (a == 2)
            {
                int i = dataGridView1.Rows.Add();
                i = 1;

                dataGridView1.Rows[i].Cells[0].Value = 2;
                dataGridView1.Rows[i].Cells[1].Value = "Mustafa";
                dataGridView1.Rows[i].Cells[2].Value = "Gündoğdu";
                dataGridView1.Rows[i].Cells[3].Value = "Siber Güvenlik";
                dataGridView1.Rows[i].Cells[4].Value = "Bolu";
            }
        }
    }
}
