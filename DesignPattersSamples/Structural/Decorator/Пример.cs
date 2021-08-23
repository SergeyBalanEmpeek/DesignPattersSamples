using DesignPattersSamples.Structural.Decorator.Интерфейсы;
using DesignPattersSamples.Structural.Decorator.Модели.Декораторы;
using DesignPattersSamples.Structural.Decorator.Модели.Специальности;

namespace DesignPattersSamples.Structural.Decorator
{
    public class Пример
    {
        public void Пример1()
        {
            IРабочий рабочий = new Маляр();
            IБригадир бригадир = new Бригадир(рабочий);
            IПрораб прораб = new Прораб(бригадир);

            прораб.ВыполнитьРаботу();
        }
    }
}