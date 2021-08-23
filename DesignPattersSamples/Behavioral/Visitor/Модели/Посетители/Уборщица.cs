using DesignPattersSamples.Behavioral.Visitor.Интерфейсы;
using DesignPattersSamples.Behavioral.Visitor.Модели.Объекты;

namespace DesignPattersSamples.Behavioral.Visitor.Модели.Посетители
{
    public class Уборщица : IПосетитель
    {
        public void ПроверитьСтроителя(Строитель строитель)
        {
            // Попросить выйти для уборки
        }

        public void ПроверитьОборудование(Оборудование оборудование)
        {
            // Натереть до блеска
        }
    }
}