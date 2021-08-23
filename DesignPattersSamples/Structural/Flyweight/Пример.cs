using DesignPattersSamples.Structural.Flyweight.Интерфейсы;
using DesignPattersSamples.Structural.Flyweight.Модели;

// ReSharper disable StringLiteralTypo
namespace DesignPattersSamples.Structural.Flyweight
{
    public class Пример
    {
        public void Пример1()
        {
            var фабрика = new Фабрика();

            IСтроитель строитель = фабрика.НайтиСтроителя(
                1232365252323232,
                "Рафшан",
                "Аскерович");

            строитель.Работать();
            строитель.Работать();
            строитель.Работать();

            фабрика.ОбновитьСтроителя(строитель);
        }
    }
}