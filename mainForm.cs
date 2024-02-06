using Newtonsoft.Json;
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
    public partial class mainForm : Form
    {
        private TabControl tabControl1;
        private TabPage tabPageWorkout;
        private TabPage tabPageCheatMeal;
        private Button btnAddWorkout;
        private Button btnAddCheatMeal;
        public static User authenticatedUser = null;
        private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/login";

        public mainForm()
        {

            if(authenticatedUser == null)
            {
                if (LoginForm.authenticatedUser != null)
                {
                    authenticatedUser = LoginForm.authenticatedUser;
                }
                else { 
                authenticatedUser= SignupForm.authenticatedUser;
                }
            }
            InitializeComponent();


            loadUserInfo();
      }

        private async void loadUserInfo()
        {
            //                    private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/login";


            string username = authenticatedUser.Username;
            string pw = authenticatedUser.Password;
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
                        var responseObject = JsonConvert.DeserializeAnonymousType(responseContent, new { Message = "", User = new User(), uid = 0 });
                        authenticatedUser = responseObject.User;
                       
                        textName.Text = authenticatedUser.Name;
                        textAge.Text = "" + authenticatedUser.Age;
                        textGender.Text = authenticatedUser.Gender;
                        textHeight.Text = "" + authenticatedUser.Height;
                        textWeight.Text = "" + authenticatedUser.Weight;
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Error!. Please try again.");
                    }

                }
                catch (HttpRequestException ex)
                {
                    // Handle error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }











         
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void tabPageWorkout_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewMealHistoryForm viewMealHistoryForm = new ViewMealHistoryForm();
            viewMealHistoryForm.ShowDialog();
        }
      

        private void btnAddWorkout_Click_1(object sender, EventArgs e)
        {
            // Add workout logic here
            WorkoutForm workoutForm = new WorkoutForm();
            
            if (workoutForm.ShowDialog() == DialogResult.OK)
            {
               
                string exerciseName = workoutForm.ExerciseName;
                string duration = workoutForm.Duration;

                // Perform the logic to add the workout using the entered exercise name and duration
                // You can customize this part based on your specific requirements

                MessageBox.Show($"Workout added: Exercise Name - {exerciseName}, Duration - {duration}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewHistoryForm  viewHistoryForm = new ViewHistoryForm();
            viewHistoryForm.ShowDialog();
        }

        private void btnAddCheatMeal_Click_1(object sender, EventArgs e)
        {
            CheatMealForm cheatMealForm = new CheatMealForm();
            if (cheatMealForm.ShowDialog() == DialogResult.OK)
            {
                string mealName = cheatMealForm.MealName;
                string description = cheatMealForm.Description;

                // Perform the logic to add the cheat meal using the entered meal name and description
                // You can customize this part based on your specific requirements

                MessageBox.Show($"Cheat meal added: Meal Name - {mealName}, Description - {description}");
            }

        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BMICalculatorForm bMICalculatorForm = new BMICalculatorForm();
            bMICalculatorForm.ShowDialog();
            loadUserInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FitnessPredictionForm fitnessPredictionForm = new FitnessPredictionForm();  
            fitnessPredictionForm.ShowDialog();
        }

        private void tabPageUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm=new UpdateForm();
            updateForm.ShowDialog();
            loadUserInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Show the login screen or entry point form
            authenticatedUser = null;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close the main form (optional)
            this.Close();
        }
    }
}
