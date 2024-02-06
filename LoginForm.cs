using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace FitnessTracker
{
    public partial class LoginForm : Form
    {
        private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/login";
        public static User authenticatedUser = null;
        public static int userid = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the login form
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text;
            string pw = passwordtext.Text;
            User user = new User
            {                
                Username = username,
                Password = pw
            };


            // Send the meal data to the backend microservice
            using (var httpClient = new HttpClient())
            {
                var serializedUser = JsonConvert.SerializeObject(user);
                var content = new StringContent(serializedUser, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(BackendApiBaseUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();


                    if (response.IsSuccessStatusCode)
                    {
                        // Login successful
                        var responseObject = JsonConvert.DeserializeAnonymousType(responseContent, new { Message = "", User = new User(),uid=0 });
                        authenticatedUser = responseObject.User;
                        userid = responseObject.uid;
                        MessageBox.Show($"Login successful. Welcome, {authenticatedUser.Name}!");

                        this.Hide();  // Hide the login form
                        mainForm mainForm = new mainForm();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }

                }
                catch (HttpRequestException ex)
                {
                    // Handle error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
            }
}
