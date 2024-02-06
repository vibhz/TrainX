using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class UpdateForm : Form
    {
        public static User authenticatedUser = null;
        public static int uid = 0;
        public UpdateForm()
        {
           
                if (mainForm.authenticatedUser != null)
                {
                    authenticatedUser = mainForm.authenticatedUser;
                    uid = LoginForm.userid;

                }
               
            
            InitializeComponent();
            loadBMIdata();

        }

        private void loadBMIdata()
        {
            txtName.Text =authenticatedUser.Name;
            txtAge.Text=""+authenticatedUser.Age;
            txtHeight.Text = "" + authenticatedUser.Height;
            txtWeight.Text = "" + authenticatedUser.Weight;
            if (authenticatedUser.Gender == "male")
            {
                cmbGender.SelectedIndex = 0;
            }
            else {
                cmbGender.SelectedIndex = 1;
            }
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {

                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://localhost:44332/apigateway/updateuser");

                    int userId = uid;
                    double Height = double.Parse(txtHeight.Text);
                    double Weight = double.Parse(txtWeight.Text);
                    string Name = txtName.Text;
                    int Age = int.Parse(txtAge.Text);
                    string Gender = cmbGender.SelectedItem.ToString();


                    HttpResponseMessage response = await httpClient.GetAsync($"?userId={userId}&uName={Name}&uAge={Age}&uGender={Gender}&uHeight={Height}&uWeight={Weight}");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);

                    // var workoutHistory = JsonConvert.DeserializeObject<List<Workout>>(responseBody);




                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
