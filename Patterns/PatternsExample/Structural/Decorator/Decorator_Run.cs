using Patterns.Modules;
using Patterns.PatternsExample.Structural.Decorator.Decorators;
using Patterns.PatternsExample.Structural.Decorator.Interfaces;
using Patterns.PatternsExample.Structural.Decorator.Models;

namespace Patterns.PatternsExample.Structural.Decorator
{
    public class Decorator_Run : AbstractPattern, IStructural
    {
        public override string Name => "Декоратор / Decorator";

        public override void Run()
        {
            var normalHuman = new OrdinaryHuman();

            #region Constructor
            // Можно через конструкторы. Тогда мы говорим, что наш человек не поменяется
            var boozerDecorator = new BoozerDecorator(normalHuman);
            var vegetarianDecorator = new VegetarianDecorator(normalHuman);
            var vegetarianAndBoozerDecorator = new VegetarianDecorator(boozerDecorator);

            boozerDecorator.AskAlms();

            GetResult(normalHuman);
            GetResult(boozerDecorator);
            GetResult(vegetarianDecorator);
            GetResult(vegetarianAndBoozerDecorator);
            #endregion

            #region Set-Method
            // А можно через Set-метод
            System.Console.WriteLine("--- --- ---");
            normalHuman = new OrdinaryHuman();
            vegetarianDecorator = new VegetarianDecorator(null);

            GetResult(vegetarianDecorator); // Тут скажет только веган

            vegetarianDecorator.SetHuman(normalHuman); // Декорируем (оборачиваем) человека

            GetResult(vegetarianDecorator); // Человек + Веган
            #endregion
        }

        private void GetResult(Human human)
        {
            System.Console.WriteLine($"{human.GetType().Name} speak: {human.Speak()}");
        }
    }
}
