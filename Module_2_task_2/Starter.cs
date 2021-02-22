using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_task_2.Services;
using Module_2_task_2.Models;
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
            var celery = new Celery { Name = "Стебель сельдерея", Weight = 200, CaloriePerGram = 0.12, Price = 22.78, CountryOfOrigin = Country.Ukraine };
        }
    }
}
