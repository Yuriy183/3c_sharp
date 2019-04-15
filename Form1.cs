using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3c_sharp
{
    public partial class Form1 : Form
    {

        private int i = 0;
        public int I { get => i; set => i = value;}

        private int n = 3;
        public int N { get => n; set => n = value; }
        Vector[] vectors;


        public Form1()
        {
            InitializeComponent();
            vectors = new Vector[N];
            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector();
            }
        }
        


        private void btnRnd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            textBox1.Text = Convert.ToString(rnd.Next(0, 10));
            textBox2.Text = Convert.ToString(rnd.Next(0, 10));
            textBox3.Text = Convert.ToString(rnd.Next(0, 10));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (I < vectors.Length)
            {
                vectors[I] = new Vector();
                vectors[I].X = Convert.ToDouble(textBox1.Text);
                vectors[I].Y = Convert.ToDouble(textBox2.Text);
                vectors[I].Z = Convert.ToDouble(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Вы ввели числа");
            }
            I++;

            textBox4.Text += "Длина вектора a: " + vectors[0].GetLength();
            textBox4.Text += "Длина вектора b: " + vectors[1].GetLength();
            textBox4.Text += "Длина вектора c: " + vectors[2].GetLength();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (I < vectors.Length)
            {
                vectors[I] = new Vector();
                vectors[I].X = Convert.ToDouble(textBox1.Text);
                vectors[I].Y = Convert.ToDouble(textBox2.Text);
                vectors[I].Z = Convert.ToDouble(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Вы ввели числа");
            }
            I++;

            textBox4.Text += "Длина вектора a: " + vectors[0].GetLength();
            textBox4.Text += "Длина вектора b: " + vectors[1].GetLength();
            textBox4.Text += "Длина вектора c: " + vectors[2].GetLength();
        }
    }
}
