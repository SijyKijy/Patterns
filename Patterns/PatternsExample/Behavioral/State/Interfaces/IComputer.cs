namespace Patterns.PatternsExample.Behavioral.State.Interfaces
{
    public interface IComputer
    {
        public void SetState(AbstractBootState state);

        public void Enable();
        public void Disable();
    }
}
