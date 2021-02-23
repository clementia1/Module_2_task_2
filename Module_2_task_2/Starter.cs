using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_task_2.Helpers;
using Module_2_task_2.Services;
using Module_2_task_2.Models;
using Module_2_task_2.Models.Fruits;
using Module_2_task_2.Models.Ingredients.Vegetables;

namespace Module_2_task_2
{
    public class Starter
    {
        private readonly SaladService _saladService;

        public Starter()
        {
            _saladService = new SaladService();
        }

        public void Run()
        {
            Ingredient celery = new Celery { Name = "Celery stalk", Weight = 200, Price = 22.78, CountryOfOrigin = Country.Ukraine };
            _saladService.Add(celery);

            Ingredient apple = new Apple { Name = "Apple", Weight = 140, Price = 3.43, CountryOfOrigin = Country.Poland };
            _saladService.Add(apple);

            var ukrainianIngredients = _saladService.Filter(Country.Ukraine);

            Array.Sort(ukrainianIngredients, new SortCaloriesDescendingHelper());
        }
    }
}
