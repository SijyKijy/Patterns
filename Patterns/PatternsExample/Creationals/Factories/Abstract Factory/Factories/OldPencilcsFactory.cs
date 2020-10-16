using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.Interfaces;
using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.OldPencils;

namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Factories
{
    public class OldPencilcsFactory : IPencilsFactory
    {
        public IHardPencil CreateHardPencil() =>
            new OldHardPencil();

        public ISoftPencil CreateSoftPencil() =>
            new OldSoftPencil();
    }
}
