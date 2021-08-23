using DesignPattersSamples.Behavioral.ChainOfResponsibility.Интерфейс;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели.Общие
{
    public abstract class Рабочий : IРабочий
    {
        protected IРабочий СледующийРабочий;

        public IРабочий УстановитьСледующего(IРабочий рабочий)
        {
            СледующийРабочий = рабочий;
            return рабочий;
        }

        public abstract void Работать(ТипРаботы типРаботы);
    }
}