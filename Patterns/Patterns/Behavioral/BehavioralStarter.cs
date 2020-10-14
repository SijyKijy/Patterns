using Patterns.Modules;

namespace Patterns.Patterns.Behavioral
{
    public class BehavioralStarter : IStarter<IBehavioral>
    {
        public void Start(IBehavioral pattern) => pattern.Run();
    }
}
