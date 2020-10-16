using System;

namespace Patterns.PatternsExample.Behavioral.State.Interfaces
{
    /// <summary>
    /// Абстрактный класс для наших состояний
    /// </summary>
    public abstract class AbstractBootState
    {
        protected IComputer Computer { get; set; }

        public void SetComputer(IComputer computer) => Computer = computer; // Установить контекст
        public abstract void Enable();
        public abstract void Disable();
        public void ShowState() => Console.WriteLine($"Состояние компьютера: {this}");
    }
}
