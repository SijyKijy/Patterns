namespace Patterns.PatternsExample.Behavioral.Mediator.Interfaces
{
    /// <summary>
    /// Абстрактный класс для наших компонентов / коллег (моделей)
    /// </summary>
    public abstract class AbstractColleague
    {
        protected IMediator mediator;

        public AbstractColleague(IMediator mediator = null) => this.mediator = mediator;

        public void SetMediator(IMediator mediator) => this.mediator = mediator;
    }
}
