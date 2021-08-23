using DesignPattersSamples.Behavioral.Mediator.Интерфейсы;
using DesignPattersSamples.Behavioral.Mediator.Перечисления;

namespace DesignPattersSamples.Behavioral.Mediator.Модели
{
    public class Заказчик : IЗаказчик
    {
        public IПрораб Прораб { get; set; }

        public void СделатьЗаказ()
        {
            Прораб.Событие(ТипСобытия.ЗаказСделан);
        }

        public void ПринятьРаботу()
        {
            /* Имплементация */
        }
    }
}