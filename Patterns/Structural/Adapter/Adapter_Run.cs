using Patterns.Structural.Adapter.Interfaces;
using Patterns.Structural.Adapter.Models;

namespace Patterns.Structural.Adapter
{
    public class Adapter_Run
    {
        public Adapter_Run()
        {
            string phone = "Мобила";

            var charger = new Charger();
            IPowerbank powerbank = new Powerbank();

            //charger.ChargePhone(phone, powerbank); // Мы не можем зарядить телефон через powerbank (слишком медленно). Давайте трансформируем его

            IFastCharge charge = new PowerbankAdapter(powerbank); // Трансформируем powerbank через адаптер

            charger.ChargePhone(phone, charge); // Ого, заряжает!
        }
    }
}
