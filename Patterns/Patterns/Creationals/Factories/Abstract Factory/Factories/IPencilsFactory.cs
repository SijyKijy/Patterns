using Patterns.Patterns.Creationals.Factories.Abstract_Factory.Models.Interfaces;

namespace Patterns.Patterns.Creationals.Factories.Abstract_Factory.Factories
{
    public interface IPencilsFactory
    {
        ISoftPencil CreateSoftPencil();
        IHardPencil CreateHardPencil();
    }
}
