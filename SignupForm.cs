using Newtonsoft.Json;
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

namespace FitnessTracker
{
    public partial class SignupForm : Form
    {
        public static User authenticatedUser = null;
        public static int userid= 0;

        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private NumericUpDown numAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblWeight;
        private TextBox txtWeight;
        private Label lblHeight;
        private TextBox txtHeight;
        private Button btnSignup;

        private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/User";

        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            // Retrieve the values from the form fields
        
            // Validate the input fields before adding the cheat meal
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtWeight.Text) ||
                string.IsNullOrEmpty(txtHeight.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            string name = txtName.Text;
            int age = (int)numAge.Value;
            string gender = cmbGender.SelectedItem.ToString();
            double weight = double.Parse(txtWeight.Text);
            double height = double.Parse(txtHeight.Text);
            string username = usernametext.Text;
            string pw = passwordtext.Text;

            User user = new User {
                Name = name,
                Age=age,
                Gender=gender,
                Weight=weight,
                Height=height,
                Username=username,
                Password=pw
            };


            // Send the meal data to the backend microservice
            using (var httpClient = new HttpClient())
            {
                var serializedUser = JsonConvert.SerializeObject(user);
                var content = new StringContent(serializedUser, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(BackendApiBaseUrl, content);
                    //response.EnsureSuccessStatusCode();
                    // Show success message to the user
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var responseObject = JsonConvert.DeserializeAnonymousType(responseContent, new { Message = "", User = new User(),uid=0 });
                        authenticatedUser = responseObject.User;
                        userid = responseObject.uid;
                        MessageBox.Show($"SignUp successful. Welcome, {authenticatedUser.Name}!");

                        this.Hide();  // Hide the login form
                        mainForm mainForm = new mainForm();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        responseContent = await response.Content.ReadAsStringAsync();
                        ShowMessageBox("Signup Failed", responseContent);
                    }
                   
              

                }
                catch (HttpRequestException ex)
                {
                    // Handle error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
           




        }
        private static void ShowMessageBox(string title, string message)
        {
            // Show the message in a MessageBox
            System.Windows.Forms.MessageBox.Show(message, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void SignupForm_Load_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the login form
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
