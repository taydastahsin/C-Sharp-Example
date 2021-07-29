using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Atölyesi__MenuStrip_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Film, Brian O'Conner (Paul Walker), Dominic Toretto (Vin Diesel) ve Mia Toretto'nun (Brewster) 100 milyon dolar çalmak için bir soygun planı yapmalarıyla başlar. Hemen ardından iş adamı Hernan Reyes (Joaquim de Almeida) ve DEA ajanı Luke Hobbs (Johnson) onların tutuklanmaları için iş başına geçerler.";
            listBox1.Items .Add ("Hızlı ve Öfkeli 1");
            listBox2.Items.Add(toolStripComboBox1.Text); 

        }
    }
}
