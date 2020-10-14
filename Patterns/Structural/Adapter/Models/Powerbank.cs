using Patterns.Structural.Adapter.Interfaces;

namespace Patterns.Structural.Adapter.Models
{
    // Он не реализует интерфейс ICharge, но мы хотим работать именно с ICharge
    public class Powerbank : IPowerbank
    {
        public string Charge() => "Заряжаем!";
    }
}
