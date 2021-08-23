using DesignPattersSamples.Behavioral.Strategy.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Strategy.Модели
{
    public class Строитель : IСтроитель
    {
        public void Работать(IРабота работа)
        {
            работа.Выполнить();
        }
    }
}