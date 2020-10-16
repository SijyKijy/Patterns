using Patterns.PatternsExample.Structural.Bridge.Interfaces;
using System;

namespace Patterns.PatternsExample.Structural.Bridge.Models.Devices
{
    public class Lamp : Device
    {
        public override string Model => "Умная лампа";

        public override bool IsEnabled { get; protected set; }

        public override void Enable()
        {
            if (!CheckEnabled(false))
            {
                Console.WriteLine($"Включаем свет у девайса: {Model}");
                IsEnabled = true;
            }
        }

        public override void Disable()
        {
            if (CheckEnabled(true))
            {
                Console.WriteLine($"Выключаем свет у девайса: {Model}");
                IsEnabled = false;
            }
        }
    }
}
