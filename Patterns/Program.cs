using Patterns.Patterns.Creationals;
using Patterns.Patterns.Creationals.Builder;
using Patterns.Patterns.Creationals.Factories.Abstract_Factory;
using Patterns.Patterns.Creationals.Factories.Factory_Method;
using Patterns.Patterns.Creationals.Factories.Simple_Factory;
using Patterns.Patterns.Creationals.Prototype;

using Patterns.Patterns.Structural;
using Patterns.Patterns.Structural.Adapter;
using Patterns.Patterns.Structural.Decorator;
using Patterns.Patterns.Structural.Facade;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creationals
            System.Console.WriteLine("\t --- Порождающие ---");
            var creationalsStarter = new CreationalsStarter();

            creationalsStarter.Start(new SimpleFactory_Run());
            creationalsStarter.Start(new FactoryMethod_Run());
            creationalsStarter.Start(new AbstractFactory_Run());

            creationalsStarter.Start(new Builder_Run());

            creationalsStarter.Start(new Prototype_Run());
            #endregion

            #region Structural
            System.Console.WriteLine("\t --- Структурные ---");
            var structuralStarter = new StructuralStarter();

            structuralStarter.Start(new Decorator_Run());
            structuralStarter.Start(new Facade_Run());
            structuralStarter.Start(new Adapter_Run());

            #endregion

            #region Behavioral
            System.Console.WriteLine("\t --- Поведенческие ---");


            #endregion
        }
    }
}
