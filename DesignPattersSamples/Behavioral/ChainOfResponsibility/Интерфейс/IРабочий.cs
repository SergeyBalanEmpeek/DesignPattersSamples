using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility.Интерфейс
{
    public interface IРабочий
    {
        void Работать(ТипРаботы типРаботы);

        IРабочий УстановитьСледующего(IРабочий рабочий);
    }
}