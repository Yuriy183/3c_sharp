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
        Vector vector = new Vector();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vector.X = Convert.ToDouble(textBox1.Text);
            vector.Y = Convert.ToDouble(textBox2.Text);
            vector.Z = Convert.ToDouble(textBox3.Text);
            textBox4.Text = vector.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
