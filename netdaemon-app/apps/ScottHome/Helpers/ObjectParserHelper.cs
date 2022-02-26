namespace daemonapp.apps.ScottHome.Helpers;

public static class ObjectParserHelper
{
    public static DateTime? ToDateTime (this object? o)
    {
        if (o != null && DateTime.TryParse(o.ToString(), out var d))
            return d;

        return null;
    }
}