using System;
using Module_2_task_2.Models;
using Module_2_task_2.Helpers;

namespace Module_2_task_2.Services
{
    public class SaladService
    {
        private readonly Salad _salad;

        public SaladService()
        {
            _salad = new Salad();
        }

        public bool Add(Ingredient ingredient)
        {
            _salad.Ingredients.Push(ingredient);
            return true;
        }

        public void Remove(int index)
        {
            _salad.Ingredients.RemoveByIndex(index);
        }

        public void RemoveAll()
        {
            _salad.Ingredients.Clear();
        }
    }
}
