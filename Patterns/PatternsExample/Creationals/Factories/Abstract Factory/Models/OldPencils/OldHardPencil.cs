using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.Interfaces;
using System;

namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.OldPencils
{
    public class OldHardPencil : IHardPencil
    {
        public OldHardPencil()
        {
            Console.WriteLine($"Создали: {nameof(OldHardPencil)}");
        }

        public string Name => "Старый твёрдый карандаш";

        public void Draw(IPencil pencil = null) => Console.WriteLine($"Пишем. Карандаш: {pencil.Name}");
    }
}
