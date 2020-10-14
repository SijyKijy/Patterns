﻿using Patterns.Modules;
using Patterns.Patterns.Creationals.Factories.Simple_Factory.Models;

namespace Patterns.Patterns.Creationals.Factories.Simple_Factory
{
    public class SimpleFactory_Run : Pattern, ICreationals
    {
        public override string Name => "Простая фабрика / Simple Factory";

        public override void Run()
        {
            ComputerFactory factory = new ComputerFactory();
            factory.Create(new WindowsPC()).Print(); // Windows
            factory.Create(new LinuxPC()).Print(); // Linux
            factory.Create(new MacPC()).Print(); // Mac
        }
    }
}