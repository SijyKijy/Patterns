using Patterns.Modules;
using Patterns.PatternsExample.Behavioral.Strategy.Models;
using Patterns.PatternsExample.Behavioral.Strategy.Models.Strategies;

namespace Patterns.PatternsExample.Behavioral.Strategy
{
    public class Strategy_Run : AbstractPattern, IBehavioral
    {
        public override string Name => "Стратегия / Strategy";

        public override void Run()
        {
            GPS gps = new GPS(new RoadStrategy()); // Выбираем изначальный маршрут по дороге
            gps.ShowRoute(); // Показываем маршрут

            gps.Strategy = new WalkingStrategy(); // Переключаемся на пеший маршрут
            gps.ShowRoute();
        }
    }
}
