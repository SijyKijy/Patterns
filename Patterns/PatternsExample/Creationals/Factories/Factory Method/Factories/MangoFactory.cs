using Patterns.PatternsExample.Creationals.Factories.Factory_Method.Interfaces;
using Patterns.PatternsExample.Creationals.Factories.Factory_Method.Models;

namespace Patterns.PatternsExample.Creationals.Factories.Factory_Method.Factories
{
    public class MangoFactory : FoodFactory
    {
        public override IFood GetFood() => new Mango();
    }
}
