using DesignPattersSamples.Creational.FactoryMethod.Интерфейсы;
using DesignPattersSamples.Creational.FactoryMethod.Модели.Строители;

namespace DesignPattersSamples.Creational.FactoryMethod
{
    public class Пример
    {
        public void Пример1()
        {
            IСтроитель строитель = new Штукатурщик();
            IРабота работа = строитель.ПолучитьРаботу();
            работа.Выполнить();

            строитель = new Маляр();
            работа = строитель.ПолучитьРаботу();
            работа.Выполнить();
        }
    }
}