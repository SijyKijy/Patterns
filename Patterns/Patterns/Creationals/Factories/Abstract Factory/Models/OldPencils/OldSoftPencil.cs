using Patterns.Patterns.Creationals.Factories.Abstract_Factory.Models.Interfaces;
using System;

namespace Patterns.Patterns.Creationals.Factories.Abstract_Factory.Models.OldPencils
{
    public class OldSoftPencil : ISoftPencil
    {
        public OldSoftPencil()
        {
            Console.WriteLine($"Создали: {nameof(OldSoftPencil)}");
        }

        public string Name => "Старый мягкий карандаш";

        public void Draw(IPencil pencil = null) => Console.WriteLine($"Пишем. Карандаш: {pencil.Name}");
    }
}
