using Patterns.Modules;
using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Factories;
using System;

namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory
{
    public class AbstractFactory_Run : AbstractPattern, ICreationals
    {
        public override string Name => "Абстрактная фабрика / AbstractFactory";

        public override void Run()
        {
            Run(new NewPencilsFactory());
            Console.WriteLine("--- --- ---");
            Run(new OldPencilcsFactory());
        }

        private void Run(IPencilsFactory factory)
        {
            var hardPencil = factory.CreateHardPencil();
            var softPencil = factory.CreateSoftPencil();

            // Hard Pencil
            Console.WriteLine($"Hard Pencil: {hardPencil.Name}");
            hardPencil.Draw(softPencil);

            // Soft Pencil
            Console.WriteLine($"Soft Pencil: {softPencil.Name}");
            softPencil.Draw(hardPencil);
        }
    }
}
