namespace DesignPattersSamples.Behavioral.Mediator.Интерфейсы
{
    public interface IЗаказчик
    {
        IПрораб Прораб { get; set; }
        void СделатьЗаказ();
        void ПринятьРаботу();
    }
}