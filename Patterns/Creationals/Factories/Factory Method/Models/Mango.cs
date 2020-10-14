using Patterns.Creationals.Factories.Factory_Method.Interfaces;
using System;

namespace Patterns.Creationals.Factories.Factory_Method.Models
{
    public class Mango : IFood
    {
        public int Nutrition => 100;

        public string Name => "Манго";

        public void Eat() => Console.WriteLine($"Кушаем {Name}");
    }
}
