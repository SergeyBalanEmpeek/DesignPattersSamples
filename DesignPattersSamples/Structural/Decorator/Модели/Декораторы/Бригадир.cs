
using DesignPattersSamples.Structural.Decorator.Интерфейсы;

namespace DesignPattersSamples.Structural.Decorator.Модели.Декораторы
{
    public class Бригадир : IБригадир
    {
        private readonly IРабочий _рабочий;

        public Бригадир(IРабочий рабочий)
        {
            _рабочий = рабочий;
        }

        public void ВыполнитьРаботу()
        {
            ОсобаяРаботаБригадира();

            // Если осталось время
            _рабочий.ВыполнитьРаботу();
        }

        public void ОсобаяРаботаБригадира()
        {
            // Имплементация
        }
    }
}