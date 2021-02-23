using System;
using Module_2_task_2.Models;
using Module_2_task_2.Helpers;

namespace Module_2_task_2.Services
{
    public class SaladService
    {
        public Ingredient[] GetIngredients(Salad salad)
        {
            return salad.Ingredients;
        }

        public bool Add(Salad salad, Ingredient ingredient)
        {
            salad.Ingredients.Push(ingredient);
            return true;
        }

        public bool RemoveByIndex(Salad salad, int index)
        {
            salad.Ingredients.RemoveByIndex(index);
            return true;
        }

        public bool RemoveAll(Salad salad)
        {
            salad.Ingredients.Clear();
            return true;
        }

        public Salad FilterByCountry(Salad salad, Country country)
        {
            salad.Ingredients = Array.FindAll(salad.Ingredients, item => item.CountryOfOrigin == country);
            return salad;
        }

        public Salad FilterByPrice(Salad salad, double minPrice, double maxPrice)
        {
            salad.Ingredients = Array.FindAll(salad.Ingredients, item => item.Price >= minPrice && item.Price <= maxPrice);
            return salad;
        }

        public Salad FilterByCalories(Salad salad, double minCaloriePerGram, double maxCaloriePerGram)
        {
            salad.Ingredients = Array.FindAll(salad.Ingredients, item => item.Price >= minCaloriePerGram && item.Price <= maxCaloriePerGram);
            return salad;
        }

        public Salad Filter(Salad salad, double minPrice, double maxPrice, Country country)
        {
            var filteredByPrice = FilterByPrice(salad, minPrice, maxPrice);
            return FilterByCountry(filteredByPrice, country);
        }

        public Salad Filter(Salad salad, double minPrice, double maxPrice, double minCaloriePerGram, double maxCaloriePerGram, Country country)
        {
            var filteredByPrice = FilterByPrice(salad, minPrice, maxPrice);
            var filteredByCalories = FilterByCalories(filteredByPrice, minCaloriePerGram, maxCaloriePerGram);
            return FilterByCountry(filteredByCalories, country);
        }

        public double GetTotalCalories(Salad salad)
        {
            double totalCalories = 0;

            foreach (var item in salad.Ingredients)
            {
                double caloriesForIngredient = item.Weight * item.CaloriePerGram;
                totalCalories += caloriesForIngredient;
            }

            return totalCalories;
        }

        public void PrintIngredients(Salad salad)
        {
            foreach (var item in salad.Ingredients)
            {
                Console.WriteLine($"{item.Name} from {item.CountryOfOrigin}, calories per gram: {item.CaloriePerGram}");
            }
        }
    }
}
