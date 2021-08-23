namespace DesignPattersSamples.Behavioral.TemplateMethod.Модели
{
    public abstract class Начальник
    {
        // Переопределеине запрещено
        public void ПринятьЗаказ()
        {
            /* Имплементация */
        }

        // Переопределение обязательно
        public abstract void СледитьЗаРаботой();

        // Переопределение разрешено
        public virtual void ПринятьРаботу()
        {
            /* Имплементация */
        }
    }
}