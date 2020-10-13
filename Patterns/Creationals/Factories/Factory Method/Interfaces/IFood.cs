namespace Patterns.Creationals.Factories.FactoryMethod.Interfaces
{
    public interface IFood
    {
        int Nutrition { get; }
        string Name { get; }
        void Eat();
    }
}
