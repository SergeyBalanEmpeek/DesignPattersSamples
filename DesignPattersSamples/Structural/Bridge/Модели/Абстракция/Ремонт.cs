using DesignPattersSamples.Structural.Bridge.Интерфейсы;

namespace DesignPattersSamples.Structural.Bridge.Модели.Абстракция
{
    public class Ремонт
    {
        protected readonly IСтроитель Строитель;

        public Ремонт(IСтроитель строитель)
        {
            Строитель = строитель;
        }

        public virtual void ПроводитьРаботы()
        {
            Строитель.Работать();
        }
    }
}