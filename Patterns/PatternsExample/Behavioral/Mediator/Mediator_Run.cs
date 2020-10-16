using Patterns.Modules;
using Patterns.PatternsExample.Behavioral.Mediator.Colleagues;
using Patterns.PatternsExample.Behavioral.Mediator.Interfaces;
using Patterns.PatternsExample.Behavioral.Mediator.Mediators;

namespace Patterns.PatternsExample.Behavioral.Mediator
{
    public class Mediator_Run : AbstractPattern, IBehavioral
    {
        public override string Name => "Посредник / Mediator";

        public override void Run()
        {
            var phone = new Phone();
            var laptop = new Laptop();

            var mediator = new Router(new AbstractColleague[] { phone, laptop });

            phone.SendMessage("Сообщение для телефонов");
            laptop.SendMessage("Сообщение для ноутбуков");
        }
    }
}
