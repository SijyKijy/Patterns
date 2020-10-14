using Patterns.Structural.Decorator.Interfaces;

namespace Patterns.Structural.Decorator
{
    public class Decorator_Run
    {
        public void GetResult(Human human)
        {
            System.Console.WriteLine($"{human.GetType().Name} speak: {human.Speak()}");
        }
    }
}
