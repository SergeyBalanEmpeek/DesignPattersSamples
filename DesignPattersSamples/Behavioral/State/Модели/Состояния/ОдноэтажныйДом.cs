namespace DesignPattersSamples.Behavioral.State.Модели.Состояния
{
    public class ОдноэтажныйДом : Дом
    {
        public override void Строить()
        {
            Стройка.КонвертироватьДомВ(new ДвухэтажныйДом());
        }

        public override void Демонтировать()
        {
            Стройка.КонвертироватьДомВ(new ФундаментДома());
        }
    }
}