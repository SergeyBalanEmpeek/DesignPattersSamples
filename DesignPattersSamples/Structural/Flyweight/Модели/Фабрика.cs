using System.Collections.Generic;
using DesignPattersSamples.Structural.Flyweight.Интерфейсы;

namespace DesignPattersSamples.Structural.Flyweight.Модели
{
    public class Фабрика
    {
        private readonly Dictionary<long, decimal> _опытСтроителей;

        public Фабрика()
        {
            _опытСтроителей = new Dictionary<long, decimal>();
        }

        public IСтроитель НайтиСтроителя(long идентификационныйНомер, string имя, string фамилия)
        {
            var строитель = new Строитель
            {
                ИдентификационныйНомер = идентификационныйНомер,
                Имя = имя,
                Фамилия = фамилия
            };

            if (_опытСтроителей.ContainsKey(идентификационныйНомер))
            {
                строитель.Опыт = _опытСтроителей[идентификационныйНомер];
            }

            return строитель;
        }

        public void ОбновитьСтроителя(IСтроитель строитель)
        {
            _опытСтроителей[строитель.ИдентификационныйНомер] = строитель.Опыт;
        }
    }
}