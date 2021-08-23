using DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели.Общие;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели
{
    public class Плиточник : Рабочий
    {
        public override void Работать(ТипРаботы типРаботы)
        {
            if (типРаботы == ТипРаботы.УложитьПлитку)
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