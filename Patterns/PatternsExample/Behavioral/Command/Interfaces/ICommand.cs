namespace Patterns.PatternsExample.Behavioral.Command.Interfaces
{
    /// <summary>
    /// Интерфейс для всех команд
    /// </summary>
    public interface ICommand
    {
        void Execute(); // Метод для старта команды
        void Undo(); // Метод для отмены команды
    }
}
