using Patterns.Creationals.Factories.FactoryMethod;
using Patterns.Creationals.Factories.FactoryMethod.Factories;

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
        }
    }
}
