using System;
using DesignPattersSamples.Creational.Prototype.Интерфейсы;

namespace DesignPattersSamples.Creational.Prototype.Модели
{
    public class Строитель : IСтроитель
    {
        public Строитель(string имя, string фамилия)
        {
            Имя = имя;
            Фамилия = фамилия;
        }

        public string Имя { get; }
        public string Фамилия { get; }

        public int Навык { get; private set; }

        public void Работать()
        {
            var прирост = new Random().Next(1, 5);

            Навык = Навык + прирост < 100
                ? Навык + прирост
                : 100;
        }

        public object Clone()
            => new Строитель(Имя, Фамилия)
            {
                // Здесь мы имеем доступ к приватному полю,
                // поскольку оно 'private set'
                Навык = Навык,
            };
    }
}