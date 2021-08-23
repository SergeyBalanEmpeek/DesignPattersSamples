namespace DesignPattersSamples.Creational.Builder.Интерфейсы
{
    public interface IПрораб
    {
        void НазначитьСтроителя(IСтроитель строитель);

        void ПостроитьБюджетныйДом();

        void ПостроитьОбычныйДом();

        void ПостроитьПремиумДом();
    }
}