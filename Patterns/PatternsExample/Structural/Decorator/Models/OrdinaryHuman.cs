using Patterns.PatternsExample.Structural.Decorator.Interfaces;

namespace Patterns.PatternsExample.Structural.Decorator.Models
{
    public class OrdinaryHuman : Human
    {
        public override string Speak() => "Привет, как жизнь?";
    }
}
