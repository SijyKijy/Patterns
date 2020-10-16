using System;

namespace Patterns.PatternsExample.Behavioral.Command.Models
{
    /// <summary>
    /// Класс получатель
    /// С ним работают команды делегируя ему свои действия
    /// </summary>
    public class Chef
    {
        public string Order { get; set; }

        public void Cook(string order) => Console.WriteLine($"Шэф начал готовить: {order}");

        public void UndoCook() => Console.WriteLine($"Шэф перестал готовить: {Order}");
    }
}
