using DesignPattersSamples.Structural.Flyweight.Интерфейсы;

namespace DesignPattersSamples.Structural.Flyweight.Модели
{
    public class Строитель : IСтроитель
    {
        public long ИдентификационныйНомер { get; set; }

        public string Имя { get; set; }

        public string Фамилия { get; set; }

        public decimal Опыт { get; set; }

        public void Работать()
        {
            Опыт += 0.1m;
        }
    }
}