﻿using Patterns.PatternsExample.Behavioral;
using Patterns.PatternsExample.Behavioral.Template_Method;

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
            //System.Console.WriteLine("\t --- Структурные ---");
            //var structuralStarter = new StructuralStarter();

            //structuralStarter.Start(new Decorator_Run());
            //structuralStarter.Start(new Facade_Run());
            //structuralStarter.Start(new Adapter_Run());
            //structuralStarter.Start(new Composite_Run());
            //structuralStarter.Start(new Proxy_Run());
            //structuralStarter.Start(new Bridge_Run());
            #endregion

            #region Behavioral
            System.Console.WriteLine("\t --- Поведенческие ---");
            var behavioralStarter = new BehavioralStarter();

            //behavioralStarter.Start(new Strategy_Run());
            behavioralStarter.Start(new TemplateMethod_Run());
            #endregion
        }
    }
}
