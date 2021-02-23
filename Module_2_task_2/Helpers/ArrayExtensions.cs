using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_task_2.Models;

namespace Module_2_task_2.Helpers
{
    public static class ArrayExtensions
    {
        public static int Push<T>(this T[] sourceArray, T value)
        {
            var index = Array.IndexOf(sourceArray, default(T));

            if (index != -1)
            {
                sourceArray[index] = value;
            }

            return index;
        }

        public static bool Clear<T>(this T[] sourceArray)
        {
            Array.Clear(sourceArray, 0, sourceArray.Length);
            return true;
        }

        public static T[] RemoveByIndex<T>(this T[] sourceArray, int index)
        {
            sourceArray[index] = default(T);
            return sourceArray;
        }
    }
}
