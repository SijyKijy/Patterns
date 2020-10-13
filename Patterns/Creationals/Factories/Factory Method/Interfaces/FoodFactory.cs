namespace Patterns.Creationals.Factories.FactoryMethod.Interfaces
{
    public abstract class FoodFactory
    {
        public abstract IFood GetFood();

        public int CheckNutrition() => GetFood().Nutrition;
    }
}
