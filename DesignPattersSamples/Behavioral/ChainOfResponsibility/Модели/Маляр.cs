using DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели.Общие;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели
{
    public class Маляр : Рабочий
    {
        public override void Работать(ТипРаботы типРаботы)
        {
            if (типРаботы == ТипРаботы.Покрасить)
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