namespace Patterns.Modules
{
    public interface IStarter<T> where T : IPattern
    {
        void Start(T pattern);
    }
}
