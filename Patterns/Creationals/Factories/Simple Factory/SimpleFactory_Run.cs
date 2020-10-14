using Patterns.Creationals.Factories.Simple_Factory.Models;

namespace Patterns.Creationals.Factories.Simple_Factory
{
    public class SimpleFactory_Run : Pattern
    {
        protected override string Name => "Простая фабрика / Simple Factory";

        protected override void Run()
        {
            System.Console.WriteLine("--- Simple Factory ---");
            ComputerFactory factory = new ComputerFactory();
            factory.Create(new WindowsPC()).Print(); // Windows
            factory.Create(new LinuxPC()).Print(); // Linux
            factory.Create(new MacPC()).Print(); // Mac
        }
    }
}
