using System;

namespace Patterns.Creationals.Factories.Simple_Factory.Models
{
    public class LinuxPC : IComputer
    {
        public void Print()
        {
            Console.WriteLine($"This is {nameof(LinuxPC)}");
        }
    }
}
