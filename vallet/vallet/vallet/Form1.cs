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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string http = "https://kurs.zakon.kz/data/avrg.json";
            WebRequest req = (WebRequest)WebRequest.Create(@"" + http);
            WebResponse resp = (WebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string tex = sr.ReadToEnd();
            JArray a = JArray.Parse(tex);
            label_usd_sell.Text = a[0]["sell"].ToString();
            label_eur_sell.Text = a[1]["sell"].ToString();
            label_cny_sell.Text = a[2]["sell"].ToString();
            label_kgs_sell.Text = a[3]["sell"].ToString();
            label_rub_sell.Text = a[4]["sell"].ToString();
            label_gbp_sell.Text = a[5]["sell"].ToString();
            label_jpy_sell.Text = a[6]["sell"].ToString();

            label_usd_buy.Text = a[0]["buy"].ToString();
            label_eur_buy.Text = a[1]["buy"].ToString();
            label_cny_buy.Text = a[2]["buy"].ToString();
            label_kgs_buy.Text = a[3]["buy"].ToString();
            label_rub_buy.Text = a[4]["buy"].ToString();
            label_gbp_buy.Text = a[5]["buy"].ToString();
            label_jpy_buy.Text = a[6]["buy"].ToString();
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
            label_usd_sell.Text = a[0]["sell"].ToString();
            label_eur_sell.Text = a[1]["sell"].ToString();
            label_cny_sell.Text = a[2]["sell"].ToString();
            label_kgs_sell.Text = a[3]["sell"].ToString();
            label_rub_sell.Text = a[4]["sell"].ToString();
            label_gbp_sell.Text = a[5]["sell"].ToString();
            label_jpy_sell.Text = a[6]["sell"].ToString();

            label_usd_buy.Text = a[0]["buy"].ToString();
            label_eur_buy.Text = a[1]["buy"].ToString();
            label_cny_buy.Text = a[2]["buy"].ToString();
            label_kgs_buy.Text = a[3]["buy"].ToString();
            label_rub_buy.Text = a[4]["buy"].ToString();
            label_gbp_buy.Text = a[5]["buy"].ToString();
            label_jpy_buy.Text = a[6]["buy"].ToString();
        }
    }
}
