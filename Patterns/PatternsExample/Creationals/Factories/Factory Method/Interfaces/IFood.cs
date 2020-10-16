namespace Patterns.PatternsExample.Creationals.Factories.Factory_Method.Interfaces
{
    public interface IFood
    {
        int Nutrition { get; }
        string Name { get; }
        void Eat();
    }
}
