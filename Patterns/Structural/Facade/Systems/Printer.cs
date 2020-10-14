using System;

namespace Patterns.Structural.Facade.Systems
{
    public class Printer
    {
        public string Print() => "I'm printer!";
        public void Clean() => Console.WriteLine("Starting clean...");
    }
}
