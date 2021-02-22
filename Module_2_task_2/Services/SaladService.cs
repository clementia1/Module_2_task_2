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

        public Ingredient[] GetIngredients()
        {
            return _salad.Ingredients;
        }

        public bool Add(Ingredient ingredient)
        {
            _salad.Ingredients.Push(ingredient);
            return true;
        }

        public bool RemoveByIndex(int index)
        {
            _salad.Ingredients.RemoveByIndex(index);
            return true;
        }

        public bool RemoveAll()
        {
            _salad.Ingredients.Clear();
            return true;
        }

        public Ingredient[] FilterByCountry(Country country)
        {
            var filteredArray = Array.FindAll(_salad.Ingredients, item => item.CountryOfOrigin == country);
            return filteredArray;
        }

        public double GetTotalCalories()
        {
            double totalCalories = 0;

            foreach (var item in _salad.Ingredients)
            {
                double caloriesForIngredient = item.Weight * item.CaloriePerGram;
                totalCalories += caloriesForIngredient;
            }

            return totalCalories;
        }
    }
}
