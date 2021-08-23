using System.Collections.Generic;

namespace DesignPattersSamples.Structural.Composite.Интерфейсы
{
    public interface IНачальник
    {
        public List<IРаботник> Подчиненные { get; set; }
    }
}