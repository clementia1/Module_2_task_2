using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Fruits
{
    public class Grape : Fruit
    {
        public override string Name { get; set; } = "Grape";
        public override double CaloriePerGram { get; set; } = 0.67;

        public void RemoveSeeds()
        {
            Console.WriteLine("Removing seeds from grape");
        }
    }
}
