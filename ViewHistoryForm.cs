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
using System.Xml.Linq;

namespace FitnessTracker
{
    public partial class ViewHistoryForm : Form
    {
        private DataGridView dgvWorkouts;
        //private int userId = 0;
        private List<Workout> workouts = new List<Workout>();
        public static User authenticatedUser = null;
        public static int uid = 0;

        //private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/"; 
        //static HttpClient httpClient = new HttpClient();

        DateTime currentDate = DateTime.Now;

        public ViewHistoryForm()
        {

            if (mainForm.authenticatedUser != null)
            {
                authenticatedUser = mainForm.authenticatedUser;
                uid = LoginForm.userid;

            }

            InitializeComponent();

            PopulateWorkoutHistory();



        }

        private async void PopulateWorkoutHistory()
        {


            dgvWorkouts.ColumnCount = 7;
            dgvWorkouts.Columns[0].Name = "Workout Name";
            dgvWorkouts.Columns[1].Name = "Duration";
            dgvWorkouts.Columns[2].Name = "Exercise Type";
            dgvWorkouts.Columns[3].Name = "Equipment";
            dgvWorkouts.Columns[4].Name = "Intensity";
            dgvWorkouts.Columns[5].Name = "Calories Burned ";
            dgvWorkouts.Columns[6].Name = "Date";

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44332/apigateway/workouthistory");

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"?userid={uid}");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var workoutHistory = JsonConvert.DeserializeObject<List<Workout>>(responseBody);
                    workouts.Clear();

                    // Use the workoutHistory data as needed
                    foreach (var w in workoutHistory)
                    {
                        Workout workout = new Workout
                             (
                                 w.ExerciseId,
                                 w.ExerciseName,
                                 w.Duration,
                                 w.WorkoutDate,
                                 w.ExerciseType,
                                 w.Intensity,
                                 w.Equipment,
                                 w.CaloriesBurn,
                                 w.UserId

                             );
                        workouts.Add(workout);


                        dgvWorkouts.Rows.Add(w.ExerciseName, w.Duration, w.ExerciseType, w.Equipment, w.Intensity, w.CaloriesBurn, w.WorkoutDate);
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

        }

        private void ViewHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvWorkouts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewHistoryForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvWorkouts.Rows.Clear();
            lastmonthchecked.Checked = false;
            lastweekchecked.Checked = false;
            PopulateWorkoutHistory();

        }

        private void lastweekchecked_CheckedChanged(object sender, EventArgs e)
        {
            if (lastweekchecked.Checked)
            {
                if (comboBox1.SelectedItem != null)
                {
                    int weeks = int.Parse(comboBox1.SelectedItem.ToString()); // Number of weeks to filter
                    filterbyWeeks(weeks);
                    CalculateTotalCaloriesBurnedForWeeks(weeks);
                }
                else
                {
                    // ComboBox does not have a selected item
                    MessageBox.Show("Please Select filter count");

                }

            }
        }

        private void CalculateTotalCaloriesBurnedForWeeks(int numberOfWeeks)
        {
            double totalCaloriesBurned = 0.0;
            DateTime currentDate = DateTime.Now;

            for (int i = 0; i < numberOfWeeks; i++)
            {
                DateTime startOfWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek).AddDays(-7 * i);
                // var filteredworkouts = workoutHistory.Where(w => w.WorkoutDate >= filterStartDate && w.WorkoutDate <= currentDate);

                foreach (Workout workout in workouts)
                {
                    if (workout.WorkoutDate >= startOfWeek && workout.WorkoutDate <= startOfWeek.AddDays(6))
                    {
                        totalCaloriesBurned += workout.Duration * workout.CaloriesBurn;
                    }
                }
            }
            textCaleries.Text = $"{totalCaloriesBurned} caleries";


            //    return totalCaloriesBurned;
        }
        private void CalculateTotalCaloriesBurnedForMonths(int numberOfMonths)
        {
            double totalCaloriesBurned = 0;
            DateTime currentDate = DateTime.Now;



            for (int i = 0; i < numberOfMonths; i++)
            {
                DateTime startOfMonth = currentDate.AddMonths(-i).AddDays(-currentDate.Day + 1);

                foreach (Workout workout in workouts)
                {
                    if (workout.WorkoutDate.Year == startOfMonth.Year && workout.WorkoutDate.Month == startOfMonth.Month)
                    {
                        totalCaloriesBurned += workout.Duration * workout.CaloriesBurn;
                    }
                }
            }

            textCaleries.Text = $"{totalCaloriesBurned} caleries";
        }



        private void filterbyWeeks(int weeks)
        {
            dgvWorkouts.Rows.Clear();

            DateTime filterStartDate = currentDate.AddDays(-7 * weeks);

            // Filter the workout history based on the week range
            var filteredworkouts = workouts.Where(w => w.WorkoutDate >= filterStartDate && w.WorkoutDate <= currentDate);

            // Add rows to the DataGridView with filtered workout history data
            foreach (var w in filteredworkouts)
            {
                dgvWorkouts.Rows.Add(w.ExerciseName, w.Duration, w.ExerciseType, w.Equipment, w.Intensity, w.CaloriesBurn, w.WorkoutDate);
            }
        }

        private void lastmonthchecked_CheckedChanged(object sender, EventArgs e)
        {
            if (lastmonthchecked.Checked)
            {
                if (comboBox1.SelectedItem != null)
                {
                    int weeks = int.Parse(comboBox1.SelectedItem.ToString()); // Number of weeks to filter
                    filterbyMonths(weeks);
                    CalculateTotalCaloriesBurnedForMonths(weeks);
                }
                else
                {
                    // ComboBox does not have a selected item
                    MessageBox.Show("Please Select filter count");

                }



            }
        }

        private void filterbyMonths(int weeks)
        {
            dgvWorkouts.Rows.Clear();

            DateTime filterStartDate = currentDate.AddMonths(-weeks).AddDays(1);
            DateTime filterEndDate = currentDate;

            // Filter the workout history based on the month range
            var filteredworkouts = workouts.Where(w => w.WorkoutDate >= filterStartDate && w.WorkoutDate <= filterEndDate);

            // Add rows to the DataGridView with filtered workout history data
            foreach (var w in filteredworkouts)
            {
                dgvWorkouts.Rows.Add(w.ExerciseName, w.Duration, w.ExerciseType, w.Equipment, w.Intensity, w.CaloriesBurn, w.WorkoutDate);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int weeks = int.Parse(comboBox1.SelectedItem.ToString()); // Number of weeks to filter

            if (lastweekchecked.Checked)
            {
                filterbyWeeks(weeks);
                CalculateTotalCaloriesBurnedForWeeks(weeks);

            }
            else if (lastmonthchecked.Checked)
            {
                filterbyMonths(weeks);
                CalculateTotalCaloriesBurnedForMonths(weeks);

            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {


            XElement xmlData = new XElement("Workout",
                new XElement("UserId", uid));

            string xmlString = xmlData.ToString();


            string apiUrl = "https://localhost:44332/apigateway/deleteByUserId";

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));

                HttpContent content = new StringContent(xmlString, Encoding.UTF8, "application/xml");
                HttpResponseMessage response = httpClient.PostAsync(apiUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Request successful. Workouts deleted.");
                    dgvWorkouts.Rows.Clear();
                    workouts.Clear();

                }
                else
                {
                    MessageBox.Show($"Request failed. Status code: {response.StatusCode}");
                }
            }

            
        }
    }
}
