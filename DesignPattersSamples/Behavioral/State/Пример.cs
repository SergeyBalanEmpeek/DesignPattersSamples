using DesignPattersSamples.Behavioral.State.Модели;
using DesignPattersSamples.Behavioral.State.Модели.Состояния;

namespace DesignPattersSamples.Behavioral.State
{
    public class Пример
    {
        public void Пример1()
        {
            var стройка = new Стройка(new ФундаментДома());

            // Фундамент > ОдноэтажныйДом
            стройка.Строить();

            // Одноэтажный -> Двухэтажный
            стройка.Строить();

            // Двухэтажный -> Одноэтажный
            стройка.Демонтировать();

            // Одноэтажный -> Двухэтажный
            стройка.Строить();
        }
    }
}