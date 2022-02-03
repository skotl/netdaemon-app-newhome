using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using daemonapp.apps.ScottHome.UkhoTidalApi.Model;

namespace daemonapp.apps.ScottHome.UkhoTidalApi;

public class TidalApi
{
    private readonly string? _apiKey;
    private readonly HttpClient _httpClient;
    private const string GetStationsUrl = "https://admiraltyapi.azure-api.net/uktidalapi/api/V1/Stations?name={stationName}";
    private const string GetTidalEventsUrl = "https://admiraltyapi.azure-api.net/uktidalapi/api/V1/Stations/{stationId}/TidalEvents";
    private const string AuthHeaderParm = "Ocp-Apim-Subscription-Key";

    public TidalApi(string? apiKey, HttpClient httpClient)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
            throw new ArgumentException("API Key cannot be empty", nameof(apiKey));
        
        _apiKey = apiKey;
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<string?> GetStationIdAsync(string? stationName)
    {
        _httpClient.DefaultRequestHeaders.Add(AuthHeaderParm, _apiKey);
        var uri = GetStationsUrl.Replace("{stationName}", stationName);
        var response = await _httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var result = JsonSerializer.Deserialize<TidalStationCollection>(json, jsonOptions);
        if (result is not { Features: { Length: 1 } })
            throw new FormatException(
                $"Could not identify the station details for 'name={stationName}', response was: {json}");

        return result?.Features[0]?.Properties?.Id;
    }

    public async Task<List<TidalEvent>> GetTidalEvents(string? stationId)
    {
        _httpClient.DefaultRequestHeaders.Add(AuthHeaderParm, _apiKey);
        var uri = GetTidalEventsUrl.Replace("{stationId}", stationId);
        var response = await _httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();
        
        var json = await response.Content.ReadAsStringAsync();
        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };
        
        var results = JsonSerializer.Deserialize<TidalEvent[]>(json, jsonOptions);
        if (results == null || results.Length == 0)
            throw new InvalidDataException($"No tidal events returned, response was: {json}");

        return results.ToList();
    }
}