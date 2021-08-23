using System;
using System.Net.Http;
using System.Threading.Tasks;

// ReSharper disable StringLiteralTypo
namespace DesignPattersSamples.Creational.Singleton.Модели
{
    public class Интеграция
    {
        private static readonly HttpClient Клиент;

        static Интеграция()
        {
            Клиент = new HttpClient();
        }

        public async Task ПолучитьДанные()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");
            var response = await Клиент.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Ошибка загрузки");
            }
        }
    }
}