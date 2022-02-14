using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double toplam = 0;
            int sayac = 1;
            int not,ortalama;
            while (sayac <= 10)
            {
                not = Convert.ToInt32(textBox1.Text);
                toplam = toplam + not;
                sayac = sayac + 1;
            }
            ortalama = toplam / 10;
            label2.Text = ortalama;
            listBox1.Items.Add(toplam);

         
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

