using Patterns.Structural.Decorator.Interfaces;

namespace Patterns.Structural.Decorator.Models
{
    public class OrdinaryHuman : Human
    {
        public override string Speak() => "Привет, как жизнь?";
    }
}
