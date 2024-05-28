using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace ACTIVITY_6
{
    public partial class Form1 : Form

    {
        private HttpClient client = new HttpClient();
        private string baseUrl = "http://localhost/api.php";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            // GET Request
            HttpResponseMessage responseGet = await client.GetAsync(baseUrl);
            if (responseGet.IsSuccessStatusCode)
            {
                string responseContent = await responseGet.Content.ReadAsStringAsync();
                List<CaseData> cases = JsonConvert.DeserializeObject<List<CaseData>>(responseContent);

                dataGridView.DataSource = cases;
            }
            else
            {
                MessageBox.Show("GET Request Failed");
            }
        }


        private async void btnPost_Click_1(object sender, EventArgs e)
        {
            string caseNumber = txtCaseNumber.Text;
            string caseTitle = txtCaseTitle.Text;
            string caseType = txtCaseType.Text;
            string caseStatus = txtCaseStatus.Text;
            string attorneyName = txtAttorneyName.Text;
            string prosecutorName = txtProsecutorName.Text;

            // Separate attorney and prosecutor names
            string[] attorneyNames = attorneyName.Split(' ');
            string[] prosecutorNames = prosecutorName.Split(' ');

            // Check if names were correctly separated
            if (attorneyNames.Length < 2 || prosecutorNames.Length < 2)
            {
                MessageBox.Show("Please enter both first and last names for attorney and prosecutor.");
                return;
            }

            // POST Request
            var postData = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("case_number", caseNumber),
        new KeyValuePair<string, string>("case_title", caseTitle),
        new KeyValuePair<string, string>("case_type", caseType),
        new KeyValuePair<string, string>("case_status", caseStatus),
        new KeyValuePair<string, string>("attorney_fname", attorneyNames[0]),
        new KeyValuePair<string, string>("attorney_lname", attorneyNames[1]),
        new KeyValuePair<string, string>("prosecutor_fname", prosecutorNames[0]),
        new KeyValuePair<string, string>("prosecutor_lname", prosecutorNames[1])
    });

            HttpResponseMessage responsePost = await client.PostAsync(baseUrl, postData);
            if (responsePost.IsSuccessStatusCode)
            {
                string responseContent = await responsePost.Content.ReadAsStringAsync();
                MessageBox.Show("POST Request Successful");
                btnGet_Click(sender, e); // Refresh the data grid
            }
            else
            {
                string errorContent = await responsePost.Content.ReadAsStringAsync();
                MessageBox.Show("POST Request Failed: " + errorContent);
            }
        }

        public class CaseData
        {
            public string case_number { get; set; }
            public string case_title { get; set; }
            public string case_status { get; set; }

            public string case_type { get; set; }
            public string attorney_name { get; set; }
            public string prosecutor_name { get; set; }
        }
    }
}