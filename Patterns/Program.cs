using Patterns.PatternsExample.Behavioral;
using Patterns.PatternsExample.Behavioral.Command;
using Patterns.PatternsExample.Behavioral.Mediator;
using Patterns.PatternsExample.Behavioral.State;
using Patterns.PatternsExample.Behavioral.Strategy;
using Patterns.PatternsExample.Behavioral.Template_Method;

using Patterns.PatternsExample.Creationals;
using Patterns.PatternsExample.Creationals.Builder;
using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory;
using Patterns.PatternsExample.Creationals.Factories.Factory_Method;
using Patterns.PatternsExample.Creationals.Factories.Simple_Factory;
using Patterns.PatternsExample.Creationals.Prototype;

using Patterns.PatternsExample.Structural;
using Patterns.PatternsExample.Structural.Adapter;
using Patterns.PatternsExample.Structural.Bridge;
using Patterns.PatternsExample.Structural.Composite;
using Patterns.PatternsExample.Structural.Decorator;
using Patterns.PatternsExample.Structural.Facade;
using Patterns.PatternsExample.Structural.Proxy;

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
            structuralStarter.Start(new Composite_Run());
            structuralStarter.Start(new Proxy_Run());
            structuralStarter.Start(new Bridge_Run());
            #endregion

            #region Behavioral
            System.Console.WriteLine("\t --- Поведенческие ---");
            var behavioralStarter = new BehavioralStarter();

            behavioralStarter.Start(new Strategy_Run());
            behavioralStarter.Start(new TemplateMethod_Run());
            behavioralStarter.Start(new State_Run());
            behavioralStarter.Start(new Mediator_Run());
            behavioralStarter.Start(new Command_Run());
            #endregion
        }
    }
}
