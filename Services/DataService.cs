using MauiAppTempoAgora.Models;
using Newtonsoft.Json.Linq;
using System.Net;

namespace MauiAppTempoAgora.Services
{
    public class DataService
    {
        public static async Task<Tempo?> GetPrevisao(string cidade)
        {
            Tempo? t = null;

            string chave = "6135072afe7f6cec1537d5cb08a5a1a2";

            string url = $"https://api.openweathermap.org/data/2.5/weather?" +
                         $"q={cidade}&units=metric&lang=pt_br&appid={chave}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage resp = await client.GetAsync(url);

                    if (resp.IsSuccessStatusCode)
                    {
                        string json = await resp.Content.ReadAsStringAsync();

                        var rascunho = JObject.Parse(json);

                        var sunriseUnix = (long?)rascunho["sys"]?["sunrise"];
                        var sunsetUnix = (long?)rascunho["sys"]?["sunset"];

                        DateTime sunrise = sunriseUnix.HasValue
                            ? DateTimeOffset.FromUnixTimeSeconds(sunriseUnix.Value).ToLocalTime().DateTime
                            : DateTime.MinValue;

                        DateTime sunset = sunsetUnix.HasValue
                            ? DateTimeOffset.FromUnixTimeSeconds(sunsetUnix.Value).ToLocalTime().DateTime
                            : DateTime.MinValue;

                        t = new Tempo
                        {
                            Lat = (double?)rascunho["coord"]?["lat"] ?? 0.0,
                            Lon = (double?)rascunho["coord"]?["lon"] ?? 0.0,
                            Description = (string?)rascunho["weather"]?[0]?["description"] ?? "",
                            Main = (string?)rascunho["weather"]?[0]?["main"] ?? "",
                            TempMin = (double?)rascunho["main"]?["temp_min"] ?? 0.0,
                            TempMax = (double?)rascunho["main"]?["temp_max"] ?? 0.0,
                            Speed = (double?)rascunho["wind"]?["speed"] ?? 0.0,
                            Visibility = (int?)rascunho["visibility"] ?? 0,
                            Sunrise = sunrise.ToString("HH:mm"),
                            Sunset = sunset.ToString("HH:mm"),
                        };
                    }
                    else if (resp.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new Exception("Cidade não encontrada.");
                    }
                    else if (resp.StatusCode == HttpStatusCode.RequestTimeout || resp.StatusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        throw new Exception("Sem conexão com a internet.");
                    }
                    else
                    {
                        throw new Exception("Erro ao obter dados da previsão do tempo.");
                    }
                }
                catch (HttpRequestException)
                {
                    throw new Exception("Sem conexão com a internet.");
                }
            }

            return t;
        }
    }
}
