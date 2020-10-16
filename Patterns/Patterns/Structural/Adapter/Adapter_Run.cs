using Patterns.Modules;
using Patterns.Patterns.Structural.Adapter.Interfaces;
using Patterns.Patterns.Structural.Adapter.Models;

namespace Patterns.Patterns.Structural.Adapter
{
    public class Adapter_Run : AbstractPattern, IStructural
    {
        public override string Name => "Адаптер / Adapter";

        public override void Run()
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
