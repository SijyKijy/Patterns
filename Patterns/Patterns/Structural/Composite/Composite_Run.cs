using Patterns.Modules;
using Patterns.Patterns.Structural.Composite.Models;

namespace Patterns.Patterns.Structural.Composite
{
    public class Composite_Run : AbstractPattern, IStructural
    {
        public override string Name => "Компоновщик / Composite";

        public override void Run()
        {
            Box box = new Box("SmallBox");

            box.Add(new Product("Журнал"));
            box.Add(new Product("Стакан"));
            box.Add(new Product("Ручка"));

            box.Display();
        }
    }
}
