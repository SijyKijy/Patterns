namespace Patterns.Creationals.Factories.Factory_Method.Interfaces
{
    public abstract class FoodFactory
    {
        public abstract IFood GetFood();

        public int CheckNutrition() => GetFood().Nutrition;
    }
}
