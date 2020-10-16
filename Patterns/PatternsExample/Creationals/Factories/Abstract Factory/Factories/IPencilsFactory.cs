using Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.Interfaces;

namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Factories
{
    public interface IPencilsFactory
    {
        ISoftPencil CreateSoftPencil();
        IHardPencil CreateHardPencil();
    }
}
