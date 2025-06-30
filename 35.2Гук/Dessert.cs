using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._2Гук
{
    class Dessert : Dish
    {
        public bool IsGlutenFree { get; set; } // Безглютеновый ли десерт

        public Dessert(string name, decimal price, int calories, int preparationTime, bool isGlutenFree)
            : base(name, price, calories, preparationTime)
        {
            IsGlutenFree = isGlutenFree;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Десерт: {Name}, Цена: {Price:C}, Калории: {Calories}, Время приготовления: {PreparationTime} мин, Безглютеновый: {IsGlutenFree}");
        }
    }
}
