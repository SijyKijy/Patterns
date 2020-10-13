using Patterns.Creationals.Factories.FactoryMethod.Interfaces;
using System;

namespace Patterns.Creationals.Factories.FactoryMethod.Models
{
    public class Burger : IFood
    {
        public int Nutrition => 350;

        public string Name => "Бургер";

        public void Eat() => Console.WriteLine($"Кушаем {Name}");
    }
}
