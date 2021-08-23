using DesignPattersSamples.Creational.Builder.Интерфейсы;
using DesignPattersSamples.Creational.Builder.Модели;

namespace DesignPattersSamples.Creational.Builder
{
    public class Пример
    {
        public void Пример1()
        {
            IСтроитель строитель = new Строитель();
            IПрораб прораб = new Прораб();

            прораб.НазначитьСтроителя(строитель);
            прораб.ПостроитьОбычныйДом();
        }

        public void Пример2()
        {
            IСтроитель строитель = new Строитель();

            строитель.ПостроитьДом(2, 5);
            строитель.ПостроитьГараж(2);
            строитель.СделатьДорожки();
        }
    }
}