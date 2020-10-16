using Patterns.Modules;

namespace Patterns.PatternsExample.Creationals
{
    public class CreationalsStarter : IStarter<ICreationals>
    {
        public void Start(ICreationals pattern) => pattern.Run();
    }
}
