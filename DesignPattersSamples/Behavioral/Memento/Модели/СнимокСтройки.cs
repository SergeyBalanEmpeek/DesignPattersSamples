using System;
using DesignPattersSamples.Behavioral.Memento.Интерфейсы;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace DesignPattersSamples.Behavioral.Memento.Модели
{
    public class СнимокСтройки : IСнимокСтройки
    {
        public СнимокСтройки(int мешковЦемента, int мешковКлея, int пачекПлитки)
        {
            МешковЦемента = мешковЦемента;
            МешковКлея = мешковКлея;
            ПачекПлитки = пачекПлитки;
            ДатаСнимка = DateTime.UtcNow;
        }

        public int МешковЦемента { get; }
        public int МешковКлея  { get; }
        public int ПачекПлитки  { get; }
        public DateTime ДатаСнимка { get; }
    }
}