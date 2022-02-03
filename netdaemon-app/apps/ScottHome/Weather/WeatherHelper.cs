using System.Text.Json;
using daemonapp.apps.ScottHome.Weather.Model;
using HomeAssistantGenerated;

namespace daemonapp.apps.ScottHome.Weather;

public class WeatherHelper
{
    public static WeatherForecast[] GetWeatherForecast(WeatherEntity weather)
    {
        if (weather?.Attributes?.Forecast == null)
            return Array.Empty<WeatherForecast>();
        
        var json = (JsonElement)weather.Attributes.Forecast;
        return JsonSerializer.Deserialize<WeatherForecast[]>(json) ?? Array.Empty<WeatherForecast>();
    }
}