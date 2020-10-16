using Patterns.PatternsExample.Creationals.Builder.Interfaces;
using Patterns.PatternsExample.Creationals.Builder.Models;
using System;

namespace Patterns.PatternsExample.Creationals.Builder.Modules.Builders
{
    public class ModernHouseBuilder : HouseBuilder<ModernHouse>
    {
        private readonly ModernHouse _house;

        public ModernHouseBuilder(ModernHouse house) : base(house)
        {
            _house = house;
        }

        public void BuildStatue()
        {
            Console.WriteLine($"Строим статую. Материал: {_house.Material}");
            _house.AddPart("Каменная статуя");
        }
    }
}
