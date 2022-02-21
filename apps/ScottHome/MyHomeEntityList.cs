using System.Collections.Generic;

namespace daemonapp.apps.ScottHome;

public class MyHomeEntityList
{
    public static List<string> GetFamily => new List<string>
        { "person.jo_laidlaw", "person.scott_leckie", "person.theo" };

    public static string GetHomeOccupancy => "sensor.home_occupancy";
}