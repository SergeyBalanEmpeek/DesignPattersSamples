using DesignPattersSamples.Structural.Decorator.Интерфейсы;

namespace DesignPattersSamples.Structural.Decorator.Модели.Декораторы
{
    public class Прораб : IПрораб
    {
        private readonly IРабочий _рабочий;

        public Прораб(IРабочий рабочий)
        {
            _рабочий = рабочий;
        }

        public void ВыполнитьРаботу()
        {
            ОсобаяРаботаПрораба();

            // Если осталось время
            _рабочий.ВыполнитьРаботу();
        }

        public void ОсобаяРаботаПрораба()
        {
            // Имплементация
        }
    }
}