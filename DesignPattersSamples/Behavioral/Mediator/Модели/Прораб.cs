using DesignPattersSamples.Behavioral.Mediator.Интерфейсы;
using DesignPattersSamples.Behavioral.Mediator.Перечисления;

namespace DesignPattersSamples.Behavioral.Mediator.Модели
{
    public class Прораб : IПрораб
    {
        private readonly IЗаказчик _заказчик;
        private readonly IСтроитель _строитель;

        public Прораб(IЗаказчик заказчик, IСтроитель строитель)
        {
            заказчик.Прораб = this;
            _заказчик = заказчик;

            строитель.Прораб = this;
            _строитель = строитель;
        }

        public void Событие(ТипСобытия тип)
        {
            switch (тип)
            {
                case ТипСобытия.ЗаказСделан:
                    _строитель.Работать();
                    break;

                case ТипСобытия.РаботаСделана:
                    _заказчик.ПринятьРаботу();
                    break;
            }
        }

    }
}