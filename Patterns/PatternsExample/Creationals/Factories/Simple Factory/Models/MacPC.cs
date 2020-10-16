using System;

namespace Patterns.PatternsExample.Creationals.Factories.Simple_Factory.Models
{
    public class MacPC : IComputer
    {
        public void Print()
        {
            Console.WriteLine($"This is {nameof(MacPC)}");
        }
    }
}
