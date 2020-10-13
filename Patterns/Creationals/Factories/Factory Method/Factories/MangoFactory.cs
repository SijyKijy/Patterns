using Patterns.Creationals.Factories.FactoryMethod.Interfaces;
using Patterns.Creationals.Factories.FactoryMethod.Models;

namespace Patterns.Creationals.Factories.FactoryMethod.Factories
{
    public class MangoFactory : FoodFactory
    {
        public override IFood GetFood() => new Mango();
    }
}
