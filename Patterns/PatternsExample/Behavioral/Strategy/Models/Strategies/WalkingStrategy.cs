using Patterns.PatternsExample.Behavioral.Strategy.Interfaces;

namespace Patterns.PatternsExample.Behavioral.Strategy.Models.Strategies
{
    public class WalkingStrategy : IRouteStrategy
    {
        public string GetResult() => "Калькулируем пеший маршрут";
    }
}
