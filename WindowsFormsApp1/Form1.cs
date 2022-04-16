using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            int sayi1 = 0;
            int sayi2 = 1;
            int fibonacci;

            int kacaKadar = Convert.ToInt32(textBox1.Text);

            listBox1.Items.Add(sayi1);
            listBox1.Items.Add(sayi2);

            for ( int i = 1; i < kacaKadar; i++)
            {
                fibonacci = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = fibonacci;

                listBox1.Items.Add(fibonacci);
            }
        }
    }
}
