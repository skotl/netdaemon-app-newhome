namespace daemonapp.apps.ScottHome.Weather.Model;

public class WeatherForecast
{
    [System.Text.Json.Serialization.JsonPropertyNameAttribute("condition")]
    public string? Condition { get; init; }

    [System.Text.Json.Serialization.JsonPropertyNameAttribute("precipitation")]
    public double? Precipitation { get; init; }

    [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
    public double? Temperature { get; init; }

    [System.Text.Json.Serialization.JsonPropertyNameAttribute("templow")]
    public double? TempLow { get; init; }

    [System.Text.Json.Serialization.JsonPropertyNameAttribute("datetime")]
    public DateTime? DateTime { get; init; }
    
    [System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_bearing")]
    public double? WindBearing { get; init; }

    [System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_speed")]
    public double? WindSpeed { get; init; }

    public override string ToString()
    {
        return $"{DateTime}: {TempLow}-{Temperature}";
    }
}