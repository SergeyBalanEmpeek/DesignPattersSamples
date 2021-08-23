using System;

namespace DesignPattersSamples.Behavioral.Memento.Интерфейсы
{
    public interface IСнимокСтройки
    {
        public int МешковЦемента { get; }
        public int МешковКлея  { get; }
        public int ПачекПлитки  { get; }
        public DateTime ДатаСнимка { get; }
    }
}