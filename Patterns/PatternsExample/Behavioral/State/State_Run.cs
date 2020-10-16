using Patterns.Modules;
using Patterns.PatternsExample.Behavioral.State.Models;
using Patterns.PatternsExample.Behavioral.State.States;

namespace Patterns.PatternsExample.Behavioral.State
{
    public class State_Run : AbstractPattern, IBehavioral
    {
        public override string Name => "Состояние / State";

        // Скорее всего перепишу пример, т.к. он не очень
        public override void Run()
        {
            var computer = new Computer();

            computer.Enable();
            System.Console.WriteLine("--- --- ---");
            computer.Disable();

            // Мы можем менять состояние ручками
            System.Console.WriteLine("--- --- ---");
            computer.SetState(new LoadedState());
            computer.Enable(); // Тут нас ждёт ошибка, т.к. мы состояние компьютера включено
        }
    }
}
