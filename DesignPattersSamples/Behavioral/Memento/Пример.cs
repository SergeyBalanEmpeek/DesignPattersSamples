using System.Linq;
using DesignPattersSamples.Behavioral.Memento.Интерфейсы;
using DesignPattersSamples.Behavioral.Memento.Модели;

namespace DesignPattersSamples.Behavioral.Memento
{
    public class Пример
    {
        public void Пример1()
        {
            IСтройка стройка = new Стройка();
            IИсторияСтройки историяСтройки = new ИсторияСтройки();

            стройка.ЗавезтиМатериал(5, 50, 70);
            историяСтройки.ДобавитьСостояние(стройка.ЗапомнитьСостояние());

            стройка.ПроводитьРаботы();
            стройка.ПроводитьРаботы();

            // Гипотетически :)
            стройка.ВосстановитьСостояние(историяСтройки.История.FirstOrDefault());
        }
    }
}