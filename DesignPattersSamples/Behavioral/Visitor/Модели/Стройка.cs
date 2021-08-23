using System.Collections.Generic;
using DesignPattersSamples.Behavioral.Visitor.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Visitor.Модели
{
    public class Стройка
    {
        private readonly List<IОбъект> _объекты = new List<IОбъект>();

        public void Добавить(IОбъект объект)
            => _объекты.Add(объект);

        public void Принять(IПосетитель посетитель)
        {
            // Пришел посетитель, делает обход всех объектов
            foreach (var объект in _объекты)
            {
                объект.Принять(посетитель);
            }
        }
    }
}