using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public static class UserData
    {
        public static List<User> users { get; } = new List<User>();
    }
    public class User
    {
        public int uid { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        // Add more properties as needed
    }
}
