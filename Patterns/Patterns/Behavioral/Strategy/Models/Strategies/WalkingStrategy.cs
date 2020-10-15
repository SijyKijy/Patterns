using Patterns.Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Patterns.Behavioral.Strategy.Models.Strategies
{
    public class WalkingStrategy : IRouteStrategy
    {
        public string GetResult() => "Калькулируем пеший маршрут";
    }
}
