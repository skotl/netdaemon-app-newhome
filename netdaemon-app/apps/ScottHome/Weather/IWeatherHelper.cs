using System.Collections.Generic;
using daemonapp.apps.ScottHome.Weather.Model;
using HomeAssistantGenerated;

namespace daemonapp.apps.ScottHome.Weather;

public interface IWeatherHelper
{
    IEnumerable<WeatherForecast> GetWeatherForecast(WeatherEntity weather);
}