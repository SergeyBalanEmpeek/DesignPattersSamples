using DesignPattersSamples.Behavioral.Visitor.Интерфейсы;
using DesignPattersSamples.Behavioral.Visitor.Модели.Объекты;

namespace DesignPattersSamples.Behavioral.Visitor.Модели.Посетители
{
    public class Инспектор : IПосетитель
    {
        public void ПроверитьСтроителя(Строитель строитель)
        {
            // Уволить если пахнет алкоголем
        }

        public void ПроверитьОборудование(Оборудование оборудование)
        {
            // Списать если оборудование уже отработало своё
        }
    }
}