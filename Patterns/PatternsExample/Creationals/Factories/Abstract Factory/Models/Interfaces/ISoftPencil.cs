namespace Patterns.PatternsExample.Creationals.Factories.Abstract_Factory.Models.Interfaces
{
    public interface ISoftPencil : IPencil
    {
        void Draw(IPencil pencil = null);
    }
}