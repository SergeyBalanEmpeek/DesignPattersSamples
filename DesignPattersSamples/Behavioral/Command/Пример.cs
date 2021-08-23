using DesignPattersSamples.Behavioral.Command.Интерфейсы;
using DesignPattersSamples.Behavioral.Command.Модели;

namespace DesignPattersSamples.Behavioral.Command
{
    public class Пример
    {
        public void Пример1()
        {
            IРабота работа = new КладкаСтены();
            IСтроитель строитель = new Строитель(работа);

            IПрораб прораб = new Прораб();
            прораб.ДобавитьСтроителя(строитель);
            прораб.ЗаставитьСтроить();
            прораб.ЗаставитьРазобрать();
        }
    }
}