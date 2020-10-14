using Patterns.Creationals.Factories.Factory_Method.Interfaces;
using Patterns.Creationals.Factories.Factory_Method.Models;

namespace Patterns.Creationals.Factories.Factory_Method.Factories
{
    public class MangoFactory : FoodFactory
    {
        public override IFood GetFood() => new Mango();
    }
}
