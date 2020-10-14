namespace Patterns
{
    public abstract class Pattern
    {
        public Pattern() => ShowPatternName();

        protected abstract string Name { get; }
        protected abstract void Run();

        private void ShowPatternName()
        {
            System.Console.WriteLine("--- --- --- ---");
            System.Console.WriteLine($"Запуск паттерна: {Name}");
            System.Console.WriteLine("--- --- --- ---");
            Run();
        }
    }
}
