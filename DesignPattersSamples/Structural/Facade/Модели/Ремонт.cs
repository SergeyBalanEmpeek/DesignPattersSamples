using System.Collections.Generic;
using DesignPattersSamples.Structural.Facade.Интерфейсы;

namespace DesignPattersSamples.Structural.Facade.Модели
{
    public class Ремонт : IРемонт
    {
        private readonly IЗаказчик _заказчик;
        private readonly List<IРабочий> _рабочие;

        public Ремонт(IЗаказчик заказчик, List<IРабочий> рабочие)
        {
            _заказчик = заказчик;
            _рабочие = рабочие;
        }

        public void ПроизвестиРемонт()
        {
            _заказчик.КупитьМатериалы();

            foreach (var рабочий in _рабочие)
            {
                рабочий.Работать();
            }

            foreach (var рабочий in _рабочие)
            {
                _заказчик.ОплатитьРаботу(рабочий);
            }
        }
    }
}