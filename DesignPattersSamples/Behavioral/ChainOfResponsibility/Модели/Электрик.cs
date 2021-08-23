using DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели.Общие;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели
{
    public class Электрик : Рабочий
    {
        public override void Работать(ТипРаботы типРаботы)
        {
            if (типРаботы == ТипРаботы.РазвестиЭлектрику)
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