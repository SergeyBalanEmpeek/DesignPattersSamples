using System.Collections.Generic;
using DesignPattersSamples.Structural.Composite.Интерфейсы;

namespace DesignPattersSamples.Structural.Composite.Модели
{
    public class Начальник : IНачальник, IРаботник
    {
        public List<IРаботник> Подчиненные { get; set; } = new List<IРаботник>();

        public void Работать()
        {
            foreach (var подчиненный in Подчиненные)
            {
                подчиненный.Работать();
            }
        }
    }
}