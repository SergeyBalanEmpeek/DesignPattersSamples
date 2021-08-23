namespace DesignPattersSamples.Behavioral.Observer.Интерфейсы
{
    public interface IСервисПодписки
    {
        void ДобавитьКлиента(IЗаказчик клиент);
        void УдалитьКлиента(IЗаказчик клиент);
        void УведомитьВсех(string сообщение);
    }
}