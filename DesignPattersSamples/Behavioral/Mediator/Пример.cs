using DesignPattersSamples.Behavioral.Mediator.Интерфейсы;
using DesignPattersSamples.Behavioral.Mediator.Модели;

// ReSharper disable UnusedVariable
namespace DesignPattersSamples.Behavioral.Mediator
{
    public class Пример
    {
        public void Пример1()
        {
            IЗаказчик заказчик = new Заказчик();
            IСтроитель строитель = new Строитель();
            IПрораб прораб = new Прораб(заказчик, строитель);

            заказчик.СделатьЗаказ();
            строитель.СдатьРаботу();
        }
    }
}