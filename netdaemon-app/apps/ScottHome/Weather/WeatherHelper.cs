using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using daemonapp.apps.ScottHome.Weather.Model;
using HomeAssistantGenerated;

namespace daemonapp.apps.ScottHome.Weather;

public class WeatherHelper : IWeatherHelper
{
    private readonly ILogger<WeatherHelper> _logger;

    public WeatherHelper(ILogger<WeatherHelper> logger)
    {
        _logger = logger;
    }

    public IEnumerable<WeatherForecast> GetWeatherForecast(WeatherEntity weather)
    {
        var list = new List<WeatherForecast>();

        if (weather?.Attributes?.Forecast == null)
            return list;

        list.AddRange(weather.Attributes.Forecast
                .Select(f => ((JsonElement)f).Deserialize<WeatherForecast>())
                .Where(w => w != null)!
        );

        ValidateList(list);

        return list;
    }

    private void ValidateList(IEnumerable<WeatherForecast> list)
    {
        var failures = list.Where(w =>
            w.TempLow == null ||
            w.Temperature == null ||
            w.DateTime == null)
            .ToList();

        if (!failures.Any())
            return;

        var sb = new StringBuilder();
        failures.ForEach(w => sb.AppendLine(w.ToString()));

        _logger.LogWarning("One or more weather forecasts is invalid:\r\n{Failures}", sb.ToString());
    }
}