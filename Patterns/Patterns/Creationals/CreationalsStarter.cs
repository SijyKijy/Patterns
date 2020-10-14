using Patterns.Modules;

namespace Patterns.Patterns.Creationals
{
    public class CreationalsStarter : IStarter<ICreationals>
    {
        public void Start(ICreationals pattern) => pattern.Run();
    }
}
