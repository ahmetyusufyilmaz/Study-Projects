using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        int sayi1, sayi2, toplam;

        public Form1()
        {
            InitializeComponent();
        
        }

        private void cikarButton_Click(object sender, EventArgs e)
        {
            toplam = sayi1 - sayi2;
            sonucLabel.Text = "Sonuç= " + toplam.ToString();
        }

        private void carpButton_Click(object sender, EventArgs e)
        {
            toplam = sayi1 * sayi2;
            sonucLabel.Text = "Sonuç= " + toplam.ToString();
        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            toplam = sayi1 / sayi2;
            sonucLabel.Text = "Sonuç= " + toplam.ToString();
        }
       

        private void toplaButton_Click(object sender, EventArgs e)
        {
            toplam = sayi1 + sayi2;
            sonucLabel.Text = "Sonuç= " +toplam.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt32(textBox2.Text);
        }
    }
}
