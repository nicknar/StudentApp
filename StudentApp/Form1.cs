using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IEnumerable<jobs> baseQuery, currentQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Splash splash = new Splash();
            splash.Show();
            string json = new WebClient().DownloadString(@"https://data.cityofnewyork.us/Business/NYC-Jobs/kpav-sd4t");
            json = new WebClient().DownloadString(@"http://data.cityofnewyork.us/resource/99br-frp6.json");

            var jobs = JsonConvert.DeserializeObject<List<jobs>>(json);
            baseQuery = from j in jobs orderby j.agency select j;
            currentQuery = baseQuery;

            splash.Hide();

        }
        public void displayList(string borough)
        {
            currentQuery = baseQuery;
            currentQuery = from j in currentQuery where j.borough_community.Contains(borough) select j;
            List<string> id = new List<string>();
            listBox1.Items.Clear();
            foreach (var j in currentQuery)
            {
                if (!id.Contains(j.agency))
                {
                    listBox1.Items.Add(j.agency);
                    id.Add(j.agency);
                }
            }
            MessageBox.Show(currentQuery.Count() + " jobs found");

        }
        private void rbtnq_Click(object sender, EventArgs e)
        {
            displayList("Queens");
        }

        private void rbtnm_Click(object sender, EventArgs e)
        {
            displayList("Manhattan");
        }

        private void rbtmbx_Click(object sender, EventArgs e)
        {
            displayList("Bronx");
        }

        private void rbtnbn_Click(object sender, EventArgs e)
        {
            displayList("Brooklyn");
        }

        private void rbtnst_Click(object sender, EventArgs e)
        {
            displayList("Staten Island");
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            currentQuery = baseQuery;
            currentQuery = from j in currentQuery where j.agency.Equals(listBox1.Text) select j;
            string lt = "", lg = "";
            string phone = "",site= "";
            
            foreach (var j in currentQuery)
            {
                lt = j.location_1.ToList()[1].ToString().Split(',')[1].Substring(1, 10);
                lg = j.location_1.ToList()[2].ToString().Split(',')[1].Substring(1, 10);
                phone = j.contact_number;
                site = j.site_name;
            }
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + lg + "," + lt + "&zoom=13&size=200x200&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
            requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/streetview?size=200x200&location=" + lg + ","+ lt + "&heading=235&sensor=false");
            repsonsePic = requestPic.GetResponse();
            map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox2.Image = map;

            label2.Text = phone;
            label4.Text = site;
            
        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
