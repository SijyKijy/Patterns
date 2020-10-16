using Patterns.PatternsExample.Behavioral.Mediator.Interfaces;
using System;

namespace Patterns.PatternsExample.Behavioral.Mediator.Colleagues
{
    /// <summary>
    /// Конкретный объект телефона
    /// </summary>
    public class Phone : AbstractColleague
    {
        public void SendMessage(string text)
        {
            Console.WriteLine("Посылаем сообщение с телефона");
            mediator.Notify(this, text);
        }
    }
}
