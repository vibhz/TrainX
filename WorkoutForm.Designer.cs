using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace FitnessTracker
{
    partial class WorkoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/Workout";


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutForm));
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.txtExerciseName = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboexerxiseType = new System.Windows.Forms.ComboBox();
            this.comboIntensity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEquipments = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caloriespermin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workoutDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Location = new System.Drawing.Point(12, 48);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(81, 13);
            this.lblExerciseName.TabIndex = 4;
            this.lblExerciseName.Text = "Exercise Name:";
            // 
            // txtExerciseName
            // 
            this.txtExerciseName.Location = new System.Drawing.Point(209, 48);
            this.txtExerciseName.Name = "txtExerciseName";
            this.txtExerciseName.Size = new System.Drawing.Size(259, 20);
            this.txtExerciseName.TabIndex = 3;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 137);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(95, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration (minutes):";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(209, 134);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(259, 20);
            this.txtDuration.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(209, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Workout";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exercise Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboexerxiseType
            // 
            this.comboexerxiseType.FormattingEnabled = true;
            this.comboexerxiseType.Items.AddRange(new object[] {
            "Cardio",
            "Weightlifting",
            "Yoga"});
            this.comboexerxiseType.Location = new System.Drawing.Point(209, 90);
            this.comboexerxiseType.Name = "comboexerxiseType";
            this.comboexerxiseType.Size = new System.Drawing.Size(259, 21);
            this.comboexerxiseType.TabIndex = 7;
            this.comboexerxiseType.Text = "Select Exercise Type";
            this.comboexerxiseType.SelectedIndexChanged += new System.EventHandler(this.comboexerxiseType_SelectedIndexChanged);
            // 
            // comboIntensity
            // 
            this.comboIntensity.FormattingEnabled = true;
            this.comboIntensity.Items.AddRange(new object[] {
            "Low",
            "Moderate",
            "High"});
            this.comboIntensity.Location = new System.Drawing.Point(209, 182);
            this.comboIntensity.Name = "comboIntensity";
            this.comboIntensity.Size = new System.Drawing.Size(259, 21);
            this.comboIntensity.TabIndex = 9;
            this.comboIntensity.Text = "Select Level of Effort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Intensity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboEquipments
            // 
            this.comboEquipments.FormattingEnabled = true;
            this.comboEquipments.Items.AddRange(new object[] {
            "Treadmills",
            "Dumbbells",
            "Resistance Bands",
            "Body Weight"});
            this.comboEquipments.Location = new System.Drawing.Point(209, 230);
            this.comboEquipments.Name = "comboEquipments";
            this.comboEquipments.Size = new System.Drawing.Size(259, 21);
            this.comboEquipments.TabIndex = 11;
            this.comboEquipments.Text = "Select Equipment ";
            this.comboEquipments.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Equipment Used:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Calories Burn(per min):";
            // 
            // caloriespermin
            // 
            this.caloriespermin.Location = new System.Drawing.Point(209, 284);
            this.caloriespermin.Name = "caloriespermin";
            this.caloriespermin.Size = new System.Drawing.Size(259, 20);
            this.caloriespermin.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Workout Date:";
            // 
            // workoutDate
            // 
            this.workoutDate.Location = new System.Drawing.Point(209, 330);
            this.workoutDate.Name = "workoutDate";
            this.workoutDate.Size = new System.Drawing.Size(259, 20);
            this.workoutDate.TabIndex = 15;
            // 
            // WorkoutForm
            // 
            this.ClientSize = new System.Drawing.Size(506, 489);
            this.Controls.Add(this.workoutDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.caloriespermin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboEquipments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboIntensity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboexerxiseType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtExerciseName);
            this.Controls.Add(this.lblExerciseName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Workouts";
            this.Load += new System.EventHandler(this.WorkoutForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public static int wid = WorkoutData.Workouts.Count;
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            int userid = LoginForm.userid;
            string exerciseName = txtExerciseName.Text;
            int duration = int.Parse(txtDuration.Text);
            wid = wid + 1;
            DateTime date = workoutDate.Value.Date;
            double caloriesBurn=double.Parse(caloriespermin.Text);



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

            // WorkoutData.Workouts.Add(workout);

            //MessageBox.Show("Workout added successfully.");
            // Send the workout data to the backend microservice
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
        }

        #endregion
        private Label label1;
        private ComboBox comboexerxiseType;
        private ComboBox comboIntensity;
        private Label label2;
        private ComboBox comboEquipments;
        private Label label3;
        private Label label4;
        private TextBox caloriespermin;
        private Label label5;
        private DateTimePicker workoutDate;
    }
}