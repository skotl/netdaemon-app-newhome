namespace daemonapp.apps.ScottHome.UkhoTidalApi.Model;

public class TidalEvent
{
    public enum EventTypeState
    {
        HighWater,
        LowWater
    }

    public EventTypeState EventType { get; set; }
    public DateTime DateTime { get; set; }
    public bool IsApproximateTime { get; set; }
    public decimal Height { get; set; }
    public bool IsApproximateHeight { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
        return $"{EventType} at {this.DateTime.ToLocalTime()}, {Height}m";
    }
}