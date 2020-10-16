using Patterns.PatternsExample.Behavioral.State.Interfaces;
using System;

namespace Patterns.PatternsExample.Behavioral.State.States
{
    public class StartState : AbstractBootState
    {
        private AbstractBootState _nextState;

        public override void Enable()
        {
            Console.WriteLine("Начинаем запуск...");
            ShowState();

            _nextState = new LoadingState();
            Computer.SetState(_nextState);
            _nextState.Enable();
        }

        public override void Disable()
        {
            Console.WriteLine("Выключились");
            ShowState();
        }

        public override string ToString() => "Выключен";
    }
}
