using Patterns.Patterns.Behavioral.Strategy.Interfaces;
using System;

namespace Patterns.Patterns.Behavioral.Strategy.Models
{
    /// <summary>
    /// Наш контекст
    /// Именно этим классом должен оперировать клиент
    /// </summary>
    public class GPS
    {
        public IRouteStrategy Strategy { get; set; } // Стратегию можно менять на лету. Одна из ключевых особенностей паттерна! (Можно вынести в отдельный метод)

        public GPS(IRouteStrategy strategy) => Strategy = strategy;

        public void ShowRoute()
        {
            Console.WriteLine(Strategy.GetResult());
        }
    }
}
