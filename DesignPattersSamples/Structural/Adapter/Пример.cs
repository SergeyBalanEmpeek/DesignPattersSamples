using DesignPattersSamples.Structural.Adapter.Интерфейсы;
using DesignPattersSamples.Structural.Adapter.Модели;
using DesignPattersSamples.Structural.Adapter.Модели.Несовместимые;

namespace DesignPattersSamples.Structural.Adapter
{
    public class Пример
    {
        public void Пример1()
        {
            IСтроитель строитель1 = new СтроительРафшан(new Рафшан());
            IСтроитель строитель2 = new СтроительДжамшут(new Джамшут());

            строитель1.Работать();
            строитель2.Работать();
        }
    }
}