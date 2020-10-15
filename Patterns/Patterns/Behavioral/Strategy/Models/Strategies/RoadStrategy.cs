using Patterns.Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Patterns.Behavioral.Strategy.Models.Strategies
{
    public class RoadStrategy : IRouteStrategy
    {
        public string GetResult() => "Калькулируем маршрут по дороге";
    }
}
