using DesignPattersSamples.Structural.Adapter.Интерфейсы;
using DesignPattersSamples.Structural.Adapter.Модели.Несовместимые;

namespace DesignPattersSamples.Structural.Adapter.Модели
{
    public class СтроительДжамшут : IСтроитель
    {
        private readonly Джамшут _строитель;

        public СтроительДжамшут(Джамшут строитель)
        {
            _строитель = строитель;
        }

        public void Работать()
        {
            _строитель.ПытатьсяРаботать();
        }
    }
}