using Patterns.PatternsExample.Creationals.Builder.Interfaces;
using Patterns.PatternsExample.Creationals.Builder.Models;
using System;

namespace Patterns.PatternsExample.Creationals.Builder.Modules.Builders
{
    public class WoodHouseBuilder : HouseBuilder<WoodHouse>
    {
        private readonly WoodHouse _house;

        public WoodHouseBuilder(WoodHouse house) : base(house)
        {
            _house = house;
        }

        public void BuildWoodTable()
        {
            Console.WriteLine($"Строим стол. Материал: {_house.Material}");
            _house.AddPart("Деревянный стол");
        }
    }
}
