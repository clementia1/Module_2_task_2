using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_task_2.Models;

namespace Module_2_task_2.Helpers
{
    public class SortCaloriesDescendingHelper : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            Ingredient ing1 = (Ingredient)a;
            Ingredient ing2 = (Ingredient)b;

            if (ing1.CaloriePerGram > ing2.CaloriePerGram)
            {
                return 1;
            }

            if (ing1.CaloriePerGram < ing2.CaloriePerGram)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
