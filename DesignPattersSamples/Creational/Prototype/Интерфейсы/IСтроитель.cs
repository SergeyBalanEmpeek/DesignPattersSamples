using System;

namespace DesignPattersSamples.Creational.Prototype.Интерфейсы
{
    public interface IСтроитель: ICloneable
    {
        string Имя { get; }
        string Фамилия { get; }

        int Навык { get; }

        void Работать();
    }
}