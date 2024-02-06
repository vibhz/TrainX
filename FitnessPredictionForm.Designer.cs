using System;
using System.Windows.Forms;

namespace FitnessTracker
{
    partial class FitnessPredictionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitnessPredictionForm));
            this.btnPredict = new System.Windows.Forms.Button();
            this.lstWorkouts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeightPrediction = new System.Windows.Forms.TextBox();
            this.txtFitnessStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeightPrediction = new System.Windows.Forms.Label();
            this.lblFitnessStatus = new System.Windows.Forms.Label();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtWorkoutName = new System.Windows.Forms.TextBox();
            this.lblWorkoutName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboexerxiseType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboIntensity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEquipments = new System.Windows.Forms.ComboBox();
            this.caloriespermin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.workoutDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPredict.Location = new System.Drawing.Point(23, 504);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(939, 27);
            this.btnPredict.TabIndex = 5;
            this.btnPredict.Text = "Predict";
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click_1);
            // 
            // lstWorkouts
            // 
            this.lstWorkouts.ItemHeight = 16;
            this.lstWorkouts.Location = new System.Drawing.Point(23, 269);
            this.lstWorkouts.Name = "lstWorkouts";
            this.lstWorkouts.Size = new System.Drawing.Size(979, 164);
            this.lstWorkouts.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Workout List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your Weight Prediction:";
            // 
            // txtWeightPrediction
            // 
            this.txtWeightPrediction.Location = new System.Drawing.Point(196, 558);
            this.txtWeightPrediction.Name = "txtWeightPrediction";
            this.txtWeightPrediction.ReadOnly = true;
            this.txtWeightPrediction.Size = new System.Drawing.Size(232, 22);
            this.txtWeightPrediction.TabIndex = 11;
            // 
            // txtFitnessStatus
            // 
            this.txtFitnessStatus.Location = new System.Drawing.Point(674, 558);
            this.txtFitnessStatus.Name = "txtFitnessStatus";
            this.txtFitnessStatus.ReadOnly = true;
            this.txtFitnessStatus.Size = new System.Drawing.Size(288, 22);
            this.txtFitnessStatus.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Your Fitness Status:";
            // 
            // lblWeightPrediction
            // 
            this.lblWeightPrediction.AutoSize = true;
            this.lblWeightPrediction.Location = new System.Drawing.Point(20, 160);
            this.lblWeightPrediction.Name = "lblWeightPrediction";
            this.lblWeightPrediction.Size = new System.Drawing.Size(0, 16);
            this.lblWeightPrediction.TabIndex = 8;
            // 
            // lblFitnessStatus
            // 
            this.lblFitnessStatus.AutoSize = true;
            this.lblFitnessStatus.Location = new System.Drawing.Point(20, 120);
            this.lblFitnessStatus.Name = "lblFitnessStatus";
            this.lblFitnessStatus.Size = new System.Drawing.Size(0, 16);
            this.lblFitnessStatus.TabIndex = 7;
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddWorkout.Location = new System.Drawing.Point(557, 156);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(445, 23);
            this.btnAddWorkout.TabIndex = 4;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click_1);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(140, 111);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(288, 22);
            this.txtDuration.TabIndex = 3;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(17, 114);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(117, 16);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration (minutes):";
            // 
            // txtWorkoutName
            // 
            this.txtWorkoutName.Location = new System.Drawing.Point(140, 20);
            this.txtWorkoutName.Name = "txtWorkoutName";
            this.txtWorkoutName.Size = new System.Drawing.Size(288, 22);
            this.txtWorkoutName.TabIndex = 1;
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.AutoSize = true;
            this.lblWorkoutName.Location = new System.Drawing.Point(20, 20);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(100, 16);
            this.lblWorkoutName.TabIndex = 0;
            this.lblWorkoutName.Text = "Workout Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Exercise Type:";
            // 
            // comboexerxiseType
            // 
            this.comboexerxiseType.FormattingEnabled = true;
            this.comboexerxiseType.Items.AddRange(new object[] {
            "Cardio",
            "Weightlifting",
            "Yoga"});
            this.comboexerxiseType.Location = new System.Drawing.Point(140, 64);
            this.comboexerxiseType.Name = "comboexerxiseType";
            this.comboexerxiseType.Size = new System.Drawing.Size(288, 24);
            this.comboexerxiseType.TabIndex = 15;
            this.comboexerxiseType.Text = "Select Exercise Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Intensity:";
            // 
            // comboIntensity
            // 
            this.comboIntensity.FormattingEnabled = true;
            this.comboIntensity.Items.AddRange(new object[] {
            "Low",
            "Moderate",
            "High"});
            this.comboIntensity.Location = new System.Drawing.Point(714, 12);
            this.comboIntensity.Name = "comboIntensity";
            this.comboIntensity.Size = new System.Drawing.Size(288, 24);
            this.comboIntensity.TabIndex = 17;
            this.comboIntensity.Text = "Select Level of Effort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Equipment Used:";
            // 
            // comboEquipments
            // 
            this.comboEquipments.FormattingEnabled = true;
            this.comboEquipments.Items.AddRange(new object[] {
            "Treadmills",
            "Dumbbells",
            "Resistance Bands",
            "Body Weight"});
            this.comboEquipments.Location = new System.Drawing.Point(714, 60);
            this.comboEquipments.Name = "comboEquipments";
            this.comboEquipments.Size = new System.Drawing.Size(288, 24);
            this.comboEquipments.TabIndex = 19;
            this.comboEquipments.Text = "Select Equipment ";
            // 
            // caloriespermin
            // 
            this.caloriespermin.Location = new System.Drawing.Point(714, 111);
            this.caloriespermin.Name = "caloriespermin";
            this.caloriespermin.Size = new System.Drawing.Size(288, 22);
            this.caloriespermin.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Calories Burn(per min):";
            // 
            // workoutDate
            // 
            this.workoutDate.Location = new System.Drawing.Point(140, 157);
            this.workoutDate.Name = "workoutDate";
            this.workoutDate.Size = new System.Drawing.Size(288, 22);
            this.workoutDate.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Workout Date:";
            // 
            // FitnessPredictionForm
            // 
            this.ClientSize = new System.Drawing.Size(1051, 714);
            this.Controls.Add(this.workoutDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.caloriespermin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEquipments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboIntensity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboexerxiseType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFitnessStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeightPrediction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWorkoutName);
            this.Controls.Add(this.txtWorkoutName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.btnAddWorkout);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.lstWorkouts);
            this.Controls.Add(this.lblFitnessStatus);
            this.Controls.Add(this.lblWeightPrediction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FitnessPredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness Prediction";
            this.Load += new System.EventHandler(this.FitnessPredictionForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
          
        }
        private void btnPredict_Click(object sender, EventArgs e)
        {
        
        }
        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWeightPrediction;
        private TextBox txtFitnessStatus;
        private Label label3;
        private Label lblWeightPrediction;
        private Label lblFitnessStatus;
        private Button btnAddWorkout;
        private TextBox txtDuration;
        private Label lblDuration;
        private TextBox txtWorkoutName;
        private Label lblWorkoutName;
        private Label label4;
        private ComboBox comboexerxiseType;
        private Label label6;
        private ComboBox comboIntensity;
        private Label label5;
        private ComboBox comboEquipments;
        private TextBox caloriespermin;
        private Label label7;
        private DateTimePicker workoutDate;
        private Label label8;
    }
}