namespace Patterns.Modules
{
    public abstract class Pattern : IPattern
    {
        public Pattern() => ShowPatternName();

        public abstract string Name { get; }
        public abstract void Run();

        private void ShowPatternName()
        {
            System.Console.WriteLine("\t--- START ---");
            System.Console.WriteLine($"Запуск паттерна: {Name}");
            System.Console.WriteLine("\t--- --- ---");
        }
    }
}
