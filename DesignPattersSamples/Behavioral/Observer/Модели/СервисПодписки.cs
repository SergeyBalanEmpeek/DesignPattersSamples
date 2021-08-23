using System.Collections.Generic;
using DesignPattersSamples.Behavioral.Observer.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Observer.Модели
{
    public class СервисПодписки : IСервисПодписки
    {
        private readonly List<IЗаказчик> _клиенты = new List<IЗаказчик>();

        public void ДобавитьКлиента(IЗаказчик клиент)
        {
            _клиенты.Add(клиент);
        }

        public void УдалитьКлиента(IЗаказчик клиент)
        {
            _клиенты.Remove(клиент);
        }

        public void УведомитьВсех(string сообщение)
        {
            foreach (var клиент in _клиенты)
            {
                клиент.Уведомить(сообщение);
            }
        }
    }
}