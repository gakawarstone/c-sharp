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

        public double func(double x, double a)
        {
            double b = 2;
            return x + Math.Sqrt(Math.Abs(Math.Pow(x, 3) + a - b*Math.Exp(x)));
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
                while (x <= (xk + dx / 2))
                {
                    double y = func(x, a);
                    label6.Text += $"x = {x};\ny={y}\n";

                    x = x + dx;
                }

            } catch
            {
                label6.Text = "ERRROR";
            }
        }
    }
}
