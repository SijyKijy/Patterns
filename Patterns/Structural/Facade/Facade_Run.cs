﻿using Patterns.Structural.Facade.Systems;

namespace Patterns.Structural.Facade
{
    public class Facade_Run
    {
        public Facade_Run()
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
