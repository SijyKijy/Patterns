using Patterns.Creationals.Builder.Models;
using Patterns.Creationals.Builder.Modules;
using Patterns.Creationals.Builder.Modules.Builders;

namespace Patterns.Creationals.Builder
{
    public class Builder_Run
    {
        public Builder_Run()
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
