namespace DesignPattersSamples.Behavioral.Visitor.Интерфейсы
{
    public interface IОбъект
    {
        void Принять(IПосетитель посетитель);
    }
}