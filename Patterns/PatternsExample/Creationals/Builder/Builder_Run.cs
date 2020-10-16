using Patterns.Modules;
using Patterns.PatternsExample.Creationals.Builder.Models;
using Patterns.PatternsExample.Creationals.Builder.Modules;
using Patterns.PatternsExample.Creationals.Builder.Modules.Builders;

namespace Patterns.PatternsExample.Creationals.Builder
{
    public class Builder_Run : AbstractPattern, ICreationals
    {
        public override string Name => "Строитель/Builder";

        public override void Run()
        {
            // Стройка через директора
            var builder = new ModernHouseBuilder(new ModernHouse());
            var director = new Director(builder);
            director.BuildModernHouse();
            director.BuildSimpleHouse();

            // Стройка руками
            System.Console.WriteLine("Строим ручками");
            var builder2 = new WoodHouseBuilder(new WoodHouse());
            builder2.BuildFloor();
            builder2.BuildWoodTable();
            System.Console.WriteLine(builder2.Build().GetParts());
        }
    }
}
