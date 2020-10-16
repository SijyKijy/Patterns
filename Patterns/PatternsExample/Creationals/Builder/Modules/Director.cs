using Patterns.PatternsExample.Creationals.Builder.Modules.Builders;

namespace Patterns.PatternsExample.Creationals.Builder.Modules
{
    public class Director
    {
        private ModernHouseBuilder _builder;
        public Director(ModernHouseBuilder builder) => _builder = builder;

        public ModernHouseBuilder Builder
        {
            set => _builder = value;
        }

        public void BuildModernHouse()
        {
            System.Console.WriteLine("Строим модерн");
            _builder.BuildFloor();
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.BuildStatue();
            System.Console.WriteLine(_builder.Build().GetParts());
        }

        public void BuildSimpleHouse()
        {
            System.Console.WriteLine("Строим обычный дом");
            _builder.BuildFloor();
            _builder.BuildWalls();
            _builder.BuildRoof();
            System.Console.WriteLine(_builder.Build().GetParts());
        }
    }
}
