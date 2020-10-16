using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.Interfaces;
using System;

namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.NewPencils
{
    public class NewSoftPencil : ISoftPencil
    {
        public NewSoftPencil()
        {
            Console.WriteLine($"Создали: {nameof(NewSoftPencil)}");
        }

        public string Name => "Новенький мягкий карандаш";

        public void Draw(IPencil pencil = null) => Console.WriteLine($"Пишем. Карандаш: {pencil.Name}");
    }
}
