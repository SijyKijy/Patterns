using Patterns.PatternsExample.Behavioral.Mediator.Interfaces;
using System;

namespace Patterns.PatternsExample.Behavioral.Mediator.Colleagues
{
    public class Laptop : AbstractColleague
    {
        public void SendMessage(string text)
        {
            Console.WriteLine("Посылаем сообщение с ноутбука");
            mediator.Notify(this, text);
        }
    }
}
