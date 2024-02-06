using System;
using System.Windows.Forms;

namespace FitnessTracker
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUserInfo = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageWorkout = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.tabPageCheatMeal = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddCheatMeal = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUserInfo.SuspendLayout();
            this.tabPageWorkout.SuspendLayout();
            this.tabPageCheatMeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUserInfo);
            this.tabControl1.Controls.Add(this.tabPageWorkout);
            this.tabControl1.Controls.Add(this.tabPageCheatMeal);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUserInfo
            // 
            this.tabPageUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageUserInfo.Controls.Add(this.button6);
            this.tabPageUserInfo.Controls.Add(this.button5);
            this.tabPageUserInfo.Controls.Add(this.button4);
            this.tabPageUserInfo.Controls.Add(this.textHeight);
            this.tabPageUserInfo.Controls.Add(this.textWeight);
            this.tabPageUserInfo.Controls.Add(this.textGender);
            this.tabPageUserInfo.Controls.Add(this.textAge);
            this.tabPageUserInfo.Controls.Add(this.textName);
            this.tabPageUserInfo.Controls.Add(this.label5);
            this.tabPageUserInfo.Controls.Add(this.label4);
            this.tabPageUserInfo.Controls.Add(this.label3);
            this.tabPageUserInfo.Controls.Add(this.label2);
            this.tabPageUserInfo.Controls.Add(this.label1);
            this.tabPageUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserInfo.Name = "tabPageUserInfo";
            this.tabPageUserInfo.Size = new System.Drawing.Size(765, 260);
            this.tabPageUserInfo.TabIndex = 3;
            this.tabPageUserInfo.Text = "User Infomation";
            this.tabPageUserInfo.UseVisualStyleBackColor = true;
            this.tabPageUserInfo.Click += new System.EventHandler(this.tabPageUserInfo_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(599, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 22);
            this.button4.TabIndex = 10;
            this.button4.Text = "Calculate BMI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textHeight
            // 
            this.textHeight.AcceptsReturn = true;
            this.textHeight.Location = new System.Drawing.Point(170, 192);
            this.textHeight.Name = "textHeight";
            this.textHeight.ReadOnly = true;
            this.textHeight.Size = new System.Drawing.Size(361, 20);
            this.textHeight.TabIndex = 9;
            // 
            // textWeight
            // 
            this.textWeight.AcceptsReturn = true;
            this.textWeight.Location = new System.Drawing.Point(170, 149);
            this.textWeight.Name = "textWeight";
            this.textWeight.ReadOnly = true;
            this.textWeight.Size = new System.Drawing.Size(361, 20);
            this.textWeight.TabIndex = 8;
            // 
            // textGender
            // 
            this.textGender.AcceptsReturn = true;
            this.textGender.Location = new System.Drawing.Point(170, 107);
            this.textGender.Name = "textGender";
            this.textGender.ReadOnly = true;
            this.textGender.Size = new System.Drawing.Size(361, 20);
            this.textGender.TabIndex = 7;
            // 
            // textAge
            // 
            this.textAge.AcceptsReturn = true;
            this.textAge.Location = new System.Drawing.Point(170, 68);
            this.textAge.Name = "textAge";
            this.textAge.ReadOnly = true;
            this.textAge.Size = new System.Drawing.Size(361, 20);
            this.textAge.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.AcceptsReturn = true;
            this.textName.Location = new System.Drawing.Point(170, 30);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(361, 20);
            this.textName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height (cm): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight (kg): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // tabPageWorkout
            // 
            this.tabPageWorkout.Controls.Add(this.button2);
            this.tabPageWorkout.Controls.Add(this.button1);
            this.tabPageWorkout.Controls.Add(this.btnAddWorkout);
            this.tabPageWorkout.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkout.Name = "tabPageWorkout";
            this.tabPageWorkout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkout.Size = new System.Drawing.Size(765, 260);
            this.tabPageWorkout.TabIndex = 0;
            this.tabPageWorkout.Text = "Workout Details";
            this.tabPageWorkout.UseVisualStyleBackColor = true;
            this.tabPageWorkout.Click += new System.EventHandler(this.tabPageWorkout_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(16, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(728, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Predict Future Workout";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(16, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(728, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Workout History";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddWorkout.Location = new System.Drawing.Point(16, 27);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(728, 30);
            this.btnAddWorkout.TabIndex = 0;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click_1);
            // 
            // tabPageCheatMeal
            // 
            this.tabPageCheatMeal.Controls.Add(this.button3);
            this.tabPageCheatMeal.Controls.Add(this.btnAddCheatMeal);
            this.tabPageCheatMeal.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheatMeal.Name = "tabPageCheatMeal";
            this.tabPageCheatMeal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheatMeal.Size = new System.Drawing.Size(765, 260);
            this.tabPageCheatMeal.TabIndex = 2;
            this.tabPageCheatMeal.Text = "Meal Details";
            this.tabPageCheatMeal.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(6, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(753, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "View Meal History";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddCheatMeal
            // 
            this.btnAddCheatMeal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddCheatMeal.Location = new System.Drawing.Point(6, 23);
            this.btnAddCheatMeal.Name = "btnAddCheatMeal";
            this.btnAddCheatMeal.Size = new System.Drawing.Size(753, 30);
            this.btnAddCheatMeal.TabIndex = 0;
            this.btnAddCheatMeal.Text = "Add Cheat Meal";
            this.btnAddCheatMeal.Click += new System.EventHandler(this.btnAddCheatMeal_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(599, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 22);
            this.button5.TabIndex = 11;
            this.button5.Text = "Update Info";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Thistle;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(599, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 22);
            this.button6.TabIndex = 12;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(918, 508);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainX";
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUserInfo.ResumeLayout(false);
            this.tabPageUserInfo.PerformLayout();
            this.tabPageWorkout.ResumeLayout(false);
            this.tabPageCheatMeal.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewWorkoutHistory_Click(object sender, EventArgs e)
        {
            // View workout history logic here
            MessageBox.Show("View workout history functionality");
        }

        private void btnAddCheatMeal_Click(object sender, EventArgs e)
        {
            // Add cheat meal logic here
            MessageBox.Show("Add cheat meal functionality");
        }
        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private TabPage tabPageUserInfo;
        private TextBox textHeight;
        private TextBox textWeight;
        private TextBox textGender;
        private TextBox textAge;
        private TextBox textName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}