using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public static class CheatMealData
    {
        public static List<CheatMeal> CheatMeals { get; } = new List<CheatMeal>();
    }

    public class CheatMeal
    {
        public string MealName { get; set; }
        public string Description { get; set; }
        public double CalorieCount { get; set; }

        public DateTime MealDate { get; set; }

        public int UserId { get; set; }

        public CheatMeal(string mname, String des,double ccount,DateTime date,int uid)
        {
           MealName = mname;
           Description = des;
           CalorieCount = ccount;
           MealDate= date;
           UserId = uid;
        }
    }
}
