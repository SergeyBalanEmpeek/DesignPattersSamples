namespace DesignPattersSamples.Behavioral.State.Модели
{
    public class Стройка
    {
        private Дом _дом;

        public Стройка(Дом дом)
        {
            КонвертироватьДомВ(дом);
        }

        public void КонвертироватьДомВ(Дом дом)
        {
            дом.НазначитьСтройку(this);
            _дом = дом;
        }

        public void Строить()
        {
            _дом.Строить();
        }

        public void Демонтировать()
        {
            _дом.Демонтировать();
        }
    }
}