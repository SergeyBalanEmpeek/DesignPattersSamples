using DesignPattersSamples.Behavioral.TemplateMethod.Модели;

namespace DesignPattersSamples.Behavioral.TemplateMethod
{
    public class Пример
    {
        public void Пример1()
        {
            Начальник прораб = new Прораб();
            прораб.ПринятьЗаказ();
            прораб.СледитьЗаРаботой();
            прораб.ПринятьРаботу();
        }
    }
}