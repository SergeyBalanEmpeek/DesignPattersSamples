using DesignPattersSamples.Structural.Proxy.Интерфейсы;
using DesignPattersSamples.Structural.Proxy.Модели;

namespace DesignPattersSamples.Structural.Proxy
{
    public class Пример
    {
        public void Пример1()
        {
            IПрораб прораб = new Прораб(new Строитель());
            прораб.УправлятьРабочим();
        }
    }
}