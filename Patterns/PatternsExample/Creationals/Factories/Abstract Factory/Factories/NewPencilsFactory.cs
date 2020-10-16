using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.Interfaces;
using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.NewPencils;

namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Factories
{
    public class NewPencilsFactory : IPencilsFactory
    {
        public IHardPencil CreateHardPencil() =>
            new NewHardPencil();

        public ISoftPencil CreateSoftPencil() =>
            new NewSoftPencil();
    }
}
