using Patterns.PatternsExample.Structural.Adapter.Interfaces;
using System;

namespace Patterns.PatternsExample.Structural.Adapter.Models
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
