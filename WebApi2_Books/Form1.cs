using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace WebApi2_Books
{
    public partial class Form1 : Form
    {
        private string URI = "";

        public Form1()
        {
            InitializeComponent();
        }

        public async void GetAllBooks()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var BooksJsonString = await response.Content.ReadAsStringAsync();
                        gdvDados.DataSource = JsonConvert.DeserializeObject<Books[]>(BooksJsonString).ToList();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            GetAllBooks();
        }
    }
}