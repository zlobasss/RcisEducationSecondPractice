
using System.Net;
using Newtonsoft.Json;

namespace PracticWork6
{
    class Program
    {
        static void Main()
        {
            string input = "";
            string apiKey = "2b9bff9f068f86100d8aa726ec417e04";
            string city;

            while (input != "0")
            {
                Console.WriteLine("Запросы:");
                Console.WriteLine("1) Прогноз погоды сейчас; \n2) Прогноз погоды на 5 дней");
                Console.Write("Введите номер запроса: ");
                input = Console.ReadLine()!;
                Console.Write("Введите название города: ");
                city = Console.ReadLine()!;
                
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        GetWeatherCityNow(city, apiKey);
                        break;
                    case "2": 
                        GetWeatherCityFiveDays(city, apiKey);
                        break;
                    default:
                        input = "0";
                        break;
                }
                Console.WriteLine();
            }
        }

        static void GetWeatherCityNow(string city, string apiKey)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&units=metric&lang=ru&appid="+apiKey;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse;
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string response;
        
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) 
                {
                    response = streamReader.ReadToEnd();
                }

                WeatherResNow weatherRes = JsonConvert.DeserializeObject<WeatherResNow>(response)!;
        
                Console.WriteLine("Местность: {0}", weatherRes.Name);
                Console.WriteLine("Текущая погода: {0}", weatherRes.Weather[0].Description);
                Console.WriteLine("Температура {0}°C, ощущается, как {1}°C", weatherRes.Main.Temp, weatherRes.Main.Feels_like);
                Console.WriteLine("Скорость ветра = {0} м/c; Направление ветра: {1}", weatherRes.Wind.Speed, weatherRes.Wind.DegToString());
            }
            catch (WebException)
            {
                Console.WriteLine("По данному запросу ничего не найдено!!!");
            }
        }
        
        static void GetWeatherCityFiveDays(string city, string apiKey)
        {
            string url = "https://api.openweathermap.org/data/2.5/forecast?q="+city+"&units=metric&cnt=40&lang=ru&appid="+apiKey;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse;
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string response;
        
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream())) 
                {
                    response = streamReader.ReadToEnd();
                }

                WeatherResFiveDays weatherRes = JsonConvert.DeserializeObject<WeatherResFiveDays>(response)!;
        
                Console.WriteLine("Город {0}", weatherRes.City.Name);

                for (int i = 0; i < weatherRes.List.Length; ++i)
                {
                    Console.WriteLine();
                    Console.WriteLine("Время: {0}", weatherRes.List[i].Dt_txt);
                    Console.WriteLine("Погода: {0}", weatherRes.List[i].Weather[0].Description);
                    Console.WriteLine("Температура {0}°C, ощущается, как {1}°C", weatherRes.List[i].Main.Temp, weatherRes.List[i].Main.Feels_like);
                    Console.WriteLine("Скорость ветра = {0} м/c; Направление ветра: {1}", weatherRes.List[i].Wind.Speed, weatherRes.List[i].Wind.DegToString());
                }
                
                
            }
            catch (WebException)
            {
                Console.WriteLine("По данному запросу ничего не найдено!!!");
            }
        }
    }
}