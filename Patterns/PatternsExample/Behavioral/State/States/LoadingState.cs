using Patterns.PatternsExample.Behavioral.State.Interfaces;
using System;
using System.Threading.Tasks;

namespace Patterns.PatternsExample.Behavioral.State.States
{
    public class LoadingState : AbstractBootState
    {
        private AbstractBootState _nextState;

        public override void Enable()
        {
            Console.WriteLine("Загружаемся...");
            ShowState();
            Task.Delay(2000).Wait();

            _nextState = new LoadedState();
            Computer.SetState(_nextState);
            _nextState.Enable();
        }

        public override void Disable()
        {
            Console.WriteLine("Выключаемся...");
            ShowState();
            Task.Delay(1000).Wait();

            _nextState = new StartState();
            Computer.SetState(_nextState);
            _nextState.Disable();
        }

        public override string ToString() => "Загрузка";
    }
}
