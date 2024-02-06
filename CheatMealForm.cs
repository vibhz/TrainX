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
    public partial class CheatMealForm : Form
    {
        private Label lblMealId;
        private TextBox txtMealId;
        private Label lblMealName;
        private TextBox txtMealName;
        private Label lblDescription;
        private Label lblCalorieCount;
        private TextBox txtCalorieCount;
        private Button btnAdd;

        public int MealId { get { return int.Parse(txtMealId.Text); } }
        public string MealName { get { return txtMealName.Text; } }
        public string Description { get { return txtDescription.Text; } }
        public int CalorieCount { get { return int.Parse(txtCalorieCount.Text); } }

        public CheatMealForm()
        {

            InitializeComponent();
        }

        private void CheatMealForm_Load(object sender, EventArgs e)
        {

        }

        private void CheatMealForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
