namespace DesignPattersSamples.Creational.Builder.Интерфейсы
{
    public interface IСтроитель
    {
        void ПостроитьДом(int этажей, int комнат);

        void ПостроитьГараж(int машин);

        void СделатьДорожки();

        void ПосадитьСад();

        void УстановитьБассейн();
    }
}