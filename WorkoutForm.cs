using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class WorkoutForm : Form
    {
        private Label lblExerciseName;
        private TextBox txtExerciseName;
        private Label lblDuration;
        private TextBox txtDuration;
        private Button btnAdd;

        public string ExerciseName { get { return txtExerciseName.Text; } }
        public string Duration { get { return txtDuration.Text; } }

        public WorkoutForm()
        {
            InitializeComponent();
        }

        private void WorkoutForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboexerxiseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WorkoutForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
