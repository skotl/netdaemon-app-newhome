using System.Collections.Generic;

namespace daemonapp.apps.ScottHome;

public class MyHomeEntityList
{
    public static List<string> GetFamily => new List<string>
        { "person.jo", "person.scott", "person.theo" };
    
    public static List<string> GetFamilyTrackers => new List<string>
        { "device_tracker.jo_s_iphone", "device_tracker.scott_s_xr", "device_tracker.theos_iphone_6s" };

    public static string GetHomeOccupancy => "sensor.home_occupancy";
}