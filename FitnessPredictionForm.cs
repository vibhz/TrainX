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
    public partial class FitnessPredictionForm : Form
    {
        private Button btnPredict;
        private ListBox lstWorkouts;

        private List<Workout> workouts;
        private List<CheatMeal> cheatMeals;
        private int workoutCount = 0;
        private int mealCount = 0;

        private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/Workout";

        public static User authenticatedUser = null;
        public static int uid = 0;

        private double currentWeight;

        public FitnessPredictionForm()
        {

            if (LoginForm.authenticatedUser != null)
            {
                authenticatedUser = LoginForm.authenticatedUser;
                uid = LoginForm.userid;
            }
            else
            {
                authenticatedUser = SignupForm.authenticatedUser;
                uid = SignupForm.userid;
            }
            currentWeight = authenticatedUser.Weight;


            workouts = new List<Workout>();
            cheatMeals= new List<CheatMeal>();
            lstWorkouts=new ListBox();
            loadWorkouts();
            loadMeals();
            InitializeComponent();



        }

        private async void loadMeals()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44332/apigateway/mealhistory");

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"?userid={uid}");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var mealHistory = JsonConvert.DeserializeObject<List<CheatMeal>>(responseBody);
                   // MessageBox.Show($"Mealdata:{mealHistory.Count}");
                    foreach (var cheatMeal in mealHistory)
                    {
                        CheatMeal cm = new CheatMeal
         (
             cheatMeal.MealName,
             cheatMeal.Description,
             cheatMeal.CalorieCount,
             cheatMeal.MealDate,
             cheatMeal.UserId

         );

                        cheatMeals.Add(cm);
                    }

                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private async void loadWorkouts()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44332/apigateway/workouthistory");

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"?userid={uid}");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var workoutHistory = JsonConvert.DeserializeObject<List<Workout>>(responseBody);
                    workoutCount = workoutHistory.Count;
                    lstWorkouts.Items.Clear();

                    // Use the workoutHistory data as needed
                    workouts.Clear();
                    foreach (var w in workoutHistory)
                    {

                        String a = w.ExerciseName + " |" + w.ExerciseType + " |" + w.Intensity + " |" + w.Equipment + " |" + w.Duration + " : " + "minutes\n";
                        lstWorkouts.Items.Add(a);
                        Console.WriteLine($"ExerciseName: {w.ExerciseName}");
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
                        workouts.Add( workout );


                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            }

        
       

        private void FitnessPredictionForm_Load(object sender, EventArgs e)
        {

        }
        int wid = 0;

        private async void btnAddWorkout_Click_1(object sender, EventArgs e)
        {
            int userid = 1;

            string exerciseName = txtWorkoutName.Text;
            double duration = double.Parse(txtDuration.Text);
            DateTime date = workoutDate.Value.Date;
            double caloriesBurn = double.Parse(caloriespermin.Text);
            wid = wid + 1;

            Workout workout = new Workout
          (

            wid,
            exerciseName,
              duration,
              date, 
              comboexerxiseType.SelectedItem.ToString(),
              comboIntensity.SelectedItem.ToString(),
              comboEquipments.SelectedItem.ToString(),
              caloriesBurn,
              userid





          );

            using (var httpClient = new HttpClient())
            {
                var serializedWorkout = JsonConvert.SerializeObject(workout);
                var content = new StringContent(serializedWorkout, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(BackendApiBaseUrl, content);
                    response.EnsureSuccessStatusCode();

                    // Show success message to the user
                    MessageBox.Show("Workout added successfully!");
                }
                catch (HttpRequestException ex)
                {
                    // Handle error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            txtWorkoutName.Clear();
            txtDuration.Clear();
            caloriespermin.Clear();
            comboexerxiseType.Items.Clear();
            comboIntensity.Items.Clear();
            comboEquipments.Items.Clear();
            loadWorkouts();



        }

        private void btnPredict_Click_1(object sender, EventArgs e)
        {
            if (workouts.Count == 0)
            {
                MessageBox.Show("Please add at least one workout before predicting.");
                return;
            }
            // Calculate total workout duration
            double totalDuration = 0.0;
            double totalcalburn = 0.0;

            foreach (Workout workout in workouts)
            {
                totalDuration += workout.Duration;
                totalcalburn += workout.CaloriesBurn;
            }
            // Perform prediction based on the workout pattern
            currentWeight = authenticatedUser.Weight;

            int cheatMealcount = cheatMeals.Count;
            double calcountmeal= 0.0;
            foreach (CheatMeal c in cheatMeals)
            {
                calcountmeal += c.CalorieCount;
            }
           // MessageBox.Show($"data: weight:{currentWeight} duration:{totalDuration} cal burn: {totalcalburn} mealCount:{cheatMealcount} calcount:{calcountmeal}");


            double predictedWeight = PredictFutureWeight(currentWeight,totalDuration,totalcalburn,cheatMealcount,calcountmeal);

            // Display the fitness status and weight prediction
            txtFitnessStatus.Text = GetFitnessStatus(currentWeight,totalDuration,cheatMealcount);
            txtWeightPrediction.Text = $"{predictedWeight} kg";


        }
       

        public static double PredictFutureWeight(double currentWeight, double workoutDuration, double caloriesBurnedPerMinute, int numberOfCheatMeals, double calorieCountPerCheatMeal)
        {
            double caloriesBurned = workoutDuration * caloriesBurnedPerMinute;

            // Typically, 3,500 calories burned result in approximately 1 pound of weight loss or gain
            double weightChange = (caloriesBurned - (numberOfCheatMeals * calorieCountPerCheatMeal)) / 3500;

            double futureWeight = currentWeight - weightChange;

            return futureWeight;
        }

        public static string GetFitnessStatus(double currentWeight, double workoutDuration, int numberOfCheatMeals)
        {
            // Define thresholds for fitness status based on your criteria
            double thresholdLow = 1500;  // Example threshold for low fitness level
            double thresholdMedium = 2500;  // Example threshold for medium fitness level

            // Calculate the total calories burned during the workout
            double caloriesBurned = workoutDuration * 10;  // Assuming 10 calories burned per minute of workout

            // Calculate the impact of cheat meals on fitness status
            double cheatMealImpact = numberOfCheatMeals * 500;  // Assuming 500 calories per cheat meal

            // Calculate the net calories (calories burned minus cheat meal impact)
            double netCalories = caloriesBurned - cheatMealImpact;

            // Determine the fitness status based on net calories and weight
            if (netCalories < thresholdLow)
            {
                return "Low Fitness Level";
            }
            else if (netCalories < thresholdMedium)
            {
                return "Medium Fitness Level";
            }
            else
            {
                return "High Fitness Level";
            }
        }


        private void FitnessPredictionForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
