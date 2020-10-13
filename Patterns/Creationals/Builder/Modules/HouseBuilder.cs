using Patterns.Creationals.Builder.Interfaces;
using System;

namespace Patterns.Creationals.Builder.Modules
{
    public class HouseBuilder : IHouseBuilder<House>
    {
        private House _house;

        public HouseBuilder(House house) => _house = house;

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

        public House Build() => _house;
    }
}
