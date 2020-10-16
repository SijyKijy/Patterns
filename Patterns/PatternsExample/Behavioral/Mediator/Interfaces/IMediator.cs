namespace Patterns.PatternsExample.Behavioral.Mediator.Interfaces
{
    /// <summary>
    /// Общий интерфейс для всех посредников, т.к. паттерн это позволяет
    /// </summary>
    public interface IMediator
    {
        void Notify(object sender, string message);
    }
}
