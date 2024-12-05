using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._11._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayilar;
        char harf;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rasgele = new Random();
            StringBuilder olustur = new StringBuilder();
            for (int i = 1; i <= 8; i++)
            {
                sayilar = rasgele.Next(65,90);//aski tablosundaki büyük harfleri getirir
                harf = Convert.ToChar(sayilar);
                olustur.Append(harf);
            }
            label1.Text = DateTime.Now.Year+" " + olustur.ToString();


        }
    }
}
