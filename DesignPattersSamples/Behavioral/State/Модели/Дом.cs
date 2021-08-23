namespace DesignPattersSamples.Behavioral.State.Модели
{
    public abstract class Дом
    {
        protected Стройка Стройка;

        public void НазначитьСтройку(Стройка стройка)
        {
            Стройка = стройка;
        }

        public abstract void Строить();

        public abstract void Демонтировать();
    }
}