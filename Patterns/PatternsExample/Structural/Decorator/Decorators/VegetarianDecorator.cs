using Patterns.PatternsExample.Structural.Decorator.Interfaces;

namespace Patterns.PatternsExample.Structural.Decorator.Decorators
{
    public class VegetarianDecorator : HumanDecorator
    {
        public VegetarianDecorator(Human human) : base(human)
        {
        }

        public override string Speak() => $"{base.Speak()} | Я не ем мясцо!";
    }
}
