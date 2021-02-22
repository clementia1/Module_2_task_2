using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_task_2.Models.Fruits
{
    public abstract class Fruit
    {
        public int SlicesCount { get; set; } = 1;

        public abstract void Prepare();
    }
}
