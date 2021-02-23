using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Ingredients.Сondiments
{
    public class BlackPepper : Сondiment
    {
        public override string Name { get; set; } = "Black pepper";
        public override double CaloriePerGram { get; set; } = 2.51;
    }
}
