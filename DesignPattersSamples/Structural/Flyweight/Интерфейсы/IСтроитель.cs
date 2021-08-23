namespace DesignPattersSamples.Structural.Flyweight.Интерфейсы
{
    public interface IСтроитель
    {
        long ИдентификационныйНомер { get; set; }

        string Имя { get; set; }

        string Фамилия { get; set; }

        decimal Опыт { get; set; }

        void Работать();
    }
}