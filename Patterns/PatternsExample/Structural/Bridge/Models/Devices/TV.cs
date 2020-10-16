using Patterns.PatternsExample.Structural.Bridge.Interfaces;
using System;

namespace Patterns.PatternsExample.Structural.Bridge.Models.Devices
{
    public class TV : Device
    {
        public override bool IsEnabled { get; protected set; }

        public override string Model => "Smart-TV";
        public int Volume { get; private set; }

        public override void Enable()
        {
            if (!CheckEnabled(false))
            {
                Console.WriteLine($"Включаем экран у девайса: {Model}");
                IsEnabled = true;
            }
        }

        public override void Disable()
        {
            if (CheckEnabled(true))
            {
                Console.WriteLine($"Выключаем экран у девайса: {Model}");
                IsEnabled = false;
            }
        }

        public void SetVolume(int volume)
        {
            if (CheckEnabled(true) && volume > 0)
            {
                Volume = volume;
                Console.WriteLine($"Громкость девайса {Model} установлена на {Volume}%");
            }
            else
                Console.WriteLine($"Громкость не может быть меньше нуля!");
        }
    }
}
