using DesignPattersSamples.Behavioral.Strategy.Интерфейсы;
using DesignPattersSamples.Behavioral.Strategy.Модели;
using DesignPattersSamples.Behavioral.Strategy.Модели.Работы;

namespace DesignPattersSamples.Behavioral.Strategy
{
    public class Пример
    {
        public void Пример1()
        {
            IСтроитель работа = new Строитель();
            работа.Работать(new Шпаклевка());
            работа.Работать(new Покраска());
        }
    }
}