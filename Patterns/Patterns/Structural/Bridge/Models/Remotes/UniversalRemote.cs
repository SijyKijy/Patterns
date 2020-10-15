using Patterns.Patterns.Structural.Bridge.Interfaces;
using Patterns.Patterns.Structural.Bridge.Models.Devices;
using System;

namespace Patterns.Patterns.Structural.Bridge.Models.Remotes
{
    public class UniversalRemote : Remote
    {
        public UniversalRemote(Device device) : base(device) { }

        public override string Model => "Универсальный пульт";

        public void SetVolume(int volume)
        {
            if (Device is TV tv)
                tv.SetVolume(volume);
            else
                Console.WriteLine($"Девайс ({Device.Model}) не поддерживает регулировку громкости");
        }
    }
}
