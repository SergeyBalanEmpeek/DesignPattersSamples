using System.Collections;
using System.Collections.Generic;
using DesignPattersSamples.Behavioral.Iterator.Интерфейсы;
using DesignPattersSamples.Behavioral.Iterator.Модели.Вспомогательные;

namespace DesignPattersSamples.Behavioral.Iterator.Модели
{
    public class Строители : IEnumerable<IСтроитель>
    {
        private readonly List<IСтроитель> _строители = new List<IСтроитель>();

        // Добавляем строителя в коллекцию
        public void ДобавитьСтроителя(IСтроитель строитель)
            => _строители.Add(строитель);

        // Передаём наш собственный перечислитель
        public IEnumerator<IСтроитель> GetEnumerator()
            => new ИтераторСтроителей(_строители.ToArray());

        // Имплементация необходимого интерфейса
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}