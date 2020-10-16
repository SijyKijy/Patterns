using Patterns.PatternsExample.Structural.Bridge.Models.Devices;
using Patterns.PatternsExample.Structural.Bridge.Models.Remotes;
using System;

namespace Patterns.PatternsExample.Structural.Bridge
{
    public class Bridge_Run : IStructural
    {
        public string Name => "Мост / Bridge";

        public void Run()
        {
            Console.WriteLine("\tВыбор лампы:");
            var universalRemote = new UniversalRemote(new Lamp()); // Кидаем в абстракцию управление лампой

            universalRemote.Enable();
            universalRemote.SetVolume(50);
            universalRemote.Disable();

            Console.WriteLine("\tПереключение на TV:");
            universalRemote.Device = new TV(); // Переключаемся на телевизор

            universalRemote.Enable();
            universalRemote.SetVolume(50);
            universalRemote.Disable();
        }
    }
}
