﻿using Patterns.Modules;
using Patterns.Patterns.Structural.Facade.Systems;

namespace Patterns.Patterns.Structural.Facade
{
    public class Facade_Run : AbstractPattern, IStructural
    {
        public override string Name => "Фасад / Facade";

        public override void Run()
        {
            var counter = new Counter();
            var printer = new Printer();

            Run(new Facade(counter, printer));
        }

        private void Run(Facade facade)
        {
            facade.PrintAndSum(10);
        }
    }
}
