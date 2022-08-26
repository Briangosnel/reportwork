using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace BiblioBook
{
    public partial class Form1 : Form
    {

        public static async Task<List<string>> booklist()
        {
                HttpClient client = new HttpClient()
                {
                    BaseAddress = new Uri(@"https://localhost:7105"),
                };
                var response = await client.GetAsync("/booklist");
                string str = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<string>>(str);
                return result;            
        }
        public static async Task<List<string>> personnames()
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync("/personnames");
            string str = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<string>>(str);
            return result;
        }




        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in await personnames())
            {
                cmbReader.Items.Add(s);
            }
            foreach (string s in await booklist())
            {
                lstBooks.Items.Add(s);
            }
            cmbReader.SelectedIndex = 0;
            lstBooks.SelectedIndex = 0;
            txtKol.Text = "7";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public async void updatelstInform()
        {
            lstInform.Items.Clear();
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync("/reports");
            string str = await response.Content.ReadAsStringAsync();
            var reportsstv = JsonConvert.DeserializeObject<List<string>>(str);
            foreach (string s in reportsstv)
            {
                lstInform.Items.Add(s);
            }
            lstInform.SelectedIndex = lstInform.Items.Count-1;
            if (lstInform.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnClear.Enabled = false;
            }
        }
        private void btnVisibleInform_Click(object sender, EventArgs e)
        {
            grbInform.Visible = false;
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            btnVisibleInform.Enabled = false;
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync("/deletereports");
            updatelstInform();
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync($"/deletereport?report={lstInform.Text}");
            lstInform.Items.Clear();
            updatelstInform();
        }

        private async void btnInform_Click(object sender, EventArgs e)
        {
            string statustemp = string.Empty;
            grbInform.Visible = true;
            btnRemove.Enabled = true;
            btnClear.Enabled = true;
            btnVisibleInform.Enabled = true;
            lstInform.Items.Clear();
            if (rdbStatus1.Checked)
                statustemp = rdbStatus1.Text;
            if (rdbStatus2.Checked)
                statustemp = rdbStatus2.Text;
            if (rdbStatus3.Checked)
                statustemp = rdbStatus3.Text;

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(@"https://localhost:7105"),
            };
            var response = await client.GetAsync($"/report?name={cmbReader.Text}&status={statustemp}&book={lstBooks.Text}&days={txtKol.Text}");
            string str = await response.Content.ReadAsStringAsync();
            updatelstInform();
        }
    }
    }
