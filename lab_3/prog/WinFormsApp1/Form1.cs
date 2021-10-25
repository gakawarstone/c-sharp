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
                double x, y, z;
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);

                double answ;
                double[] i = { func(x), y, z };
                double maxValue = i.Max();
                double[] a = { func(x), y };
                double minValue = a.Max();

                answ = (maxValue / minValue) + 5;

                label5.Text = Convert.ToString(answ);

            } catch
            {
                label5.Text = "ERRROR";
            }
        }
    }
}
