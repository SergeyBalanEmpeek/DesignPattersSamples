using DesignPattersSamples.Behavioral.Mediator.Интерфейсы;
using DesignPattersSamples.Behavioral.Mediator.Перечисления;

namespace DesignPattersSamples.Behavioral.Mediator.Модели
{
    public class Строитель : IСтроитель
    {
        public IПрораб Прораб { get; set; }

        public void Работать()
        {
            /* Имплементация */
        }

        public void СдатьРаботу()
        {
            Прораб.Событие(ТипСобытия.РаботаСделана);
        }
    }
}