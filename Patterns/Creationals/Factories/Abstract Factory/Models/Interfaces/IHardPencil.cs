namespace Patterns.Creationals.Factories.Abstract_Factory.Models.Interfaces
{
    public interface IHardPencil : IPencil
    {
        void Draw(IPencil pencil = null);
    }
}