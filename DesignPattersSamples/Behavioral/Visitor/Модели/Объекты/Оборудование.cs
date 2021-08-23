using DesignPattersSamples.Behavioral.Visitor.Интерфейсы;

// ReSharper disable UnusedMember.Global
namespace DesignPattersSamples.Behavioral.Visitor.Модели.Объекты
{
    public class Оборудование : IОбъект
    {
        public string Название { get; set; }
        public int ИнвентаризационныйНомер{ get; set; }

        public void Принять(IПосетитель посетитель)
        {
            посетитель.ПроверитьОборудование(this);
        }
    }
}