using DesignPattersSamples.Behavioral.Visitor.Модели;
using DesignPattersSamples.Behavioral.Visitor.Модели.Объекты;
using DesignPattersSamples.Behavioral.Visitor.Модели.Посетители;

namespace DesignPattersSamples.Behavioral.Visitor
{
    public class Пример
    {
        public void Пример1()
        {
            var пример = new Стройка();

            пример.Добавить(new Строитель());
            пример.Добавить(new Строитель());
            пример.Добавить(new Оборудование());

            пример.Принять(new Уборщица());
            пример.Принять(new Инспектор());
        }
    }
}