using Patterns.Modules;

namespace Patterns.Patterns.Structural
{
    public class StructuralStarter : IStarter<IStructural>
    {
        public void Start(IStructural pattern) => pattern.Run();
    }
}
