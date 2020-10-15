namespace Patterns.Patterns.Structural.Facade.Systems
{
    public class Counter
    {
        private int _number;

        public string Add(int number) => (_number + number).ToString();
    }
}
