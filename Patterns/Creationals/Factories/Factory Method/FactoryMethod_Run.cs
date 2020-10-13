using Patterns.Creationals.Factories.FactoryMethod.Interfaces;
using System;

namespace Patterns.Creationals.Factories.FactoryMethod
{
    public class FactoryMethod_Run
    {
        public FactoryMethod_Run(FoodFactory factory)
        {
            var food = factory.GetFood();
            var nutrition = factory.CheckNutrition();

            Console.WriteLine($"Food: {food.Name} | Nutrition: {nutrition}");
            food.Eat();
        }
    }
}
