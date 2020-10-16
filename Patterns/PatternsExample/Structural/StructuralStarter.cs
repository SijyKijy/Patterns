using Patterns.Modules;

namespace Patterns.PatternsExample.Structural
{
    public class StructuralStarter : IStarter<IStructural>
    {
        public void Start(IStructural pattern) => pattern.Run();
    }
}
