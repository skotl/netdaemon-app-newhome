namespace daemonapp.apps.ScottHome.UkhoTidalApi.Model;

public class TidalStation
{
    public class GeometryConfig
    {
        public string? Type { get; set; }
        public decimal[]? Coordinates { get; set; }
    }

    public class PropertiesConfig
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
    }

    public GeometryConfig? Geometry { get; set; }
    public PropertiesConfig? Properties { get; set; }
    
}