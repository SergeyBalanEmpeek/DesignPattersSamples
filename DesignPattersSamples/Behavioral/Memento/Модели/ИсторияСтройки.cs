using System.Collections.Generic;
using DesignPattersSamples.Behavioral.Memento.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Memento.Модели
{
    public class ИсторияСтройки : IИсторияСтройки
    {
        public List<IСнимокСтройки> История { get; } = new List<IСнимокСтройки>();

        public void ДобавитьСостояние(IСнимокСтройки снимокСтройки)
        {
            История.Add(снимокСтройки);
        }
    }
}