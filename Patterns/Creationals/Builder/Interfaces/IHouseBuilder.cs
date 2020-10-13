namespace Patterns.Creationals.Builder.Interfaces
{
    public interface IHouseBuilder<T> where T : House
    {
        void BuildWalls();
        void BuildRoof();
        void BuildFloor();
        T Build();
    }
}
