using Patterns.PatternsExample.Behavioral.Mediator.Colleagues;
using Patterns.PatternsExample.Behavioral.Mediator.Interfaces;
using System;

namespace Patterns.PatternsExample.Behavioral.Mediator.Mediators
{
    public class Router : IMediator
    {
        private readonly AbstractColleague[] _colleagues;

        public Router(AbstractColleague[] colleagues)
        {
            foreach (var colleague in colleagues)
                colleague.SetMediator(this);

            _colleagues = colleagues;
        }

        public void Notify(object sender, string message)
        {
            switch (sender)
            {
                case Laptop:
                    // Логика для всех ноутбуков
                    Console.WriteLine($"(Только для ноутбуков) Текст: {message} ");
                    break;
                case Phone:
                    // Логика для всех телефонов
                    Console.WriteLine($"(Только для телефонов) Текст: {message} ");
                    break;
            }
        }
    }
}
