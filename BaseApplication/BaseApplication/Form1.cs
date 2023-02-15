using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          await GetRequest();
        }

        async Task GetRequest()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("http://127.0.0.1:122/api/getTransactions");

            richTextBox1.Text = content;

        }
    }
}
