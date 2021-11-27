using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using Newtonsoft.Json.Linq;

namespace vallet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] vallets = { "KZT" ,"USD", "EUR", "CNY", "KGS", "RUB", "GBP", "JPN" };

            comboBox1.Items.AddRange(vallets);
            comboBox2.Items.AddRange(vallets);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string http = "https://kurs.zakon.kz/data/avrg.json";
            WebRequest req = (WebRequest)WebRequest.Create(@"" + http);
            WebResponse resp = (WebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string tex = sr.ReadToEnd();
            JArray a = JArray.Parse(tex);
            double usd = (double)a[0]["sell"];
            double answ = Convert.ToDouble(textBox1.Text) / usd;
            textBox2.Text = answ.ToString("0.00");
        }
    }
}
