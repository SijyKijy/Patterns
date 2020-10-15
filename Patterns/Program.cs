
using Patterns.Patterns.Structural;
using Patterns.Patterns.Structural.Bridge;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creationals
            //System.Console.WriteLine("\t --- Порождающие ---");
            //var creationalsStarter = new CreationalsStarter();

            //creationalsStarter.Start(new SimpleFactory_Run());
            //creationalsStarter.Start(new FactoryMethod_Run());
            //creationalsStarter.Start(new AbstractFactory_Run());

            //creationalsStarter.Start(new Builder_Run());

            //creationalsStarter.Start(new Prototype_Run());
            #endregion

            #region Structural
            System.Console.WriteLine("\t --- Структурные ---");
            var structuralStarter = new StructuralStarter();

            //structuralStarter.Start(new Decorator_Run());
            //structuralStarter.Start(new Facade_Run());
            //structuralStarter.Start(new Adapter_Run());
            //structuralStarter.Start(new Composite_Run());
            //structuralStarter.Start(new Proxy_Run());
            structuralStarter.Start(new Bridge_Run());
            #endregion

            #region Behavioral
            //System.Console.WriteLine("\t --- Поведенческие ---");


            #endregion
        }
    }
}
