using DesignPattersSamples.Behavioral.Iterator.Модели;

namespace DesignPattersSamples.Behavioral.Iterator
{
    public class Пример
    {
        public void Пример1()
        {
            var строители = new Строители();
            строители.ДобавитьСтроителя(new Строитель());
            строители.ДобавитьСтроителя(new Строитель());
            строители.ДобавитьСтроителя(new Строитель());

            foreach (var строитель in строители)
            {
                строитель.Работать();
            }
        }
    }
}