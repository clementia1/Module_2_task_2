using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Fruits
{
    public class Apple : Fruit
    {
        public override double CaloriePerGram { get; set; } = 0.47;
        public string Type { get; set; }
    }
}
