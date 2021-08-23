using System.Collections.Generic;
using DesignPattersSamples.Structural.Facade.Интерфейсы;
using DesignPattersSamples.Structural.Facade.Модели;
using IРабочий = DesignPattersSamples.Structural.Facade.Интерфейсы.IРабочий;

namespace DesignPattersSamples.Structural.Facade
{
    public class Пример
    {
        public void Пример1()
        {
            IЗаказчик заказчик = new Заказчик();
            List<IРабочий> рабочие = new List<IРабочий>
            {
                new Рабочий(),
                new Рабочий(),
            };

            IРемонт ремонт = new Ремонт(заказчик, рабочие);
            ремонт.ПроизвестиРемонт();
        }
    }
}