using Patterns.PatternsExample.Creationals.Factories.Simple_Factory.Models;
using System;

namespace Patterns.PatternsExample.Creationals.Factories.Simple_Factory
{
    public class ComputerFactory
    {
        public IComputer Create(IComputer type) =>
            type switch
            {
                WindowsPC => new WindowsPC(),
                LinuxPC => new LinuxPC(),
                MacPC => new MacPC(),
                _ => throw new ArgumentException("Unknown type")
            };
    }
}
