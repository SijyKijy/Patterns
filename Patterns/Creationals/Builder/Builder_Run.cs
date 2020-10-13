using Patterns.Creationals.Builder.Models;
using Patterns.Creationals.Builder.Modules;
using System;

namespace Patterns.Creationals.Builder
{
    public class Builder_Run
    {
        public Builder_Run()
        {
            var builder = new HouseBuilder(new WoodHouse());
            var director = new Director(builder);
            Console.WriteLine(director.BuildHouse().GetParts());

            director.Builder = new HouseBuilder(new ModernHouse());
            Console.WriteLine(director.BuildHouse().GetParts());
        }
    }
}
