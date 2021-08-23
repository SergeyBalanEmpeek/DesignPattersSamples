using System;
using DesignPattersSamples.Creational.Prototype.Интерфейсы;
using DesignPattersSamples.Creational.Prototype.Модели;

// ReSharper disable All
namespace DesignPattersSamples.Creational.Prototype
{
    public class Пример
    {
        public void Пример1()
        {
            IСтроитель строитель = new Строитель(
                "Равшан",
                "Аскерович");

            строитель.Работать();
            строитель.Работать();
            строитель.Работать();
            строитель.Работать();

            IСтроитель строитель2 = (IСтроитель)строитель.Clone();

            if (строитель.Навык != строитель2.Навык)
            {
                var ошибка = "Навык строителей должен был совпасть";
                throw new Exception(ошибка);
            }
        }
    }
}