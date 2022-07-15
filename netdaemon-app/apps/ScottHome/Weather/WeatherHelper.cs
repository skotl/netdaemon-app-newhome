using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using daemonapp.apps.ScottHome.Weather.Model;
using HomeAssistantGenerated;

namespace daemonapp.apps.ScottHome.Weather;

public static class WeatherHelper
{
    public static IEnumerable<WeatherForecast> GetWeatherForecast(WeatherEntity weather)
    {
        var list = new List<WeatherForecast>();

        if (weather?.Attributes?.Forecast == null)
            return list;

        list.AddRange(weather.Attributes.Forecast
                .Select(f => ((JsonElement)f).Deserialize<WeatherForecast>())
                .Where(w => w != null)!
        );
        
        return list;
    }
}