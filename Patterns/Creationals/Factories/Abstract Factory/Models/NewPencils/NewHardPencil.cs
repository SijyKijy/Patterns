using Patterns.Creationals.Factories.Abstract_Factory.Models.Interfaces;
using System;

namespace Patterns.Creationals.Factories.Abstract_Factory.Models.NewPencils
{
    public class NewHardPencil : IHardPencil
    {
        public NewHardPencil()
        {
            Console.WriteLine($"Создали: {nameof(NewHardPencil)}");
        }

        public string Name => "Новенький твёрдый карандаш";

        public void Draw(IPencil pencil = null) => Console.WriteLine($"Пишем. Карандаш: {pencil.Name}");
    }
}
