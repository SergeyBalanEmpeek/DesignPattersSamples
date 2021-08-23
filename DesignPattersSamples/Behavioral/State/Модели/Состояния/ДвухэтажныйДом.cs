namespace DesignPattersSamples.Behavioral.State.Модели.Состояния
{
    public class ДвухэтажныйДом : Дом
    {
        public override void Строить()
        {
            // Уже некуда строить
        }

        public override void Демонтировать()
        {
            Стройка.КонвертироватьДомВ(new ОдноэтажныйДом());
        }
    }
}