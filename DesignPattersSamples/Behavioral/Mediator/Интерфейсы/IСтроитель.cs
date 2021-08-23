namespace DesignPattersSamples.Behavioral.Mediator.Интерфейсы
{
    public interface IСтроитель
    {
        IПрораб Прораб { get; set; }
        void Работать();
        void СдатьРаботу();
    }
}