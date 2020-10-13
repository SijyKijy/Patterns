using Patterns.Creationals.Builder.Interfaces;

namespace Patterns.Creationals.Builder.Modules
{
    public class Director
    {
        private IHouseBuilder<House> _builder;
        public Director(IHouseBuilder<House> builder)
        {
            _builder = builder;
        }

        public IHouseBuilder<House> Builder
        {
            set => _builder = value;
        }

        public House BuildHouse()
        {
            _builder.BuildFloor();
            _builder.BuildWalls();
            _builder.BuildRoof();
            return _builder.Build();
        }
    }
}
