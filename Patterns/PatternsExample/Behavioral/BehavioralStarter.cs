using Patterns.Modules;

namespace Patterns.PatternsExample.Behavioral
{
    public class BehavioralStarter : IStarter<IBehavioral>
    {
        public void Start(IBehavioral pattern) => pattern.Run();
    }
}
