using Patterns.Patterns.Structural.Adapter.Interfaces;
using System;

namespace Patterns.Patterns.Structural.Adapter.Models
{
    public class Charger
    {
        public void ChargePhone(string phone, IFastCharge charge)
        {
            Console.WriteLine($"Идёт зарядка телефона: {phone}");
            charge.FastCharge();
        }
    }
}
