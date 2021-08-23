using System.Collections.Generic;

namespace DesignPattersSamples.Behavioral.Memento.Интерфейсы
{
    public interface IИсторияСтройки
    {
        List<IСнимокСтройки> История { get; }
        void ДобавитьСостояние(IСнимокСтройки снимокСтройки);
    }
}