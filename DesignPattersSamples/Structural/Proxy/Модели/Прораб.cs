using DesignPattersSamples.Structural.Proxy.Интерфейсы;

namespace DesignPattersSamples.Structural.Proxy.Модели
{
    public class Прораб : IПрораб
    {
        private readonly IСтроитель _строитель;

        public Прораб(IСтроитель строитель)
        {
            _строитель = строитель;
        }

        public void УправлятьРабочим()
        {
            // Особые действия до основного
            ВыдаватьАванс();

            // Выполнение основного действия
            _строитель.Работать();

            // Особые действия после основного
            ВыдатьОстатокДенег();
        }

        private void ВыдаватьАванс()
        {
        }

        private void ВыдатьОстатокДенег()
        {
        }
    }
}