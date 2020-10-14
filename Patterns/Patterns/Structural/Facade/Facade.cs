using Patterns.Patterns.Structural.Facade.Systems;
using System;

namespace Patterns.Patterns.Structural.Facade
{
    public class Facade
    {
        protected Counter _counter;
        protected Printer _printer;

        public Facade(Counter counter, Printer printer)
        {
            _counter = counter;
            _printer = printer;
        }

        public void PrintAndSum(int number) => Console.WriteLine($"Printer: {_printer.Print()} | Counter: {_counter.Add(number)}");
    }
}
