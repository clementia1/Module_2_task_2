using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Fruits.Nuts
{
    public class Walnut : Nut
    {
        public override string Name { get; set; } = "Walnut";
        public override double CaloriePerGram { get; set; } = 6.54;
    }
}
