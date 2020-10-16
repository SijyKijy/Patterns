using Patterns.PatternsExample.Behavioral.State.Interfaces;
using System;

namespace Patterns.PatternsExample.Behavioral.State.States
{
    public class LoadedState : AbstractBootState
    {
        private AbstractBootState _nextState;

        public override void Enable()
        {
            Console.WriteLine("Загрузились!");
            ShowState();
        }

        public override void Disable()
        {
            Console.WriteLine("Начинаем выключаться...");
            ShowState();

            _nextState = new LoadingState();
            Computer.SetState(_nextState);
            _nextState.Disable();
        }

        public override string ToString() => "Включен";
    }
}
