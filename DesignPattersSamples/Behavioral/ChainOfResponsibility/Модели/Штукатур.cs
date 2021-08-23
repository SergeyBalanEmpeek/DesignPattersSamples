using DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели.Общие;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели
{
    public class Штукатур : Рабочий
    {
        public override void Работать(ТипРаботы типРаботы)
        {
            if (типРаботы == ТипРаботы.Поштукатурить)
            {
                // Моя работа, работаем
            }
            else
            {
                // Просим другого
                СледующийРабочий?.Работать(типРаботы);
            }
        }
    }
}