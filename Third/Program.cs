using System.Net.Http.Json;
using System.Text.Json.Serialization;

using var http = new HttpClient();

var url = "https://api.open-meteo.com/v1/forecast?latitude=48.85&longitude=2.35&current=temperature_2m,wind_speed_10m";
var weather = await http.GetFromJsonAsync<WeatherResponse>(url);

Console.WriteLine($"Temperature: {weather!.Current.Temperature} C");
Console.WriteLine($"Wind: {weather.Current.WindSpeed} km/h");

record WeatherResponse(CurrentWeather Current);

record CurrentWeather(
    [property: JsonPropertyName("temperature_2m")] double Temperature,
    [property: JsonPropertyName("wind_speed_10m")] double WindSpeed);
