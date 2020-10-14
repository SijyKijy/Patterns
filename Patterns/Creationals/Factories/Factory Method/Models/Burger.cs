using Patterns.Creationals.Factories.Factory_Method.Interfaces;
using System;

namespace Patterns.Creationals.Factories.Factory_Method.Models
{
    public class Burger : IFood
    {
        public int Nutrition => 350;

        public string Name => "Бургер";

        public void Eat() => Console.WriteLine($"Кушаем {Name}");
    }
}
