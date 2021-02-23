using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Fruits
{
    public abstract class Fruit : Ingredient
    {
        public int SlicesCount { get; set; } = 1;

        public virtual void Prepare()
        {
        }
    }
}
