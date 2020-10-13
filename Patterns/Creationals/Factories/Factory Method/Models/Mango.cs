using Patterns.Creationals.Factories.FactoryMethod.Interfaces;
using System;

namespace Patterns.Creationals.Factories.FactoryMethod.Models
{
    public class Mango : IFood
    {
        public int Nutrition => 100;

        public string Name => "Манго";

        public void Eat() => Console.WriteLine($"Кушаем {Name}");
    }
}
