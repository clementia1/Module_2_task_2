using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_task_2.Helpers;
using Module_2_task_2.Services;
using Module_2_task_2.Models;
using Module_2_task_2.Models.Fruits;
using Module_2_task_2.Models.Fruits.Nuts;
using Module_2_task_2.Models.Ingredients.Vegetables;
using Module_2_task_2.Models.Ingredients.Сondiments;
using Module_2_task_2.Models.Ingredients.Сondiments.Sauces;

namespace Module_2_task_2
{
    public class Starter
    {
        private readonly SaladService _saladService;
        private readonly Salad _salad;

        public Starter()
        {
            _saladService = new SaladService();
            _salad = new Salad();
        }

        public void Run()
        {
            _salad.Ingredients = new Ingredient[8];
            Ingredient celery = new Celery { Weight = 200, Price = 22.78, CountryOfOrigin = Country.Ukraine };
            Ingredient grape = new Grape { Weight = 150, Price = 26.985, CountryOfOrigin = Country.France };
            Ingredient apple = new Apple { Weight = 140, Price = 3.43, CountryOfOrigin = Country.Poland };
            Ingredient walnut = new Walnut { Weight = 20, Price = 2.4, CountryOfOrigin = Country.Ukraine };
            Ingredient pecan = new Pecan { Weight = 50, Price = 52.5, CountryOfOrigin = Country.Iran };
            Ingredient mayonnaise = new Mayonnaise { Weight = 180, Price = 9.6, CountryOfOrigin = Country.Ukraine };
            Ingredient salt = new Salt { Weight = 2.4, Price = 0.03816, CountryOfOrigin = Country.Ukraine };
            Ingredient blackPepper = new BlackPepper { Weight = 1, Price = 0.152, CountryOfOrigin = Country.India };

            _saladService.Add(_salad, celery);
            _saladService.Add(_salad, apple);
            _saladService.Add(_salad, grape);
            _saladService.Add(_salad, walnut);
            _saladService.Add(_salad, pecan);
            _saladService.Add(_salad, mayonnaise);
            _saladService.Add(_salad, salt);
            _saladService.Add(_salad, blackPepper);

            var ukrainianIngredients = _saladService.FilterByCountry(_salad, Country.Ukraine);
            _saladService.PrintIngredients(ukrainianIngredients);

            Array.Sort(ukrainianIngredients.Ingredients, new SortCaloriesDescendingHelper());
            _saladService.PrintIngredients(_salad);

            var totalCalories = _saladService.GetTotalCalories(_salad);
            Console.WriteLine($"Total calories in salad: {totalCalories}");

            Console.ReadKey();
        }
    }
}
