using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp
{
    public class WeatherService
    {
        //https://api.openweathermap.org/data/2.5/weather?q=Chigorodo


        private const string ApiKey = "5712a50371b788a5fb76d405bd3b5eaa";
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather?q=Chigorodo&appid=";

        public async Task<WeatherData> GetWeatherDataAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(ApiKey, city);

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<WeatherData>(json);
                }

                return null;
            }
        }
    }

}