using Patterns.PatternsExample.Behavioral.Command.Models;

namespace Patterns.PatternsExample.Behavioral.Command.Interfaces
{
    public abstract class AbstractOrderCommand : ICommand
    {
        protected Chef reciever;

        protected string order;

        public AbstractOrderCommand(Chef reciever, string order)
        {
            this.reciever = reciever;
            this.order = order;
        }

        public void Undo()
        {
            System.Console.WriteLine($"Отмена заказа: {order}");
            reciever.Order = order;
            reciever.UndoCook();
        }

        public abstract void Execute();

    }
}
