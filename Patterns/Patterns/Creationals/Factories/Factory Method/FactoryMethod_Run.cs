using Patterns.Modules;
using Patterns.Patterns.Creationals.Factories.Factory_Method.Factories;
using Patterns.Patterns.Creationals.Factories.Factory_Method.Interfaces;
using System;

namespace Patterns.Patterns.Creationals.Factories.Factory_Method
{
    public class FactoryMethod_Run : Pattern, ICreationals
    {
        public override string Name => "Фабричный метод / FactoryMethod";

        public override void Run()
        {
            Run(new BurgerFactory());
            Console.WriteLine("--- --- ---");
            Run(new MangoFactory());
        }

        private void Run(FoodFactory factory)
        {
            var food = factory.GetFood();
            var nutrition = factory.CheckNutrition();

            Console.WriteLine($"Food: {food.Name} | Nutrition: {nutrition}");
            food.Eat();
        }
    }
}
