using System.Collections.Generic;
using DesignPattersSamples.Behavioral.Command.Интерфейсы;

namespace DesignPattersSamples.Behavioral.Command.Модели
{
    public class Прораб : IПрораб
    {
        private readonly List<IСтроитель> _строители = new List<IСтроитель>();

        public void ДобавитьСтроителя(IСтроитель строитель)
        {
            _строители.Add(строитель);
        }

        public void ЗаставитьСтроить()
        {
            foreach (var строитель in _строители)
            {
                строитель.Построить();
            }
        }

        public void ЗаставитьРазобрать()
        {
            foreach (var строитель in _строители)
            {
                строитель.Разобрать();
            }
        }
    }
}