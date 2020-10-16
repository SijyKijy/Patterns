using Patterns.Modules;
using Patterns.PatternsExample.Behavioral.Command.Models;
using System;

namespace Patterns.PatternsExample.Behavioral.Command
{
    public class Command_Run : AbstractPattern, IBehavioral
    {
        public override string Name => "Команда / Command";

        public override void Run()
        {
            var invoker = new Waiter();

            invoker.TakeOrder("Карбонара");
            Console.WriteLine("--- --- ---");
            invoker.UndoOrder();
        }
    }
}
