using Patterns.Creationals.Factories.Abstract_Factory.Factories;
using System;

namespace Patterns.Creationals.Factories.Abstract_Factory
{
    public class AbstractFactory_Run
    {
        public AbstractFactory_Run(IPencilsFactory factory)
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
