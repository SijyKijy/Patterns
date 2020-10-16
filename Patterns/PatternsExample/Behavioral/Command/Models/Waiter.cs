using Patterns.PatternsExample.Behavioral.Command.Commands;
using Patterns.PatternsExample.Behavioral.Command.Interfaces;
using System;
using System.Collections.Generic;

namespace Patterns.PatternsExample.Behavioral.Command.Models
{
    /// <summary>
    /// Класс отправитель
    /// С этим классов взаимодействует клиент
    /// </summary>
    public class Waiter
    {
        private Stack<ICommand> _commandHistory; // Стек для хранения команд. Служит для отката команды
        private Chef _activeChef;

        public ICommand Command { private get; set; }

        public Waiter()
        {
            _commandHistory = new Stack<ICommand>();
            _activeChef = new Chef();
        }

        public void TakeOrder(string order)
        {
            Command = new CookCommand(_activeChef, order);
            Command.Execute();
            _commandHistory.Push(Command);

            Console.WriteLine($"Заказ отправлен: {order}");
        }

        public void ShowActiveOrder() => Console.WriteLine($"Текущий заказ: {_activeChef.Order ?? "Нет"}");

        public void UndoOrder()
        {
            if (_commandHistory.Count > 0)
            {
                var command = _commandHistory.Pop();
                command.Undo();
            }
        }
    }
}
