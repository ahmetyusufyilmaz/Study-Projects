using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> fiyatlar = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            fiyatlar.Add("Domates (1kg)", 10);
            fiyatlar.Add("Sivri Biber (1kg)", 12);
            fiyatlar.Add("Patlıcan (1kg)", 15);
            fiyatlar.Add("Soğan (1kg)", 8);
            fiyatlar.Add("Salatalık (1kg)", 10);
            fiyatlar.Add("Kıvırcık (1demet)", 8);
            fiyatlar.Add("Maydonoz (1demet)", 4);
            fiyatlar.Add("Sarımsak (1kg)", 12);
            fiyatlar.Add("Taze Fasulye (1kg)", 6);
            fiyatlar.Add("Havuç (1kg)", 5);
            fiyatlar.Add("Limon (1kg)", 7);
            fiyatlar.Add("Lahana (1kg)", 12);
            fiyatlar.Add("Patates (1kg)", 8);
            fiyatlar.Add("Havuç(1kg)", 5);
            fiyatlar.Add("Kırmızı Biber (1kg)", 11);
           

            foreach (var item in fiyatlar.Keys)
            {
                sebzeBox.Items.Add(item);
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            string secili = selectedSebzeBox.SelectedItem.ToString();
            selectedSebzeBox.Items.Remove(secili);
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            string secili = sebzeBox.SelectedItem.ToString();
            selectedSebzeBox.Items.Add(secili);
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            foreach (var item in selectedSebzeBox.Items)
            {
                int fiyat = fiyatlar[item.ToString()];
                toplam += fiyat;
            }
            label1.Text = "Toplam Tutar: "+toplam.ToString()+" TL";
        }
    }
    }

