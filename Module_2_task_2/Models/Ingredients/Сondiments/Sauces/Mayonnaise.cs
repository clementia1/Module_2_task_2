using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Ingredients.Сondiments.Sauces
{
    public class Mayonnaise : Sauce
    {
        public override string Name { get; set; } = "Mayonnaise";
        public override double CaloriePerGram { get; set; } = 6.8;
    }
}
