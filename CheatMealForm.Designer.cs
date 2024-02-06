using System.Windows.Forms;
using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace FitnessTracker
{
    partial class CheatMealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private const string BackendApiBaseUrl = "https://localhost:44332/apigateway/Meal";


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheatMealForm));
            this.lblMealName = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCalorieCount = new System.Windows.Forms.Label();
            this.txtCalorieCount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.mealDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMealName
            // 
            this.lblMealName.AutoSize = true;
            this.lblMealName.Location = new System.Drawing.Point(20, 30);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(80, 16);
            this.lblMealName.TabIndex = 0;
            this.lblMealName.Text = "Meal Name:";
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(120, 30);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(352, 22);
            this.txtMealName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblCalorieCount
            // 
            this.lblCalorieCount.AutoSize = true;
            this.lblCalorieCount.Location = new System.Drawing.Point(20, 161);
            this.lblCalorieCount.Name = "lblCalorieCount";
            this.lblCalorieCount.Size = new System.Drawing.Size(90, 16);
            this.lblCalorieCount.TabIndex = 4;
            this.lblCalorieCount.Text = "Calorie Count:";
            // 
            // txtCalorieCount
            // 
            this.txtCalorieCount.Location = new System.Drawing.Point(120, 158);
            this.txtCalorieCount.Name = "txtCalorieCount";
            this.txtCalorieCount.Size = new System.Drawing.Size(352, 22);
            this.txtCalorieCount.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(120, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Cheat Meal";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 72);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // mealDate
            // 
            this.mealDate.Location = new System.Drawing.Point(120, 208);
            this.mealDate.Name = "mealDate";
            this.mealDate.Size = new System.Drawing.Size(352, 22);
            this.mealDate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Meal Date:";
            // 
            // CheatMealForm
            // 
            this.ClientSize = new System.Drawing.Size(553, 351);
            this.Controls.Add(this.mealDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblMealName);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCalorieCount);
            this.Controls.Add(this.txtCalorieCount);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheatMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Meal";
            this.Load += new System.EventHandler(this.CheatMealForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public static int mealId = CheatMealData.CheatMeals.Count;
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate the input fields before adding the cheat meal
            if (string.IsNullOrEmpty(txtMealName.Text) || string.IsNullOrEmpty(txtDescription.Text) || 
                string.IsNullOrEmpty(txtCalorieCount.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            int userid = LoginForm.userid;
            mealId = mealId+1;
            string mealName = txtMealName.Text;
            string description = txtDescription.Text;
            int calorieCount = int.Parse(txtCalorieCount.Text);
            DateTime date = mealDate.Value.Date;

            CheatMeal cheatMeal = new CheatMeal
            (
                mealName,
                description,
                calorieCount,
                date,
                userid

            );
            MessageBox.Show("meal" + mealName);


            // Send the meal data to the backend microservice
            using (var httpClient = new HttpClient())
            {
                var serializedMeal = JsonConvert.SerializeObject(cheatMeal);
                Console.WriteLine(serializedMeal);

                var content = new StringContent(serializedMeal, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(BackendApiBaseUrl, content);
                    response.EnsureSuccessStatusCode();

                    // Show success message to the user
                    MessageBox.Show("Cheat meal added successfully.");
                }
                catch (HttpRequestException ex)
                {
                    // Handle error
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
           // CheatMealData.CheatMeals.Add(cheatMeal);

            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        private RichTextBox txtDescription;
        private DateTimePicker mealDate;
        private Label label5;
    }
}