using DesignPattersSamples.Structural.Bridge.Интерфейсы;

namespace DesignPattersSamples.Structural.Bridge.Модели.Абстракция
{
    public class РемонтНаКрещатике : Ремонт
    {
        public РемонтНаКрещатике(IСтроитель строитель)
            : base(строитель)
        {
        }

        public override void ПроводитьРаботы()
        {
            // Утром - взятки
            // Вечером - официальные работы
            Строитель.Работать();
        }
    }
}