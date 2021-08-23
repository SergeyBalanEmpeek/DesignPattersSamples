using DesignPattersSamples.Behavioral.ChainOfResponsibility.Интерфейс;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Модели;
using DesignPattersSamples.Behavioral.ChainOfResponsibility.Перечисления;

namespace DesignPattersSamples.Behavioral.ChainOfResponsibility
{
    public class Пример
    {
        public void Пример1()
        {
            IРабочий рабочий = new Маляр();

            рабочий.УстановитьСледующего(new Штукатур())
                   .УстановитьСледующего(new Электрик())
                   .УстановитьСледующего(new Плиточник());

            // Кто-то их них да уложит плитку
            // Сами разберутся между собой...
            рабочий.Работать(ТипРаботы.УложитьПлитку);
        }
    }
}