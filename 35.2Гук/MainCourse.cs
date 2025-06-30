using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _35._2Гук
{
    class MainCourse : Dish
    {
        public int SpicinessLevel { get; set; } // Уровень остроты (1-10)

        public MainCourse(string name, decimal price, int calories, int preparationTime, int spicinessLevel)
            : base(name, price, calories, preparationTime)
        {
            SpicinessLevel = spicinessLevel;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Основное блюдо: {Name}, Цена: {Price:C}, Калории: {Calories}, Время приготовления: {PreparationTime} мин, Острота: {SpicinessLevel}/10");
        }
    }
}
