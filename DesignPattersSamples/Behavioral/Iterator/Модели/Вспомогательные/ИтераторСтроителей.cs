using System;
using System.Collections;
using System.Collections.Generic;
using DesignPattersSamples.Behavioral.Iterator.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Iterator.Модели.Вспомогательные
{
    public class ИтераторСтроителей : IEnumerator<IСтроитель>
    {
        private readonly IСтроитель[] _строители;
        private int _позиция = -1;

        // Конструктор
        public ИтераторСтроителей(IСтроитель[] строители)
            => _строители = строители;

        // Возврат текущего строителя
        public IСтроитель Current
            => _позиция >= 0 && _позиция < _строители.Length
                ? _строители[_позиция]
                : throw new InvalidOperationException();

        // Переход к следующему строителю
        public bool MoveNext()
        {
            if (_позиция >= _строители.Length - 1)
            {
                // Перечисление закончено
                return false;
            }

            _позиция++;
            return true;
        }

        // Сброс позиции
        public void Reset() => _позиция = -1;

        public void Dispose() { }

        // Имплементация необходимого интерфейса
        object IEnumerator.Current => Current;
    }
}