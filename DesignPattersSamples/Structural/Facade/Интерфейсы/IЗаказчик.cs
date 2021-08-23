namespace DesignPattersSamples.Structural.Facade.Интерфейсы
{
    public interface IЗаказчик
    {
        void КупитьМатериалы();
        void ОплатитьРаботу(IРабочий рабочий);
    }
}