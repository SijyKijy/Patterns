namespace Patterns.Patterns.Structural.Composite.Interfaces
{
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display();
        public abstract bool IsComposite { get; }

    }
}
