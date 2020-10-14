namespace Patterns.Structural.Decorator.Interfaces
{
    public abstract class HumanDecorator : Human
    {
        protected Human _human;

        public HumanDecorator(Human human)
        {
            _human = human;
        }

        public void SetHuman(Human human) => _human = human;

        public override string Speak() => _human?.Speak();
    }
}
