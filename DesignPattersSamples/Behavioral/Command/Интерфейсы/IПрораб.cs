namespace DesignPattersSamples.Behavioral.Command.Интерфейсы
{
    public interface IПрораб
    {
        void ДобавитьСтроителя(IСтроитель строитель);
        void ЗаставитьСтроить();
        void ЗаставитьРазобрать();
    }
}