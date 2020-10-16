using Patterns.PatternsExample.Behavioral.Command.Interfaces;
using Patterns.PatternsExample.Behavioral.Command.Models;
using System;

namespace Patterns.PatternsExample.Behavioral.Command.Commands
{
    public class CookCommand : AbstractOrderCommand
    {
        public CookCommand(Chef reciever, string order) : base(reciever, order) { }

        public override void Execute()
        {
            Console.WriteLine("Посылаем заказ");
            reciever.Cook(order);
        }
    }
}
