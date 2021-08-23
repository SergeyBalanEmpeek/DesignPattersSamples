using System.Threading.Tasks;
using DesignPattersSamples.Creational.Singleton.Модели;

namespace DesignPattersSamples.Creational.Singleton
{
    public class Пример
    {
        public async Task Пример1()
        {
            var интеграция = new Интеграция();
            await интеграция.ПолучитьДанные();
        }
    }
}