using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public double func(double x)
        {
            return x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x0, xk, dx, a;
                x0 = Convert.ToDouble(textBox1.Text);
                xk = Convert.ToDouble(textBox2.Text);
                dx = Convert.ToDouble(textBox3.Text);
                a = Convert.ToDouble(textBox4.Text);

                double x = x0;

                label5.Text = Convert.ToString(x0);

            } catch
            {
                label5.Text = "ERRROR";
            }
        }
    }
}
