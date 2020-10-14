using Patterns.Structural.Decorator;
using Patterns.Structural.Decorator.Decorators;
using Patterns.Structural.Decorator.Models;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creationals

            #region Factories
            // Simple Factory
            //new SimpleFactory_Run();

            //// Abstract Factory
            //new AbstractFactory_Run(new NewPencilsFactory());
            //Console.WriteLine("--- --- ---");
            //new AbstractFactory_Run(new OldPencilcsFactory());

            ////Factory Method
            //new FactoryMethod_Run(new BurgerFactory());
            //System.Console.WriteLine("--- --- ---");
            //new FactoryMethod_Run(new MangoFactory());
            #endregion

            #region Builder
            //new Builder_Run();
            #endregion

            #region Prototype
            //new Prototype_Run();
            #endregion

            #endregion

            #region Structural

            #region Decorator
            //var normalHuman = new OrdinaryHuman();
            //var simple = new Decorator_Run();

            //// Можно через конструкторы. Тогда мы говорим, что наш человек не поменяется
            //var boozerDecorator = new BoozerDecorator(normalHuman);
            //var vegetarianDecorator = new VegetarianDecorator(normalHuman);
            //var vegetarianAndBoozerDecorator = new VegetarianDecorator(boozerDecorator);

            //boozerDecorator.AskAlms();

            //simple.GetResult(normalHuman);
            //simple.GetResult(boozerDecorator);
            //simple.GetResult(vegetarianDecorator);
            //simple.GetResult(vegetarianAndBoozerDecorator);

            //// А можно через Set-метод
            //System.Console.WriteLine("--- --- ---");
            //normalHuman = new OrdinaryHuman();
            //vegetarianDecorator = new VegetarianDecorator(null);

            //simple.GetResult(vegetarianDecorator); // Тут скажет только веган

            //vegetarianDecorator.SetHuman(normalHuman); // Декорируем (оборачиваем) человека

            //simple.GetResult(vegetarianDecorator); // Человек + Веган
            #endregion

            #endregion

            #region Behavioral



            #endregion
        }
    }
}
