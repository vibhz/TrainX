using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public static class WorkoutData
    {
        public static List<Workout> Workouts { get; } = new List<Workout>();
    }

    public class Workout
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public double Duration { get; set; }

        public string ExerciseType { get; set; }
        public string Intensity { get; set; }
        public string Equipment { get; set; }

        public double CaloriesBurn{ get; set; }

        public DateTime WorkoutDate { get; set; }
        public int UserId { get; set; }


        public Workout(int eid, string EName, double duration, DateTime date, string exerciseType, string intensity, string equipment, double caloriesBurn, int userId)
        {
            ExerciseId = eid;
            ExerciseName = EName;
            Duration = duration;
            WorkoutDate = date;
            ExerciseType = exerciseType;
            Intensity = intensity;
            Equipment = equipment;
            CaloriesBurn = caloriesBurn;
            UserId = userId;
        }
    }
}
