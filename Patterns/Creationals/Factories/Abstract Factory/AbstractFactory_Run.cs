using Patterns.Creationals.Factories.Abstract_Factory.Factories;
using System;

namespace Patterns.Creationals.Factories.Abstract_Factory
{
    public class AbstractFactory_Run : Pattern
    {
        protected override string Name => "Абстрактная фабрика / AbstractFactory";

        protected override void Run()
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
