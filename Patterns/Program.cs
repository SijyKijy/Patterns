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
            var normanHuman = new OrdinaryHuman();

            var simple = new Decorator_Run();

            var boozerHuman = new BoozerDecorator(normanHuman);
            var vegetarian = new VegetarianDecorator(normanHuman);
            var vegetarianAndBoozer = new VegetarianDecorator(boozerHuman);


            simple.GetResult(normanHuman);
            simple.GetResult(boozerHuman);
            simple.GetResult(vegetarian);
            simple.GetResult(vegetarianAndBoozer);
            #endregion

            #endregion

            #region Behavioral



            #endregion
        }
    }
}
