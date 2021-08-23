using DesignPattersSamples.Structural.Adapter.Интерфейсы;
using DesignPattersSamples.Structural.Adapter.Модели.Несовместимые;

namespace DesignPattersSamples.Structural.Adapter.Модели
{
    public class СтроительРафшан : IСтроитель
    {
        private readonly Рафшан _строитель;

        public СтроительРафшан(Рафшан строитель)
        {
            _строитель = строитель;
        }

        public void Работать()
        {
            // _строитель.Бухать();
            _строитель.ПлохоРаботать();
        }
    }
}