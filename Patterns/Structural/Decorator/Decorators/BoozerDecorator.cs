﻿using Patterns.Structural.Decorator.Interfaces;

namespace Patterns.Structural.Decorator.Decorators
{
    public class BoozerDecorator : HumanDecorator
    {
        public BoozerDecorator(Human human) : base(human)
        {
        }

        public override string Speak() => $"{base.Speak()} | ROOOOAAAAR!";

        public void AskAlms() => System.Console.WriteLine("Подайте рублик на попить!");
    }
}
