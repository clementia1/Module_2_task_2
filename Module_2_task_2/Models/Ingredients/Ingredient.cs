using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double CaloriePerGram { get; set; }
        public Country CountryOfOrigin { get; set; }
        public double Price { get; set; }

        public double GetCalories(double weight, int caloriePerGram)
        {
            return weight * (double)caloriePerGram;
        }
    }
}
