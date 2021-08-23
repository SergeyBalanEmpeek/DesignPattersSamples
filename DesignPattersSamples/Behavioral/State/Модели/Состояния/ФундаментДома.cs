namespace DesignPattersSamples.Behavioral.State.Модели.Состояния
{
    public class ФундаментДома : Дом
    {
        public override void Строить()
        {
            Стройка.КонвертироватьДомВ(new ОдноэтажныйДом());
        }

        public override void Демонтировать()
        {
            // Уже нечего демонтировать
        }
    }
}