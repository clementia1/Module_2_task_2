using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Fruits
{
    public abstract class Fruit
    {
        public string Name { get; set; }
        public int CaloriePerGram { get; set; }
        public double Weight { get; set; }
        public string CountryOfOrigin { get; set; }
        public double Price { get; set; }

        public double GetCalories(double weight, int caloriePerGram)
        {
            return weight * (double)caloriePerGram;
        }

        public abstract void Prepare();
    }
}
