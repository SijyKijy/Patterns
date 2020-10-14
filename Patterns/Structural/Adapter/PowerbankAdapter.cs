using Patterns.Structural.Adapter.Interfaces;
using System;

namespace Patterns.Structural.Adapter
{
    public class PowerbankAdapter : IFastCharge
    {
        private readonly IPowerbank _powerbank;

        public PowerbankAdapter(IPowerbank powerbank)
        {
            _powerbank = powerbank;
        }

        public void FastCharge()
        {
            if (_powerbank != null)
                Console.WriteLine($"{_powerbank.Charge()} | Быстрая зарядка");
            else
                throw new NullReferenceException("Powerbank отсутствует");
        }
    }
}
