using DesignPattersSamples.Behavioral.Visitor.Интерфейсы;

// ReSharper disable UnusedMember.Global
namespace DesignPattersSamples.Behavioral.Visitor.Модели.Объекты
{
    public class Строитель : IОбъект
    {
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public long ИдентификационныйНомер{ get; set; }

        public void Принять(IПосетитель посетитель)
        {
            посетитель.ПроверитьСтроителя(this);
        }
    }
}