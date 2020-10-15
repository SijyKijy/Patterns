using System;

namespace Patterns.Patterns.Structural.Bridge.Interfaces
{
    /// <summary>
    /// Ветка реализаций.
    /// Тут определяется базовая (низкоуровневая и сложная) реализация
    /// Которая потом будет удобно скомпонована в абстракции <see cref="Remote"/> и использована клиентом
    /// Клиент, в идеале, не должен лезть в ветку реализации
    /// (!) Реализация не обязана точно следовать интерфейсу абстракции
    /// </summary>
    public abstract class Device
    {
        public abstract bool IsEnabled { get; protected set; }
        public abstract void Enable();
        public abstract void Disable();
        public abstract string Model { get; }

        protected bool CheckEnabled(bool showMessage)
        {
            if (IsEnabled)
                return true;
            else
            {
                if (showMessage) Console.WriteLine($"Девайс: {Model} выключен");
                return false;
            }
        }
    }
}
