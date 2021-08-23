using DesignPattersSamples.Behavioral.Command.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Command.Модели
{
    public class Строитель : IСтроитель
    {
        private readonly IРабота _работа;

        public Строитель(IРабота работа)
        {
            _работа = работа;
        }

        public void Построить()
        {
            _работа.Сделать();
        }

        public void Разобрать()
        {
            _работа.Разобрать();
        }
    }
}