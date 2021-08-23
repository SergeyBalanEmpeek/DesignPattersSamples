using DesignPattersSamples.Structural.Bridge.Модели.Абстракция;
using DesignPattersSamples.Structural.Bridge.Модели.Имплементация;

namespace DesignPattersSamples.Structural.Bridge
{
    public class Пример
    {
        public void Пример1()
        {

            Ремонт ремонт = new Ремонт(new Маляр());
            ремонт.ПроводитьРаботы();

            ремонт = new РемонтНаКрещатике(new Штукатур());
            ремонт.ПроводитьРаботы();
        }
    }
}