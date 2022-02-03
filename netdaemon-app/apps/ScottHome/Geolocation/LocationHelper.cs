using daemonapp.apps.ScottHome.Geolocation.Model;

namespace daemonapp.apps.ScottHome.Geolocation;

public static class LocationHelper
{
    private const double Tolerance = 0.000001;
    public static double CalculateDistance(Coordinates point1, Coordinates point2)
    {
        return CalculateDistance(point1.Latitude, point1.Longitude, point2.Latitude, point2.Longitude);
    }
    
    public static double CalculateDistance(double? lat, double? lon, Coordinates otherLocation)
    {
        if (!lat.HasValue || !lon.HasValue)
            return 0;

        return CalculateDistance(lat.Value, lon.Value, otherLocation.Latitude, otherLocation.Longitude);
    }
    
    public static double CalculateDistance(double? lat1, double? lon1, double? lat2, double? lon2)
    {
        if (!lat1.HasValue || !lon1.HasValue || !lat2.HasValue || !lon2.HasValue)
            return 0;

        return CalculateDistance(lat1.Value, lon1.Value, lat2.Value, lon2.Value);
    }

    private static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        if (Math.Abs(lat1 - lat2) < Tolerance && Math.Abs(lon1 - lon2) < Tolerance)
            return 0;
        
        var d1 = lat1 * (Math.PI / 180.0);
        var num1 = lon1 * (Math.PI / 180.0);
        var d2 = lat2 * (Math.PI / 180.0);
        var num2 = lon2 * (Math.PI / 180.0) - num1;
        var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                 Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
        return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
    }

}