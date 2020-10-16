using Patterns.PatternsExample.Behavioral.State.Interfaces;
using Patterns.PatternsExample.Behavioral.State.States;
using System;

namespace Patterns.PatternsExample.Behavioral.State.Models
{
    /// <summary>
    /// Контекст. Именно с ним взаимодействует клиент
    /// </summary>
    public class Computer : IComputer
    {
        protected AbstractBootState State { get; private set; }

        public Computer()
        {
            State = new StartState();
            State.SetComputer(this);
        }

        public void SetState(AbstractBootState state)
        {
            State = state;
            State.SetComputer(this);
        }

        public void Enable()
        {
            if (State is LoadedState)
            {
                Console.WriteLine("Комплюктер уже запущен");
                return;
            }
            State.Enable();
        }

        public void Disable()
        {
            if (State is StartState)
            {
                Console.WriteLine("Комплюктер уже выключен");
                return;
            }
            State.Disable();
        }
    }
}
