using System;

namespace Patterns.Patterns.Creationals.Builder.Interfaces
{
    public abstract class HouseBuilder<T> where T : House, new()
    {
        private T _house;

        public HouseBuilder(T house) => _house = house;

        public void BuildFloor()
        {
            Console.WriteLine($"Строим пол. Материал: {_house.Material}");
            _house.AddPart("Пол");
        }

        public void BuildRoof()
        {
            Console.WriteLine($"Строим крышу. Материал: {_house.Material}");
            _house.AddPart("Крыша");
        }

        public void BuildWalls()
        {
            Console.WriteLine($"Строим стены. Материал: {_house.Material}");
            _house.AddPart("Стены");
        }

        public void Reset() => _house = new T();

        public T Build()
        {
            T result = _house;
            Reset();
            return result;
        }
    }
}
