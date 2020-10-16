namespace Patterns.PatternsExample.Structural.Bridge.Interfaces
{
    /// <summary>
    /// Ветка абстракций.
    /// Именно с этим интерфейсом должен взаимодействовать клиент.
    /// В этом классе происходит делегирование всей работы в ветку реализации (<see cref="Device"/>)
    /// Просто компонуем сложные этапы реализации <see cref="Device"/> в методы, которыми будет управлять клиент
    /// </summary>
    public abstract class Remote
    {
        public Device Device { get; set; } // Реализацию можно менять, при условии следования общему интерфейсу
        public abstract string Model { get; }

        public Remote(Device device) => Device = device;

        public virtual void Enable() => Device.Enable();

        public virtual void Disable() => Device.Disable();
    }
}
