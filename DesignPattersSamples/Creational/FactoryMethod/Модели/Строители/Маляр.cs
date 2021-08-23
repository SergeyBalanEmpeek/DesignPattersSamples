using DesignPattersSamples.Creational.FactoryMethod.Интерфейсы;
using DesignPattersSamples.Creational.FactoryMethod.Модели.Работы;

namespace DesignPattersSamples.Creational.FactoryMethod.Модели.Строители
{
    public class Маляр : IСтроитель
    {
        public IРабота ПолучитьРаботу()
        {
            return new Покраска();
        }
    }
}