using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Ingredients.Vegetables
{
    public class Celery : Vegetable
    {
        public override string Name { get; set; } = "Celery";
        public override double CaloriePerGram { get; set; } = 0.12;
    }
}
