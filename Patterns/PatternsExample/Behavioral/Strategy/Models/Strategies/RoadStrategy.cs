using Patterns.PatternsExample.Behavioral.Strategy.Interfaces;

namespace Patterns.PatternsExample.Behavioral.Strategy.Models.Strategies
{
    public class RoadStrategy : IRouteStrategy
    {
        public string GetResult() => "Калькулируем маршрут по дороге";
    }
}
